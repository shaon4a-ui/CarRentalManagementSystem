using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customer
{
    partial class BrowseCarsForm
    {
        private System.ComponentModel.IContainer components = null;

        // Header
        private Panel headerPanel;
        private Button btnBack;
        private Label lblPageTitle;
        private Label lblSubtitle;
        private Label lblCustomer;

        // Filters
        private Panel filterPanel;
        private Label lblFilterTitle;
        private Label lblBrand;
        private ComboBox cmbBrand;
        private Label lblVehicleType;
        private ComboBox cmbVehicleType;
        private Label lblSeats;
        private ComboBox cmbSeats;
        private Label lblMaxPrice;
        private ComboBox cmbMaxPrice;
        private Label lblLocation;
        private ComboBox cmbLocation;
        private Button btnApplyFilters;
        private Button btnResetFilters;

        // Search
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblResults;

        // Results
        private Panel carsContainer;
        private FlowLayoutPanel carsFlowPanel;
        private Label lblNoCars;

        private Panel card1;
        private PictureBox picCar1;
        private Label lblCarName1;
        private Label lblCarInfo1;
        private Label lblCarLocation1;
        private Label lblCarAvailability1;
        private Label lblCarPrice1;
        private Button btnDetails1;
        private Panel card2;
        private PictureBox picCar2;
        private Label lblCarName2;
        private Label lblCarInfo2;
        private Label lblCarLocation2;
        private Label lblCarAvailability2;
        private Label lblCarPrice2;
        private Button btnDetails2;
        private Panel card3;
        private PictureBox picCar3;
        private Label lblCarName3;
        private Label lblCarInfo3;
        private Label lblCarLocation3;
        private Label lblCarAvailability3;
        private Label lblCarPrice3;
        private Button btnDetails3;
        private Panel card4;
        private PictureBox picCar4;
        private Label lblCarName4;
        private Label lblCarInfo4;
        private Label lblCarLocation4;
        private Label lblCarAvailability4;
        private Label lblCarPrice4;
        private Button btnDetails4;
        private Panel card5;
        private PictureBox picCar5;
        private Label lblCarName5;
        private Label lblCarInfo5;
        private Label lblCarLocation5;
        private Label lblCarAvailability5;
        private Label lblCarPrice5;
        private Button btnDetails5;
        private Panel card6;
        private PictureBox picCar6;
        private Label lblCarName6;
        private Label lblCarInfo6;
        private Label lblCarLocation6;
        private Label lblCarAvailability6;
        private Label lblCarPrice6;
        private Button btnDetails6;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            btnBack = new Button();
            lblPageTitle = new Label();
            lblSubtitle = new Label();
            lblCustomer = new Label();
            filterPanel = new Panel();
            lblFilterTitle = new Label();
            lblBrand = new Label();
            cmbBrand = new ComboBox();
            lblVehicleType = new Label();
            cmbVehicleType = new ComboBox();
            lblSeats = new Label();
            cmbSeats = new ComboBox();
            lblMaxPrice = new Label();
            cmbMaxPrice = new ComboBox();
            lblLocation = new Label();
            cmbLocation = new ComboBox();
            btnApplyFilters = new Button();
            btnResetFilters = new Button();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblResults = new Label();
            carsContainer = new Panel();
            carsFlowPanel = new FlowLayoutPanel();
            lblNoCars = new Label();
            card1 = new Panel();
            btnDetails1 = new Button();
            lblCarPrice1 = new Label();
            lblCarAvailability1 = new Label();
            lblCarLocation1 = new Label();
            lblCarInfo1 = new Label();
            lblCarName1 = new Label();
            picCar1 = new PictureBox();
            card2 = new Panel();
            btnDetails2 = new Button();
            lblCarPrice2 = new Label();
            lblCarAvailability2 = new Label();
            lblCarLocation2 = new Label();
            lblCarInfo2 = new Label();
            lblCarName2 = new Label();
            picCar2 = new PictureBox();
            card3 = new Panel();
            btnDetails3 = new Button();
            lblCarPrice3 = new Label();
            lblCarAvailability3 = new Label();
            lblCarLocation3 = new Label();
            lblCarInfo3 = new Label();
            lblCarName3 = new Label();
            picCar3 = new PictureBox();
            card4 = new Panel();
            btnDetails4 = new Button();
            lblCarPrice4 = new Label();
            lblCarAvailability4 = new Label();
            lblCarLocation4 = new Label();
            lblCarInfo4 = new Label();
            lblCarName4 = new Label();
            picCar4 = new PictureBox();
            card5 = new Panel();
            btnDetails5 = new Button();
            lblCarPrice5 = new Label();
            lblCarAvailability5 = new Label();
            lblCarLocation5 = new Label();
            lblCarInfo5 = new Label();
            lblCarName5 = new Label();
            picCar5 = new PictureBox();
            card6 = new Panel();
            btnDetails6 = new Button();
            lblCarPrice6 = new Label();
            lblCarAvailability6 = new Label();
            lblCarLocation6 = new Label();
            lblCarInfo6 = new Label();
            lblCarName6 = new Label();
            picCar6 = new PictureBox();
            headerPanel.SuspendLayout();
            filterPanel.SuspendLayout();
            carsContainer.SuspendLayout();
            carsFlowPanel.SuspendLayout();
            card1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar1).BeginInit();
            card2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar2).BeginInit();
            card3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar3).BeginInit();
            card4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar4).BeginInit();
            card5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar5).BeginInit();
            card6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar6).BeginInit();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(19, 45, 76);
            headerPanel.Controls.Add(btnBack);
            headerPanel.Controls.Add(lblPageTitle);
            headerPanel.Controls.Add(lblSubtitle);
            headerPanel.Controls.Add(lblCustomer);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1500, 92);
            headerPanel.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(19, 45, 76);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(92, 125, 160);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(20, 20);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 48);
            btnBack.TabIndex = 0;
            btnBack.Text = "←  Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(620, 10);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(219, 47);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Browse Cars";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(220, 232, 245);
            lblSubtitle.Location = new Point(610, 57);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(260, 21);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Find the perfect car for your journey";
            // 
            // lblCustomer
            // 
            lblCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCustomer.ForeColor = Color.White;
            lblCustomer.Location = new Point(1385, 35);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(83, 21);
            lblCustomer.TabIndex = 3;
            lblCustomer.Text = "Customer";
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.White;
            filterPanel.BorderStyle = BorderStyle.FixedSingle;
            filterPanel.Controls.Add(lblFilterTitle);
            filterPanel.Controls.Add(lblBrand);
            filterPanel.Controls.Add(cmbBrand);
            filterPanel.Controls.Add(lblVehicleType);
            filterPanel.Controls.Add(cmbVehicleType);
            filterPanel.Controls.Add(lblSeats);
            filterPanel.Controls.Add(cmbSeats);
            filterPanel.Controls.Add(lblMaxPrice);
            filterPanel.Controls.Add(cmbMaxPrice);
            filterPanel.Controls.Add(lblLocation);
            filterPanel.Controls.Add(cmbLocation);
            filterPanel.Controls.Add(btnApplyFilters);
            filterPanel.Controls.Add(btnResetFilters);
            filterPanel.Location = new Point(28, 112);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(300, 690);
            filterPanel.TabIndex = 1;
            // 
            // lblFilterTitle
            // 
            lblFilterTitle.AutoSize = true;
            lblFilterTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblFilterTitle.ForeColor = Color.FromArgb(19, 45, 76);
            lblFilterTitle.Location = new Point(22, 20);
            lblFilterTitle.Name = "lblFilterTitle";
            lblFilterTitle.Size = new Size(133, 35);
            lblFilterTitle.TabIndex = 0;
            lblFilterTitle.Text = "Filter Cars";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblBrand.ForeColor = Color.FromArgb(42, 62, 82);
            lblBrand.Location = new Point(22, 75);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(55, 21);
            lblBrand.TabIndex = 1;
            lblBrand.Text = "Brand";
            // 
            // cmbBrand
            // 
            cmbBrand.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBrand.Font = new Font("Segoe UI", 10F);
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Items.AddRange(new object[] { "All Brands", "Toyota", "BMW", "Tata", "Honda", "Nissan", "Mitsubishi", "Hyundai", "Ford", "Mercedes-Benz" });
            cmbBrand.Location = new Point(22, 101);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(254, 31);
            cmbBrand.TabIndex = 2;
            // 
            // lblVehicleType
            // 
            lblVehicleType.AutoSize = true;
            lblVehicleType.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblVehicleType.ForeColor = Color.FromArgb(42, 62, 82);
            lblVehicleType.Location = new Point(22, 153);
            lblVehicleType.Name = "lblVehicleType";
            lblVehicleType.Size = new Size(106, 21);
            lblVehicleType.TabIndex = 3;
            lblVehicleType.Text = "Vehicle Type";
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicleType.Font = new Font("Segoe UI", 10F);
            cmbVehicleType.FormattingEnabled = true;
            cmbVehicleType.Items.AddRange(new object[] { "All Types", "Sedan", "SUV", "Van", "Luxury" });
            cmbVehicleType.Location = new Point(22, 179);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(254, 31);
            cmbVehicleType.TabIndex = 4;
            // 
            // lblSeats
            // 
            lblSeats.AutoSize = true;
            lblSeats.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblSeats.ForeColor = Color.FromArgb(42, 62, 82);
            lblSeats.Location = new Point(22, 231);
            lblSeats.Name = "lblSeats";
            lblSeats.Size = new Size(50, 21);
            lblSeats.TabIndex = 5;
            lblSeats.Text = "Seats";
            // 
            // cmbSeats
            // 
            cmbSeats.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSeats.Font = new Font("Segoe UI", 10F);
            cmbSeats.FormattingEnabled = true;
            cmbSeats.Items.AddRange(new object[] { "All Seats", "2 Seats", "4 Seats", "5 Seats", "6 Seats", "7 Seats", "8 Seats" });
            cmbSeats.Location = new Point(22, 257);
            cmbSeats.Name = "cmbSeats";
            cmbSeats.Size = new Size(254, 31);
            cmbSeats.TabIndex = 6;
            // 
            // lblMaxPrice
            // 
            lblMaxPrice.AutoSize = true;
            lblMaxPrice.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblMaxPrice.ForeColor = Color.FromArgb(42, 62, 82);
            lblMaxPrice.Location = new Point(22, 309);
            lblMaxPrice.Name = "lblMaxPrice";
            lblMaxPrice.Size = new Size(175, 21);
            lblMaxPrice.TabIndex = 7;
            lblMaxPrice.Text = "Maximum Price / Day";
            // 
            // cmbMaxPrice
            // 
            cmbMaxPrice.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaxPrice.Font = new Font("Segoe UI", 10F);
            cmbMaxPrice.FormattingEnabled = true;
            cmbMaxPrice.Items.AddRange(new object[] { "Any Price", "Under ৳3,000", "Under ৳5,000", "Under ৳7,000", "Under ৳10,000", "Under ৳15,000" });
            cmbMaxPrice.Location = new Point(22, 335);
            cmbMaxPrice.Name = "cmbMaxPrice";
            cmbMaxPrice.Size = new Size(254, 31);
            cmbMaxPrice.TabIndex = 8;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLocation.ForeColor = Color.FromArgb(42, 62, 82);
            lblLocation.Location = new Point(22, 387);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(76, 21);
            lblLocation.TabIndex = 9;
            lblLocation.Text = "Location";
            // 
            // cmbLocation
            // 
            cmbLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbLocation.Font = new Font("Segoe UI", 10F);
            cmbLocation.FormattingEnabled = true;
            cmbLocation.Items.AddRange(new object[] { "All Locations", "Dhaka", "Chittagong", "Sylhet", "Rajshahi", "Khulna", "Rangpur", "Barisal", "Mymensingh" });
            cmbLocation.Location = new Point(22, 413);
            cmbLocation.Name = "cmbLocation";
            cmbLocation.Size = new Size(254, 31);
            cmbLocation.TabIndex = 10;
            // 
            // btnApplyFilters
            // 
            btnApplyFilters.BackColor = Color.FromArgb(30, 136, 255);
            btnApplyFilters.Cursor = Cursors.Hand;
            btnApplyFilters.FlatAppearance.BorderSize = 0;
            btnApplyFilters.FlatStyle = FlatStyle.Flat;
            btnApplyFilters.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnApplyFilters.ForeColor = Color.White;
            btnApplyFilters.Location = new Point(22, 478);
            btnApplyFilters.Name = "btnApplyFilters";
            btnApplyFilters.Size = new Size(254, 50);
            btnApplyFilters.TabIndex = 11;
            btnApplyFilters.Text = "Apply Filters";
            btnApplyFilters.UseVisualStyleBackColor = false;
            btnApplyFilters.Click += btnApplyFilters_Click;
            // 
            // btnResetFilters
            // 
            btnResetFilters.BackColor = Color.White;
            btnResetFilters.Cursor = Cursors.Hand;
            btnResetFilters.FlatAppearance.BorderColor = Color.FromArgb(205, 215, 225);
            btnResetFilters.FlatStyle = FlatStyle.Flat;
            btnResetFilters.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnResetFilters.ForeColor = Color.FromArgb(42, 62, 82);
            btnResetFilters.Location = new Point(22, 535);
            btnResetFilters.Name = "btnResetFilters";
            btnResetFilters.Size = new Size(254, 50);
            btnResetFilters.TabIndex = 12;
            btnResetFilters.Text = "Reset Filters";
            btnResetFilters.UseVisualStyleBackColor = false;
            btnResetFilters.Click += btnResetFilters_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(19, 45, 76);
            lblSearch.Location = new Point(355, 112);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(166, 23);
            lblSearch.TabIndex = 13;
            lblSearch.Text = "Search by car name";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 11F);
            txtSearch.Location = new Point(355, 140);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(790, 32);
            txtSearch.TabIndex = 14;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(30, 136, 255);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(1160, 136);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 41);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResults.ForeColor = Color.FromArgb(72, 88, 105);
            lblResults.Location = new Point(365, 194);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(123, 23);
            lblResults.TabIndex = 16;
            lblResults.Text = "Available Cars";
            // 
            // carsContainer
            // 
            carsContainer.BackColor = Color.White;
            carsContainer.BorderStyle = BorderStyle.FixedSingle;
            carsContainer.Controls.Add(carsFlowPanel);
            carsContainer.Location = new Point(355, 230);
            carsContainer.Name = "carsContainer";
            carsContainer.Padding = new Padding(8);
            carsContainer.Size = new Size(1117, 572);
            carsContainer.TabIndex = 17;
            // 
            // carsFlowPanel
            // 
            carsFlowPanel.AutoScroll = true;
            carsFlowPanel.BackColor = Color.FromArgb(244, 248, 252);
            carsFlowPanel.Controls.Add(lblNoCars);
            carsFlowPanel.Controls.Add(card1);
            carsFlowPanel.Controls.Add(card2);
            carsFlowPanel.Controls.Add(card3);
            carsFlowPanel.Controls.Add(card4);
            carsFlowPanel.Controls.Add(card5);
            carsFlowPanel.Controls.Add(card6);
            carsFlowPanel.Dock = DockStyle.Fill;
            carsFlowPanel.FlowDirection = FlowDirection.TopDown;
            carsFlowPanel.Location = new Point(8, 8);
            carsFlowPanel.Name = "carsFlowPanel";
            carsFlowPanel.Padding = new Padding(18, 16, 18, 16);
            carsFlowPanel.Size = new Size(1099, 554);
            carsFlowPanel.TabIndex = 0;
            carsFlowPanel.WrapContents = false;
            // 
            // lblNoCars
            // 
            lblNoCars.AutoSize = true;
            lblNoCars.Font = new Font("Segoe UI", 11F);
            lblNoCars.ForeColor = Color.FromArgb(107, 125, 145);
            lblNoCars.Location = new Point(21, 16);
            lblNoCars.Name = "lblNoCars";
            lblNoCars.Size = new Size(306, 25);
            lblNoCars.TabIndex = 0;
            lblNoCars.Text = "No cars match your selected filters.";
            lblNoCars.Visible = false;
            // 
            // card1
            // 
            card1.BackColor = Color.White;
            card1.BorderStyle = BorderStyle.FixedSingle;
            card1.Controls.Add(btnDetails1);
            card1.Controls.Add(lblCarPrice1);
            card1.Controls.Add(lblCarAvailability1);
            card1.Controls.Add(lblCarLocation1);
            card1.Controls.Add(lblCarInfo1);
            card1.Controls.Add(lblCarName1);
            card1.Controls.Add(picCar1);
            card1.Location = new Point(20, 41);
            card1.Margin = new Padding(2, 0, 2, 12);
            card1.Name = "card1";
            card1.Size = new Size(1035, 145);
            card1.TabIndex = 1;
            card1.Visible = false;
            // 
            // btnDetails1
            // 
            btnDetails1.BackColor = Color.FromArgb(30, 136, 255);
            btnDetails1.Cursor = Cursors.Hand;
            btnDetails1.FlatAppearance.BorderSize = 0;
            btnDetails1.FlatStyle = FlatStyle.Flat;
            btnDetails1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDetails1.ForeColor = Color.White;
            btnDetails1.Location = new Point(875, 91);
            btnDetails1.Name = "btnDetails1";
            btnDetails1.Size = new Size(135, 40);
            btnDetails1.TabIndex = 6;
            btnDetails1.Text = "View Details";
            btnDetails1.UseVisualStyleBackColor = false;
            btnDetails1.Click += ViewDetails_Click;
            // 
            // lblCarPrice1
            // 
            lblCarPrice1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCarPrice1.ForeColor = Color.FromArgb(30, 136, 255);
            lblCarPrice1.Location = new Point(530, 100);
            lblCarPrice1.Name = "lblCarPrice1";
            lblCarPrice1.Size = new Size(220, 28);
            lblCarPrice1.TabIndex = 5;
            lblCarPrice1.Text = "৳3,400 / day";
            // 
            // lblCarAvailability1
            // 
            lblCarAvailability1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCarAvailability1.ForeColor = Color.FromArgb(22, 163, 74);
            lblCarAvailability1.Location = new Point(220, 103);
            lblCarAvailability1.Name = "lblCarAvailability1";
            lblCarAvailability1.Size = new Size(180, 22);
            lblCarAvailability1.TabIndex = 4;
            lblCarAvailability1.Text = "● Available";
            // 
            // lblCarLocation1
            // 
            lblCarLocation1.Font = new Font("Segoe UI", 9.5F);
            lblCarLocation1.ForeColor = Color.FromArgb(72, 88, 105);
            lblCarLocation1.Location = new Point(220, 78);
            lblCarLocation1.Name = "lblCarLocation1";
            lblCarLocation1.Size = new Size(400, 24);
            lblCarLocation1.TabIndex = 3;
            lblCarLocation1.Text = "Location: Dhaka";
            // 
            // lblCarInfo1
            // 
            lblCarInfo1.Font = new Font("Segoe UI", 9.5F);
            lblCarInfo1.ForeColor = Color.FromArgb(102, 119, 138);
            lblCarInfo1.Location = new Point(220, 52);
            lblCarInfo1.Name = "lblCarInfo1";
            lblCarInfo1.Size = new Size(500, 24);
            lblCarInfo1.TabIndex = 2;
            lblCarInfo1.Text = "Sedan  •  4 Seats  •  2025";
            // 
            // lblCarName1
            // 
            lblCarName1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCarName1.ForeColor = Color.FromArgb(19, 45, 76);
            lblCarName1.Location = new Point(220, 16);
            lblCarName1.Name = "lblCarName1";
            lblCarName1.Size = new Size(500, 30);
            lblCarName1.TabIndex = 1;
            lblCarName1.Text = "Car Name";
            // 
            // picCar1
            // 
            picCar1.BackColor = Color.FromArgb(242, 246, 250);
            picCar1.Location = new Point(12, 12);
            picCar1.Name = "picCar1";
            picCar1.Size = new Size(190, 119);
            picCar1.SizeMode = PictureBoxSizeMode.Zoom;
            picCar1.TabIndex = 0;
            picCar1.TabStop = false;
            // 
            // card2
            // 
            card2.BackColor = Color.White;
            card2.BorderStyle = BorderStyle.FixedSingle;
            card2.Controls.Add(btnDetails2);
            card2.Controls.Add(lblCarPrice2);
            card2.Controls.Add(lblCarAvailability2);
            card2.Controls.Add(lblCarLocation2);
            card2.Controls.Add(lblCarInfo2);
            card2.Controls.Add(lblCarName2);
            card2.Controls.Add(picCar2);
            card2.Location = new Point(20, 198);
            card2.Margin = new Padding(2, 0, 2, 12);
            card2.Name = "card2";
            card2.Size = new Size(1035, 145);
            card2.TabIndex = 2;
            card2.Visible = false;
            // 
            // btnDetails2
            // 
            btnDetails2.BackColor = Color.FromArgb(30, 136, 255);
            btnDetails2.Cursor = Cursors.Hand;
            btnDetails2.FlatAppearance.BorderSize = 0;
            btnDetails2.FlatStyle = FlatStyle.Flat;
            btnDetails2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDetails2.ForeColor = Color.White;
            btnDetails2.Location = new Point(875, 91);
            btnDetails2.Name = "btnDetails2";
            btnDetails2.Size = new Size(135, 40);
            btnDetails2.TabIndex = 6;
            btnDetails2.Text = "View Details";
            btnDetails2.UseVisualStyleBackColor = false;
            btnDetails2.Click += ViewDetails_Click;
            // 
            // lblCarPrice2
            // 
            lblCarPrice2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCarPrice2.ForeColor = Color.FromArgb(30, 136, 255);
            lblCarPrice2.Location = new Point(530, 100);
            lblCarPrice2.Name = "lblCarPrice2";
            lblCarPrice2.Size = new Size(220, 28);
            lblCarPrice2.TabIndex = 5;
            lblCarPrice2.Text = "৳3,400 / day";
            // 
            // lblCarAvailability2
            // 
            lblCarAvailability2.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCarAvailability2.ForeColor = Color.FromArgb(22, 163, 74);
            lblCarAvailability2.Location = new Point(220, 103);
            lblCarAvailability2.Name = "lblCarAvailability2";
            lblCarAvailability2.Size = new Size(180, 22);
            lblCarAvailability2.TabIndex = 4;
            lblCarAvailability2.Text = "● Available";
            // 
            // lblCarLocation2
            // 
            lblCarLocation2.Font = new Font("Segoe UI", 9.5F);
            lblCarLocation2.ForeColor = Color.FromArgb(72, 88, 105);
            lblCarLocation2.Location = new Point(220, 78);
            lblCarLocation2.Name = "lblCarLocation2";
            lblCarLocation2.Size = new Size(400, 24);
            lblCarLocation2.TabIndex = 3;
            lblCarLocation2.Text = "Location: Dhaka";
            // 
            // lblCarInfo2
            // 
            lblCarInfo2.Font = new Font("Segoe UI", 9.5F);
            lblCarInfo2.ForeColor = Color.FromArgb(102, 119, 138);
            lblCarInfo2.Location = new Point(220, 52);
            lblCarInfo2.Name = "lblCarInfo2";
            lblCarInfo2.Size = new Size(500, 24);
            lblCarInfo2.TabIndex = 2;
            lblCarInfo2.Text = "Sedan  •  4 Seats  •  2025";
            // 
            // lblCarName2
            // 
            lblCarName2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCarName2.ForeColor = Color.FromArgb(19, 45, 76);
            lblCarName2.Location = new Point(220, 16);
            lblCarName2.Name = "lblCarName2";
            lblCarName2.Size = new Size(500, 30);
            lblCarName2.TabIndex = 1;
            lblCarName2.Text = "Car Name";
            // 
            // picCar2
            // 
            picCar2.BackColor = Color.FromArgb(242, 246, 250);
            picCar2.Location = new Point(12, 12);
            picCar2.Name = "picCar2";
            picCar2.Size = new Size(190, 119);
            picCar2.SizeMode = PictureBoxSizeMode.Zoom;
            picCar2.TabIndex = 0;
            picCar2.TabStop = false;
            // 
            // card3
            // 
            card3.BackColor = Color.White;
            card3.BorderStyle = BorderStyle.FixedSingle;
            card3.Controls.Add(btnDetails3);
            card3.Controls.Add(lblCarPrice3);
            card3.Controls.Add(lblCarAvailability3);
            card3.Controls.Add(lblCarLocation3);
            card3.Controls.Add(lblCarInfo3);
            card3.Controls.Add(lblCarName3);
            card3.Controls.Add(picCar3);
            card3.Location = new Point(20, 355);
            card3.Margin = new Padding(2, 0, 2, 12);
            card3.Name = "card3";
            card3.Size = new Size(1035, 145);
            card3.TabIndex = 3;
            card3.Visible = false;
            // 
            // btnDetails3
            // 
            btnDetails3.BackColor = Color.FromArgb(30, 136, 255);
            btnDetails3.Cursor = Cursors.Hand;
            btnDetails3.FlatAppearance.BorderSize = 0;
            btnDetails3.FlatStyle = FlatStyle.Flat;
            btnDetails3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDetails3.ForeColor = Color.White;
            btnDetails3.Location = new Point(875, 91);
            btnDetails3.Name = "btnDetails3";
            btnDetails3.Size = new Size(135, 40);
            btnDetails3.TabIndex = 6;
            btnDetails3.Text = "View Details";
            btnDetails3.UseVisualStyleBackColor = false;
            btnDetails3.Click += ViewDetails_Click;
            // 
            // lblCarPrice3
            // 
            lblCarPrice3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCarPrice3.ForeColor = Color.FromArgb(30, 136, 255);
            lblCarPrice3.Location = new Point(530, 100);
            lblCarPrice3.Name = "lblCarPrice3";
            lblCarPrice3.Size = new Size(220, 28);
            lblCarPrice3.TabIndex = 5;
            lblCarPrice3.Text = "৳3,400 / day";
            // 
            // lblCarAvailability3
            // 
            lblCarAvailability3.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCarAvailability3.ForeColor = Color.FromArgb(22, 163, 74);
            lblCarAvailability3.Location = new Point(220, 103);
            lblCarAvailability3.Name = "lblCarAvailability3";
            lblCarAvailability3.Size = new Size(180, 22);
            lblCarAvailability3.TabIndex = 4;
            lblCarAvailability3.Text = "● Available";
            // 
            // lblCarLocation3
            // 
            lblCarLocation3.Font = new Font("Segoe UI", 9.5F);
            lblCarLocation3.ForeColor = Color.FromArgb(72, 88, 105);
            lblCarLocation3.Location = new Point(220, 78);
            lblCarLocation3.Name = "lblCarLocation3";
            lblCarLocation3.Size = new Size(400, 24);
            lblCarLocation3.TabIndex = 3;
            lblCarLocation3.Text = "Location: Dhaka";
            // 
            // lblCarInfo3
            // 
            lblCarInfo3.Font = new Font("Segoe UI", 9.5F);
            lblCarInfo3.ForeColor = Color.FromArgb(102, 119, 138);
            lblCarInfo3.Location = new Point(220, 52);
            lblCarInfo3.Name = "lblCarInfo3";
            lblCarInfo3.Size = new Size(500, 24);
            lblCarInfo3.TabIndex = 2;
            lblCarInfo3.Text = "Sedan  •  4 Seats  •  2025";
            // 
            // lblCarName3
            // 
            lblCarName3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCarName3.ForeColor = Color.FromArgb(19, 45, 76);
            lblCarName3.Location = new Point(220, 16);
            lblCarName3.Name = "lblCarName3";
            lblCarName3.Size = new Size(500, 30);
            lblCarName3.TabIndex = 1;
            lblCarName3.Text = "Car Name";
            // 
            // picCar3
            // 
            picCar3.BackColor = Color.FromArgb(242, 246, 250);
            picCar3.Location = new Point(12, 12);
            picCar3.Name = "picCar3";
            picCar3.Size = new Size(190, 119);
            picCar3.SizeMode = PictureBoxSizeMode.Zoom;
            picCar3.TabIndex = 0;
            picCar3.TabStop = false;
            // 
            // card4
            // 
            card4.BackColor = Color.White;
            card4.BorderStyle = BorderStyle.FixedSingle;
            card4.Controls.Add(btnDetails4);
            card4.Controls.Add(lblCarPrice4);
            card4.Controls.Add(lblCarAvailability4);
            card4.Controls.Add(lblCarLocation4);
            card4.Controls.Add(lblCarInfo4);
            card4.Controls.Add(lblCarName4);
            card4.Controls.Add(picCar4);
            card4.Location = new Point(20, 512);
            card4.Margin = new Padding(2, 0, 2, 12);
            card4.Name = "card4";
            card4.Size = new Size(1035, 145);
            card4.TabIndex = 4;
            card4.Visible = false;
            // 
            // btnDetails4
            // 
            btnDetails4.BackColor = Color.FromArgb(30, 136, 255);
            btnDetails4.Cursor = Cursors.Hand;
            btnDetails4.FlatAppearance.BorderSize = 0;
            btnDetails4.FlatStyle = FlatStyle.Flat;
            btnDetails4.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDetails4.ForeColor = Color.White;
            btnDetails4.Location = new Point(875, 91);
            btnDetails4.Name = "btnDetails4";
            btnDetails4.Size = new Size(135, 40);
            btnDetails4.TabIndex = 6;
            btnDetails4.Text = "View Details";
            btnDetails4.UseVisualStyleBackColor = false;
            btnDetails4.Click += ViewDetails_Click;
            // 
            // lblCarPrice4
            // 
            lblCarPrice4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCarPrice4.ForeColor = Color.FromArgb(30, 136, 255);
            lblCarPrice4.Location = new Point(530, 100);
            lblCarPrice4.Name = "lblCarPrice4";
            lblCarPrice4.Size = new Size(220, 28);
            lblCarPrice4.TabIndex = 5;
            lblCarPrice4.Text = "৳3,400 / day";
            // 
            // lblCarAvailability4
            // 
            lblCarAvailability4.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCarAvailability4.ForeColor = Color.FromArgb(22, 163, 74);
            lblCarAvailability4.Location = new Point(220, 103);
            lblCarAvailability4.Name = "lblCarAvailability4";
            lblCarAvailability4.Size = new Size(180, 22);
            lblCarAvailability4.TabIndex = 4;
            lblCarAvailability4.Text = "● Available";
            // 
            // lblCarLocation4
            // 
            lblCarLocation4.Font = new Font("Segoe UI", 9.5F);
            lblCarLocation4.ForeColor = Color.FromArgb(72, 88, 105);
            lblCarLocation4.Location = new Point(220, 78);
            lblCarLocation4.Name = "lblCarLocation4";
            lblCarLocation4.Size = new Size(400, 24);
            lblCarLocation4.TabIndex = 3;
            lblCarLocation4.Text = "Location: Dhaka";
            // 
            // lblCarInfo4
            // 
            lblCarInfo4.Font = new Font("Segoe UI", 9.5F);
            lblCarInfo4.ForeColor = Color.FromArgb(102, 119, 138);
            lblCarInfo4.Location = new Point(220, 52);
            lblCarInfo4.Name = "lblCarInfo4";
            lblCarInfo4.Size = new Size(500, 24);
            lblCarInfo4.TabIndex = 2;
            lblCarInfo4.Text = "Sedan  •  4 Seats  •  2025";
            // 
            // lblCarName4
            // 
            lblCarName4.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCarName4.ForeColor = Color.FromArgb(19, 45, 76);
            lblCarName4.Location = new Point(220, 16);
            lblCarName4.Name = "lblCarName4";
            lblCarName4.Size = new Size(500, 30);
            lblCarName4.TabIndex = 1;
            lblCarName4.Text = "Car Name";
            // 
            // picCar4
            // 
            picCar4.BackColor = Color.FromArgb(242, 246, 250);
            picCar4.Location = new Point(12, 12);
            picCar4.Name = "picCar4";
            picCar4.Size = new Size(190, 119);
            picCar4.SizeMode = PictureBoxSizeMode.Zoom;
            picCar4.TabIndex = 0;
            picCar4.TabStop = false;
            // 
            // card5
            // 
            card5.BackColor = Color.White;
            card5.BorderStyle = BorderStyle.FixedSingle;
            card5.Controls.Add(btnDetails5);
            card5.Controls.Add(lblCarPrice5);
            card5.Controls.Add(lblCarAvailability5);
            card5.Controls.Add(lblCarLocation5);
            card5.Controls.Add(lblCarInfo5);
            card5.Controls.Add(lblCarName5);
            card5.Controls.Add(picCar5);
            card5.Location = new Point(20, 669);
            card5.Margin = new Padding(2, 0, 2, 12);
            card5.Name = "card5";
            card5.Size = new Size(1035, 145);
            card5.TabIndex = 5;
            card5.Visible = false;
            // 
            // btnDetails5
            // 
            btnDetails5.BackColor = Color.FromArgb(30, 136, 255);
            btnDetails5.Cursor = Cursors.Hand;
            btnDetails5.FlatAppearance.BorderSize = 0;
            btnDetails5.FlatStyle = FlatStyle.Flat;
            btnDetails5.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDetails5.ForeColor = Color.White;
            btnDetails5.Location = new Point(875, 91);
            btnDetails5.Name = "btnDetails5";
            btnDetails5.Size = new Size(135, 40);
            btnDetails5.TabIndex = 6;
            btnDetails5.Text = "View Details";
            btnDetails5.UseVisualStyleBackColor = false;
            btnDetails5.Click += ViewDetails_Click;
            // 
            // lblCarPrice5
            // 
            lblCarPrice5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCarPrice5.ForeColor = Color.FromArgb(30, 136, 255);
            lblCarPrice5.Location = new Point(530, 100);
            lblCarPrice5.Name = "lblCarPrice5";
            lblCarPrice5.Size = new Size(220, 28);
            lblCarPrice5.TabIndex = 5;
            lblCarPrice5.Text = "৳3,400 / day";
            // 
            // lblCarAvailability5
            // 
            lblCarAvailability5.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCarAvailability5.ForeColor = Color.FromArgb(22, 163, 74);
            lblCarAvailability5.Location = new Point(220, 103);
            lblCarAvailability5.Name = "lblCarAvailability5";
            lblCarAvailability5.Size = new Size(180, 22);
            lblCarAvailability5.TabIndex = 4;
            lblCarAvailability5.Text = "● Available";
            // 
            // lblCarLocation5
            // 
            lblCarLocation5.Font = new Font("Segoe UI", 9.5F);
            lblCarLocation5.ForeColor = Color.FromArgb(72, 88, 105);
            lblCarLocation5.Location = new Point(220, 78);
            lblCarLocation5.Name = "lblCarLocation5";
            lblCarLocation5.Size = new Size(400, 24);
            lblCarLocation5.TabIndex = 3;
            lblCarLocation5.Text = "Location: Dhaka";
            // 
            // lblCarInfo5
            // 
            lblCarInfo5.Font = new Font("Segoe UI", 9.5F);
            lblCarInfo5.ForeColor = Color.FromArgb(102, 119, 138);
            lblCarInfo5.Location = new Point(220, 52);
            lblCarInfo5.Name = "lblCarInfo5";
            lblCarInfo5.Size = new Size(500, 24);
            lblCarInfo5.TabIndex = 2;
            lblCarInfo5.Text = "Sedan  •  4 Seats  •  2025";
            // 
            // lblCarName5
            // 
            lblCarName5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCarName5.ForeColor = Color.FromArgb(19, 45, 76);
            lblCarName5.Location = new Point(220, 16);
            lblCarName5.Name = "lblCarName5";
            lblCarName5.Size = new Size(500, 30);
            lblCarName5.TabIndex = 1;
            lblCarName5.Text = "Car Name";
            // 
            // picCar5
            // 
            picCar5.BackColor = Color.FromArgb(242, 246, 250);
            picCar5.Location = new Point(12, 12);
            picCar5.Name = "picCar5";
            picCar5.Size = new Size(190, 119);
            picCar5.SizeMode = PictureBoxSizeMode.Zoom;
            picCar5.TabIndex = 0;
            picCar5.TabStop = false;
            // 
            // card6
            // 
            card6.BackColor = Color.White;
            card6.BorderStyle = BorderStyle.FixedSingle;
            card6.Controls.Add(btnDetails6);
            card6.Controls.Add(lblCarPrice6);
            card6.Controls.Add(lblCarAvailability6);
            card6.Controls.Add(lblCarLocation6);
            card6.Controls.Add(lblCarInfo6);
            card6.Controls.Add(lblCarName6);
            card6.Controls.Add(picCar6);
            card6.Location = new Point(20, 826);
            card6.Margin = new Padding(2, 0, 2, 12);
            card6.Name = "card6";
            card6.Size = new Size(1035, 145);
            card6.TabIndex = 6;
            card6.Visible = false;
            // 
            // btnDetails6
            // 
            btnDetails6.BackColor = Color.FromArgb(30, 136, 255);
            btnDetails6.Cursor = Cursors.Hand;
            btnDetails6.FlatAppearance.BorderSize = 0;
            btnDetails6.FlatStyle = FlatStyle.Flat;
            btnDetails6.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDetails6.ForeColor = Color.White;
            btnDetails6.Location = new Point(875, 91);
            btnDetails6.Name = "btnDetails6";
            btnDetails6.Size = new Size(135, 40);
            btnDetails6.TabIndex = 6;
            btnDetails6.Text = "View Details";
            btnDetails6.UseVisualStyleBackColor = false;
            btnDetails6.Click += ViewDetails_Click;
            // 
            // lblCarPrice6
            // 
            lblCarPrice6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblCarPrice6.ForeColor = Color.FromArgb(30, 136, 255);
            lblCarPrice6.Location = new Point(530, 100);
            lblCarPrice6.Name = "lblCarPrice6";
            lblCarPrice6.Size = new Size(220, 28);
            lblCarPrice6.TabIndex = 5;
            lblCarPrice6.Text = "৳3,400 / day";
            // 
            // lblCarAvailability6
            // 
            lblCarAvailability6.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCarAvailability6.ForeColor = Color.FromArgb(22, 163, 74);
            lblCarAvailability6.Location = new Point(220, 103);
            lblCarAvailability6.Name = "lblCarAvailability6";
            lblCarAvailability6.Size = new Size(180, 22);
            lblCarAvailability6.TabIndex = 4;
            lblCarAvailability6.Text = "● Available";
            // 
            // lblCarLocation6
            // 
            lblCarLocation6.Font = new Font("Segoe UI", 9.5F);
            lblCarLocation6.ForeColor = Color.FromArgb(72, 88, 105);
            lblCarLocation6.Location = new Point(220, 78);
            lblCarLocation6.Name = "lblCarLocation6";
            lblCarLocation6.Size = new Size(400, 24);
            lblCarLocation6.TabIndex = 3;
            lblCarLocation6.Text = "Location: Dhaka";
            // 
            // lblCarInfo6
            // 
            lblCarInfo6.Font = new Font("Segoe UI", 9.5F);
            lblCarInfo6.ForeColor = Color.FromArgb(102, 119, 138);
            lblCarInfo6.Location = new Point(220, 52);
            lblCarInfo6.Name = "lblCarInfo6";
            lblCarInfo6.Size = new Size(500, 24);
            lblCarInfo6.TabIndex = 2;
            lblCarInfo6.Text = "Sedan  •  4 Seats  •  2025";
            // 
            // lblCarName6
            // 
            lblCarName6.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblCarName6.ForeColor = Color.FromArgb(19, 45, 76);
            lblCarName6.Location = new Point(220, 16);
            lblCarName6.Name = "lblCarName6";
            lblCarName6.Size = new Size(500, 30);
            lblCarName6.TabIndex = 1;
            lblCarName6.Text = "Car Name";
            // 
            // picCar6
            // 
            picCar6.BackColor = Color.FromArgb(242, 246, 250);
            picCar6.Location = new Point(12, 12);
            picCar6.Name = "picCar6";
            picCar6.Size = new Size(190, 119);
            picCar6.SizeMode = PictureBoxSizeMode.Zoom;
            picCar6.TabIndex = 0;
            picCar6.TabStop = false;
            // 
            // BrowseCarsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 248, 252);
            ClientSize = new Size(1500, 840);
            Controls.Add(carsContainer);
            Controls.Add(lblResults);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(filterPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "BrowseCarsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Browse Cars";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            carsContainer.ResumeLayout(false);
            carsFlowPanel.ResumeLayout(false);
            carsFlowPanel.PerformLayout();
            card1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCar1).EndInit();
            card2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCar2).EndInit();
            card3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCar3).EndInit();
            card4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCar4).EndInit();
            card5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCar5).EndInit();
            card6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCar6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
