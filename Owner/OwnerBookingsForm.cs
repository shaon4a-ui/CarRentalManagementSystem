using System;
using System.Data;
using System.Drawing;
using System.IO;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using CarRentalManagementSystem.Database;

namespace CarRentalManagementSystem.Owner
{
    public partial class OwnerBookingsForm : Form
    {
        private readonly int ownerID;
        private readonly DatabaseHelper db = new DatabaseHelper();

        private int currentPage = 1;
        private const int pageSize = 5;
        private int totalRecords = 0;

        public OwnerBookingsForm(int ownerID)
        {
            InitializeComponent();
            this.ownerID = ownerID;
        }

        private void OwnerBookingsForm_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            cmbSort.SelectedIndex = 0;
            LoadOwnerName();
            LoadBookings();
        }

        private void LoadOwnerName()
        {
            try
            {
                using SqlConnection con = db.GetConnection();
                con.Open();

                const string query = @"
                    SELECT FullName, Username
                    FROM Users
                    WHERE UserID = @UserID";

                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", ownerID);

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string fullName = reader["FullName"]?.ToString() ?? "";
                    string username = reader["Username"]?.ToString() ?? "";

                    lblOwnerName.Text =
                        string.IsNullOrWhiteSpace(fullName) ? username : fullName;
                }
            }
            catch
            {
                lblOwnerName.Text = "Owner";
            }
        }

        private void LoadBookings()
        {
            try
            {
                using SqlConnection con = db.GetConnection();
                con.Open();

                string where = @"
                    FROM Bookings b
                    INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                    INNER JOIN Users u ON b.CustomerID = u.UserID
                    OUTER APPLY
                    (
                        SELECT TOP 1
                            p.PaymentStatus,
                            p.PaymentMethod
                        FROM Payments p
                        WHERE p.BookingID = b.BookingID
                        ORDER BY p.PaymentID DESC
                    ) pay
                    WHERE v.OwnerID = @OwnerID";

                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    where += @"
                        AND
                        (
                            u.FullName LIKE '%' + @Search + '%'
                            OR v.Brand LIKE '%' + @Search + '%'
                            OR v.Model LIKE '%' + @Search + '%'
                            OR CAST(b.BookingID AS NVARCHAR(20)) LIKE '%' + @Search + '%'
                        )";
                }

                if (cmbStatus.SelectedItem?.ToString() != "All Status")
                    where += " AND b.BookingStatus = @Status";

                if (chkFrom.Checked)
                    where += " AND b.StartDate >= @FromDate";

                if (chkTo.Checked)
                    where += " AND b.EndDate <= @ToDate";

                string countQuery = "SELECT COUNT(*) " + where;

                using (SqlCommand countCommand =
                    new SqlCommand(countQuery, con))
                {
                    AddFilterParameters(countCommand);
                    totalRecords = Convert.ToInt32(countCommand.ExecuteScalar());
                }

                int totalPages =
                    Math.Max(1, (int)Math.Ceiling(totalRecords / (double)pageSize));

                if (currentPage > totalPages)
                    currentPage = totalPages;

                string orderBy = "b.BookingID DESC";

                if (cmbSort.SelectedItem?.ToString() == "Oldest First")
                    orderBy = "b.BookingID ASC";
                else if (cmbSort.SelectedItem?.ToString() == "Amount: High to Low")
                    orderBy = "b.TotalAmount DESC";
                else if (cmbSort.SelectedItem?.ToString() == "Amount: Low to High")
                    orderBy = "b.TotalAmount ASC";
                else if (cmbSort.SelectedItem?.ToString() == "Start Date")
                    orderBy = "b.StartDate DESC";

                int offset = (currentPage - 1) * pageSize;

                string query = $@"
                    SELECT
                        b.BookingID,
                        v.Brand + ' ' + v.Model AS CarName,
                        v.VehicleType,
                        v.Year AS CarYear,
                        v.ImagePath,
                        u.FullName AS CustomerName,
                        u.Email AS CustomerEmail,
                        u.Username AS CustomerUsername,
                        b.StartDate,
                        b.EndDate,
                        b.TotalAmount,
                        b.BookingStatus,
                        ISNULL(pay.PaymentStatus, 'Unpaid') AS PaymentStatus,
                        ISNULL(pay.PaymentMethod, '') AS PaymentMethod
                    {where}
                    ORDER BY {orderBy}
                    OFFSET @Offset ROWS
                    FETCH NEXT @PageSize ROWS ONLY";

                using SqlCommand cmd = new SqlCommand(query, con);
                AddFilterParameters(cmd);
                cmd.Parameters.AddWithValue("@Offset", offset);
                cmd.Parameters.AddWithValue("@PageSize", pageSize);

                dgvBookings.Rows.Clear();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int rowIndex = dgvBookings.Rows.Add();

                        DataGridViewRow row = dgvBookings.Rows[rowIndex];

                        row.Cells["colBookingID"].Value =
                            "#" + reader["BookingID"];

                        row.Cells["colCarImage"].Value =
                            LoadImage(reader["ImagePath"]?.ToString() ?? "");

                        row.Cells["colCar"].Value =
                            $"{reader["CarName"]?.ToString() ?? ""}\r\n" +
                            $"{reader["VehicleType"]?.ToString() ?? ""} · {reader["CarYear"]?.ToString() ?? ""}";

                        row.Cells["colCustomer"].Value =
                            $"{reader["CustomerName"]?.ToString() ?? ""}\r\n" +
                            $"{reader["CustomerEmail"]?.ToString() ?? ""}";

                        row.Cells["colStartDate"].Value =
                            Convert.ToDateTime(reader["StartDate"]).ToString("dd MMM yyyy");

                        row.Cells["colEndDate"].Value =
                            Convert.ToDateTime(reader["EndDate"]).ToString("dd MMM yyyy");

                        decimal amount = Convert.ToDecimal(reader["TotalAmount"]);

                        row.Cells["colAmount"].Value =
                            $"৳ {amount:N0}";

                        row.Cells["colStatus"].Value =
                            reader["BookingStatus"]?.ToString() ?? "";

                        row.Cells["colPayment"].Value =
                            reader["PaymentStatus"]?.ToString() ?? "Unpaid";

                        row.Cells["colView"].Value = "View";

                        string status =
                            reader["BookingStatus"]?.ToString() ?? "";

                        string paymentStatus =
                            reader["PaymentStatus"]?.ToString() ?? "Unpaid";

                        // Owner action rules:
                        // Pending + Paid     -> Confirm enabled
                        // Pending + Unpaid   -> Cancel enabled
                        // Confirmed + Paid   -> Return enabled
                        // Completed/Cancelled -> all actions locked
                        bool canConfirm =
                            status.Equals("Pending", StringComparison.OrdinalIgnoreCase) &&
                            paymentStatus.Equals("Paid", StringComparison.OrdinalIgnoreCase);

                        bool canCancel =
                            status.Equals("Pending", StringComparison.OrdinalIgnoreCase) &&
                            paymentStatus.Equals("Unpaid", StringComparison.OrdinalIgnoreCase);

                        bool canReturn =
                            status.Equals("Confirmed", StringComparison.OrdinalIgnoreCase) &&
                            paymentStatus.Equals("Paid", StringComparison.OrdinalIgnoreCase);

                        row.Cells["colConfirm"].Value =
                            canConfirm ? "✓ Confirm" : "—";
                        row.Cells["colConfirm"].ReadOnly = true;

                        row.Cells["colCancel"].Value =
                            canCancel ? "✕ Cancel" : "—";
                        row.Cells["colCancel"].ReadOnly = true;

                        row.Cells["colReturn"].Value =
                            canReturn ? "↻ Return" : "—";
                        row.Cells["colReturn"].ReadOnly = true;

                        // Store the current action permissions with the row so the
                        // click handler can enforce the same rules as the UI.
                        row.Tag = new BookingRowData
                        {
                            BookingID = Convert.ToInt32(reader["BookingID"]),
                            CarName = reader["CarName"]?.ToString() ?? "",
                            CustomerName = reader["CustomerName"]?.ToString() ?? "",
                            CustomerEmail = reader["CustomerEmail"]?.ToString() ?? "",
                            StartDate = Convert.ToDateTime(reader["StartDate"]),
                            EndDate = Convert.ToDateTime(reader["EndDate"]),
                            Amount = amount,
                            BookingStatus = status,
                            PaymentStatus = paymentStatus,
                            PaymentMethod = reader["PaymentMethod"]?.ToString() ?? "",
                            CanConfirm = canConfirm,
                            CanCancel = canCancel,
                            CanReturn = canReturn
                        };

                        continue;

                    }
                }

                // The DataReader is now closed before these additional commands execute.
                UpdateStatistics(con);
                UpdatePagination();
                ApplyRowColors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load bookings.\n\n" + ex.Message,
                    "Owner Bookings",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void AddFilterParameters(SqlCommand command)
        {
            command.Parameters.AddWithValue("@OwnerID", ownerID);
            command.Parameters.AddWithValue(
                "@Search",
                txtSearch.Text.Trim());

            if (cmbStatus.SelectedItem?.ToString() != "All Status")
            {
                command.Parameters.AddWithValue(
                    "@Status",
                    cmbStatus.SelectedItem?.ToString() ?? "");
            }

            if (chkFrom.Checked)
                command.Parameters.AddWithValue(
                    "@FromDate",
                    dtpFrom.Value.Date);

            if (chkTo.Checked)
                command.Parameters.AddWithValue(
                    "@ToDate",
                    dtpTo.Value.Date.AddDays(1).AddTicks(-1));
        }

        private Image LoadImage(string imagePath)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(imagePath))
                    return null;

                string normalized = imagePath.Trim()
                    .Replace('/', Path.DirectorySeparatorChar)
                    .Replace('\\', Path.DirectorySeparatorChar);

                string[] possiblePaths;

                if (Path.IsPathRooted(normalized))
                {
                    possiblePaths = new[] { normalized };
                }
                else
                {
                    string fileName = Path.GetFileName(normalized);

                    possiblePaths = new[]
                    {
                        Path.Combine(AppContext.BaseDirectory, normalized),
                        Path.Combine(AppContext.BaseDirectory, "Images", fileName),
                        Path.Combine(AppContext.BaseDirectory, fileName)
                    };
                }

                string fullPath = null;

                foreach (string path in possiblePaths)
                {
                    if (File.Exists(path))
                    {
                        fullPath = path;
                        break;
                    }
                }

                if (string.IsNullOrWhiteSpace(fullPath))
                    return null;

                // Create an independent bitmap so the source file is not locked.
                using (FileStream stream = new FileStream(
                    fullPath, FileMode.Open, FileAccess.Read, FileShare.Read))
                using (Image original = Image.FromStream(stream))
                {
                    return new Bitmap(original, new Size(72, 48));
                }
            }
            catch
            {
                return null;
            }
        }

        private void UpdateStatistics(SqlConnection con)
        {
            lblTotalValue.Text = ExecuteScalarCount(
                con,
                @"SELECT COUNT(*)
                  FROM Bookings b
                  INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                  WHERE v.OwnerID = @OwnerID");

            lblConfirmedValue.Text = ExecuteScalarCount(
                con,
                @"SELECT COUNT(*)
                  FROM Bookings b
                  INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                  WHERE v.OwnerID = @OwnerID
                    AND b.BookingStatus = 'Confirmed'");

            lblPendingValue.Text = ExecuteScalarCount(
                con,
                @"SELECT COUNT(*)
                  FROM Bookings b
                  INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                  WHERE v.OwnerID = @OwnerID
                    AND b.BookingStatus = 'Pending'");

            lblCompletedValue.Text = ExecuteScalarCount(
                con,
                @"SELECT COUNT(*)
                  FROM Bookings b
                  INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                  WHERE v.OwnerID = @OwnerID
                    AND b.BookingStatus = 'Completed'");
        }

        private string ExecuteScalarCount(SqlConnection con, string query)
        {
            using SqlCommand command = new SqlCommand(query, con);
            command.Parameters.AddWithValue("@OwnerID", ownerID);

            return Convert.ToInt32(command.ExecuteScalar()).ToString();
        }

        private void UpdatePagination()
        {
            int totalPages =
                Math.Max(1, (int)Math.Ceiling(totalRecords / (double)pageSize));

            lblPageInfo.Text =
                $"Showing {Math.Min(totalRecords, ((currentPage - 1) * pageSize) + 1)}" +
                $" to {Math.Min(totalRecords, currentPage * pageSize)}" +
                $" of {totalRecords} booking{(totalRecords == 1 ? "" : "s")}";

            lblPageNumber.Text = currentPage.ToString();
            btnPrevious.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
        }

        private void ApplyRowColors()
        {
            foreach (DataGridViewRow row in dgvBookings.Rows)
            {
                if (row.Cells["colStatus"].Value != null)
                {
                    string status =
                        row.Cells["colStatus"].Value.ToString() ?? "";

                    if (status == "Pending")
                    {
                        row.Cells["colStatus"].Style.BackColor =
                            Color.FromArgb(255, 247, 224);
                        row.Cells["colStatus"].Style.ForeColor =
                            Color.FromArgb(194, 112, 0);
                    }
                    else if (status == "Confirmed")
                    {
                        row.Cells["colStatus"].Style.BackColor =
                            Color.FromArgb(220, 252, 231);
                        row.Cells["colStatus"].Style.ForeColor =
                            Color.FromArgb(22, 101, 52);
                    }
                    else if (status == "Completed")
                    {
                        row.Cells["colStatus"].Style.BackColor =
                            Color.FromArgb(237, 233, 254);
                        row.Cells["colStatus"].Style.ForeColor =
                            Color.FromArgb(109, 40, 217);
                    }
                    else if (status == "Cancelled")
                    {
                        row.Cells["colStatus"].Style.BackColor =
                            Color.FromArgb(254, 226, 226);
                        row.Cells["colStatus"].Style.ForeColor =
                            Color.FromArgb(185, 28, 28);
                    }
                }

                if (row.Cells["colPayment"].Value != null)
                {
                    string payment =
                        row.Cells["colPayment"].Value.ToString() ?? "";

                    if (payment == "Paid")
                    {
                        row.Cells["colPayment"].Style.BackColor =
                            Color.FromArgb(220, 252, 231);
                        row.Cells["colPayment"].Style.ForeColor =
                            Color.FromArgb(22, 101, 52);
                    }
                    else
                    {
                        row.Cells["colPayment"].Style.BackColor =
                            Color.FromArgb(254, 226, 226);
                        row.Cells["colPayment"].Style.ForeColor =
                            Color.FromArgb(185, 28, 28);
                    }
                }
            }
        }

        private BookingRowData GetBookingRow(int rowIndex)
        {
            if (rowIndex < 0 ||
                rowIndex >= dgvBookings.Rows.Count)
                return null;

            return dgvBookings.Rows[rowIndex].Tag as BookingRowData;
        }

        private void dgvBookings_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            BookingRowData booking =
                GetBookingRow(e.RowIndex);

            if (booking == null)
                return;

            string columnName =
                dgvBookings.Columns[e.ColumnIndex].Name;

            if (columnName == "colView")
            {
                ViewBooking(booking);
            }
            else if (columnName == "colConfirm" && booking.CanConfirm)
            {
                ConfirmBooking(booking);
            }
            else if (columnName == "colCancel" && booking.CanCancel)
            {
                CancelBooking(booking);
            }
            else if (columnName == "colReturn" && booking.CanReturn)
            {
                MarkBookingReturned(booking);
            }
        }

        private void ViewBooking(BookingRowData booking)
        {
            MessageBox.Show(
                $"Booking #{booking.BookingID}\n\n" +
                $"Car: {booking.CarName}\n" +
                $"Customer: {booking.CustomerName}\n" +
                $"Email: {booking.CustomerEmail}\n\n" +
                $"Start: {booking.StartDate:dd MMM yyyy}\n" +
                $"End: {booking.EndDate:dd MMM yyyy}\n" +
                $"Amount: ৳{booking.Amount:N0}\n" +
                $"Booking Status: {booking.BookingStatus}\n" +
                $"Payment: {booking.PaymentStatus}" +
                (string.IsNullOrWhiteSpace(booking.PaymentMethod)
                    ? ""
                    : $"\nPayment Method: {booking.PaymentMethod}"),
                "Booking Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void ConfirmBooking(BookingRowData booking)
        {
            if (!booking.CanConfirm)
                return;

            DialogResult result = MessageBox.Show(
                $"Confirm booking #{booking.BookingID} for {booking.CustomerName}?\n\n" +
                $"Vehicle: {booking.CarName}\n" +
                $"Amount: ৳{booking.Amount:N0}",
                "Confirm Booking",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using SqlConnection con = db.GetConnection();
                con.Open();

                const string query = @"
                    UPDATE b
                    SET BookingStatus = 'Confirmed'
                    FROM Bookings b
                    INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                    WHERE b.BookingID = @BookingID
                      AND v.OwnerID = @OwnerID
                      AND b.BookingStatus = 'Pending'
                      AND EXISTS
                      (
                          SELECT 1
                          FROM Payments p
                          WHERE p.BookingID = b.BookingID
                            AND p.PaymentStatus = 'Paid'
                      )";

                using SqlCommand command =
                    new SqlCommand(query, con);

                command.Parameters.AddWithValue(
                    "@BookingID",
                    booking.BookingID);

                command.Parameters.AddWithValue(
                    "@OwnerID",
                    ownerID);

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(
                        "Booking confirmed successfully.",
                        "Booking Confirmed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadBookings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not confirm the booking.\n\n" + ex.Message,
                    "Confirm Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void MarkBookingReturned(BookingRowData booking)
        {
            if (!booking.CanReturn)
                return;

            DialogResult result = MessageBox.Show(
                $"Mark booking #{booking.BookingID} as completed?\\n\\n" +
                $"Customer: {booking.CustomerName}\\n" +
                $"Vehicle: {booking.CarName}\\n" +
                $"Return date: {DateTime.Today:dd MMM yyyy}\\n\\n" +
                "This means the customer has returned the vehicle.",
                "Complete Rental",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using SqlConnection con = db.GetConnection();
                con.Open();

                using SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    const string bookingQuery = @"
                        UPDATE b
                        SET BookingStatus = 'Completed'
                        FROM Bookings b
                        INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                        WHERE b.BookingID = @BookingID
                          AND v.OwnerID = @OwnerID
                          AND b.BookingStatus = 'Confirmed'
                          AND EXISTS
                          (
                              SELECT 1
                              FROM Payments p
                              WHERE p.BookingID = b.BookingID
                                AND p.PaymentStatus = 'Paid'
                          )";

                    using (SqlCommand bookingCommand =
                        new SqlCommand(bookingQuery, con, transaction))
                    {
                        bookingCommand.Parameters.AddWithValue(
                            "@BookingID", booking.BookingID);
                        bookingCommand.Parameters.AddWithValue(
                            "@OwnerID", ownerID);

                        if (bookingCommand.ExecuteNonQuery() == 0)
                        {
                            transaction.Rollback();
                            MessageBox.Show(
                                "The booking could not be completed. It may have already been changed.",
                                "Complete Rental",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            return;
                        }
                    }

                    const string vehicleQuery = @"
                        UPDATE v
                        SET AvailabilityStatus = 'Available'
                        FROM Vehicles v
                        INNER JOIN Bookings b ON b.VehicleID = v.VehicleID
                        WHERE b.BookingID = @BookingID
                          AND v.OwnerID = @OwnerID";

                    using (SqlCommand vehicleCommand =
                        new SqlCommand(vehicleQuery, con, transaction))
                    {
                        vehicleCommand.Parameters.AddWithValue(
                            "@BookingID", booking.BookingID);
                        vehicleCommand.Parameters.AddWithValue(
                            "@OwnerID", ownerID);

                        vehicleCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show(
                        "Rental completed successfully. The vehicle is now available.",
                        "Rental Completed",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadBookings();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not complete the rental.\\n\\n" + ex.Message,
                    "Complete Rental",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CancelBooking(BookingRowData booking)
        {
            if (!booking.CanCancel)
                return;

            DialogResult result = MessageBox.Show(
                $"Cancel booking #{booking.BookingID}?\n\n" +
                $"Customer: {booking.CustomerName}\n" +
                $"Vehicle: {booking.CarName}",
                "Cancel Booking",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using SqlConnection con = db.GetConnection();
                con.Open();

                const string query = @"
                    UPDATE b
                    SET BookingStatus = 'Cancelled'
                    FROM Bookings b
                    INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                    WHERE b.BookingID = @BookingID
                      AND v.OwnerID = @OwnerID
                      AND b.BookingStatus = 'Pending'
                      AND NOT EXISTS
                      (
                          SELECT 1
                          FROM Payments p
                          WHERE p.BookingID = b.BookingID
                            AND p.PaymentStatus = 'Paid'
                      )";

                using SqlCommand command =
                    new SqlCommand(query, con);

                command.Parameters.AddWithValue(
                    "@BookingID",
                    booking.BookingID);

                command.Parameters.AddWithValue(
                    "@OwnerID",
                    ownerID);

                if (command.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(
                        "Booking cancelled successfully.",
                        "Booking Cancelled",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadBookings();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not cancel the booking.\n\n" + ex.Message,
                    "Cancel Booking",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            LoadBookings();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbStatus.SelectedIndex = 0;
            cmbSort.SelectedIndex = 0;
            chkFrom.Checked = false;
            chkTo.Checked = false;
            currentPage = 1;

            LoadBookings();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadBookings();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated)
            {
                currentPage = 1;
                LoadBookings();
            }
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated)
            {
                currentPage = 1;
                LoadBookings();
            }
        }

        private void DateFilterChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated)
            {
                currentPage = 1;
                LoadBookings();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                LoadBookings();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int totalPages =
                Math.Max(1, (int)Math.Ceiling(totalRecords / (double)pageSize));

            if (currentPage < totalPages)
            {
                currentPage++;
                LoadBookings();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private sealed class BookingRowData
        {
            public int BookingID { get; set; }
            public string CarName { get; set; } = "";
            public string CustomerName { get; set; } = "";
            public string CustomerEmail { get; set; } = "";
            public DateTime StartDate { get; set; }
            public DateTime EndDate { get; set; }
            public decimal Amount { get; set; }
            public string BookingStatus { get; set; } = "";
            public string PaymentStatus { get; set; } = "";
            public string PaymentMethod { get; set; } = "";
            public bool CanConfirm { get; set; }
            public bool CanCancel { get; set; }
            public bool CanReturn { get; set; }
        }
    }
}
