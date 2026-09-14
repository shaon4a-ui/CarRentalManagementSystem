using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;

namespace CarRentalManagementSystem.Customer
{
    public partial class MyPaymentsForm : Form
    {
        private readonly int customerID;

        public MyPaymentsForm()
        {
            InitializeComponent();
        }

        public MyPaymentsForm(int customerID) : this()
        {
            this.customerID = customerID;
        }

        private void MyPaymentsForm_Load(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            LoadPayments();
        }

        private void LoadPayments()
        {
            try
            {
                using SqlConnection connection = new DatabaseHelper().GetConnection();
                connection.Open();

                string query = @"
                    SELECT
                        p.PaymentID AS [Payment ID],
                        p.BookingID AS [Booking ID],
                        v.Brand + ' ' + v.Model AS [Car],
                        p.Amount AS [Amount],
                        p.PaymentMethod AS [Payment Method],
                        p.TransactionDate AS [Payment Date],
                        p.PaymentStatus AS [Status]
                    FROM Payments p
                    INNER JOIN Bookings b ON p.BookingID = b.BookingID
                    INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                    WHERE b.CustomerID = @CustomerID";

                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    query += @"
                        AND (
                            CAST(p.PaymentID AS NVARCHAR(20)) LIKE '%' + @Search + '%'
                            OR CAST(p.BookingID AS NVARCHAR(20)) LIKE '%' + @Search + '%'
                            OR v.Brand LIKE '%' + @Search + '%'
                            OR v.Model LIKE '%' + @Search + '%'
                            OR p.PaymentMethod LIKE '%' + @Search + '%'
                        )";
                }

                if (cmbStatus.SelectedItem?.ToString() != "All Status")
                    query += " AND p.PaymentStatus = @Status";

                query += " ORDER BY p.PaymentID DESC";

                using SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", customerID);

                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                    command.Parameters.AddWithValue("@Search", txtSearch.Text.Trim());

                if (cmbStatus.SelectedItem?.ToString() != "All Status")
                    command.Parameters.AddWithValue("@Status", cmbStatus.SelectedItem?.ToString() ?? "");

                using SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dgvPayments.DataSource = table;
                UpdateStatistics(connection);
                FormatGrid();

                lblResults.Text = $"{table.Rows.Count} payment(s) found";
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Could not load your payment history.\n\n" + ex.Message,
                    "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatistics(SqlConnection connection)
        {
            string totalPaidQuery = @"
                SELECT ISNULL(SUM(p.Amount), 0)
                FROM Payments p
                INNER JOIN Bookings b ON p.BookingID = b.BookingID
                WHERE b.CustomerID = @CustomerID AND p.PaymentStatus = 'Paid'";

            string successfulQuery = @"
                SELECT COUNT(*)
                FROM Payments p
                INNER JOIN Bookings b ON p.BookingID = b.BookingID
                WHERE b.CustomerID = @CustomerID AND p.PaymentStatus = 'Paid'";

            string pendingQuery = @"
                SELECT COUNT(*)
                FROM Payments p
                INNER JOIN Bookings b ON p.BookingID = b.BookingID
                WHERE b.CustomerID = @CustomerID AND p.PaymentStatus = 'Pending'";

            lblTotalPaidValue.Text = $"৳{ExecuteDecimal(connection, totalPaidQuery):N0}";
            lblSuccessfulValue.Text = ExecuteInt(connection, successfulQuery).ToString();
            lblPendingValue.Text = ExecuteInt(connection, pendingQuery).ToString();
        }

        private decimal ExecuteDecimal(SqlConnection connection, string query)
        {
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", customerID);
            return Convert.ToDecimal(command.ExecuteScalar());
        }

        private int ExecuteInt(SqlConnection connection, string query)
        {
            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CustomerID", customerID);
            return Convert.ToInt32(command.ExecuteScalar());
        }

        private void FormatGrid()
        {
            if (dgvPayments.Columns.Count == 0)
                return;

            dgvPayments.ReadOnly = true;
            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AllowUserToResizeRows = false;
            dgvPayments.MultiSelect = false;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dgvPayments.Columns.Contains("Payment ID"))
                dgvPayments.Columns["Payment ID"].FillWeight = 65;
            if (dgvPayments.Columns.Contains("Booking ID"))
                dgvPayments.Columns["Booking ID"].FillWeight = 65;
            if (dgvPayments.Columns.Contains("Car"))
                dgvPayments.Columns["Car"].FillWeight = 125;
            if (dgvPayments.Columns.Contains("Amount"))
                dgvPayments.Columns["Amount"].FillWeight = 90;
            if (dgvPayments.Columns.Contains("Payment Method"))
                dgvPayments.Columns["Payment Method"].FillWeight = 105;
            if (dgvPayments.Columns.Contains("Payment Date"))
                dgvPayments.Columns["Payment Date"].FillWeight = 105;
            if (dgvPayments.Columns.Contains("Status"))
                dgvPayments.Columns["Status"].FillWeight = 80;

            if (dgvPayments.Columns.Contains("Amount"))
                dgvPayments.Columns["Amount"].DefaultCellStyle.Format = "৳#,##0";

            if (dgvPayments.Columns.Contains("Payment Date"))
                dgvPayments.Columns["Payment Date"].DefaultCellStyle.Format = "dd MMM yyyy, hh:mm tt";

            foreach (DataGridViewRow row in dgvPayments.Rows)
            {
                string status = row.Cells["Status"].Value?.ToString() ?? "";

                if (status.Equals("Paid", StringComparison.OrdinalIgnoreCase))
                {
                    row.Cells["Status"].Style.ForeColor = Color.FromArgb(16, 140, 92);
                    row.Cells["Status"].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
                else if (status.Equals("Pending", StringComparison.OrdinalIgnoreCase))
                {
                    row.Cells["Status"].Style.ForeColor = Color.FromArgb(190, 120, 15);
                    row.Cells["Status"].Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadPayments();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            cmbStatus.SelectedIndex = 0;
            LoadPayments();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated)
                LoadPayments();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
