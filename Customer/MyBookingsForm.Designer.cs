using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customer
{
    partial class MyBookingsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerPanel;
        private Button btnBack;
        private Label lblTitle;
        private Label lblSubtitle;

        private Panel summaryTotalPanel;
        private Panel summaryActivePanel;
        private Panel summaryCompletedPanel;
        private Label lblTotalBookingsTitle;
        private Label lblTotalBookingsValue;
        private Label lblTotalBookingsCaption;
        private Label lblActiveRentalsTitle;
        private Label lblActiveRentalsValue;
        private Label lblActiveRentalsCaption;
        private Label lblCompletedTitle;
        private Label lblCompletedValue;
        private Label lblCompletedCaption;

        private Panel filterBarPanel;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblStatusFilter;
        private ComboBox cmbStatusFilter;
        private Button btnRefresh;

        private Label lblResults;
        private Panel bookingsContainer;
        private FlowLayoutPanel bookingsFlowPanel;
        private Label lblNoBookings;

        private Button btnCancelBooking;
        private Button btnPayNow;

        private Panel card1;
        private PictureBox picCar1;
        private Label lblBookingNumber1;
        private Label lblCarName1;
        private Label lblCarInfo1;
        private Label lblBookingDates1;
        private Label lblBookingAmount1;
        private Label lblPaymentStatus1;
        private Label lblBookingStatus1;
        private Button btnViewDetails1;
        private Panel card2;
        private PictureBox picCar2;
        private Label lblBookingNumber2;
        private Label lblCarName2;
        private Label lblCarInfo2;
        private Label lblBookingDates2;
        private Label lblBookingAmount2;
        private Label lblPaymentStatus2;
        private Label lblBookingStatus2;
        private Button btnViewDetails2;
        private Panel card3;
        private PictureBox picCar3;
        private Label lblBookingNumber3;
        private Label lblCarName3;
        private Label lblCarInfo3;
        private Label lblBookingDates3;
        private Label lblBookingAmount3;
        private Label lblPaymentStatus3;
        private Label lblBookingStatus3;
        private Button btnViewDetails3;
        private Panel card4;
        private PictureBox picCar4;
        private Label lblBookingNumber4;
        private Label lblCarName4;
        private Label lblCarInfo4;
        private Label lblBookingDates4;
        private Label lblBookingAmount4;
        private Label lblPaymentStatus4;
        private Label lblBookingStatus4;
        private Button btnViewDetails4;
        private Panel card5;
        private PictureBox picCar5;
        private Label lblBookingNumber5;
        private Label lblCarName5;
        private Label lblCarInfo5;
        private Label lblBookingDates5;
        private Label lblBookingAmount5;
        private Label lblPaymentStatus5;
        private Label lblBookingStatus5;
        private Button btnViewDetails5;
        private Panel card6;
        private PictureBox picCar6;
        private Label lblBookingNumber6;
        private Label lblCarName6;
        private Label lblCarInfo6;
        private Label lblBookingDates6;
        private Label lblBookingAmount6;
        private Label lblPaymentStatus6;
        private Label lblBookingStatus6;
        private Button btnViewDetails6;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            btnBack = new Button();
            lblTitle = new Label();
            lblSubtitle = new Label();

            summaryTotalPanel = new Panel();
            summaryActivePanel = new Panel();
            summaryCompletedPanel = new Panel();

            lblTotalBookingsTitle = new Label();
            lblTotalBookingsValue = new Label();
            lblTotalBookingsCaption = new Label();
            lblActiveRentalsTitle = new Label();
            lblActiveRentalsValue = new Label();
            lblActiveRentalsCaption = new Label();
            lblCompletedTitle = new Label();
            lblCompletedValue = new Label();
            lblCompletedCaption = new Label();

            filterBarPanel = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblStatusFilter = new Label();
            cmbStatusFilter = new ComboBox();
            btnRefresh = new Button();

            lblResults = new Label();
            bookingsContainer = new Panel();
            bookingsFlowPanel = new FlowLayoutPanel();
            lblNoBookings = new Label();

            btnCancelBooking = new Button();
            btnPayNow = new Button();

            card1 = new Panel();
            picCar1 = new PictureBox();
            lblBookingNumber1 = new Label();
            lblCarName1 = new Label();
            lblCarInfo1 = new Label();
            lblBookingDates1 = new Label();
            lblBookingAmount1 = new Label();
            lblPaymentStatus1 = new Label();
            lblBookingStatus1 = new Label();
            btnViewDetails1 = new Button();
            card2 = new Panel();
            picCar2 = new PictureBox();
            lblBookingNumber2 = new Label();
            lblCarName2 = new Label();
            lblCarInfo2 = new Label();
            lblBookingDates2 = new Label();
            lblBookingAmount2 = new Label();
            lblPaymentStatus2 = new Label();
            lblBookingStatus2 = new Label();
            btnViewDetails2 = new Button();
            card3 = new Panel();
            picCar3 = new PictureBox();
            lblBookingNumber3 = new Label();
            lblCarName3 = new Label();
            lblCarInfo3 = new Label();
            lblBookingDates3 = new Label();
            lblBookingAmount3 = new Label();
            lblPaymentStatus3 = new Label();
            lblBookingStatus3 = new Label();
            btnViewDetails3 = new Button();
            card4 = new Panel();
            picCar4 = new PictureBox();
            lblBookingNumber4 = new Label();
            lblCarName4 = new Label();
            lblCarInfo4 = new Label();
            lblBookingDates4 = new Label();
            lblBookingAmount4 = new Label();
            lblPaymentStatus4 = new Label();
            lblBookingStatus4 = new Label();
            btnViewDetails4 = new Button();
            card5 = new Panel();
            picCar5 = new PictureBox();
            lblBookingNumber5 = new Label();
            lblCarName5 = new Label();
            lblCarInfo5 = new Label();
            lblBookingDates5 = new Label();
            lblBookingAmount5 = new Label();
            lblPaymentStatus5 = new Label();
            lblBookingStatus5 = new Label();
            btnViewDetails5 = new Button();
            card6 = new Panel();
            picCar6 = new PictureBox();
            lblBookingNumber6 = new Label();
            lblCarName6 = new Label();
            lblCarInfo6 = new Label();
            lblBookingDates6 = new Label();
            lblBookingAmount6 = new Label();
            lblPaymentStatus6 = new Label();
            lblBookingStatus6 = new Label();
            btnViewDetails6 = new Button();

            headerPanel.SuspendLayout();
            filterBarPanel.SuspendLayout();
            bookingsContainer.SuspendLayout();
            bookingsFlowPanel.SuspendLayout();
            SuspendLayout();

            headerPanel.BackColor = Color.FromArgb(19, 45, 76);
            headerPanel.Controls.Add(btnBack);
            headerPanel.Controls.Add(lblTitle);
            headerPanel.Controls.Add(lblSubtitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Size = new Size(1400, 118);

            btnBack.BackColor = Color.FromArgb(31, 61, 101);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(92, 125, 160);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(24, 28);
            btnBack.Size = new Size(105, 52);
            btnBack.Text = "←  Back";
            btnBack.Click += btnBack_Click;

            lblTitle.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(280, 12);
            lblTitle.Size = new Size(840, 48);
            lblTitle.Text = "My Bookings";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;

            lblSubtitle.Font = new Font("Segoe UI", 10.5F);
            lblSubtitle.ForeColor = Color.FromArgb(210, 225, 242);
            lblSubtitle.Location = new Point(280, 63);
            lblSubtitle.Size = new Size(840, 30);
            lblSubtitle.Text = "View and manage your car rental bookings";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;

            summaryTotalPanel.BackColor = Color.FromArgb(224, 238, 255);
            summaryTotalPanel.BorderStyle = BorderStyle.FixedSingle;
            summaryTotalPanel.Controls.Add(lblTotalBookingsCaption);
            summaryTotalPanel.Controls.Add(lblTotalBookingsValue);
            summaryTotalPanel.Controls.Add(lblTotalBookingsTitle);
            summaryTotalPanel.Location = new Point(28, 138);
            summaryTotalPanel.Size = new Size(430, 105);

            lblTotalBookingsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTotalBookingsTitle.ForeColor = Color.FromArgb(19, 65, 120);
            lblTotalBookingsTitle.Location = new Point(20, 14);
            lblTotalBookingsTitle.Size = new Size(200, 24);
            lblTotalBookingsTitle.Text = "Total Bookings";

            lblTotalBookingsValue.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblTotalBookingsValue.ForeColor = Color.FromArgb(19, 65, 120);
            lblTotalBookingsValue.Location = new Point(20, 42);
            lblTotalBookingsValue.Size = new Size(55, 52);
            lblTotalBookingsValue.Text = "0";

            lblTotalBookingsCaption.Font = new Font("Segoe UI", 9.5F);
            lblTotalBookingsCaption.ForeColor = Color.FromArgb(86, 108, 132);
            lblTotalBookingsCaption.Location = new Point(70, 61);
            lblTotalBookingsCaption.Size = new Size(100, 22);
            lblTotalBookingsCaption.Text = "Bookings";

            summaryActivePanel.BackColor = Color.FromArgb(225, 247, 236);
            summaryActivePanel.BorderStyle = BorderStyle.FixedSingle;
            summaryActivePanel.Controls.Add(lblActiveRentalsCaption);
            summaryActivePanel.Controls.Add(lblActiveRentalsValue);
            summaryActivePanel.Controls.Add(lblActiveRentalsTitle);
            summaryActivePanel.Location = new Point(480, 138);
            summaryActivePanel.Size = new Size(430, 105);

            lblActiveRentalsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblActiveRentalsTitle.ForeColor = Color.FromArgb(22, 111, 62);
            lblActiveRentalsTitle.Location = new Point(20, 14);
            lblActiveRentalsTitle.Size = new Size(180, 24);
            lblActiveRentalsTitle.Text = "Active Rentals";

            lblActiveRentalsValue.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblActiveRentalsValue.ForeColor = Color.FromArgb(22, 111, 62);
            lblActiveRentalsValue.Location = new Point(20, 42);
            lblActiveRentalsValue.Size = new Size(55, 52);
            lblActiveRentalsValue.Text = "0";

            lblActiveRentalsCaption.Font = new Font("Segoe UI", 9.5F);
            lblActiveRentalsCaption.ForeColor = Color.FromArgb(74, 117, 91);
            lblActiveRentalsCaption.Location = new Point(70, 61);
            lblActiveRentalsCaption.Size = new Size(100, 22);
            lblActiveRentalsCaption.Text = "Rentals";

            summaryCompletedPanel.BackColor = Color.FromArgb(239, 232, 255);
            summaryCompletedPanel.BorderStyle = BorderStyle.FixedSingle;
            summaryCompletedPanel.Controls.Add(lblCompletedCaption);
            summaryCompletedPanel.Controls.Add(lblCompletedValue);
            summaryCompletedPanel.Controls.Add(lblCompletedTitle);
            summaryCompletedPanel.Location = new Point(932, 138);
            summaryCompletedPanel.Size = new Size(430, 105);

            lblCompletedTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCompletedTitle.ForeColor = Color.FromArgb(91, 57, 170);
            lblCompletedTitle.Location = new Point(20, 14);
            lblCompletedTitle.Size = new Size(160, 24);
            lblCompletedTitle.Text = "Completed";

            lblCompletedValue.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblCompletedValue.ForeColor = Color.FromArgb(91, 57, 170);
            lblCompletedValue.Location = new Point(20, 42);
            lblCompletedValue.Size = new Size(55, 52);
            lblCompletedValue.Text = "0";

            lblCompletedCaption.Font = new Font("Segoe UI", 9.5F);
            lblCompletedCaption.ForeColor = Color.FromArgb(110, 91, 150);
            lblCompletedCaption.Location = new Point(70, 61);
            lblCompletedCaption.Size = new Size(100, 22);
            lblCompletedCaption.Text = "Rentals";

            filterBarPanel.BackColor = Color.White;
            filterBarPanel.BorderStyle = BorderStyle.FixedSingle;
            filterBarPanel.Controls.Add(btnRefresh);
            filterBarPanel.Controls.Add(cmbStatusFilter);
            filterBarPanel.Controls.Add(lblStatusFilter);
            filterBarPanel.Controls.Add(btnSearch);
            filterBarPanel.Controls.Add(txtSearch);
            filterBarPanel.Controls.Add(lblSearch);
            filterBarPanel.Location = new Point(28, 258);
            filterBarPanel.Size = new Size(1334, 80);

            lblSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(19, 45, 76);
            lblSearch.Location = new Point(18, 27);
            lblSearch.Size = new Size(55, 21);
            lblSearch.Text = "Search";

            txtSearch.Font = new Font("Segoe UI", 10.5F);
            txtSearch.Location = new Point(82, 23);
            txtSearch.Size = new Size(455, 31);
            txtSearch.KeyDown += txtSearch_KeyDown;

            btnSearch.BackColor = Color.FromArgb(30, 136, 255);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(548, 20);
            btnSearch.Size = new Size(105, 38);
            btnSearch.Text = "Search";
            btnSearch.Click += btnSearch_Click;

            lblStatusFilter.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblStatusFilter.ForeColor = Color.FromArgb(19, 45, 76);
            lblStatusFilter.Location = new Point(680, 27);
            lblStatusFilter.Size = new Size(104, 21);
            lblStatusFilter.Text = "Filter Status";

            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.Font = new Font("Segoe UI", 10F);
            cmbStatusFilter.Items.AddRange(new object[] { "All Statuses", "Pending", "Confirmed", "Cancelled", "Completed" });
            cmbStatusFilter.Location = new Point(792, 23);
            cmbStatusFilter.Size = new Size(220, 31);
            cmbStatusFilter.SelectedIndexChanged += cmbStatusFilter_SelectedIndexChanged;

            btnRefresh.BackColor = Color.FromArgb(30, 136, 255);
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(1190, 20);
            btnRefresh.Size = new Size(120, 38);
            btnRefresh.Text = "↻  Refresh";
            btnRefresh.Click += btnRefresh_Click;

            lblResults.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblResults.ForeColor = Color.FromArgb(19, 45, 76);
            lblResults.Location = new Point(35, 353);
            lblResults.Size = new Size(500, 25);
            lblResults.Text = "0 booking(s) found";

            bookingsContainer.BackColor = Color.White;
            bookingsContainer.BorderStyle = BorderStyle.FixedSingle;
            bookingsContainer.Controls.Add(bookingsFlowPanel);
            bookingsContainer.Location = new Point(28, 385);
            bookingsContainer.Padding = new Padding(8);
            bookingsContainer.Size = new Size(1334, 390);

            bookingsFlowPanel.AutoScroll = true;
            bookingsFlowPanel.BackColor = Color.FromArgb(244, 248, 252);
            bookingsFlowPanel.Dock = DockStyle.Fill;
            bookingsFlowPanel.FlowDirection = FlowDirection.TopDown;
            bookingsFlowPanel.Padding = new Padding(18, 16, 18, 16);
            bookingsFlowPanel.WrapContents = false;

            lblNoBookings.AutoSize = true;
            lblNoBookings.Font = new Font("Segoe UI", 11F);
            lblNoBookings.ForeColor = Color.FromArgb(107, 125, 145);
            lblNoBookings.Location = new Point(25, 25);
            lblNoBookings.Text = "No bookings match your filters.";
            lblNoBookings.Visible = false;

            // BOOKING CARD 1
            card1.BackColor = Color.White;
            card1.BorderStyle = BorderStyle.FixedSingle;
            card1.Controls.Add(btnViewDetails1);
            card1.Controls.Add(lblBookingStatus1);
            card1.Controls.Add(lblPaymentStatus1);
            card1.Controls.Add(lblBookingAmount1);
            card1.Controls.Add(lblBookingDates1);
            card1.Controls.Add(lblCarInfo1);
            card1.Controls.Add(lblCarName1);
            card1.Controls.Add(lblBookingNumber1);
            card1.Controls.Add(picCar1);
            card1.Margin = new Padding(0, 0, 0, 12);
            card1.Name = "card1";
            card1.Size = new Size(1250, 178);
            card1.TabIndex = 1;
            card1.Visible = false;

            picCar1.BackColor = Color.FromArgb(242, 246, 250);
            picCar1.Location = new Point(16, 16);
            picCar1.Name = "picCar1";
            picCar1.Size = new Size(285, 144);
            picCar1.SizeMode = PictureBoxSizeMode.Zoom;
            picCar1.TabIndex = 0;
            picCar1.TabStop = false;

            lblBookingNumber1.BackColor = Color.FromArgb(19, 45, 76);
            lblBookingNumber1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBookingNumber1.ForeColor = Color.White;
            lblBookingNumber1.Location = new Point(28, 28);
            lblBookingNumber1.Name = "lblBookingNumber1";
            lblBookingNumber1.Size = new Size(105, 30);
            lblBookingNumber1.TabIndex = 1;
            lblBookingNumber1.Text = "Booking #0";
            lblBookingNumber1.TextAlign = ContentAlignment.MiddleCenter;

            lblCarName1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblCarName1.ForeColor = Color.FromArgb(19, 45, 76);
            lblCarName1.Location = new Point(325, 22);
            lblCarName1.Name = "lblCarName1";
            lblCarName1.Size = new Size(500, 32);
            lblCarName1.TabIndex = 2;
            lblCarName1.Text = "Car Name";

            lblCarInfo1.Font = new Font("Segoe UI", 9.5F);
            lblCarInfo1.ForeColor = Color.FromArgb(75, 96, 120);
            lblCarInfo1.Location = new Point(325, 57);
            lblCarInfo1.Name = "lblCarInfo1";
            lblCarInfo1.Size = new Size(500, 25);
            lblCarInfo1.TabIndex = 3;
            lblCarInfo1.Text = "Sedan  •  4 Seats  •  Dhaka";

            lblBookingDates1.Font = new Font("Segoe UI", 9.5F);
            lblBookingDates1.ForeColor = Color.FromArgb(75, 96, 120);
            lblBookingDates1.Location = new Point(325, 88);
            lblBookingDates1.Name = "lblBookingDates1";
            lblBookingDates1.Size = new Size(500, 25);
            lblBookingDates1.TabIndex = 4;
            lblBookingDates1.Text = "Rental dates";

            lblBookingAmount1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblBookingAmount1.ForeColor = Color.FromArgb(30, 136, 255);
            lblBookingAmount1.Location = new Point(325, 119);
            lblBookingAmount1.Name = "lblBookingAmount1";
            lblBookingAmount1.Size = new Size(220, 25);
            lblBookingAmount1.TabIndex = 5;
            lblBookingAmount1.Text = "💰  ৳0";

            lblPaymentStatus1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPaymentStatus1.Location = new Point(550, 119);
            lblPaymentStatus1.Name = "lblPaymentStatus1";
            lblPaymentStatus1.Size = new Size(220, 25);
            lblPaymentStatus1.TabIndex = 6;
            lblPaymentStatus1.Text = "Payment: Not Paid";

            lblBookingStatus1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBookingStatus1.Location = new Point(1045, 22);
            lblBookingStatus1.Name = "lblBookingStatus1";
            lblBookingStatus1.Size = new Size(175, 34);
            lblBookingStatus1.TabIndex = 7;
            lblBookingStatus1.Text = "Confirmed";
            lblBookingStatus1.TextAlign = ContentAlignment.MiddleCenter;

            btnViewDetails1.BackColor = Color.FromArgb(30, 136, 255);
            btnViewDetails1.Cursor = Cursors.Hand;
            btnViewDetails1.FlatAppearance.BorderSize = 0;
            btnViewDetails1.FlatStyle = FlatStyle.Flat;
            btnViewDetails1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnViewDetails1.ForeColor = Color.White;
            btnViewDetails1.Location = new Point(1045, 112);
            btnViewDetails1.Name = "btnViewDetails1";
            btnViewDetails1.Size = new Size(175, 42);
            btnViewDetails1.TabIndex = 8;
            btnViewDetails1.Text = "View Details";
            btnViewDetails1.UseVisualStyleBackColor = false;
            btnViewDetails1.Click += btnViewDetails1_Click;

            // BOOKING CARD 2
            card2.BackColor = Color.White;
            card2.BorderStyle = BorderStyle.FixedSingle;
            card2.Controls.Add(btnViewDetails2);
            card2.Controls.Add(lblBookingStatus2);
            card2.Controls.Add(lblPaymentStatus2);
            card2.Controls.Add(lblBookingAmount2);
            card2.Controls.Add(lblBookingDates2);
            card2.Controls.Add(lblCarInfo2);
            card2.Controls.Add(lblCarName2);
            card2.Controls.Add(lblBookingNumber2);
            card2.Controls.Add(picCar2);
            card2.Margin = new Padding(0, 0, 0, 12);
            card2.Name = "card2";
            card2.Size = new Size(1250, 178);
            card2.TabIndex = 2;
            card2.Visible = false;

            picCar2.BackColor = Color.FromArgb(242, 246, 250);
            picCar2.Location = new Point(16, 16);
            picCar2.Name = "picCar2";
            picCar2.Size = new Size(285, 144);
            picCar2.SizeMode = PictureBoxSizeMode.Zoom;
            picCar2.TabIndex = 0;
            picCar2.TabStop = false;

            lblBookingNumber2.BackColor = Color.FromArgb(19, 45, 76);
            lblBookingNumber2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBookingNumber2.ForeColor = Color.White;
            lblBookingNumber2.Location = new Point(28, 28);
            lblBookingNumber2.Name = "lblBookingNumber2";
            lblBookingNumber2.Size = new Size(105, 30);
            lblBookingNumber2.TabIndex = 1;
            lblBookingNumber2.Text = "Booking #0";
            lblBookingNumber2.TextAlign = ContentAlignment.MiddleCenter;

            lblCarName2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblCarName2.ForeColor = Color.FromArgb(19, 45, 76);
            lblCarName2.Location = new Point(325, 22);
            lblCarName2.Name = "lblCarName2";
            lblCarName2.Size = new Size(500, 32);
            lblCarName2.TabIndex = 2;
            lblCarName2.Text = "Car Name";

            lblCarInfo2.Font = new Font("Segoe UI", 9.5F);
            lblCarInfo2.ForeColor = Color.FromArgb(75, 96, 120);
            lblCarInfo2.Location = new Point(325, 57);
            lblCarInfo2.Name = "lblCarInfo2";
            lblCarInfo2.Size = new Size(500, 25);
            lblCarInfo2.TabIndex = 3;
            lblCarInfo2.Text = "Sedan  •  4 Seats  •  Dhaka";

            lblBookingDates2.Font = new Font("Segoe UI", 9.5F);
            lblBookingDates2.ForeColor = Color.FromArgb(75, 96, 120);
            lblBookingDates2.Location = new Point(325, 88);
            lblBookingDates2.Name = "lblBookingDates2";
            lblBookingDates2.Size = new Size(500, 25);
            lblBookingDates2.TabIndex = 4;
            lblBookingDates2.Text = "Rental dates";

            lblBookingAmount2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblBookingAmount2.ForeColor = Color.FromArgb(30, 136, 255);
            lblBookingAmount2.Location = new Point(325, 119);
            lblBookingAmount2.Name = "lblBookingAmount2";
            lblBookingAmount2.Size = new Size(220, 25);
            lblBookingAmount2.TabIndex = 5;
            lblBookingAmount2.Text = "💰  ৳0";

            lblPaymentStatus2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPaymentStatus2.Location = new Point(550, 119);
            lblPaymentStatus2.Name = "lblPaymentStatus2";
            lblPaymentStatus2.Size = new Size(220, 25);
            lblPaymentStatus2.TabIndex = 6;
            lblPaymentStatus2.Text = "Payment: Not Paid";

            lblBookingStatus2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBookingStatus2.Location = new Point(1045, 22);
            lblBookingStatus2.Name = "lblBookingStatus2";
            lblBookingStatus2.Size = new Size(175, 34);
            lblBookingStatus2.TabIndex = 7;
            lblBookingStatus2.Text = "Confirmed";
            lblBookingStatus2.TextAlign = ContentAlignment.MiddleCenter;

            btnViewDetails2.BackColor = Color.FromArgb(30, 136, 255);
            btnViewDetails2.Cursor = Cursors.Hand;
            btnViewDetails2.FlatAppearance.BorderSize = 0;
            btnViewDetails2.FlatStyle = FlatStyle.Flat;
            btnViewDetails2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnViewDetails2.ForeColor = Color.White;
            btnViewDetails2.Location = new Point(1045, 112);
            btnViewDetails2.Name = "btnViewDetails2";
            btnViewDetails2.Size = new Size(175, 42);
            btnViewDetails2.TabIndex = 8;
            btnViewDetails2.Text = "View Details";
            btnViewDetails2.UseVisualStyleBackColor = false;
            btnViewDetails2.Click += btnViewDetails2_Click;

            // BOOKING CARD 3
            card3.BackColor = Color.White;
            card3.BorderStyle = BorderStyle.FixedSingle;
            card3.Controls.Add(btnViewDetails3);
            card3.Controls.Add(lblBookingStatus3);
            card3.Controls.Add(lblPaymentStatus3);
            card3.Controls.Add(lblBookingAmount3);
            card3.Controls.Add(lblBookingDates3);
            card3.Controls.Add(lblCarInfo3);
            card3.Controls.Add(lblCarName3);
            card3.Controls.Add(lblBookingNumber3);
            card3.Controls.Add(picCar3);
            card3.Margin = new Padding(0, 0, 0, 12);
            card3.Name = "card3";
            card3.Size = new Size(1250, 178);
            card3.TabIndex = 3;
            card3.Visible = false;

            picCar3.BackColor = Color.FromArgb(242, 246, 250);
            picCar3.Location = new Point(16, 16);
            picCar3.Name = "picCar3";
            picCar3.Size = new Size(285, 144);
            picCar3.SizeMode = PictureBoxSizeMode.Zoom;
            picCar3.TabIndex = 0;
            picCar3.TabStop = false;

            lblBookingNumber3.BackColor = Color.FromArgb(19, 45, 76);
            lblBookingNumber3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBookingNumber3.ForeColor = Color.White;
            lblBookingNumber3.Location = new Point(28, 28);
            lblBookingNumber3.Name = "lblBookingNumber3";
            lblBookingNumber3.Size = new Size(105, 30);
            lblBookingNumber3.TabIndex = 1;
            lblBookingNumber3.Text = "Booking #0";
            lblBookingNumber3.TextAlign = ContentAlignment.MiddleCenter;

            lblCarName3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblCarName3.ForeColor = Color.FromArgb(19, 45, 76);
            lblCarName3.Location = new Point(325, 22);
            lblCarName3.Name = "lblCarName3";
            lblCarName3.Size = new Size(500, 32);
            lblCarName3.TabIndex = 2;
            lblCarName3.Text = "Car Name";

            lblCarInfo3.Font = new Font("Segoe UI", 9.5F);
            lblCarInfo3.ForeColor = Color.FromArgb(75, 96, 120);
            lblCarInfo3.Location = new Point(325, 57);
            lblCarInfo3.Name = "lblCarInfo3";
            lblCarInfo3.Size = new Size(500, 25);
            lblCarInfo3.TabIndex = 3;
            lblCarInfo3.Text = "Sedan  •  4 Seats  •  Dhaka";

            lblBookingDates3.Font = new Font("Segoe UI", 9.5F);
            lblBookingDates3.ForeColor = Color.FromArgb(75, 96, 120);
            lblBookingDates3.Location = new Point(325, 88);
            lblBookingDates3.Name = "lblBookingDates3";
            lblBookingDates3.Size = new Size(500, 25);
            lblBookingDates3.TabIndex = 4;
            lblBookingDates3.Text = "Rental dates";

            lblBookingAmount3.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblBookingAmount3.ForeColor = Color.FromArgb(30, 136, 255);
            lblBookingAmount3.Location = new Point(325, 119);
            lblBookingAmount3.Name = "lblBookingAmount3";
            lblBookingAmount3.Size = new Size(220, 25);
            lblBookingAmount3.TabIndex = 5;
            lblBookingAmount3.Text = "💰  ৳0";

            lblPaymentStatus3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPaymentStatus3.Location = new Point(550, 119);
            lblPaymentStatus3.Name = "lblPaymentStatus3";
            lblPaymentStatus3.Size = new Size(220, 25);
            lblPaymentStatus3.TabIndex = 6;
            lblPaymentStatus3.Text = "Payment: Not Paid";

            lblBookingStatus3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBookingStatus3.Location = new Point(1045, 22);
            lblBookingStatus3.Name = "lblBookingStatus3";
            lblBookingStatus3.Size = new Size(175, 34);
            lblBookingStatus3.TabIndex = 7;
            lblBookingStatus3.Text = "Confirmed";
            lblBookingStatus3.TextAlign = ContentAlignment.MiddleCenter;

            btnViewDetails3.BackColor = Color.FromArgb(30, 136, 255);
            btnViewDetails3.Cursor = Cursors.Hand;
            btnViewDetails3.FlatAppearance.BorderSize = 0;
            btnViewDetails3.FlatStyle = FlatStyle.Flat;
            btnViewDetails3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnViewDetails3.ForeColor = Color.White;
            btnViewDetails3.Location = new Point(1045, 112);
            btnViewDetails3.Name = "btnViewDetails3";
            btnViewDetails3.Size = new Size(175, 42);
            btnViewDetails3.TabIndex = 8;
            btnViewDetails3.Text = "View Details";
            btnViewDetails3.UseVisualStyleBackColor = false;
            btnViewDetails3.Click += btnViewDetails3_Click;

            // BOOKING CARD 4
            card4.BackColor = Color.White;
            card4.BorderStyle = BorderStyle.FixedSingle;
            card4.Controls.Add(btnViewDetails4);
            card4.Controls.Add(lblBookingStatus4);
            card4.Controls.Add(lblPaymentStatus4);
            card4.Controls.Add(lblBookingAmount4);
            card4.Controls.Add(lblBookingDates4);
            card4.Controls.Add(lblCarInfo4);
            card4.Controls.Add(lblCarName4);
            card4.Controls.Add(lblBookingNumber4);
            card4.Controls.Add(picCar4);
            card4.Margin = new Padding(0, 0, 0, 12);
            card4.Name = "card4";
            card4.Size = new Size(1250, 178);
            card4.TabIndex = 4;
            card4.Visible = false;

            picCar4.BackColor = Color.FromArgb(242, 246, 250);
            picCar4.Location = new Point(16, 16);
            picCar4.Name = "picCar4";
            picCar4.Size = new Size(285, 144);
            picCar4.SizeMode = PictureBoxSizeMode.Zoom;
            picCar4.TabIndex = 0;
            picCar4.TabStop = false;

            lblBookingNumber4.BackColor = Color.FromArgb(19, 45, 76);
            lblBookingNumber4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBookingNumber4.ForeColor = Color.White;
            lblBookingNumber4.Location = new Point(28, 28);
            lblBookingNumber4.Name = "lblBookingNumber4";
            lblBookingNumber4.Size = new Size(105, 30);
            lblBookingNumber4.TabIndex = 1;
            lblBookingNumber4.Text = "Booking #0";
            lblBookingNumber4.TextAlign = ContentAlignment.MiddleCenter;

            lblCarName4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblCarName4.ForeColor = Color.FromArgb(19, 45, 76);
            lblCarName4.Location = new Point(325, 22);
            lblCarName4.Name = "lblCarName4";
            lblCarName4.Size = new Size(500, 32);
            lblCarName4.TabIndex = 2;
            lblCarName4.Text = "Car Name";

            lblCarInfo4.Font = new Font("Segoe UI", 9.5F);
            lblCarInfo4.ForeColor = Color.FromArgb(75, 96, 120);
            lblCarInfo4.Location = new Point(325, 57);
            lblCarInfo4.Name = "lblCarInfo4";
            lblCarInfo4.Size = new Size(500, 25);
            lblCarInfo4.TabIndex = 3;
            lblCarInfo4.Text = "Sedan  •  4 Seats  •  Dhaka";

            lblBookingDates4.Font = new Font("Segoe UI", 9.5F);
            lblBookingDates4.ForeColor = Color.FromArgb(75, 96, 120);
            lblBookingDates4.Location = new Point(325, 88);
            lblBookingDates4.Name = "lblBookingDates4";
            lblBookingDates4.Size = new Size(500, 25);
            lblBookingDates4.TabIndex = 4;
            lblBookingDates4.Text = "Rental dates";

            lblBookingAmount4.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblBookingAmount4.ForeColor = Color.FromArgb(30, 136, 255);
            lblBookingAmount4.Location = new Point(325, 119);
            lblBookingAmount4.Name = "lblBookingAmount4";
            lblBookingAmount4.Size = new Size(220, 25);
            lblBookingAmount4.TabIndex = 5;
            lblBookingAmount4.Text = "💰  ৳0";

            lblPaymentStatus4.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPaymentStatus4.Location = new Point(550, 119);
            lblPaymentStatus4.Name = "lblPaymentStatus4";
            lblPaymentStatus4.Size = new Size(220, 25);
            lblPaymentStatus4.TabIndex = 6;
            lblPaymentStatus4.Text = "Payment: Not Paid";

            lblBookingStatus4.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBookingStatus4.Location = new Point(1045, 22);
            lblBookingStatus4.Name = "lblBookingStatus4";
            lblBookingStatus4.Size = new Size(175, 34);
            lblBookingStatus4.TabIndex = 7;
            lblBookingStatus4.Text = "Confirmed";
            lblBookingStatus4.TextAlign = ContentAlignment.MiddleCenter;

            btnViewDetails4.BackColor = Color.FromArgb(30, 136, 255);
            btnViewDetails4.Cursor = Cursors.Hand;
            btnViewDetails4.FlatAppearance.BorderSize = 0;
            btnViewDetails4.FlatStyle = FlatStyle.Flat;
            btnViewDetails4.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnViewDetails4.ForeColor = Color.White;
            btnViewDetails4.Location = new Point(1045, 112);
            btnViewDetails4.Name = "btnViewDetails4";
            btnViewDetails4.Size = new Size(175, 42);
            btnViewDetails4.TabIndex = 8;
            btnViewDetails4.Text = "View Details";
            btnViewDetails4.UseVisualStyleBackColor = false;
            btnViewDetails4.Click += btnViewDetails4_Click;

            // BOOKING CARD 5
            card5.BackColor = Color.White;
            card5.BorderStyle = BorderStyle.FixedSingle;
            card5.Controls.Add(btnViewDetails5);
            card5.Controls.Add(lblBookingStatus5);
            card5.Controls.Add(lblPaymentStatus5);
            card5.Controls.Add(lblBookingAmount5);
            card5.Controls.Add(lblBookingDates5);
            card5.Controls.Add(lblCarInfo5);
            card5.Controls.Add(lblCarName5);
            card5.Controls.Add(lblBookingNumber5);
            card5.Controls.Add(picCar5);
            card5.Margin = new Padding(0, 0, 0, 12);
            card5.Name = "card5";
            card5.Size = new Size(1250, 178);
            card5.TabIndex = 5;
            card5.Visible = false;

            picCar5.BackColor = Color.FromArgb(242, 246, 250);
            picCar5.Location = new Point(16, 16);
            picCar5.Name = "picCar5";
            picCar5.Size = new Size(285, 144);
            picCar5.SizeMode = PictureBoxSizeMode.Zoom;
            picCar5.TabIndex = 0;
            picCar5.TabStop = false;

            lblBookingNumber5.BackColor = Color.FromArgb(19, 45, 76);
            lblBookingNumber5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBookingNumber5.ForeColor = Color.White;
            lblBookingNumber5.Location = new Point(28, 28);
            lblBookingNumber5.Name = "lblBookingNumber5";
            lblBookingNumber5.Size = new Size(105, 30);
            lblBookingNumber5.TabIndex = 1;
            lblBookingNumber5.Text = "Booking #0";
            lblBookingNumber5.TextAlign = ContentAlignment.MiddleCenter;

            lblCarName5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblCarName5.ForeColor = Color.FromArgb(19, 45, 76);
            lblCarName5.Location = new Point(325, 22);
            lblCarName5.Name = "lblCarName5";
            lblCarName5.Size = new Size(500, 32);
            lblCarName5.TabIndex = 2;
            lblCarName5.Text = "Car Name";

            lblCarInfo5.Font = new Font("Segoe UI", 9.5F);
            lblCarInfo5.ForeColor = Color.FromArgb(75, 96, 120);
            lblCarInfo5.Location = new Point(325, 57);
            lblCarInfo5.Name = "lblCarInfo5";
            lblCarInfo5.Size = new Size(500, 25);
            lblCarInfo5.TabIndex = 3;
            lblCarInfo5.Text = "Sedan  •  4 Seats  •  Dhaka";

            lblBookingDates5.Font = new Font("Segoe UI", 9.5F);
            lblBookingDates5.ForeColor = Color.FromArgb(75, 96, 120);
            lblBookingDates5.Location = new Point(325, 88);
            lblBookingDates5.Name = "lblBookingDates5";
            lblBookingDates5.Size = new Size(500, 25);
            lblBookingDates5.TabIndex = 4;
            lblBookingDates5.Text = "Rental dates";

            lblBookingAmount5.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblBookingAmount5.ForeColor = Color.FromArgb(30, 136, 255);
            lblBookingAmount5.Location = new Point(325, 119);
            lblBookingAmount5.Name = "lblBookingAmount5";
            lblBookingAmount5.Size = new Size(220, 25);
            lblBookingAmount5.TabIndex = 5;
            lblBookingAmount5.Text = "💰  ৳0";

            lblPaymentStatus5.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPaymentStatus5.Location = new Point(550, 119);
            lblPaymentStatus5.Name = "lblPaymentStatus5";
            lblPaymentStatus5.Size = new Size(220, 25);
            lblPaymentStatus5.TabIndex = 6;
            lblPaymentStatus5.Text = "Payment: Not Paid";

            lblBookingStatus5.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBookingStatus5.Location = new Point(1045, 22);
            lblBookingStatus5.Name = "lblBookingStatus5";
            lblBookingStatus5.Size = new Size(175, 34);
            lblBookingStatus5.TabIndex = 7;
            lblBookingStatus5.Text = "Confirmed";
            lblBookingStatus5.TextAlign = ContentAlignment.MiddleCenter;

            btnViewDetails5.BackColor = Color.FromArgb(30, 136, 255);
            btnViewDetails5.Cursor = Cursors.Hand;
            btnViewDetails5.FlatAppearance.BorderSize = 0;
            btnViewDetails5.FlatStyle = FlatStyle.Flat;
            btnViewDetails5.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnViewDetails5.ForeColor = Color.White;
            btnViewDetails5.Location = new Point(1045, 112);
            btnViewDetails5.Name = "btnViewDetails5";
            btnViewDetails5.Size = new Size(175, 42);
            btnViewDetails5.TabIndex = 8;
            btnViewDetails5.Text = "View Details";
            btnViewDetails5.UseVisualStyleBackColor = false;
            btnViewDetails5.Click += btnViewDetails5_Click;

            // BOOKING CARD 6
            card6.BackColor = Color.White;
            card6.BorderStyle = BorderStyle.FixedSingle;
            card6.Controls.Add(btnViewDetails6);
            card6.Controls.Add(lblBookingStatus6);
            card6.Controls.Add(lblPaymentStatus6);
            card6.Controls.Add(lblBookingAmount6);
            card6.Controls.Add(lblBookingDates6);
            card6.Controls.Add(lblCarInfo6);
            card6.Controls.Add(lblCarName6);
            card6.Controls.Add(lblBookingNumber6);
            card6.Controls.Add(picCar6);
            card6.Margin = new Padding(0, 0, 0, 12);
            card6.Name = "card6";
            card6.Size = new Size(1250, 178);
            card6.TabIndex = 6;
            card6.Visible = false;

            picCar6.BackColor = Color.FromArgb(242, 246, 250);
            picCar6.Location = new Point(16, 16);
            picCar6.Name = "picCar6";
            picCar6.Size = new Size(285, 144);
            picCar6.SizeMode = PictureBoxSizeMode.Zoom;
            picCar6.TabIndex = 0;
            picCar6.TabStop = false;

            lblBookingNumber6.BackColor = Color.FromArgb(19, 45, 76);
            lblBookingNumber6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBookingNumber6.ForeColor = Color.White;
            lblBookingNumber6.Location = new Point(28, 28);
            lblBookingNumber6.Name = "lblBookingNumber6";
            lblBookingNumber6.Size = new Size(105, 30);
            lblBookingNumber6.TabIndex = 1;
            lblBookingNumber6.Text = "Booking #0";
            lblBookingNumber6.TextAlign = ContentAlignment.MiddleCenter;

            lblCarName6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblCarName6.ForeColor = Color.FromArgb(19, 45, 76);
            lblCarName6.Location = new Point(325, 22);
            lblCarName6.Name = "lblCarName6";
            lblCarName6.Size = new Size(500, 32);
            lblCarName6.TabIndex = 2;
            lblCarName6.Text = "Car Name";

            lblCarInfo6.Font = new Font("Segoe UI", 9.5F);
            lblCarInfo6.ForeColor = Color.FromArgb(75, 96, 120);
            lblCarInfo6.Location = new Point(325, 57);
            lblCarInfo6.Name = "lblCarInfo6";
            lblCarInfo6.Size = new Size(500, 25);
            lblCarInfo6.TabIndex = 3;
            lblCarInfo6.Text = "Sedan  •  4 Seats  •  Dhaka";

            lblBookingDates6.Font = new Font("Segoe UI", 9.5F);
            lblBookingDates6.ForeColor = Color.FromArgb(75, 96, 120);
            lblBookingDates6.Location = new Point(325, 88);
            lblBookingDates6.Name = "lblBookingDates6";
            lblBookingDates6.Size = new Size(500, 25);
            lblBookingDates6.TabIndex = 4;
            lblBookingDates6.Text = "Rental dates";

            lblBookingAmount6.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblBookingAmount6.ForeColor = Color.FromArgb(30, 136, 255);
            lblBookingAmount6.Location = new Point(325, 119);
            lblBookingAmount6.Name = "lblBookingAmount6";
            lblBookingAmount6.Size = new Size(220, 25);
            lblBookingAmount6.TabIndex = 5;
            lblBookingAmount6.Text = "💰  ৳0";

            lblPaymentStatus6.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPaymentStatus6.Location = new Point(550, 119);
            lblPaymentStatus6.Name = "lblPaymentStatus6";
            lblPaymentStatus6.Size = new Size(220, 25);
            lblPaymentStatus6.TabIndex = 6;
            lblPaymentStatus6.Text = "Payment: Not Paid";

            lblBookingStatus6.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBookingStatus6.Location = new Point(1045, 22);
            lblBookingStatus6.Name = "lblBookingStatus6";
            lblBookingStatus6.Size = new Size(175, 34);
            lblBookingStatus6.TabIndex = 7;
            lblBookingStatus6.Text = "Confirmed";
            lblBookingStatus6.TextAlign = ContentAlignment.MiddleCenter;

            btnViewDetails6.BackColor = Color.FromArgb(30, 136, 255);
            btnViewDetails6.Cursor = Cursors.Hand;
            btnViewDetails6.FlatAppearance.BorderSize = 0;
            btnViewDetails6.FlatStyle = FlatStyle.Flat;
            btnViewDetails6.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnViewDetails6.ForeColor = Color.White;
            btnViewDetails6.Location = new Point(1045, 112);
            btnViewDetails6.Name = "btnViewDetails6";
            btnViewDetails6.Size = new Size(175, 42);
            btnViewDetails6.TabIndex = 8;
            btnViewDetails6.Text = "View Details";
            btnViewDetails6.UseVisualStyleBackColor = false;
            btnViewDetails6.Click += btnViewDetails6_Click;


            bookingsFlowPanel.Controls.Add(lblNoBookings);
            bookingsFlowPanel.Controls.Add(card1);
            bookingsFlowPanel.Controls.Add(card2);
            bookingsFlowPanel.Controls.Add(card3);
            bookingsFlowPanel.Controls.Add(card4);
            bookingsFlowPanel.Controls.Add(card5);
            bookingsFlowPanel.Controls.Add(card6);

            btnCancelBooking.BackColor = Color.FromArgb(220, 53, 69);
            btnCancelBooking.Cursor = Cursors.Hand;
            btnCancelBooking.Enabled = false;
            btnCancelBooking.FlatStyle = FlatStyle.Flat;
            btnCancelBooking.FlatAppearance.BorderSize = 0;
            btnCancelBooking.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnCancelBooking.ForeColor = Color.White;
            btnCancelBooking.Location = new Point(28, 792);
            btnCancelBooking.Size = new Size(220, 48);
            btnCancelBooking.Text = "✕  Cancel Selected";
            btnCancelBooking.Click += btnCancelBooking_Click;

            btnPayNow.BackColor = Color.FromArgb(30, 136, 255);
            btnPayNow.Cursor = Cursors.Hand;
            btnPayNow.Enabled = false;
            btnPayNow.FlatStyle = FlatStyle.Flat;
            btnPayNow.FlatAppearance.BorderSize = 0;
            btnPayNow.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnPayNow.ForeColor = Color.White;
            btnPayNow.Location = new Point(263, 792);
            btnPayNow.Size = new Size(180, 48);
            btnPayNow.Text = "💳  Pay Now";
            btnPayNow.Click += btnPayNow_Click;

            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 248, 252);
            ClientSize = new Size(1400, 860);
            Controls.Add(btnPayNow);
            Controls.Add(btnCancelBooking);
            Controls.Add(bookingsContainer);
            Controls.Add(lblResults);
            Controls.Add(filterBarPanel);
            Controls.Add(summaryCompletedPanel);
            Controls.Add(summaryActivePanel);
            Controls.Add(summaryTotalPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MyBookingsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My Bookings";

            headerPanel.ResumeLayout(false);
            filterBarPanel.ResumeLayout(false);
            filterBarPanel.PerformLayout();
            bookingsContainer.ResumeLayout(false);
            bookingsFlowPanel.ResumeLayout(false);
            bookingsFlowPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
