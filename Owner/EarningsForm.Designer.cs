namespace CarRentalManagementSystem.Owner
{
    partial class EarningsForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Button btnRefresh;

        private System.Windows.Forms.Panel totalCard;
        private System.Windows.Forms.Label lblTotalIcon;
        private System.Windows.Forms.Label lblTotalTitle;
        private System.Windows.Forms.Label lblTotalEarningsValue;
        private System.Windows.Forms.Label lblTotalDescription;

        private System.Windows.Forms.Panel monthCard;
        private System.Windows.Forms.Label lblMonthIcon;
        private System.Windows.Forms.Label lblMonthTitle;
        private System.Windows.Forms.Label lblThisMonthValue;
        private System.Windows.Forms.Label lblMonthDescription;

        private System.Windows.Forms.Panel pendingCard;
        private System.Windows.Forms.Label lblPendingIcon;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Label lblPendingValue;
        private System.Windows.Forms.Label lblPendingDescription;

        private System.Windows.Forms.Panel completedCard;
        private System.Windows.Forms.Label lblCompletedIcon;
        private System.Windows.Forms.Label lblCompletedTitle;
        private System.Windows.Forms.Label lblCompletedValue;
        private System.Windows.Forms.Label lblCompletedDescription;

        private System.Windows.Forms.Panel overviewPanel;
        private System.Windows.Forms.Label lblOverviewTitle;
        private System.Windows.Forms.Label lblOverviewSubtitle;
        private System.Windows.Forms.Panel earningsChartPanel;

        private System.Windows.Forms.Panel paymentsPanel;
        private System.Windows.Forms.Label lblPaymentsTitle;
        private System.Windows.Forms.Label lblPaymentsSubtitle;
        private System.Windows.Forms.DataGridView dgvRecentPayments;

        private System.Windows.Forms.Panel tipPanel;
        private System.Windows.Forms.Label lblTipIcon;
        private System.Windows.Forms.Label lblTipTitle;
        private System.Windows.Forms.Label lblTipText;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.headerPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();

            this.totalCard = new System.Windows.Forms.Panel();
            this.lblTotalIcon = new System.Windows.Forms.Label();
            this.lblTotalTitle = new System.Windows.Forms.Label();
            this.lblTotalEarningsValue = new System.Windows.Forms.Label();
            this.lblTotalDescription = new System.Windows.Forms.Label();

            this.monthCard = new System.Windows.Forms.Panel();
            this.lblMonthIcon = new System.Windows.Forms.Label();
            this.lblMonthTitle = new System.Windows.Forms.Label();
            this.lblThisMonthValue = new System.Windows.Forms.Label();
            this.lblMonthDescription = new System.Windows.Forms.Label();

            this.pendingCard = new System.Windows.Forms.Panel();
            this.lblPendingIcon = new System.Windows.Forms.Label();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.lblPendingValue = new System.Windows.Forms.Label();
            this.lblPendingDescription = new System.Windows.Forms.Label();

            this.completedCard = new System.Windows.Forms.Panel();
            this.lblCompletedIcon = new System.Windows.Forms.Label();
            this.lblCompletedTitle = new System.Windows.Forms.Label();
            this.lblCompletedValue = new System.Windows.Forms.Label();
            this.lblCompletedDescription = new System.Windows.Forms.Label();

            this.overviewPanel = new System.Windows.Forms.Panel();
            this.lblOverviewTitle = new System.Windows.Forms.Label();
            this.lblOverviewSubtitle = new System.Windows.Forms.Label();
            this.earningsChartPanel = new System.Windows.Forms.Panel();

            this.paymentsPanel = new System.Windows.Forms.Panel();
            this.lblPaymentsTitle = new System.Windows.Forms.Label();
            this.lblPaymentsSubtitle = new System.Windows.Forms.Label();
            this.dgvRecentPayments = new System.Windows.Forms.DataGridView();

            this.tipPanel = new System.Windows.Forms.Panel();
            this.lblTipIcon = new System.Windows.Forms.Label();
            this.lblTipTitle = new System.Windows.Forms.Label();
            this.lblTipText = new System.Windows.Forms.Label();

            this.headerPanel.SuspendLayout();
            this.totalCard.SuspendLayout();
            this.monthCard.SuspendLayout();
            this.pendingCard.SuspendLayout();
            this.completedCard.SuspendLayout();
            this.overviewPanel.SuspendLayout();
            this.paymentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentPayments)).BeginInit();
            this.tipPanel.SuspendLayout();
            this.SuspendLayout();

            // FORM
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(244, 248, 252);
            this.ClientSize = new System.Drawing.Size(1190, 760);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EarningsForm";
            this.Text = "Earnings";
            this.Load += new System.EventHandler(this.EarningsForm_Load);

            // HEADER
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(239, 247, 255);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1190, 90);
            this.headerPanel.TabIndex = 0;
            this.headerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));

            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblTitle.Location = new System.Drawing.Point(24, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 34);
            this.lblTitle.Text = "Earnings & Revenue";

            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(70, 95, 130);
            this.lblSubtitle.Location = new System.Drawing.Point(26, 50);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(650, 22);
            this.lblSubtitle.Text = "Track your rental income, payments and financial performance.";

            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(30, 136, 255);
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Location = new System.Drawing.Point(1050, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 32);
            this.btnRefresh.Text = "↻  Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.headerPanel.Controls.Add(this.lblTitle);
            this.headerPanel.Controls.Add(this.lblSubtitle);
            this.headerPanel.Controls.Add(this.btnRefresh);

            // CARD 1
            this.totalCard.BackColor = System.Drawing.Color.FromArgb(239, 232, 255);
            this.totalCard.Location = new System.Drawing.Point(20, 105);
            this.totalCard.Name = "totalCard";
            this.totalCard.Size = new System.Drawing.Size(270, 90);
            this.totalCard.TabIndex = 1;

            this.lblTotalIcon.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalIcon.ForeColor = System.Drawing.Color.FromArgb(105, 55, 220);
            this.lblTotalIcon.Location = new System.Drawing.Point(10, 7);
            this.lblTotalIcon.Size = new System.Drawing.Size(38, 30);
            this.lblTotalIcon.Text = "৳";
            this.lblTotalIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTotalTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTotalTitle.ForeColor = System.Drawing.Color.FromArgb(105, 55, 220);
            this.lblTotalTitle.Location = new System.Drawing.Point(54, 8);
            this.lblTotalTitle.Size = new System.Drawing.Size(205, 20);
            this.lblTotalTitle.Text = "Total Earnings";

            this.lblTotalEarningsValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalEarningsValue.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblTotalEarningsValue.Location = new System.Drawing.Point(54, 30);
            this.lblTotalEarningsValue.Size = new System.Drawing.Size(205, 30);
            this.lblTotalEarningsValue.Text = "৳0";

            this.lblTotalDescription.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTotalDescription.ForeColor = System.Drawing.Color.FromArgb(60, 80, 110);
            this.lblTotalDescription.Location = new System.Drawing.Point(10, 67);
            this.lblTotalDescription.Size = new System.Drawing.Size(265, 18);
            this.lblTotalDescription.Text = "Paid confirmed bookings";

            this.totalCard.Controls.Add(this.lblTotalIcon);
            this.totalCard.Controls.Add(this.lblTotalTitle);
            this.totalCard.Controls.Add(this.lblTotalEarningsValue);
            this.totalCard.Controls.Add(this.lblTotalDescription);

            // CARD 2
            this.monthCard.BackColor = System.Drawing.Color.FromArgb(225, 241, 255);
            this.monthCard.Location = new System.Drawing.Point(305, 105);
            this.monthCard.Name = "monthCard";
            this.monthCard.Size = new System.Drawing.Size(270, 90);

            this.lblMonthIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.lblMonthIcon.ForeColor = System.Drawing.Color.FromArgb(0, 115, 230);
            this.lblMonthIcon.Location = new System.Drawing.Point(10, 7);
            this.lblMonthIcon.Size = new System.Drawing.Size(38, 30);
            this.lblMonthIcon.Text = "◷";
            this.lblMonthIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblMonthTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMonthTitle.ForeColor = System.Drawing.Color.FromArgb(0, 115, 230);
            this.lblMonthTitle.Location = new System.Drawing.Point(54, 8);
            this.lblMonthTitle.Size = new System.Drawing.Size(205, 20);
            this.lblMonthTitle.Text = "This Month";

            this.lblThisMonthValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblThisMonthValue.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblThisMonthValue.Location = new System.Drawing.Point(54, 30);
            this.lblThisMonthValue.Size = new System.Drawing.Size(205, 30);
            this.lblThisMonthValue.Text = "৳0";

            this.lblMonthDescription.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblMonthDescription.ForeColor = System.Drawing.Color.FromArgb(60, 80, 110);
            this.lblMonthDescription.Location = new System.Drawing.Point(10, 67);
            this.lblMonthDescription.Size = new System.Drawing.Size(265, 18);
            this.lblMonthDescription.Text = "Current calendar month";

            this.monthCard.Controls.Add(this.lblMonthIcon);
            this.monthCard.Controls.Add(this.lblMonthTitle);
            this.monthCard.Controls.Add(this.lblThisMonthValue);
            this.monthCard.Controls.Add(this.lblMonthDescription);

            // CARD 3
            this.pendingCard.BackColor = System.Drawing.Color.FromArgb(255, 239, 220);
            this.pendingCard.Location = new System.Drawing.Point(590, 105);
            this.pendingCard.Name = "pendingCard";
            this.pendingCard.Size = new System.Drawing.Size(270, 90);

            this.lblPendingIcon.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblPendingIcon.ForeColor = System.Drawing.Color.FromArgb(235, 125, 20);
            this.lblPendingIcon.Location = new System.Drawing.Point(10, 7);
            this.lblPendingIcon.Size = new System.Drawing.Size(38, 30);
            this.lblPendingIcon.Text = "!";
            this.lblPendingIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblPendingTitle.ForeColor = System.Drawing.Color.FromArgb(220, 105, 10);
            this.lblPendingTitle.Location = new System.Drawing.Point(54, 8);
            this.lblPendingTitle.Size = new System.Drawing.Size(205, 20);
            this.lblPendingTitle.Text = "Pending Payments";

            this.lblPendingValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblPendingValue.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblPendingValue.Location = new System.Drawing.Point(54, 30);
            this.lblPendingValue.Size = new System.Drawing.Size(205, 30);
            this.lblPendingValue.Text = "৳0";

            this.lblPendingDescription.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblPendingDescription.ForeColor = System.Drawing.Color.FromArgb(60, 80, 110);
            this.lblPendingDescription.Location = new System.Drawing.Point(10, 67);
            this.lblPendingDescription.Size = new System.Drawing.Size(265, 18);
            this.lblPendingDescription.Text = "Awaiting payment";

            this.pendingCard.Controls.Add(this.lblPendingIcon);
            this.pendingCard.Controls.Add(this.lblPendingTitle);
            this.pendingCard.Controls.Add(this.lblPendingValue);
            this.pendingCard.Controls.Add(this.lblPendingDescription);

            // CARD 4
            this.completedCard.BackColor = System.Drawing.Color.FromArgb(225, 250, 240);
            this.completedCard.Location = new System.Drawing.Point(875, 105);
            this.completedCard.Name = "completedCard";
            this.completedCard.Size = new System.Drawing.Size(275, 90);

            this.lblCompletedIcon.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblCompletedIcon.ForeColor = System.Drawing.Color.FromArgb(0, 150, 85);
            this.lblCompletedIcon.Location = new System.Drawing.Point(10, 7);
            this.lblCompletedIcon.Size = new System.Drawing.Size(38, 30);
            this.lblCompletedIcon.Text = "✓";
            this.lblCompletedIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblCompletedTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblCompletedTitle.ForeColor = System.Drawing.Color.FromArgb(0, 140, 75);
            this.lblCompletedTitle.Location = new System.Drawing.Point(54, 8);
            this.lblCompletedTitle.Size = new System.Drawing.Size(195, 22);
            this.lblCompletedTitle.Text = "Completed Bookings";

            this.lblCompletedValue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblCompletedValue.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblCompletedValue.Location = new System.Drawing.Point(54, 30);
            this.lblCompletedValue.Size = new System.Drawing.Size(180, 30);
            this.lblCompletedValue.Text = "0";

            this.lblCompletedDescription.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblCompletedDescription.ForeColor = System.Drawing.Color.FromArgb(60, 80, 110);
            this.lblCompletedDescription.Location = new System.Drawing.Point(10, 67);
            this.lblCompletedDescription.Size = new System.Drawing.Size(250, 18);
            this.lblCompletedDescription.Text = "Confirmed rentals";

            this.completedCard.Controls.Add(this.lblCompletedIcon);
            this.completedCard.Controls.Add(this.lblCompletedTitle);
            this.completedCard.Controls.Add(this.lblCompletedValue);
            this.completedCard.Controls.Add(this.lblCompletedDescription);

            // OVERVIEW
            this.overviewPanel.BackColor = System.Drawing.Color.White;
            this.overviewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.overviewPanel.Location = new System.Drawing.Point(20, 210);
            this.overviewPanel.Name = "overviewPanel";
            this.overviewPanel.Size = new System.Drawing.Size(1150, 180);
            this.overviewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));

            this.lblOverviewTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOverviewTitle.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblOverviewTitle.Location = new System.Drawing.Point(15, 8);
            this.lblOverviewTitle.Size = new System.Drawing.Size(350, 24);
            this.lblOverviewTitle.Text = "Earnings Overview";

            this.lblOverviewSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOverviewSubtitle.ForeColor = System.Drawing.Color.FromArgb(86, 112, 150);
            this.lblOverviewSubtitle.Location = new System.Drawing.Point(16, 33);
            this.lblOverviewSubtitle.Size = new System.Drawing.Size(600, 20);
            this.lblOverviewSubtitle.Text = "Monthly paid earnings from your confirmed bookings";

            this.earningsChartPanel.BackColor = System.Drawing.Color.White;
            this.earningsChartPanel.Location = new System.Drawing.Point(15, 55);
            this.earningsChartPanel.Name = "earningsChartPanel";
            this.earningsChartPanel.Size = new System.Drawing.Size(1118, 112);
            this.earningsChartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.earningsChartPanel_Paint);

            this.overviewPanel.Controls.Add(this.lblOverviewTitle);
            this.overviewPanel.Controls.Add(this.lblOverviewSubtitle);
            this.overviewPanel.Controls.Add(this.earningsChartPanel);

            // PAYMENTS
            this.paymentsPanel.BackColor = System.Drawing.Color.White;
            this.paymentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentsPanel.Location = new System.Drawing.Point(20, 405);
            this.paymentsPanel.Name = "paymentsPanel";
            this.paymentsPanel.Size = new System.Drawing.Size(1150, 230);
            this.paymentsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));

            this.lblPaymentsTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPaymentsTitle.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblPaymentsTitle.Location = new System.Drawing.Point(15, 8);
            this.lblPaymentsTitle.Size = new System.Drawing.Size(350, 24);
            this.lblPaymentsTitle.Text = "Recent Payments";

            this.lblPaymentsSubtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblPaymentsSubtitle.ForeColor = System.Drawing.Color.FromArgb(86, 112, 150);
            this.lblPaymentsSubtitle.Location = new System.Drawing.Point(16, 33);
            this.lblPaymentsSubtitle.Size = new System.Drawing.Size(600, 20);
            this.lblPaymentsSubtitle.Text = "Latest payment transactions for your vehicles";

            this.dgvRecentPayments.AllowUserToAddRows = false;
            this.dgvRecentPayments.AllowUserToDeleteRows = false;
            this.dgvRecentPayments.AllowUserToResizeRows = false;
            this.dgvRecentPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecentPayments.BackgroundColor = System.Drawing.Color.White;
            this.dgvRecentPayments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRecentPayments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRecentPayments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRecentPayments.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
                BackColor = System.Drawing.Color.FromArgb(236, 242, 249),
                Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold),
                ForeColor = System.Drawing.Color.FromArgb(11, 30, 70),
                SelectionBackColor = System.Drawing.Color.FromArgb(236, 242, 249),
                SelectionForeColor = System.Drawing.Color.FromArgb(11, 30, 70)
            };
            this.dgvRecentPayments.ColumnHeadersHeight = 28;
            this.dgvRecentPayments.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle
            {
                Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft,
                BackColor = System.Drawing.Color.White,
                Font = new System.Drawing.Font("Segoe UI", 8.5F),
                ForeColor = System.Drawing.Color.FromArgb(25, 50, 90),
                SelectionBackColor = System.Drawing.Color.FromArgb(220, 235, 250),
                SelectionForeColor = System.Drawing.Color.FromArgb(11, 30, 70)
            };
            this.dgvRecentPayments.EnableHeadersVisualStyles = false;
            this.dgvRecentPayments.GridColor = System.Drawing.Color.FromArgb(224, 232, 240);
            this.dgvRecentPayments.Location = new System.Drawing.Point(15, 55);
            this.dgvRecentPayments.MultiSelect = false;
            this.dgvRecentPayments.Name = "dgvRecentPayments";
            this.dgvRecentPayments.ReadOnly = true;
            this.dgvRecentPayments.RowHeadersVisible = false;
            this.dgvRecentPayments.RowTemplate.Height = 26;
            this.dgvRecentPayments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecentPayments.Size = new System.Drawing.Size(1118, 155);

            this.paymentsPanel.Controls.Add(this.lblPaymentsTitle);
            this.paymentsPanel.Controls.Add(this.lblPaymentsSubtitle);
            this.paymentsPanel.Controls.Add(this.dgvRecentPayments);

            // TIP
            this.tipPanel.BackColor = System.Drawing.Color.FromArgb(239, 247, 255);
            this.tipPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipPanel.Location = new System.Drawing.Point(20, 650);
            this.tipPanel.Name = "tipPanel";
            this.tipPanel.Size = new System.Drawing.Size(1150, 75);
            this.tipPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));

            this.lblTipIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 16F);
            this.lblTipIcon.ForeColor = System.Drawing.Color.FromArgb(30, 136, 255);
            this.lblTipIcon.Location = new System.Drawing.Point(15, 12);
            this.lblTipIcon.Size = new System.Drawing.Size(42, 32);
            this.lblTipIcon.Text = "💡";
            this.lblTipIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblTipTitle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblTipTitle.ForeColor = System.Drawing.Color.FromArgb(11, 30, 70);
            this.lblTipTitle.Location = new System.Drawing.Point(65, 10);
            this.lblTipTitle.Size = new System.Drawing.Size(250, 22);
            this.lblTipTitle.Text = "Earnings Tip";

            this.lblTipText.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblTipText.ForeColor = System.Drawing.Color.FromArgb(55, 80, 115);
            this.lblTipText.Location = new System.Drawing.Point(65, 34);
            this.lblTipText.Size = new System.Drawing.Size(1050, 28);
            this.lblTipText.Text = "Keep your vehicles available and maintain a strong booking history to maximize your rental income.";

            this.tipPanel.Controls.Add(this.lblTipIcon);
            this.tipPanel.Controls.Add(this.lblTipTitle);
            this.tipPanel.Controls.Add(this.lblTipText);

            // ROOT CONTROLS
            this.Controls.Add(this.tipPanel);
            this.Controls.Add(this.paymentsPanel);
            this.Controls.Add(this.overviewPanel);
            this.Controls.Add(this.completedCard);
            this.Controls.Add(this.pendingCard);
            this.Controls.Add(this.monthCard);
            this.Controls.Add(this.totalCard);
            this.Controls.Add(this.headerPanel);

            this.headerPanel.ResumeLayout(false);
            this.totalCard.ResumeLayout(false);
            this.monthCard.ResumeLayout(false);
            this.pendingCard.ResumeLayout(false);
            this.completedCard.ResumeLayout(false);
            this.overviewPanel.ResumeLayout(false);
            this.paymentsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentPayments)).EndInit();
            this.tipPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }
    }
}
