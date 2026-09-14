using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;

namespace CarRentalManagementSystem.Owner
{
    public partial class OwnerDashboardForm : Form
    {
        private readonly int userID;
        private readonly string fullName;

        private int totalCars;
        private int availableCars;
        private int rentedCars;
        private decimal totalEarnings;
        private decimal pendingAmount;

        public OwnerDashboardForm(int userID, string fullName)
        {
            InitializeComponent();

            this.userID = userID;
            this.fullName = fullName;

            lblOwnerName.Text = fullName;
            lblPageTitle.Text = $"Welcome back, {fullName}! 👋";

            if (cmbEarningsPeriod.Items.Count > 0)
                cmbEarningsPeriod.SelectedIndex = 0;
        }

        private void OwnerDashboardForm_Load(object sender, EventArgs e)
        {
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

                string totalCarsQuery = @"
                    SELECT COUNT(*)
                    FROM Vehicles
                    WHERE OwnerID = @OwnerID";

                using (SqlCommand command = new SqlCommand(totalCarsQuery, connection))
                {
                    command.Parameters.AddWithValue("@OwnerID", userID);
                    totalCars = Convert.ToInt32(command.ExecuteScalar());
                }

                string availableCarsQuery = @"
                    SELECT COUNT(*)
                    FROM Vehicles
                    WHERE OwnerID = @OwnerID
                      AND AvailabilityStatus = 'Available'";

                using (SqlCommand command = new SqlCommand(availableCarsQuery, connection))
                {
                    command.Parameters.AddWithValue("@OwnerID", userID);
                    availableCars = Convert.ToInt32(command.ExecuteScalar());
                }

                string rentedCarsQuery = @"
                    SELECT COUNT(DISTINCT b.VehicleID)
                    FROM Bookings b
                    INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                    WHERE v.OwnerID = @OwnerID
                      AND b.BookingStatus = 'Confirmed'
                      AND b.StartDate <= CAST(GETDATE() AS DATE)
                      AND b.EndDate > CAST(GETDATE() AS DATE)";

                using (SqlCommand command = new SqlCommand(rentedCarsQuery, connection))
                {
                    command.Parameters.AddWithValue("@OwnerID", userID);
                    rentedCars = Convert.ToInt32(command.ExecuteScalar());
                }

                string earningsQuery = @"
                    SELECT ISNULL(SUM(p.Amount), 0)
                    FROM Payments p
                    INNER JOIN Bookings b ON p.BookingID = b.BookingID
                    INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                    WHERE v.OwnerID = @OwnerID
                      AND p.PaymentStatus = 'Paid'
                      AND b.BookingStatus = 'Confirmed'";

                using (SqlCommand command = new SqlCommand(earningsQuery, connection))
                {
                    command.Parameters.AddWithValue("@OwnerID", userID);
                    totalEarnings = Convert.ToDecimal(command.ExecuteScalar());
                }

                string pendingBookingsQuery = @"
                    SELECT COUNT(*)
                    FROM Bookings b
                    INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                    WHERE v.OwnerID = @OwnerID
                      AND b.BookingStatus = 'Pending'";

                int pendingBookings;

                using (SqlCommand command = new SqlCommand(pendingBookingsQuery, connection))
                {
                    command.Parameters.AddWithValue("@OwnerID", userID);
                    pendingBookings = Convert.ToInt32(command.ExecuteScalar());
                }

                string pendingAmountQuery = @"
                    SELECT ISNULL(SUM(b.TotalAmount), 0)
                    FROM Bookings b
                    INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                    WHERE v.OwnerID = @OwnerID
                      AND b.BookingStatus = 'Pending'";

                using (SqlCommand command = new SqlCommand(pendingAmountQuery, connection))
                {
                    command.Parameters.AddWithValue("@OwnerID", userID);
                    pendingAmount = Convert.ToDecimal(command.ExecuteScalar());
                }

                lblTotalCars.Text = totalCars.ToString();
                lblTotalCarsDescription.Text = $"{totalCars} registered vehicles";

                lblAvailableCars.Text = availableCars.ToString();
                lblAvailableCarsDescription.Text = "Ready for rent";

                lblRentedCars.Text = rentedCars.ToString();
                lblRentedCarsDescription.Text = "In active bookings";

                lblTotalEarnings.Text = $"৳{totalEarnings:N0}";
                lblEarningsDescription.Text = "From completed bookings";

                lblPendingBookings.Text = pendingBookings.ToString();
                lblPendingDescription.Text =
                    pendingAmount > 0
                        ? $"৳{pendingAmount:N0} awaiting payment"
                        : "Awaiting payment";

                int inactiveCars = Math.Max(0, totalCars - availableCars - rentedCars);

                lblAvailableLegendValue.Text =
                    $"{availableCars} ({GetPercentage(availableCars, totalCars)}%)";

                lblRentedLegendValue.Text =
                    $"{rentedCars} ({GetPercentage(rentedCars, totalCars)}%)";

                lblInactiveLegendValue.Text =
                    $"{inactiveCars} ({GetPercentage(inactiveCars, totalCars)}%)";

                vehicleChartPanel.Invalidate();
                earningsChartPanel.Invalidate();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error while loading dashboard:\n\n" + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "An unexpected error occurred:\n\n" + ex.Message,
                    "Dashboard Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private int GetPercentage(int value, int total)
        {
            if (total <= 0)
                return 0;

            return (int)Math.Round(value / (double)total * 100);
        }

        private void vehicleChartPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle circle = new Rectangle(28, 8, 155, 155);

            using Pen backgroundPen =
                new Pen(Color.FromArgb(230, 235, 240), 22);

            g.DrawEllipse(backgroundPen, circle);

            if (totalCars > 0)
            {
                float availableAngle = 360f * availableCars / totalCars;
                float rentedAngle = 360f * rentedCars / totalCars;
                int inactiveCars = Math.Max(0, totalCars - availableCars - rentedCars);
                float inactiveAngle = 360f * inactiveCars / totalCars;

                float start = -90f;

                using Pen availablePen =
                    new Pen(Color.FromArgb(24, 194, 126), 22);

                using Pen rentedPen =
                    new Pen(Color.FromArgb(255, 170, 35), 22);

                using Pen inactivePen =
                    new Pen(Color.FromArgb(244, 85, 90), 22);

                if (availableAngle > 0)
                {
                    g.DrawArc(availablePen, circle, start, availableAngle);
                    start += availableAngle;
                }

                if (rentedAngle > 0)
                {
                    g.DrawArc(rentedPen, circle, start, rentedAngle);
                    start += rentedAngle;
                }

                if (inactiveAngle > 0)
                    g.DrawArc(inactivePen, circle, start, inactiveAngle);
            }

            using Brush whiteBrush = new SolidBrush(Color.White);
            g.FillEllipse(whiteBrush, new Rectangle(66, 46, 79, 79));

            using Font numberFont = new Font("Segoe UI", 19F, FontStyle.Bold);
            using Font labelFont = new Font("Segoe UI", 8F);
            using Brush textBrush = new SolidBrush(Color.FromArgb(11, 30, 70));

            string number = totalCars.ToString();
            SizeF numberSize = g.MeasureString(number, numberFont);

            g.DrawString(
                number,
                numberFont,
                textBrush,
                105 - numberSize.Width / 2,
                56);

            string label = "Total Cars";
            SizeF labelSize = g.MeasureString(label, labelFont);

            g.DrawString(
                label,
                labelFont,
                textBrush,
                105 - labelSize.Width / 2,
                84);
        }

        private void earningsChartPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int left = 42;
            int right = 350;
            int bottom = 155;
            int height = 115;

            using Pen gridPen =
                new Pen(Color.FromArgb(215, 225, 238));

            for (int i = 0; i <= 4; i++)
            {
                int y = bottom - i * height / 4;
                g.DrawLine(gridPen, left, y, right, y);
            }

            decimal[] values =
            {
                totalEarnings * 0.40m,
                totalEarnings * 0.68m,
                totalEarnings * 0.84m,
                totalEarnings
            };

            decimal maximum = Math.Max(1m, totalEarnings);

            int[] x = { 55, 135, 215, 295 };
            string[] labels = { "Week 1", "Week 2", "Week 3", "Week 4" };

            using Brush barBrush =
                new SolidBrush(Color.FromArgb(55, 155, 235));

            using Font labelFont =
                new Font("Segoe UI", 7.5F);

            using Brush textBrush =
                new SolidBrush(Color.FromArgb(38, 69, 110));

            for (int i = 0; i < values.Length; i++)
            {
                int barHeight =
                    (int)(values[i] / maximum * height);

                Rectangle bar =
                    new Rectangle(
                        x[i],
                        bottom - barHeight,
                        50,
                        Math.Max(1, barHeight));

                g.FillRectangle(barBrush, bar);

                SizeF labelSize =
                    g.MeasureString(labels[i], labelFont);

                g.DrawString(
                    labels[i],
                    labelFont,
                    textBrush,
                    x[i] + 25 - labelSize.Width / 2,
                    bottom + 8);
            }
        }

        private void cmbEarningsPeriod_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            earningsChartPanel.Invalidate();
        }

        private void LoadRecentBookings()
        {
            try
            {
                DatabaseHelper databaseHelper = new DatabaseHelper();

                using SqlConnection connection = databaseHelper.GetConnection();
                connection.Open();

                string query = @"
                    SELECT TOP 5
                        b.BookingID AS [Booking ID],
                        u.FullName AS [Customer],
                        v.Brand + ' ' + v.Model AS [Car],
                        b.StartDate AS [Start Date],
                        b.EndDate AS [End Date],
                        b.TotalAmount AS [Amount],
                        b.BookingStatus AS [Status]
                    FROM Bookings b
                    INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                    INNER JOIN Users u ON b.CustomerID = u.UserID
                    WHERE v.OwnerID = @OwnerID
                      AND b.BookingStatus <> 'Cancelled'
                    ORDER BY b.BookingID DESC";

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@OwnerID", userID);

                using SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvRecentBookings.DataSource = table;

                if (dgvRecentBookings.Columns.Contains("Start Date"))
                    dgvRecentBookings.Columns["Start Date"].DefaultCellStyle.Format = "dd/MM/yyyy";

                if (dgvRecentBookings.Columns.Contains("End Date"))
                    dgvRecentBookings.Columns["End Date"].DefaultCellStyle.Format = "dd/MM/yyyy";

                if (dgvRecentBookings.Columns.Contains("Amount"))
                    dgvRecentBookings.Columns["Amount"].DefaultCellStyle.Format = "৳#,##0";

                AddViewColumn();
                UpdateRecentActivity(table);
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

        private void AddViewColumn()
        {
            if (dgvRecentBookings.Columns.Contains("View"))
                return;

            DataGridViewButtonColumn viewColumn =
                new DataGridViewButtonColumn();

            viewColumn.Name = "View";
            viewColumn.HeaderText = "Action";
            viewColumn.Text = "View";
            viewColumn.UseColumnTextForButtonValue = true;
            viewColumn.FlatStyle = FlatStyle.Flat;

            viewColumn.DefaultCellStyle.ForeColor =
                Color.FromArgb(0, 115, 230);

            viewColumn.DefaultCellStyle.BackColor =
                Color.White;

            dgvRecentBookings.Columns.Add(viewColumn);
        }

        private void dgvRecentBookings_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ||
                e.ColumnIndex < 0 ||
                dgvRecentBookings.Columns[e.ColumnIndex].Name != "View")
                return;

            object value =
                dgvRecentBookings.Rows[e.RowIndex]
                    .Cells["Booking ID"].Value;

            if (value == null)
                return;

            int bookingID = Convert.ToInt32(value);

            MessageBox.Show(
                $"Booking ID: {bookingID}\n\n" +
                "Open the Owner Bookings window for complete booking management.",
                "Booking Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void UpdateRecentActivity(DataTable table)
        {
            lblActivityText1.Text = "No recent activity";
            lblActivityText2.Text = "";
            lblActivityText3.Text = "";
            lblActivityText4.Text = "";

            lblActivityTime1.Text = "";
            lblActivityTime2.Text = "";
            lblActivityTime3.Text = "";
            lblActivityTime4.Text = "";

            if (table.Rows.Count == 0)
                return;

            DataRow first = table.Rows[0];

            string customer = first["Customer"]?.ToString() ?? "";
            string car = first["Car"]?.ToString() ?? "";
            string status = first["Status"]?.ToString() ?? "";
            string amount = first["Amount"]?.ToString() ?? "0";

            lblActivityText1.Text =
                $"New booking received\r\n{customer} • {car}";

            lblActivityTime1.Text = "Recent";

            lblActivityText2.Text =
                $"৳{amount} • {car}";

            lblActivityTime2.Text = status;

            if (table.Rows.Count > 1)
            {
                DataRow second = table.Rows[1];

                lblActivityText3.Text =
                    $"Recent booking\r\n{second["Car"]} • {second["Status"]}";

                lblActivityTime3.Text = "Recent";
            }

            if (table.Rows.Count > 2)
            {
                DataRow third = table.Rows[2];

                lblActivityText4.Text =
                    $"New booking\r\n{third["Car"]} • {third["Customer"]}";

                lblActivityTime4.Text = "Recent";
            }
        }

        private Form activeContentForm;

        private void ShowDashboardContent()
        {
            CloseActiveContentForm();

            foreach (Control control in contentPanel.Controls)
                control.Visible = true;

            btnDashboard.BackColor = Color.FromArgb(21, 108, 190);
            btnMyCars.BackColor = Color.Transparent;
            btnOwnerBookings.BackColor = Color.Transparent;
            btnEarnings.BackColor = Color.Transparent;
            btnOffers.BackColor = Color.Transparent;
            btnSettings.BackColor = Color.Transparent;

            LoadDashboardStatistics();
            LoadRecentBookings();
        }

        private void ShowContentForm(Form childForm, Button selectedButton)
        {
            CloseActiveContentForm();

            foreach (Control control in contentPanel.Controls)
                control.Visible = false;

            activeContentForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.ShowInTaskbar = false;

            childForm.FormClosed += EmbeddedContentForm_FormClosed;

            contentPanel.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();

            btnDashboard.BackColor = Color.Transparent;
            btnMyCars.BackColor = Color.Transparent;
            btnOwnerBookings.BackColor = Color.Transparent;
            btnEarnings.BackColor = Color.Transparent;
            btnOffers.BackColor = Color.Transparent;
            btnSettings.BackColor = Color.Transparent;

            selectedButton.BackColor = Color.FromArgb(21, 108, 190);
        }

        private void EmbeddedContentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (sender is Form closedForm)
            {
                contentPanel.Controls.Remove(closedForm);

                if (activeContentForm == closedForm)
                    activeContentForm = null;

                closedForm.Dispose();
            }

            ShowDashboardContent();
        }

        private void CloseActiveContentForm()
        {
            if (activeContentForm == null)
                return;

            Form form = activeContentForm;
            activeContentForm = null;

            contentPanel.Controls.Remove(form);
            form.FormClosed -= EmbeddedContentForm_FormClosed;
            form.Close();
            form.Dispose();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowDashboardContent();
        }

        private void btnAddNewCar_Click(object sender, EventArgs e)
        {
            AddEditCarForm addCarForm =
                new AddEditCarForm(userID);

            addCarForm.ShowDialog();

            LoadDashboardStatistics();
            LoadRecentBookings();
        }

        private void btnMyCars_Click(object sender, EventArgs e)
        {
            ShowContentForm(
                new MyCarsForm(userID),
                btnMyCars);
        }

        private void btnOwnerBookings_Click(object sender, EventArgs e)
        {
            ShowContentForm(
                new OwnerBookingsForm(userID),
                btnOwnerBookings);
        }

        private void btnEarnings_Click(object sender, EventArgs e)
        {
            ShowContentForm(
                new EarningsForm(userID),
                btnEarnings);
        }

        private void btnOffers_Click(object sender, EventArgs e)
        {
            ShowDashboardContent();

            MessageBox.Show(
                "My Offers section is not implemented yet.",
                "My Offers",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowDashboardContent();

            MessageBox.Show(
                "Owner Settings section is not implemented yet.",
                "Settings",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show(
                    "Are you sure you want to logout?",
                    "Logout",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                CloseActiveContentForm();
                Close();
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            CloseActiveContentForm();
            base.OnFormClosed(e);
        }
    }
}
