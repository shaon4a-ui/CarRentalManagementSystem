using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Owner
{
    partial class OwnerBookingsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel mainPanel;
        private Panel headerPanel;
        private Label lblPageTitle;
        private Label lblSubtitle;
        private Label lblOwnerName;
        private Label lblOwnerRole;

        private Panel cardTotal;
        private Panel cardTotalAccent;
        private Label lblTotalIcon;
        private Label lblTotalValue;
        private Label lblTotalCaption;

        private Panel cardConfirmed;
        private Panel cardConfirmedAccent;
        private Label lblConfirmedIcon;
        private Label lblConfirmedValue;
        private Label lblConfirmedCaption;

        private Panel cardPending;
        private Panel cardPendingAccent;
        private Label lblPendingIcon;
        private Label lblPendingValue;
        private Label lblPendingCaption;

        private Panel cardCompleted;
        private Panel cardCompletedAccent;
        private Label lblCompletedIcon;
        private Label lblCompletedValue;
        private Label lblCompletedCaption;

        private Panel filterPanel;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblStatus;
        private ComboBox cmbStatus;
        private Label lblDateRange;
        private CheckBox chkFrom;
        private DateTimePicker dtpFrom;
        private CheckBox chkTo;
        private DateTimePicker dtpTo;
        private Button btnReset;
        private Button btnRefresh;

        private Panel bookingsPanel;
        private Label lblBookingsTitle;
        private Label lblResults;
        private Label lblSortBy;
        private ComboBox cmbSort;
        private DataGridView dgvBookings;

        private DataGridViewTextBoxColumn colBookingID;
        private DataGridViewImageColumn colCarImage;
        private DataGridViewTextBoxColumn colCar;
        private DataGridViewTextBoxColumn colCustomer;
        private DataGridViewTextBoxColumn colStartDate;
        private DataGridViewTextBoxColumn colEndDate;
        private DataGridViewTextBoxColumn colAmount;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colPayment;
        private DataGridViewButtonColumn colView;
        private DataGridViewButtonColumn colConfirm;
        private DataGridViewButtonColumn colCancel;
        private DataGridViewButtonColumn colReturn;

        private Label lblPageInfo;
        private Button btnPrevious;
        private Label lblPageNumber;
        private Button btnNext;

        private Panel tipPanel;
        private Label lblTipIcon;
        private Label lblTipTitle;
        private Label lblTipText;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            mainPanel = new Panel();
            tipPanel = new Panel();
            lblTipIcon = new Label();
            lblTipTitle = new Label();
            lblTipText = new Label();
            lblPageInfo = new Label();
            btnPrevious = new Button();
            lblPageNumber = new Label();
            btnNext = new Button();
            bookingsPanel = new Panel();
            lblBookingsTitle = new Label();
            lblResults = new Label();
            lblSortBy = new Label();
            cmbSort = new ComboBox();
            dgvBookings = new DataGridView();
            colBookingID = new DataGridViewTextBoxColumn();
            colCarImage = new DataGridViewImageColumn();
            colCar = new DataGridViewTextBoxColumn();
            colCustomer = new DataGridViewTextBoxColumn();
            colStartDate = new DataGridViewTextBoxColumn();
            colEndDate = new DataGridViewTextBoxColumn();
            colAmount = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colPayment = new DataGridViewTextBoxColumn();
            colView = new DataGridViewButtonColumn();
            colConfirm = new DataGridViewButtonColumn();
            colCancel = new DataGridViewButtonColumn();
            colReturn = new DataGridViewButtonColumn();
            cardCompleted = new Panel();
            cardCompletedAccent = new Panel();
            lblCompletedIcon = new Label();
            lblCompletedValue = new Label();
            lblCompletedCaption = new Label();
            cardPending = new Panel();
            cardPendingAccent = new Panel();
            lblPendingIcon = new Label();
            lblPendingValue = new Label();
            lblPendingCaption = new Label();
            cardConfirmed = new Panel();
            cardConfirmedAccent = new Panel();
            lblConfirmedIcon = new Label();
            lblConfirmedValue = new Label();
            lblConfirmedCaption = new Label();
            cardTotal = new Panel();
            cardTotalAccent = new Panel();
            lblTotalIcon = new Label();
            lblTotalValue = new Label();
            lblTotalCaption = new Label();
            filterPanel = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblDateRange = new Label();
            chkFrom = new CheckBox();
            dtpFrom = new DateTimePicker();
            chkTo = new CheckBox();
            dtpTo = new DateTimePicker();
            btnReset = new Button();
            btnRefresh = new Button();
            headerPanel = new Panel();
            lblPageTitle = new Label();
            lblSubtitle = new Label();
            lblOwnerName = new Label();
            lblOwnerRole = new Label();
            mainPanel.SuspendLayout();
            tipPanel.SuspendLayout();
            bookingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            cardCompleted.SuspendLayout();
            cardPending.SuspendLayout();
            cardConfirmed.SuspendLayout();
            cardTotal.SuspendLayout();
            filterPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(238, 244, 251);
            mainPanel.Controls.Add(tipPanel);
            mainPanel.Controls.Add(lblPageInfo);
            mainPanel.Controls.Add(btnPrevious);
            mainPanel.Controls.Add(lblPageNumber);
            mainPanel.Controls.Add(btnNext);
            mainPanel.Controls.Add(bookingsPanel);
            mainPanel.Controls.Add(cardCompleted);
            mainPanel.Controls.Add(cardPending);
            mainPanel.Controls.Add(cardConfirmed);
            mainPanel.Controls.Add(cardTotal);
            mainPanel.Controls.Add(filterPanel);
            mainPanel.Controls.Add(headerPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(26, 18, 26, 18);
            mainPanel.Size = new Size(1230, 900);
            mainPanel.TabIndex = 0;
            // 
            // tipPanel
            // 
            tipPanel.BackColor = Color.FromArgb(220, 237, 255);
            tipPanel.Controls.Add(lblTipIcon);
            tipPanel.Controls.Add(lblTipTitle);
            tipPanel.Controls.Add(lblTipText);
            tipPanel.Location = new Point(26, 768);
            tipPanel.Name = "tipPanel";
            tipPanel.Size = new Size(1178, 82);
            tipPanel.TabIndex = 0;
            // 
            // lblTipIcon
            // 
            lblTipIcon.AutoSize = true;
            lblTipIcon.Font = new Font("Segoe UI Emoji", 22F);
            lblTipIcon.ForeColor = Color.FromArgb(37, 99, 235);
            lblTipIcon.Location = new Point(24, 19);
            lblTipIcon.Name = "lblTipIcon";
            lblTipIcon.Size = new Size(73, 49);
            lblTipIcon.TabIndex = 0;
            lblTipIcon.Text = "💡";
            // 
            // lblTipTitle
            // 
            lblTipTitle.AutoSize = true;
            lblTipTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTipTitle.ForeColor = Color.FromArgb(11, 40, 90);
            lblTipTitle.Location = new Point(68, 16);
            lblTipTitle.Name = "lblTipTitle";
            lblTipTitle.Size = new Size(42, 28);
            lblTipTitle.TabIndex = 1;
            lblTipTitle.Text = "Tip";
            // 
            // lblTipText
            // 
            lblTipText.Font = new Font("Segoe UI", 8.8F);
            lblTipText.ForeColor = Color.FromArgb(55, 85, 125);
            lblTipText.Location = new Point(69, 43);
            lblTipText.Name = "lblTipText";
            lblTipText.Size = new Size(1050, 25);
            lblTipText.TabIndex = 2;
            lblTipText.Text = "Review pending requests quickly and keep your vehicle availability up to date.";
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 8.8F);
            lblPageInfo.ForeColor = Color.FromArgb(86, 112, 150);
            lblPageInfo.Location = new Point(26, 727);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(203, 20);
            lblPageInfo.TabIndex = 1;
            lblPageInfo.Text = "Showing 0 to 0 of 0 bookings";
            // 
            // btnPrevious
            // 
            btnPrevious.BackColor = Color.White;
            btnPrevious.FlatAppearance.BorderColor = Color.FromArgb(210, 218, 230);
            btnPrevious.FlatStyle = FlatStyle.Flat;
            btnPrevious.Font = new Font("Segoe UI", 12F);
            btnPrevious.ForeColor = Color.FromArgb(11, 40, 90);
            btnPrevious.Location = new Point(1048, 718);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(40, 35);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "‹";
            btnPrevious.UseVisualStyleBackColor = false;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // lblPageNumber
            // 
            lblPageNumber.BackColor = Color.FromArgb(37, 99, 235);
            lblPageNumber.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPageNumber.ForeColor = Color.White;
            lblPageNumber.Location = new Point(1092, 718);
            lblPageNumber.Name = "lblPageNumber";
            lblPageNumber.Size = new Size(36, 35);
            lblPageNumber.TabIndex = 3;
            lblPageNumber.Text = "1";
            lblPageNumber.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.White;
            btnNext.FlatAppearance.BorderColor = Color.FromArgb(210, 218, 230);
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 12F);
            btnNext.ForeColor = Color.FromArgb(11, 40, 90);
            btnNext.Location = new Point(1132, 718);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(40, 35);
            btnNext.TabIndex = 4;
            btnNext.Text = "›";
            btnNext.UseVisualStyleBackColor = false;
            btnNext.Click += btnNext_Click;
            // 
            // bookingsPanel
            // 
            bookingsPanel.BackColor = Color.White;
            bookingsPanel.Controls.Add(lblBookingsTitle);
            bookingsPanel.Controls.Add(lblResults);
            bookingsPanel.Controls.Add(lblSortBy);
            bookingsPanel.Controls.Add(cmbSort);
            bookingsPanel.Controls.Add(dgvBookings);
            bookingsPanel.Location = new Point(26, 314);
            bookingsPanel.Name = "bookingsPanel";
            bookingsPanel.Size = new Size(1178, 400);
            bookingsPanel.TabIndex = 5;
            // 
            // lblBookingsTitle
            // 
            lblBookingsTitle.AutoSize = true;
            lblBookingsTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblBookingsTitle.ForeColor = Color.FromArgb(11, 40, 90);
            lblBookingsTitle.Location = new Point(18, 12);
            lblBookingsTitle.Name = "lblBookingsTitle";
            lblBookingsTitle.Size = new Size(120, 32);
            lblBookingsTitle.TabIndex = 0;
            lblBookingsTitle.Text = "Bookings";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI", 8.8F, FontStyle.Bold);
            lblResults.ForeColor = Color.FromArgb(107, 114, 128);
            lblResults.Location = new Point(108, 18);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(18, 20);
            lblResults.TabIndex = 1;
            lblResults.Text = "0";
            // 
            // lblSortBy
            // 
            lblSortBy.AutoSize = true;
            lblSortBy.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSortBy.ForeColor = Color.FromArgb(107, 114, 128);
            lblSortBy.Location = new Point(850, 18);
            lblSortBy.Name = "lblSortBy";
            lblSortBy.Size = new Size(63, 20);
            lblSortBy.TabIndex = 2;
            lblSortBy.Text = "Sort by:";
            // 
            // cmbSort
            // 
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.Font = new Font("Segoe UI", 8.8F);
            cmbSort.Items.AddRange(new object[] { "Newest First", "Oldest First", "Amount: High to Low", "Amount: Low to High", "Start Date" });
            cmbSort.Location = new Point(905, 12);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(250, 28);
            cmbSort.TabIndex = 3;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
            // 
            // dgvBookings
            // 
            dgvBookings.AllowUserToAddRows = false;
            dgvBookings.AllowUserToDeleteRows = false;
            dgvBookings.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 251, 253);
            dgvBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookings.BackgroundColor = Color.White;
            dgvBookings.BorderStyle = BorderStyle.None;
            dgvBookings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(11, 40, 78);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.2F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(11, 40, 78);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dgvBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvBookings.ColumnHeadersHeight = 36;
            dgvBookings.Columns.AddRange(new DataGridViewColumn[] { colBookingID, colCarImage, colCar, colCustomer, colStartDate, colEndDate, colAmount, colStatus, colPayment, colView, colConfirm, colReturn, colCancel });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 8.1F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(11, 40, 90);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvBookings.DefaultCellStyle = dataGridViewCellStyle8;
            dgvBookings.EnableHeadersVisualStyles = false;
            dgvBookings.GridColor = Color.FromArgb(229, 231, 235);
            dgvBookings.Location = new Point(14, 53);
            dgvBookings.MultiSelect = false;
            dgvBookings.Name = "dgvBookings";
            dgvBookings.ReadOnly = true;
            dgvBookings.RowHeadersVisible = false;
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.RowTemplate.Height = 64;
            dgvBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookings.Size = new Size(1150, 332);
            dgvBookings.TabIndex = 4;
            dgvBookings.CellContentClick += dgvBookings_CellContentClick;
            // 
            // colBookingID
            // 
            colBookingID.FillWeight = 45F;
            colBookingID.HeaderText = "ID";
            colBookingID.MinimumWidth = 6;
            colBookingID.Name = "colBookingID";
            colBookingID.ReadOnly = true;
            // 
            // colCarImage
            // 
            colCarImage.FillWeight = 70F;
            colCarImage.HeaderText = "Photo";
            colCarImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colCarImage.MinimumWidth = 6;
            colCarImage.Name = "colCarImage";
            colCarImage.ReadOnly = true;
            // 
            // colCar
            // 
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            colCar.DefaultCellStyle = dataGridViewCellStyle3;
            colCar.FillWeight = 120F;
            colCar.HeaderText = "Car Details";
            colCar.MinimumWidth = 6;
            colCar.Name = "colCar";
            colCar.ReadOnly = true;
            // 
            // colCustomer
            // 
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            colCustomer.DefaultCellStyle = dataGridViewCellStyle4;
            colCustomer.FillWeight = 120F;
            colCustomer.HeaderText = "Customer";
            colCustomer.MinimumWidth = 6;
            colCustomer.Name = "colCustomer";
            colCustomer.ReadOnly = true;
            // 
            // colStartDate
            // 
            colStartDate.FillWeight = 82F;
            colStartDate.HeaderText = "Start Date";
            colStartDate.MinimumWidth = 6;
            colStartDate.Name = "colStartDate";
            colStartDate.ReadOnly = true;
            // 
            // colEndDate
            // 
            colEndDate.FillWeight = 82F;
            colEndDate.HeaderText = "End Date";
            colEndDate.MinimumWidth = 6;
            colEndDate.Name = "colEndDate";
            colEndDate.ReadOnly = true;
            // 
            // colAmount
            // 
            colAmount.FillWeight = 85F;
            colAmount.HeaderText = "Total Amount";
            colAmount.MinimumWidth = 6;
            colAmount.Name = "colAmount";
            colAmount.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 78F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colPayment
            // 
            colPayment.FillWeight = 72F;
            colPayment.HeaderText = "Payment";
            colPayment.MinimumWidth = 6;
            colPayment.Name = "colPayment";
            colPayment.ReadOnly = true;
            // 
            // colView
            // 
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(30, 64, 175);
            colView.DefaultCellStyle = dataGridViewCellStyle5;
            colView.FillWeight = 65F;
            colView.FlatStyle = FlatStyle.Flat;
            colView.HeaderText = "View";
            colView.MinimumWidth = 6;
            colView.Name = "colView";
            colView.ReadOnly = true;
            colView.Text = "View";
            colView.UseColumnTextForButtonValue = true;
            // 
            // colConfirm
            // 
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(187, 247, 208);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(21, 101, 52);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            colConfirm.DefaultCellStyle = dataGridViewCellStyle6;
            colConfirm.FillWeight = 82F;
            colConfirm.FlatStyle = FlatStyle.Flat;
            colConfirm.HeaderText = "Confirm";
            colConfirm.MinimumWidth = 6;
            colConfirm.Name = "colConfirm";
            colConfirm.ReadOnly = true;
            colConfirm.Text = "✓ Confirm";
            colConfirm.UseColumnTextForButtonValue = true;
            // 
            // colReturn
            // 
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(221, 214, 254);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(91, 33, 182);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            colReturn.DefaultCellStyle = dataGridViewCellStyle9;
            colReturn.FillWeight = 78F;
            colReturn.FlatStyle = FlatStyle.Flat;
            colReturn.HeaderText = "Return";
            colReturn.MinimumWidth = 6;
            colReturn.Name = "colReturn";
            colReturn.ReadOnly = true;
            colReturn.Text = "↻ Return";
            colReturn.UseColumnTextForButtonValue = true;
            // 
            // colCancel
            // 
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(254, 205, 211);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(185, 28, 28);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            colCancel.DefaultCellStyle = dataGridViewCellStyle7;
            colCancel.FillWeight = 78F;
            colCancel.FlatStyle = FlatStyle.Flat;
            colCancel.HeaderText = "Cancel";
            colCancel.MinimumWidth = 6;
            colCancel.Name = "colCancel";
            colCancel.ReadOnly = true;
            colCancel.Text = "✕ Cancel";
            colCancel.UseColumnTextForButtonValue = true;
            // 
            // cardCompleted
            // 
            cardCompleted.BackColor = Color.White;
            cardCompleted.Controls.Add(cardCompletedAccent);
            cardCompleted.Controls.Add(lblCompletedIcon);
            cardCompleted.Controls.Add(lblCompletedValue);
            cardCompleted.Controls.Add(lblCompletedCaption);
            cardCompleted.Location = new Point(902, 120);
            cardCompleted.Name = "cardCompleted";
            cardCompleted.Size = new Size(302, 78);
            cardCompleted.TabIndex = 6;
            // 
            // cardCompletedAccent
            // 
            cardCompletedAccent.BackColor = Color.FromArgb(139, 92, 246);
            cardCompletedAccent.Location = new Point(0, 0);
            cardCompletedAccent.Name = "cardCompletedAccent";
            cardCompletedAccent.Size = new Size(5, 78);
            cardCompletedAccent.TabIndex = 0;
            // 
            // lblCompletedIcon
            // 
            lblCompletedIcon.AutoSize = true;
            lblCompletedIcon.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblCompletedIcon.ForeColor = Color.FromArgb(139, 92, 246);
            lblCompletedIcon.Location = new Point(18, 17);
            lblCompletedIcon.Name = "lblCompletedIcon";
            lblCompletedIcon.Size = new Size(43, 45);
            lblCompletedIcon.TabIndex = 1;
            lblCompletedIcon.Text = "✓";
            // 
            // lblCompletedValue
            // 
            lblCompletedValue.AutoSize = true;
            lblCompletedValue.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblCompletedValue.ForeColor = Color.FromArgb(11, 40, 90);
            lblCompletedValue.Location = new Point(62, 9);
            lblCompletedValue.Name = "lblCompletedValue";
            lblCompletedValue.Size = new Size(38, 45);
            lblCompletedValue.TabIndex = 2;
            lblCompletedValue.Text = "0";
            // 
            // lblCompletedCaption
            // 
            lblCompletedCaption.AutoSize = true;
            lblCompletedCaption.Font = new Font("Segoe UI", 8.5F);
            lblCompletedCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblCompletedCaption.Location = new Point(64, 44);
            lblCompletedCaption.Name = "lblCompletedCaption";
            lblCompletedCaption.Size = new Size(74, 20);
            lblCompletedCaption.TabIndex = 3;
            lblCompletedCaption.Text = "Completed";
            // 
            // cardPending
            // 
            cardPending.BackColor = Color.White;
            cardPending.Controls.Add(cardPendingAccent);
            cardPending.Controls.Add(lblPendingIcon);
            cardPending.Controls.Add(lblPendingValue);
            cardPending.Controls.Add(lblPendingCaption);
            cardPending.Location = new Point(610, 120);
            cardPending.Name = "cardPending";
            cardPending.Size = new Size(280, 78);
            cardPending.TabIndex = 7;
            // 
            // cardPendingAccent
            // 
            cardPendingAccent.BackColor = Color.FromArgb(245, 158, 11);
            cardPendingAccent.Location = new Point(0, 0);
            cardPendingAccent.Name = "cardPendingAccent";
            cardPendingAccent.Size = new Size(5, 78);
            cardPendingAccent.TabIndex = 0;
            // 
            // lblPendingIcon
            // 
            lblPendingIcon.AutoSize = true;
            lblPendingIcon.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPendingIcon.ForeColor = Color.FromArgb(245, 158, 11);
            lblPendingIcon.Location = new Point(18, 18);
            lblPendingIcon.Name = "lblPendingIcon";
            lblPendingIcon.Size = new Size(45, 41);
            lblPendingIcon.TabIndex = 1;
            lblPendingIcon.Text = "◷";
            // 
            // lblPendingValue
            // 
            lblPendingValue.AutoSize = true;
            lblPendingValue.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblPendingValue.ForeColor = Color.FromArgb(11, 40, 90);
            lblPendingValue.Location = new Point(62, 9);
            lblPendingValue.Name = "lblPendingValue";
            lblPendingValue.Size = new Size(38, 45);
            lblPendingValue.TabIndex = 2;
            lblPendingValue.Text = "0";
            // 
            // lblPendingCaption
            // 
            lblPendingCaption.AutoSize = true;
            lblPendingCaption.Font = new Font("Segoe UI", 8.5F);
            lblPendingCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblPendingCaption.Location = new Point(64, 44);
            lblPendingCaption.Name = "lblPendingCaption";
            lblPendingCaption.Size = new Size(62, 20);
            lblPendingCaption.TabIndex = 3;
            lblPendingCaption.Text = "Pending";
            // 
            // cardConfirmed
            // 
            cardConfirmed.BackColor = Color.White;
            cardConfirmed.Controls.Add(cardConfirmedAccent);
            cardConfirmed.Controls.Add(lblConfirmedIcon);
            cardConfirmed.Controls.Add(lblConfirmedValue);
            cardConfirmed.Controls.Add(lblConfirmedCaption);
            cardConfirmed.Location = new Point(318, 120);
            cardConfirmed.Name = "cardConfirmed";
            cardConfirmed.Size = new Size(280, 78);
            cardConfirmed.TabIndex = 8;
            // 
            // cardConfirmedAccent
            // 
            cardConfirmedAccent.BackColor = Color.FromArgb(16, 185, 129);
            cardConfirmedAccent.Location = new Point(0, 0);
            cardConfirmedAccent.Name = "cardConfirmedAccent";
            cardConfirmedAccent.Size = new Size(5, 78);
            cardConfirmedAccent.TabIndex = 0;
            // 
            // lblConfirmedIcon
            // 
            lblConfirmedIcon.AutoSize = true;
            lblConfirmedIcon.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblConfirmedIcon.ForeColor = Color.FromArgb(16, 185, 129);
            lblConfirmedIcon.Location = new Point(18, 18);
            lblConfirmedIcon.Name = "lblConfirmedIcon";
            lblConfirmedIcon.Size = new Size(41, 41);
            lblConfirmedIcon.TabIndex = 1;
            lblConfirmedIcon.Text = "✓";
            // 
            // lblConfirmedValue
            // 
            lblConfirmedValue.AutoSize = true;
            lblConfirmedValue.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblConfirmedValue.ForeColor = Color.FromArgb(11, 40, 90);
            lblConfirmedValue.Location = new Point(62, 9);
            lblConfirmedValue.Name = "lblConfirmedValue";
            lblConfirmedValue.Size = new Size(38, 45);
            lblConfirmedValue.TabIndex = 2;
            lblConfirmedValue.Text = "0";
            // 
            // lblConfirmedCaption
            // 
            lblConfirmedCaption.AutoSize = true;
            lblConfirmedCaption.Font = new Font("Segoe UI", 8.5F);
            lblConfirmedCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblConfirmedCaption.Location = new Point(64, 44);
            lblConfirmedCaption.Name = "lblConfirmedCaption";
            lblConfirmedCaption.Size = new Size(79, 20);
            lblConfirmedCaption.TabIndex = 3;
            lblConfirmedCaption.Text = "Confirmed";
            // 
            // cardTotal
            // 
            cardTotal.BackColor = Color.White;
            cardTotal.Controls.Add(cardTotalAccent);
            cardTotal.Controls.Add(lblTotalIcon);
            cardTotal.Controls.Add(lblTotalValue);
            cardTotal.Controls.Add(lblTotalCaption);
            cardTotal.Location = new Point(26, 120);
            cardTotal.Name = "cardTotal";
            cardTotal.Size = new Size(280, 78);
            cardTotal.TabIndex = 9;
            // 
            // cardTotalAccent
            // 
            cardTotalAccent.BackColor = Color.FromArgb(37, 99, 235);
            cardTotalAccent.Location = new Point(0, 0);
            cardTotalAccent.Name = "cardTotalAccent";
            cardTotalAccent.Size = new Size(5, 78);
            cardTotalAccent.TabIndex = 0;
            // 
            // lblTotalIcon
            // 
            lblTotalIcon.AutoSize = true;
            lblTotalIcon.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalIcon.ForeColor = Color.FromArgb(37, 99, 235);
            lblTotalIcon.Location = new Point(18, 18);
            lblTotalIcon.Name = "lblTotalIcon";
            lblTotalIcon.Size = new Size(45, 41);
            lblTotalIcon.TabIndex = 1;
            lblTotalIcon.Text = "▣";
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTotalValue.ForeColor = Color.FromArgb(11, 40, 90);
            lblTotalValue.Location = new Point(62, 9);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(38, 45);
            lblTotalValue.TabIndex = 2;
            lblTotalValue.Text = "0";
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.AutoSize = true;
            lblTotalCaption.Font = new Font("Segoe UI", 8.5F);
            lblTotalCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblTotalCaption.Location = new Point(64, 44);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(107, 20);
            lblTotalCaption.TabIndex = 3;
            lblTotalCaption.Text = "Total Bookings";
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.White;
            filterPanel.Controls.Add(lblSearch);
            filterPanel.Controls.Add(txtSearch);
            filterPanel.Controls.Add(btnSearch);
            filterPanel.Controls.Add(lblStatus);
            filterPanel.Controls.Add(cmbStatus);
            filterPanel.Controls.Add(lblDateRange);
            filterPanel.Controls.Add(chkFrom);
            filterPanel.Controls.Add(dtpFrom);
            filterPanel.Controls.Add(chkTo);
            filterPanel.Controls.Add(dtpTo);
            filterPanel.Controls.Add(btnReset);
            filterPanel.Controls.Add(btnRefresh);
            filterPanel.Location = new Point(26, 212);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(1178, 92);
            filterPanel.TabIndex = 10;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(11, 40, 90);
            lblSearch.Location = new Point(17, 12);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(66, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "SEARCH";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(17, 37);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Customer, car or booking ID...";
            txtSearch.Size = new Size(285, 29);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(37, 99, 235);
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 8.8F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(311, 34);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(85, 34);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(11, 40, 90);
            lblStatus.Location = new Point(416, 12);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(63, 20);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "STATUS";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9F);
            cmbStatus.Items.AddRange(new object[] { "All Status", "Pending", "Confirmed", "Completed", "Cancelled" });
            cmbStatus.Location = new Point(416, 37);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(130, 28);
            cmbStatus.TabIndex = 4;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // lblDateRange
            // 
            lblDateRange.AutoSize = true;
            lblDateRange.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblDateRange.ForeColor = Color.FromArgb(11, 40, 90);
            lblDateRange.Location = new Point(566, 12);
            lblDateRange.Name = "lblDateRange";
            lblDateRange.Size = new Size(103, 20);
            lblDateRange.TabIndex = 5;
            lblDateRange.Text = "DATE RANGE";
            // 
            // chkFrom
            // 
            chkFrom.AutoSize = true;
            chkFrom.Font = new Font("Segoe UI", 8F);
            chkFrom.Location = new Point(566, 42);
            chkFrom.Name = "chkFrom";
            chkFrom.Size = new Size(63, 23);
            chkFrom.TabIndex = 6;
            chkFrom.Text = "From";
            chkFrom.CheckedChanged += DateFilterChanged;
            // 
            // dtpFrom
            // 
            dtpFrom.Font = new Font("Segoe UI", 8F);
            dtpFrom.Format = DateTimePickerFormat.Short;
            dtpFrom.Location = new Point(635, 39);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(103, 25);
            dtpFrom.TabIndex = 7;
            dtpFrom.Value = new DateTime(2026, 8, 11, 0, 0, 0, 0);
            dtpFrom.ValueChanged += DateFilterChanged;
            // 
            // chkTo
            // 
            chkTo.AutoSize = true;
            chkTo.Font = new Font("Segoe UI", 8F);
            chkTo.Location = new Point(759, 41);
            chkTo.Name = "chkTo";
            chkTo.Size = new Size(45, 23);
            chkTo.TabIndex = 8;
            chkTo.Text = "To";
            chkTo.CheckedChanged += DateFilterChanged;
            // 
            // dtpTo
            // 
            dtpTo.Font = new Font("Segoe UI", 8F);
            dtpTo.Format = DateTimePickerFormat.Short;
            dtpTo.Location = new Point(810, 37);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(103, 25);
            dtpTo.TabIndex = 9;
            dtpTo.Value = new DateTime(2026, 9, 10, 0, 0, 0, 0);
            dtpTo.ValueChanged += DateFilterChanged;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(210, 218, 230);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnReset.ForeColor = Color.FromArgb(55, 65, 81);
            btnReset.Location = new Point(929, 32);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(85, 34);
            btnReset.TabIndex = 10;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = Color.White;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(210, 218, 230);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(55, 65, 81);
            btnRefresh.Location = new Point(1041, 32);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(105, 34);
            btnRefresh.TabIndex = 11;
            btnRefresh.Text = "↻ Refresh";
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.Controls.Add(lblPageTitle);
            headerPanel.Controls.Add(lblSubtitle);
            headerPanel.Controls.Add(lblOwnerName);
            headerPanel.Controls.Add(lblOwnerRole);
            headerPanel.Location = new Point(26, 18);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1178, 88);
            headerPanel.TabIndex = 11;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(11, 40, 90);
            lblPageTitle.Location = new Point(24, 12);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(310, 50);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Owner Bookings";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(86, 112, 150);
            lblSubtitle.Location = new Point(27, 55);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(321, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "View and manage bookings for your vehicles";
            // 
            // lblOwnerName
            // 
            lblOwnerName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOwnerName.ForeColor = Color.FromArgb(11, 40, 90);
            lblOwnerName.Location = new Point(920, 19);
            lblOwnerName.Name = "lblOwnerName";
            lblOwnerName.Size = new Size(230, 24);
            lblOwnerName.TabIndex = 2;
            lblOwnerName.Text = "Owner";
            lblOwnerName.TextAlign = ContentAlignment.TopRight;
            // 
            // lblOwnerRole
            // 
            lblOwnerRole.Font = new Font("Segoe UI", 8.5F);
            lblOwnerRole.ForeColor = Color.FromArgb(107, 114, 128);
            lblOwnerRole.Location = new Point(920, 46);
            lblOwnerRole.Name = "lblOwnerRole";
            lblOwnerRole.Size = new Size(230, 20);
            lblOwnerRole.TabIndex = 3;
            lblOwnerRole.Text = "Vehicle Owner";
            lblOwnerRole.TextAlign = ContentAlignment.TopRight;
            // 
            // OwnerBookingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 244, 251);
            ClientSize = new Size(1230, 900);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OwnerBookingsForm";
            ShowInTaskbar = false;
            Text = "Owner Bookings";
            Load += OwnerBookingsForm_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            tipPanel.ResumeLayout(false);
            tipPanel.PerformLayout();
            bookingsPanel.ResumeLayout(false);
            bookingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            cardCompleted.ResumeLayout(false);
            cardCompleted.PerformLayout();
            cardPending.ResumeLayout(false);
            cardPending.PerformLayout();
            cardConfirmed.ResumeLayout(false);
            cardConfirmed.PerformLayout();
            cardTotal.ResumeLayout(false);
            cardTotal.PerformLayout();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

    }
}
