using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;
using CarRentalManagementSystem.Models;

namespace CarRentalManagementSystem.Owner
{
    public class EarningsService
    {
        private readonly DatabaseHelper databaseHelper;

        public EarningsService()
        {
            databaseHelper = new DatabaseHelper();
        }

        public Earnings GetOwnerEarnings(int ownerID)
        {
            Earnings earnings = new Earnings();

            using SqlConnection connection = databaseHelper.GetConnection();
            connection.Open();

            // 1. Total Earnings
            string totalEarningsQuery = @"
                SELECT ISNULL(SUM(p.Amount), 0)
                FROM Payments p
                INNER JOIN Bookings b
                    ON p.BookingID = b.BookingID
                INNER JOIN Vehicles v
                    ON b.VehicleID = v.VehicleID
                WHERE v.OwnerID = @OwnerID
                  AND p.PaymentStatus = 'Paid'
                  AND b.BookingStatus = 'Confirmed'";

            using (SqlCommand command = new SqlCommand(totalEarningsQuery, connection))
            {
                command.Parameters.AddWithValue("@OwnerID", ownerID);

                earnings.TotalEarnings =
                    Convert.ToDecimal(command.ExecuteScalar());
            }

            // 2. This Month Earnings
            string thisMonthQuery = @"
                SELECT ISNULL(SUM(p.Amount), 0)
                FROM Payments p
                INNER JOIN Bookings b
                    ON p.BookingID = b.BookingID
                INNER JOIN Vehicles v
                    ON b.VehicleID = v.VehicleID
                WHERE v.OwnerID = @OwnerID
                  AND p.PaymentStatus = 'Paid'
                  AND b.BookingStatus = 'Confirmed'
                  AND p.TransactionDate >= DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1)
                  AND p.TransactionDate < DATEADD(MONTH, 1,
                      DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1))";

            using (SqlCommand command = new SqlCommand(thisMonthQuery, connection))
            {
                command.Parameters.AddWithValue("@OwnerID", ownerID);

                earnings.ThisMonthEarnings =
                    Convert.ToDecimal(command.ExecuteScalar());
            }

            // 3. Pending Payments
            string pendingQuery = @"
                SELECT ISNULL(SUM(b.TotalAmount), 0)
                FROM Bookings b
                INNER JOIN Vehicles v
                    ON b.VehicleID = v.VehicleID
                LEFT JOIN Payments p
                    ON b.BookingID = p.BookingID
                WHERE v.OwnerID = @OwnerID
                  AND b.BookingStatus = 'Pending'
                  AND (p.PaymentID IS NULL OR p.PaymentStatus <> 'Paid')";

            using (SqlCommand command = new SqlCommand(pendingQuery, connection))
            {
                command.Parameters.AddWithValue("@OwnerID", ownerID);

                earnings.PendingPayments =
                    Convert.ToDecimal(command.ExecuteScalar());
            }

            // 4. Completed / Confirmed Bookings
            string completedBookingsQuery = @"
                SELECT COUNT(*)
                FROM Bookings b
                INNER JOIN Vehicles v
                    ON b.VehicleID = v.VehicleID
                WHERE v.OwnerID = @OwnerID
                  AND b.BookingStatus = 'Confirmed'";

            using (SqlCommand command =
                   new SqlCommand(completedBookingsQuery, connection))
            {
                command.Parameters.AddWithValue("@OwnerID", ownerID);

                earnings.CompletedBookings =
                    Convert.ToInt32(command.ExecuteScalar());
            }

            // 5. Monthly Earnings for Chart
            string monthlyQuery = @"
                SELECT
                    FORMAT(p.TransactionDate, 'MMM yyyy') AS MonthName,
                    SUM(p.Amount) AS Amount
                FROM Payments p
                INNER JOIN Bookings b
                    ON p.BookingID = b.BookingID
                INNER JOIN Vehicles v
                    ON b.VehicleID = v.VehicleID
                WHERE v.OwnerID = @OwnerID
                  AND p.PaymentStatus = 'Paid'
                  AND b.BookingStatus = 'Confirmed'
                  AND p.TransactionDate >= DATEADD(MONTH, -5,
                      DATEFROMPARTS(YEAR(GETDATE()), MONTH(GETDATE()), 1))
                GROUP BY
                    YEAR(p.TransactionDate),
                    MONTH(p.TransactionDate),
                    FORMAT(p.TransactionDate, 'MMM yyyy')
                ORDER BY
                    YEAR(p.TransactionDate),
                    MONTH(p.TransactionDate)";

            using (SqlCommand command = new SqlCommand(monthlyQuery, connection))
            {
                command.Parameters.AddWithValue("@OwnerID", ownerID);

                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string month =
                        reader["MonthName"]?.ToString() ?? "";

                    decimal amount =
                        Convert.ToDecimal(reader["Amount"]);

                    earnings.MonthlyEarnings[month] = amount;
                }
            }

            return earnings;
        }
    }
}
