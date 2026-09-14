using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customer
{
    partial class MyPaymentsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblPageTitle;
        private Label lblSubtitle;
        private Button btnClose;

        private Panel cardTotalPaid;
        private Panel cardSuccessful;
        private Panel cardPending;

        private Label lblTotalPaidTitle;
        private Label lblTotalPaidValue;
        private Label lblTotalPaidSub;
        private Label lblSuccessfulTitle;
        private Label lblSuccessfulValue;
        private Label lblSuccessfulSub;
        private Label lblPendingTitle;
        private Label lblPendingValue;
        private Label lblPendingSub;

        private Panel filterPanel;
        private TextBox txtSearch;
        private ComboBox cmbStatus;
        private Button btnSearch;
        private Button btnRefresh;
        private Label lblResults;

        private Panel tablePanel;
        private Label lblTableTitle;
        private Label lblTableSubtitle;
        private DataGridView dgvPayments;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            lblPageTitle = new Label();
            lblSubtitle = new Label();
            btnClose = new Button();

            cardTotalPaid = new Panel();
            lblTotalPaidTitle = new Label();
            lblTotalPaidValue = new Label();
            lblTotalPaidSub = new Label();

            cardSuccessful = new Panel();
            lblSuccessfulTitle = new Label();
            lblSuccessfulValue = new Label();
            lblSuccessfulSub = new Label();

            cardPending = new Panel();
            lblPendingTitle = new Label();
            lblPendingValue = new Label();
            lblPendingSub = new Label();

            filterPanel = new Panel();
            txtSearch = new TextBox();
            cmbStatus = new ComboBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            lblResults = new Label();

            tablePanel = new Panel();
            lblTableTitle = new Label();
            lblTableSubtitle = new Label();
            dgvPayments = new DataGridView();

            cardTotalPaid.SuspendLayout();
            cardSuccessful.SuspendLayout();
            cardPending.SuspendLayout();
            filterPanel.SuspendLayout();
            tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).BeginInit();
            SuspendLayout();

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 248, 252);
            ClientSize = new Size(1125, 900);
            Font = new Font("Segoe UI", 9F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Name = "MyPaymentsForm";
            Text = "My Payments";
            Load += MyPaymentsForm_Load;

            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(15, 39, 72);
            lblPageTitle.Location = new Point(30, 25);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Text = "My Payments";

            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 10F);
            lblSubtitle.ForeColor = Color.FromArgb(83, 108, 137);
            lblSubtitle.Location = new Point(33, 75);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Text = "View your payment history and transactions.";

            btnClose.BackColor = Color.White;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(215, 220, 227);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(65, 75, 90);
            btnClose.Location = new Point(1010, 25);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(80, 38);
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;

            cardTotalPaid.BackColor = Color.FromArgb(225, 239, 255);
            cardTotalPaid.Controls.Add(lblTotalPaidTitle);
            cardTotalPaid.Controls.Add(lblTotalPaidValue);
            cardTotalPaid.Controls.Add(lblTotalPaidSub);
            cardTotalPaid.Location = new Point(30, 120);
            cardTotalPaid.Name = "cardTotalPaid";
            cardTotalPaid.Size = new Size(335, 105);

            lblTotalPaidTitle.AutoSize = true;
            lblTotalPaidTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalPaidTitle.ForeColor = Color.FromArgb(15, 91, 160);
            lblTotalPaidTitle.Location = new Point(18, 12);
            lblTotalPaidTitle.Text = "💳  Total Paid";

            lblTotalPaidValue.AutoSize = true;
            lblTotalPaidValue.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblTotalPaidValue.ForeColor = Color.FromArgb(15, 39, 72);
            lblTotalPaidValue.Location = new Point(18, 36);
            lblTotalPaidValue.Name = "lblTotalPaidValue";
            lblTotalPaidValue.Text = "৳0";

            lblTotalPaidSub.AutoSize = true;
            lblTotalPaidSub.Font = new Font("Segoe UI", 8F);
            lblTotalPaidSub.ForeColor = Color.FromArgb(72, 97, 124);
            lblTotalPaidSub.Location = new Point(20, 76);
            lblTotalPaidSub.Text = "Amount successfully paid";

            cardSuccessful.BackColor = Color.FromArgb(225, 249, 239);
            cardSuccessful.Controls.Add(lblSuccessfulTitle);
            cardSuccessful.Controls.Add(lblSuccessfulValue);
            cardSuccessful.Controls.Add(lblSuccessfulSub);
            cardSuccessful.Location = new Point(395, 120);
            cardSuccessful.Name = "cardSuccessful";
            cardSuccessful.Size = new Size(335, 105);

            lblSuccessfulTitle.AutoSize = true;
            lblSuccessfulTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSuccessfulTitle.ForeColor = Color.FromArgb(15, 120, 80);
            lblSuccessfulTitle.Location = new Point(18, 12);
            lblSuccessfulTitle.Text = "✓  Successful Payments";

            lblSuccessfulValue.AutoSize = true;
            lblSuccessfulValue.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblSuccessfulValue.ForeColor = Color.FromArgb(15, 39, 72);
            lblSuccessfulValue.Location = new Point(18, 36);
            lblSuccessfulValue.Name = "lblSuccessfulValue";
            lblSuccessfulValue.Text = "0";

            lblSuccessfulSub.AutoSize = true;
            lblSuccessfulSub.Font = new Font("Segoe UI", 8F);
            lblSuccessfulSub.ForeColor = Color.FromArgb(72, 97, 124);
            lblSuccessfulSub.Location = new Point(20, 76);
            lblSuccessfulSub.Text = "Completed payment records";

            cardPending.BackColor = Color.FromArgb(255, 242, 224);
            cardPending.Controls.Add(lblPendingTitle);
            cardPending.Controls.Add(lblPendingValue);
            cardPending.Controls.Add(lblPendingSub);
            cardPending.Location = new Point(760, 120);
            cardPending.Name = "cardPending";
            cardPending.Size = new Size(335, 105);

            lblPendingTitle.AutoSize = true;
            lblPendingTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPendingTitle.ForeColor = Color.FromArgb(180, 105, 10);
            lblPendingTitle.Location = new Point(18, 12);
            lblPendingTitle.Text = "◷  Pending Payments";

            lblPendingValue.AutoSize = true;
            lblPendingValue.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblPendingValue.ForeColor = Color.FromArgb(15, 39, 72);
            lblPendingValue.Location = new Point(18, 36);
            lblPendingValue.Name = "lblPendingValue";
            lblPendingValue.Text = "0";

            lblPendingSub.AutoSize = true;
            lblPendingSub.Font = new Font("Segoe UI", 8F);
            lblPendingSub.ForeColor = Color.FromArgb(72, 97, 124);
            lblPendingSub.Location = new Point(20, 76);
            lblPendingSub.Text = "Awaiting payment completion";

            filterPanel.BackColor = Color.White;
            filterPanel.Controls.Add(txtSearch);
            filterPanel.Controls.Add(cmbStatus);
            filterPanel.Controls.Add(btnSearch);
            filterPanel.Controls.Add(btnRefresh);
            filterPanel.Controls.Add(lblResults);
            filterPanel.Location = new Point(30, 250);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(1065, 78);

            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(18, 17);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search payment, booking, car or method...";
            txtSearch.Size = new Size(360, 30);

            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 10F);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "All Status", "Paid", "Pending" });
            cmbStatus.Location = new Point(395, 17);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(170, 31);
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;

            btnSearch.BackColor = Color.FromArgb(30, 136, 255);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(585, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(115, 38);
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;

            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(205, 212, 222);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(45, 65, 90);
            btnRefresh.Location = new Point(715, 14);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 38);
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;

            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblResults.ForeColor = Color.FromArgb(107, 114, 128);
            lblResults.Location = new Point(855, 25);
            lblResults.Name = "lblResults";
            lblResults.Text = "0 payment(s) found";

            tablePanel.BackColor = Color.White;
            tablePanel.Controls.Add(lblTableTitle);
            tablePanel.Controls.Add(lblTableSubtitle);
            tablePanel.Controls.Add(dgvPayments);
            tablePanel.Location = new Point(30, 350);
            tablePanel.Name = "tablePanel";
            tablePanel.Size = new Size(1065, 495);

            lblTableTitle.AutoSize = true;
            lblTableTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblTableTitle.ForeColor = Color.FromArgb(15, 39, 72);
            lblTableTitle.Location = new Point(20, 16);
            lblTableTitle.Text = "Payment History";

            lblTableSubtitle.AutoSize = true;
            lblTableSubtitle.Font = new Font("Segoe UI", 8.5F);
            lblTableSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblTableSubtitle.Location = new Point(21, 45);
            lblTableSubtitle.Text = "All payment transactions connected to your bookings.";

            dgvPayments.AllowUserToAddRows = false;
            dgvPayments.AllowUserToDeleteRows = false;
            dgvPayments.AllowUserToResizeRows = false;
            dgvPayments.BackgroundColor = Color.White;
            dgvPayments.BorderStyle = BorderStyle.None;
            dgvPayments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPayments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvPayments.EnableHeadersVisualStyles = false;
            dgvPayments.GridColor = Color.FromArgb(230, 233, 238);
            dgvPayments.Location = new Point(20, 78);
            dgvPayments.Name = "dgvPayments";
            dgvPayments.ReadOnly = true;
            dgvPayments.RowHeadersVisible = false;
            dgvPayments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPayments.Size = new Size(1025, 395);
            dgvPayments.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = Color.FromArgb(31, 41, 55),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                ForeColor = Color.White,
                SelectionBackColor = Color.FromArgb(31, 41, 55),
                SelectionForeColor = Color.White
            };
            dgvPayments.DefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleLeft,
                BackColor = Color.White,
                Font = new Font("Segoe UI", 9F),
                ForeColor = Color.FromArgb(55, 65, 81),
                SelectionBackColor = Color.FromArgb(225, 239, 255),
                SelectionForeColor = Color.FromArgb(15, 39, 72)
            };
            dgvPayments.ColumnHeadersHeight = 42;
            dgvPayments.RowTemplate.Height = 38;

            Controls.Add(tablePanel);
            Controls.Add(filterPanel);
            Controls.Add(cardPending);
            Controls.Add(cardSuccessful);
            Controls.Add(cardTotalPaid);
            Controls.Add(btnClose);
            Controls.Add(lblSubtitle);
            Controls.Add(lblPageTitle);

            cardTotalPaid.ResumeLayout(false);
            cardTotalPaid.PerformLayout();
            cardSuccessful.ResumeLayout(false);
            cardSuccessful.PerformLayout();
            cardPending.ResumeLayout(false);
            cardPending.PerformLayout();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            tablePanel.ResumeLayout(false);
            tablePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPayments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
