using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;
using CarRentalManagementSystem.Models;

namespace CarRentalManagementSystem.Owner
{
    public partial class EarningsForm : Form
    {
        private readonly int ownerID;
        private Earnings earnings = new Earnings();

        public EarningsForm(int ownerID)
        {
            InitializeComponent();
            this.ownerID = ownerID;
        }

        private void EarningsForm_Load(object sender, EventArgs e)
        {
            LoadEarnings();
        }

        private void LoadEarnings()
        {
            try
            {
                EarningsService service = new EarningsService();
                earnings = service.GetOwnerEarnings(ownerID);

                lblTotalEarningsValue.Text = $"৳{earnings.TotalEarnings:N0}";
                lblThisMonthValue.Text = $"৳{earnings.ThisMonthEarnings:N0}";
                lblPendingValue.Text = $"৳{earnings.PendingPayments:N0}";
                lblCompletedValue.Text = earnings.CompletedBookings.ToString();

                LoadRecentPayments();
                earningsChartPanel.Invalidate();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Database error while loading earnings:\n\n" + ex.Message,
                    "Earnings Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load earnings:\n\n" + ex.Message,
                    "Earnings Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadRecentPayments()
        {
            DatabaseHelper databaseHelper = new DatabaseHelper();

            using SqlConnection connection = databaseHelper.GetConnection();
            connection.Open();

            string query = @"
                SELECT TOP 10
                    p.PaymentID AS [Payment ID],
                    b.BookingID AS [Booking ID],
                    v.Brand + ' ' + v.Model AS [Vehicle],
                    p.Amount AS [Amount],
                    p.PaymentMethod AS [Payment Method],
                    p.PaymentStatus AS [Payment Status],
                    p.TransactionDate AS [Transaction Date]
                FROM Payments p
                INNER JOIN Bookings b ON p.BookingID = b.BookingID
                INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                WHERE v.OwnerID = @OwnerID
                ORDER BY p.TransactionDate DESC, p.PaymentID DESC";

            using SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@OwnerID", ownerID);

            using SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);

            dgvRecentPayments.DataSource = table;

            if (dgvRecentPayments.Columns.Contains("Amount"))
                dgvRecentPayments.Columns["Amount"].DefaultCellStyle.Format = "৳#,##0";

            if (dgvRecentPayments.Columns.Contains("Transaction Date"))
                dgvRecentPayments.Columns["Transaction Date"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadEarnings();
        }

        private void earningsChartPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int left = 45;
            int right = Math.Max(left + 100, earningsChartPanel.Width - 25);
            int top = 25;
            int bottom = Math.Max(top + 60, earningsChartPanel.Height - 40);
            int chartHeight = bottom - top;

            using Pen gridPen = new Pen(Color.FromArgb(225, 232, 241), 1);

            for (int i = 0; i <= 4; i++)
            {
                int y = bottom - (i * chartHeight / 4);
                g.DrawLine(gridPen, left, y, right, y);
            }

            if (earnings.MonthlyEarnings.Count == 0)
            {
                using Font emptyFont = new Font("Segoe UI", 9F);
                using Brush emptyBrush = new SolidBrush(Color.FromArgb(110, 130, 155));
                g.DrawString("No payment history available yet.",
                    emptyFont, emptyBrush, left + 20, top + 45);
                return;
            }

            var items = earnings.MonthlyEarnings;
            decimal maximum = 1m;

            foreach (decimal value in items.Values)
                if (value > maximum) maximum = value;

            int count = items.Count;
            float slotWidth = (right - left) / (float)count;
            int barWidth = Math.Max(20, (int)(slotWidth * 0.55f));

            using Brush barBrush =
                new SolidBrush(Color.FromArgb(120, 65, 235));
            using Font labelFont = new Font("Segoe UI", 8F);
            using Brush labelBrush =
                new SolidBrush(Color.FromArgb(55, 78, 110));
            using Font amountFont = new Font("Segoe UI", 7.5F, FontStyle.Bold);
            using Brush amountBrush =
                new SolidBrush(Color.FromArgb(11, 30, 70));

            int index = 0;

            foreach (var item in items)
            {
                int x = left + (int)(index * slotWidth + (slotWidth - barWidth) / 2);
                int barHeight = (int)(item.Value / maximum * (chartHeight - 15));

                Rectangle bar = new Rectangle(
                    x,
                    bottom - barHeight,
                    barWidth,
                    Math.Max(2, barHeight));

                g.FillRectangle(barBrush, bar);

                string amount = item.Value >= 1000
                    ? $"৳{item.Value / 1000m:0.#}k"
                    : $"৳{item.Value:0}";

                SizeF amountSize = g.MeasureString(amount, amountFont);
                g.DrawString(amount, amountFont, amountBrush,
                    x + barWidth / 2f - amountSize.Width / 2f,
                    Math.Max(2, bottom - barHeight - 18));

                SizeF labelSize = g.MeasureString(item.Key, labelFont);
                g.DrawString(item.Key, labelFont, labelBrush,
                    x + barWidth / 2f - labelSize.Width / 2f,
                    bottom + 8);

                index++;
            }
        }

        
    }
}
