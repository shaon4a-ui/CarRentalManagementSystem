using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;

namespace CarRentalManagementSystem.Customer
{
    public partial class MyBookingsForm : Form
    {
        private readonly int customerID;
        private DataTable bookingsTable = new DataTable();
        private int selectedBookingID = 0;

        public MyBookingsForm(int customerID)
        {
            InitializeComponent();

            this.customerID = customerID;

            this.Load += MyBookingsForm_Load;
            this.Activated += MyBookingsForm_Activated;
        }

        // ============================================================
        // FORM LOAD
        // ============================================================

        private void MyBookingsForm_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void MyBookingsForm_Activated(object sender, EventArgs e)
        {
            LoadBookings();
        }

        // ============================================================
        // LOAD BOOKINGS
        // ============================================================

        private void LoadBookings()
        {
            try
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();

                using SqlConnection connection = databaseHelper.GetConnection();
                connection.Open();

                string query = @"
                    SELECT
                        b.BookingID AS [Booking ID],
                        v.Brand + ' ' + v.Model AS [Car],
                        v.VehicleType AS [Type],
                        v.Seats AS [Seats],
                        v.Location AS [Location],
                        v.ImagePath AS [ImagePath],
                        b.StartDate AS [Start Date],
                        b.EndDate AS [End Date],
                        b.TotalAmount AS [Total Amount],
                        b.BookingStatus AS [Booking Status],
                        ISNULL(p.PaymentStatus, 'Not Paid') AS [Payment Status]
                    FROM Bookings b
                    INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                    OUTER APPLY (
                        SELECT TOP 1 PaymentStatus
                        FROM Payments p
                        WHERE p.BookingID = b.BookingID
                        ORDER BY p.PaymentID DESC
                    ) p
                    WHERE b.CustomerID = @CustomerID
                    ORDER BY b.BookingID DESC";

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerID);

                using SqlDataAdapter adapter = new SqlDataAdapter(command);

                bookingsTable = new DataTable();
                adapter.Fill(bookingsTable);

                UpdateSummaryCards();
                ApplySearchAndFilter();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Could not load your bookings.\n\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSummaryCards()
        {
            int total = bookingsTable.Rows.Count;
            int active = 0;
            int completed = 0;
            DateTime today = DateTime.Today;

            foreach (DataRow row in bookingsTable.Rows)
            {
                string status = row["Booking Status"]?.ToString() ?? "";
                DateTime start = Convert.ToDateTime(row["Start Date"]).Date;
                DateTime end = Convert.ToDateTime(row["End Date"]).Date;

                if (status.Equals("Confirmed", StringComparison.OrdinalIgnoreCase) &&
                    today >= start && today <= end)
                    active++;

                if (!status.Equals("Cancelled", StringComparison.OrdinalIgnoreCase) &&
                    end < today)
                    completed++;
            }

            lblTotalBookingsValue.Text = total.ToString();
            lblActiveRentalsValue.Text = active.ToString();
            lblCompletedValue.Text = completed.ToString();
        }

        private void DisplayBookings(DataTable table)
        {
            Panel[] cards = { card1, card2, card3, card4, card5, card6 };
            PictureBox[] pictures = { picCar1, picCar2, picCar3, picCar4, picCar5, picCar6 };
            Label[] numbers = { lblBookingNumber1, lblBookingNumber2, lblBookingNumber3, lblBookingNumber4, lblBookingNumber5, lblBookingNumber6 };
            Label[] names = { lblCarName1, lblCarName2, lblCarName3, lblCarName4, lblCarName5, lblCarName6 };
            Label[] infos = { lblCarInfo1, lblCarInfo2, lblCarInfo3, lblCarInfo4, lblCarInfo5, lblCarInfo6 };
            Label[] dates = { lblBookingDates1, lblBookingDates2, lblBookingDates3, lblBookingDates4, lblBookingDates5, lblBookingDates6 };
            Label[] amounts = { lblBookingAmount1, lblBookingAmount2, lblBookingAmount3, lblBookingAmount4, lblBookingAmount5, lblBookingAmount6 };
            Label[] payments = { lblPaymentStatus1, lblPaymentStatus2, lblPaymentStatus3, lblPaymentStatus4, lblPaymentStatus5, lblPaymentStatus6 };
            Label[] statuses = { lblBookingStatus1, lblBookingStatus2, lblBookingStatus3, lblBookingStatus4, lblBookingStatus5, lblBookingStatus6 };
            Button[] buttons = { btnViewDetails1, btnViewDetails2, btnViewDetails3, btnViewDetails4, btnViewDetails5, btnViewDetails6 };

            for (int i = 0; i < cards.Length; i++)
            {
                cards[i].Visible = false;
                buttons[i].Tag = null;
                pictures[i].Image = null;
            }

            lblResults.Text = $"{table.Rows.Count} booking(s) found";
            lblNoBookings.Visible = table.Rows.Count == 0;

            int count = Math.Min(table.Rows.Count, cards.Length);

            for (int i = 0; i < count; i++)
            {
                DataRow row = table.Rows[i];

                int id = Convert.ToInt32(row["Booking ID"]);
                string status = row["Booking Status"]?.ToString() ?? "";
                string payment = row["Payment Status"]?.ToString() ?? "";

                numbers[i].Text = $"Booking #{id}";
                names[i].Text = row["Car"]?.ToString() ?? "";
                infos[i].Text = $"{row["Type"]}  •  {row["Seats"]} Seats  •  {row["Location"]}";
                dates[i].Text = $"📅  {Convert.ToDateTime(row["Start Date"]):dd MMM yyyy}  →  {Convert.ToDateTime(row["End Date"]):dd MMM yyyy}";
                amounts[i].Text = $"💰  ৳{Convert.ToDecimal(row["Total Amount"]):N0}";
                payments[i].Text = $"Payment: {payment}";
                statuses[i].Text = status;

                if (status.Equals("Confirmed", StringComparison.OrdinalIgnoreCase))
                {
                    statuses[i].BackColor = Color.FromArgb(220, 247, 232);
                    statuses[i].ForeColor = Color.FromArgb(22, 125, 67);
                }
                else if (status.Equals("Pending", StringComparison.OrdinalIgnoreCase))
                {
                    statuses[i].BackColor = Color.FromArgb(255, 243, 205);
                    statuses[i].ForeColor = Color.FromArgb(150, 95, 0);
                }
                else
                {
                    statuses[i].BackColor = Color.FromArgb(248, 225, 228);
                    statuses[i].ForeColor = Color.FromArgb(190, 45, 62);
                }

                payments[i].ForeColor = payment.Equals("Paid", StringComparison.OrdinalIgnoreCase)
                    ? Color.FromArgb(22, 125, 67)
                    : Color.FromArgb(190, 95, 20);

                LoadBookingImage(pictures[i], row["ImagePath"]?.ToString() ?? "");
                buttons[i].Tag = id;
                cards[i].Visible = true;
            }

            if (table.Rows.Count > cards.Length)
                lblResults.Text = $"{table.Rows.Count} booking(s) found  •  Showing first {cards.Length}";
        }

        private void LoadBookingImage(PictureBox pictureBox, string imagePath)
        {
            try
            {
                pictureBox.Image = null;
                if (string.IsNullOrWhiteSpace(imagePath))
                    return;

                string cleanPath = imagePath.Replace("/", System.IO.Path.DirectorySeparatorChar.ToString())
                    .Replace("\\", System.IO.Path.DirectorySeparatorChar.ToString());
                string fullPath = System.IO.Path.Combine(Application.StartupPath, cleanPath);

                if (!System.IO.File.Exists(fullPath))
                    return;

                using System.IO.FileStream stream = new System.IO.FileStream(
                    fullPath, System.IO.FileMode.Open, System.IO.FileAccess.Read);
                using Image original = Image.FromStream(stream);
                pictureBox.Image = new Bitmap(original);
            }
            catch
            {
                pictureBox.Image = null;
            }
        }

        private void ApplySearchAndFilter()
        {
            if (bookingsTable == null)
                return;

            string search = txtSearch.Text.Trim();
            string selected = cmbStatusFilter.SelectedItem?.ToString() ?? "All Statuses";
            DataTable filtered = bookingsTable.Clone();

            foreach (DataRow row in bookingsTable.Rows)
            {
                string id = row["Booking ID"]?.ToString() ?? "";
                string car = row["Car"]?.ToString() ?? "";
                string status = row["Booking Status"]?.ToString() ?? "";

                bool matchSearch = string.IsNullOrWhiteSpace(search) ||
                    id.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    car.Contains(search, StringComparison.OrdinalIgnoreCase);

                bool matchStatus = selected == "All Statuses" ||
                    status.Equals(selected, StringComparison.OrdinalIgnoreCase);

                if (matchSearch && matchStatus)
                    filtered.ImportRow(row);
            }

            DisplayBookings(filtered);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplySearchAndFilter();
                e.SuppressKeyPress = true;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplySearchAndFilter();
        }

        private void cmbStatusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplySearchAndFilter();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbStatusFilter.SelectedIndex = 0;
            LoadBookings();
        }

        private DataRow FindBooking(int bookingID)
        {
            foreach (DataRow row in bookingsTable.Rows)
                if (Convert.ToInt32(row["Booking ID"]) == bookingID)
                    return row;
            return null;
        }

        private void SelectBooking(int bookingID)
        {
            DataRow row = FindBooking(bookingID);
            if (row == null)
                return;

            selectedBookingID = bookingID;

            string status = row["Booking Status"]?.ToString() ?? "";
            string payment = row["Payment Status"]?.ToString() ?? "";

            bool allowed = status.Equals("Pending", StringComparison.OrdinalIgnoreCase) &&
                           payment.Equals("Not Paid", StringComparison.OrdinalIgnoreCase);

            btnCancelBooking.Enabled = allowed;
            btnPayNow.Enabled = allowed;

        }
            private void SelectBookingFromCard(object sender, EventArgs e)
        {
            if (sender is Control control && control.Tag != null)
            {
                int bookingID = Convert.ToInt32(control.Tag);
                SelectBooking(bookingID);
            }

        }

        private void ViewBookingDetails(int bookingID)
        {
            DataRow row = FindBooking(bookingID);
            if (row == null)
                return;

            SelectBooking(bookingID);

            MessageBox.Show(
                $"Booking #{bookingID}\n\n" +
                $"Car: {row["Car"]}\n" +
                $"Type: {row["Type"]}\n" +
                $"Seats: {row["Seats"]}\n" +
                $"Location: {row["Location"]}\n\n" +
                $"Rental Period: {Convert.ToDateTime(row["Start Date"]):dd MMM yyyy} - {Convert.ToDateTime(row["End Date"]):dd MMM yyyy}\n" +
                $"Total Amount: ৳{Convert.ToDecimal(row["Total Amount"]):N0}\n\n" +
                $"Booking Status: {row["Booking Status"]}\n" +
                $"Payment Status: {row["Payment Status"]}",
                "Booking Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnViewDetails1_Click(object sender, EventArgs e) { ViewBookingDetails(Convert.ToInt32(btnViewDetails1.Tag)); }
        private void btnViewDetails2_Click(object sender, EventArgs e) { ViewBookingDetails(Convert.ToInt32(btnViewDetails2.Tag)); }
        private void btnViewDetails3_Click(object sender, EventArgs e) { ViewBookingDetails(Convert.ToInt32(btnViewDetails3.Tag)); }
        private void btnViewDetails4_Click(object sender, EventArgs e) { ViewBookingDetails(Convert.ToInt32(btnViewDetails4.Tag)); }
        private void btnViewDetails5_Click(object sender, EventArgs e) { ViewBookingDetails(Convert.ToInt32(btnViewDetails5.Tag)); }
        private void btnViewDetails6_Click(object sender, EventArgs e) { ViewBookingDetails(Convert.ToInt32(btnViewDetails6.Tag)); }

        private void btnPayNow_Click(object sender, EventArgs e)
        {
            if (selectedBookingID == 0)
            {
                MessageBox.Show("Please click View Details on a booking first.", "Pay Now",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRow row = FindBooking(selectedBookingID);
            if (row == null) return;

            try
            {
                if (!row["Booking Status"].ToString().Equals("Pending", StringComparison.OrdinalIgnoreCase) ||
                    !row["Payment Status"].ToString().Equals("Not Paid", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This booking cannot be paid.", "Payment",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadBookings();
                    return;
                }

                using PaymentForm paymentForm = new PaymentForm(
                    selectedBookingID,
                    Convert.ToDecimal(row["Total Amount"]),
                    row["Car"].ToString(),
                    Convert.ToDateTime(row["Start Date"]),
                    Convert.ToDateTime(row["End Date"]));

                paymentForm.ShowDialog(this);
                selectedBookingID = 0;
                LoadBookings();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open the payment screen.\n\n" + ex.Message,
                    "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (selectedBookingID == 0)
            {
                MessageBox.Show("Please click View Details on a booking first.",
                    "Cancel Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DataRow row = FindBooking(selectedBookingID);
                if (row == null) return;

                if (!row["Booking Status"].ToString().Equals("Pending", StringComparison.OrdinalIgnoreCase) ||
                    !row["Payment Status"].ToString().Equals("Not Paid", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show(
                        "Only unpaid pending bookings can be cancelled. Paid bookings require a refund process and cannot be cancelled here.",
                        "Cancel Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to cancel this booking?",
                    "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    return;

                using SqlConnection connection = new DatabaseHelper().GetConnection();
                connection.Open();

                string query = @"
                    UPDATE Bookings
                    SET BookingStatus = 'Cancelled'
                    WHERE BookingID = @BookingID
                      AND CustomerID = @CustomerID
                      AND BookingStatus = 'Pending'";

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BookingID", selectedBookingID);
                command.Parameters.AddWithValue("@CustomerID", customerID);

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Booking cancelled successfully.",
                        "Booking Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    selectedBookingID = 0;
                    LoadBookings();
                }
                else
                {
                    MessageBox.Show("The booking could not be cancelled.",
                        "Cancel Booking", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Could not cancel the booking.\n\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}