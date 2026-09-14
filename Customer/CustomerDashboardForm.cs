using CarRentalManagementSystem.Database;
using CarRentalManagementSystem.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customer
{
    public partial class CustomerDashboardForm : Form
    {
        private readonly int userID;
        private readonly string fullName;

        public CustomerDashboardForm(int userID, string fullName)
        {
            InitializeComponent();

            this.userID = userID;
            this.fullName = fullName;

            lblProfileName.Text = fullName;
            lblWelcome.Text = $"Welcome Back, {fullName}! 👋";

            LoadDashboardStatistics();
            LoadRecentBookings();
        }

        private void LoadDashboardStatistics()
        {
            try
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();

                using SqlConnection connection = databaseHelper.GetConnection();
                connection.Open();

                string availableCarsQuery = @"
                    SELECT COUNT(*)
                    FROM Vehicles
                    WHERE AvailabilityStatus = 'Available'";

                using (SqlCommand command = new SqlCommand(availableCarsQuery, connection))
                {
                    lblAvailableCarsValue.Text =
                        Convert.ToInt32(command.ExecuteScalar()).ToString();
                }

                string bookingsQuery = @"
                    SELECT COUNT(*)
                    FROM Bookings
                    WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(bookingsQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", userID);

                    lblBookingsValue.Text =
                        Convert.ToInt32(command.ExecuteScalar()).ToString();
                }

                string activeRentalsQuery = @"
                    SELECT COUNT(*)
                    FROM Bookings
                    WHERE CustomerID = @CustomerID
                      AND BookingStatus = 'Confirmed'
                      AND CAST(GETDATE() AS date) BETWEEN StartDate AND EndDate";

                using (SqlCommand command = new SqlCommand(activeRentalsQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", userID);

                    lblActiveRentalsValue.Text =
                        Convert.ToInt32(command.ExecuteScalar()).ToString();
                }

                lblFavoritesValue.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load dashboard statistics:\n\n" + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadRecentBookings()
        {
            try
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();

                using SqlConnection connection = databaseHelper.GetConnection();
                connection.Open();

                string query = @"
                    SELECT TOP 3
                        v.Brand + ' ' + v.Model AS Car,
                        b.StartDate,
                        b.EndDate,
                        b.TotalAmount,
                        b.BookingStatus
                    FROM Bookings b
                    INNER JOIN Vehicles v
                        ON b.VehicleID = v.VehicleID
                    WHERE b.CustomerID = @CustomerID
                    ORDER BY b.BookingID DESC";

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", userID);

                using SqlDataReader reader = command.ExecuteReader();

                Label[] carLabels =
                {
                    lblRecentCar1,
                    lblRecentCar2,
                    lblRecentCar3
                };

                Label[] dateLabels =
                {
                    lblRecentDate1,
                    lblRecentDate2,
                    lblRecentDate3
                };

                Label[] amountLabels =
                {
                    lblRecentAmount1,
                    lblRecentAmount2,
                    lblRecentAmount3
                };

                Label[] statusLabels =
                {
                    lblRecentStatus1,
                    lblRecentStatus2,
                    lblRecentStatus3
                };

                for (int i = 0; i < 3; i++)
                {
                    if (reader.Read())
                    {
                        carLabels[i].Text = reader["Car"].ToString();

                        dateLabels[i].Text =
                            $"{Convert.ToDateTime(reader["StartDate"]):dd MMM yyyy} - " +
                            $"{Convert.ToDateTime(reader["EndDate"]):dd MMM yyyy}";

                        amountLabels[i].Text =
                            $"৳{Convert.ToDecimal(reader["TotalAmount"]):N0}";

                        statusLabels[i].Text =
                            reader["BookingStatus"].ToString();

                        statusLabels[i].Visible = true;
                    }
                    else
                    {
                        carLabels[i].Text = "No booking";
                        dateLabels[i].Text = "No recent booking";
                        amountLabels[i].Text = "";
                        statusLabels[i].Visible = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load recent bookings:\n\n" + ex.Message,
                    "Bookings Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardStatistics();
            LoadRecentBookings();
        }

        private void btnBrowseCars_Click(object sender, EventArgs e)
        {
            BrowseCarsForm browseCarsForm =
                new BrowseCarsForm(userID);

            browseCarsForm.ShowDialog(this);

            LoadDashboardStatistics();
            LoadRecentBookings();
        }

        private void btnMyBookings_Click(object sender, EventArgs e)
        {
            MyBookingsForm myBookingsForm =
                new MyBookingsForm(userID);

            myBookingsForm.ShowDialog(this);

            LoadDashboardStatistics();
            LoadRecentBookings();
        }

        private void btnMyPayments_Click(object sender, EventArgs e)
        {
            using (MyPaymentsForm paymentsForm = new MyPaymentsForm(userID))
            {
                paymentsForm.ShowDialog(this);
            }
        }

       

        private void btnHeroBrowse_Click(object sender, EventArgs e)
        {
            btnBrowseCars_Click(sender, e);
        }

        private void btnFeaturedBrowse_Click(object sender, EventArgs e)
        {
            btnBrowseCars_Click(sender, e);
        }

        private void btnRecentViewAll_Click(object sender, EventArgs e)
        {
            btnMyBookings_Click(sender, e);
        }

        private void btnPromoBrowse_Click(object sender, EventArgs e)
        {
            btnBrowseCars_Click(sender, e);
        }

        private void lblChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm =
                new ChangePasswordForm(userID);

            changePasswordForm.ShowDialog(this);
        }

        private void lblDeleteAccount_Click(object sender, EventArgs e)
        {
            DeleteAccountForm deleteAccountForm =
                new DeleteAccountForm(userID);

            deleteAccountForm.ShowDialog(this);

            if (deleteAccountForm.AccountDeleted)
            {
                Close();
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        
    }
}