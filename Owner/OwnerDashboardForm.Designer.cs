namespace CarRentalManagementSystem.Owner
{
    partial class OwnerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Label lblBrandIcon;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblBrandSubtitle;
        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.Label lblProfileIcon;
        private System.Windows.Forms.Label lblOwnerName;
        private System.Windows.Forms.Label lblOwnerRole;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnMyCars;
        private System.Windows.Forms.Button btnOwnerBookings;
        private System.Windows.Forms.Button btnEarnings;
        private System.Windows.Forms.Button btnOffers;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblSidebarQuote;

        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel heroPanel;
        private System.Windows.Forms.Label lblPageTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Label lblHeroCarIcon;

        private System.Windows.Forms.Panel totalCarsCard;
        private System.Windows.Forms.Label lblTotalCarsIcon;
        private System.Windows.Forms.Label lblTotalCarsTitle;
        private System.Windows.Forms.Label lblTotalCars;
        private System.Windows.Forms.Label lblTotalCarsDescription;

        private System.Windows.Forms.Panel availableCarsCard;
        private System.Windows.Forms.Label lblAvailableCarsIcon;
        private System.Windows.Forms.Label lblAvailableCarsTitle;
        private System.Windows.Forms.Label lblAvailableCars;
        private System.Windows.Forms.Label lblAvailableCarsDescription;

        private System.Windows.Forms.Panel rentedCarsCard;
        private System.Windows.Forms.Label lblRentedCarsIcon;
        private System.Windows.Forms.Label lblRentedCarsTitle;
        private System.Windows.Forms.Label lblRentedCars;
        private System.Windows.Forms.Label lblRentedCarsDescription;

        private System.Windows.Forms.Panel earningsCard;
        private System.Windows.Forms.Label lblEarningsIcon;
        private System.Windows.Forms.Label lblEarningsTitle;
        private System.Windows.Forms.Label lblTotalEarnings;
        private System.Windows.Forms.Label lblEarningsDescription;

        private System.Windows.Forms.Panel pendingCard;
        private System.Windows.Forms.Label lblPendingIcon;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Label lblPendingBookings;
        private System.Windows.Forms.Label lblPendingDescription;

        private System.Windows.Forms.Panel vehicleStatusPanel;
        private System.Windows.Forms.Label lblVehicleStatusTitle;
        private System.Windows.Forms.Label lblVehicleStatusSubtitle;
        private System.Windows.Forms.Panel vehicleChartPanel;
        private System.Windows.Forms.Label lblAvailableLegend;
        private System.Windows.Forms.Label lblAvailableLegendValue;
        private System.Windows.Forms.Label lblRentedLegend;
        private System.Windows.Forms.Label lblRentedLegendValue;
        private System.Windows.Forms.Label lblInactiveLegend;
        private System.Windows.Forms.Label lblInactiveLegendValue;

        private System.Windows.Forms.Panel earningsOverviewPanel;
        private System.Windows.Forms.Label lblEarningsOverviewTitle;
        private System.Windows.Forms.Label lblEarningsOverviewSubtitle;
        private System.Windows.Forms.ComboBox cmbEarningsPeriod;
        private System.Windows.Forms.Panel earningsChartPanel;

        private System.Windows.Forms.Panel quickActionsPanel;
        private System.Windows.Forms.Label lblQuickActionsTitle;
        private System.Windows.Forms.Button btnAddNewCar;
        private System.Windows.Forms.Button btnManageCars;
        private System.Windows.Forms.Button btnViewBookings;
        private System.Windows.Forms.Button btnViewEarnings;

        private System.Windows.Forms.Panel recentBookingsPanel;
        private System.Windows.Forms.Label lblRecentBookingsTitle;
        private System.Windows.Forms.Label lblRecentBookingsSubtitle;
        private System.Windows.Forms.Button btnViewAllBookings;
        private System.Windows.Forms.DataGridView dgvRecentBookings;

        private System.Windows.Forms.Panel activityPanel;
        private System.Windows.Forms.Label lblActivityTitle;
        private System.Windows.Forms.Button btnViewAllActivity;
        private System.Windows.Forms.Panel activityItem1;
        private System.Windows.Forms.Panel activityItem2;
        private System.Windows.Forms.Panel activityItem3;
        private System.Windows.Forms.Panel activityItem4;
        private System.Windows.Forms.Label lblActivityIcon1;
        private System.Windows.Forms.Label lblActivityIcon2;
        private System.Windows.Forms.Label lblActivityIcon3;
        private System.Windows.Forms.Label lblActivityIcon4;
        private System.Windows.Forms.Label lblActivityText1;
        private System.Windows.Forms.Label lblActivityText2;
        private System.Windows.Forms.Label lblActivityText3;
        private System.Windows.Forms.Label lblActivityText4;
        private System.Windows.Forms.Label lblActivityTime1;
        private System.Windows.Forms.Label lblActivityTime2;
        private System.Windows.Forms.Label lblActivityTime3;
        private System.Windows.Forms.Label lblActivityTime4;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            sidebarPanel = new Panel();
            lblBrandIcon = new Label();
            lblBrand = new Label();
            lblBrandSubtitle = new Label();
            profilePanel = new Panel();
            lblProfileIcon = new Label();
            lblOwnerName = new Label();
            lblOwnerRole = new Label();
            btnDashboard = new Button();
            btnMyCars = new Button();
            btnOwnerBookings = new Button();
            btnEarnings = new Button();
            btnOffers = new Button();
            btnSettings = new Button();
            btnLogout = new Button();
            lblSidebarQuote = new Label();
            contentPanel = new Panel();
            heroPanel = new Panel();
            lblPageTitle = new Label();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            lblHeroCarIcon = new Label();
            totalCarsCard = new Panel();
            lblTotalCarsIcon = new Label();
            lblTotalCarsTitle = new Label();
            lblTotalCars = new Label();
            lblTotalCarsDescription = new Label();
            availableCarsCard = new Panel();
            lblAvailableCarsIcon = new Label();
            lblAvailableCarsTitle = new Label();
            lblAvailableCars = new Label();
            lblAvailableCarsDescription = new Label();
            rentedCarsCard = new Panel();
            lblRentedCarsIcon = new Label();
            lblRentedCarsTitle = new Label();
            lblRentedCars = new Label();
            lblRentedCarsDescription = new Label();
            earningsCard = new Panel();
            lblEarningsIcon = new Label();
            lblEarningsTitle = new Label();
            lblTotalEarnings = new Label();
            lblEarningsDescription = new Label();
            pendingCard = new Panel();
            lblPendingIcon = new Label();
            lblPendingTitle = new Label();
            lblPendingBookings = new Label();
            lblPendingDescription = new Label();
            vehicleStatusPanel = new Panel();
            lblVehicleStatusTitle = new Label();
            lblVehicleStatusSubtitle = new Label();
            vehicleChartPanel = new Panel();
            lblAvailableLegend = new Label();
            lblAvailableLegendValue = new Label();
            lblRentedLegend = new Label();
            lblRentedLegendValue = new Label();
            lblInactiveLegend = new Label();
            lblInactiveLegendValue = new Label();
            earningsOverviewPanel = new Panel();
            lblEarningsOverviewTitle = new Label();
            lblEarningsOverviewSubtitle = new Label();
            cmbEarningsPeriod = new ComboBox();
            earningsChartPanel = new Panel();
            quickActionsPanel = new Panel();
            lblQuickActionsTitle = new Label();
            btnAddNewCar = new Button();
            btnManageCars = new Button();
            btnViewBookings = new Button();
            btnViewEarnings = new Button();
            recentBookingsPanel = new Panel();
            lblRecentBookingsTitle = new Label();
            lblRecentBookingsSubtitle = new Label();
            btnViewAllBookings = new Button();
            dgvRecentBookings = new DataGridView();
            activityPanel = new Panel();
            lblActivityTitle = new Label();
            btnViewAllActivity = new Button();
            activityItem1 = new Panel();
            lblActivityIcon1 = new Label();
            lblActivityText1 = new Label();
            lblActivityTime1 = new Label();
            activityItem2 = new Panel();
            lblActivityIcon2 = new Label();
            lblActivityText2 = new Label();
            lblActivityTime2 = new Label();
            activityItem3 = new Panel();
            lblActivityIcon3 = new Label();
            lblActivityText3 = new Label();
            lblActivityTime3 = new Label();
            activityItem4 = new Panel();
            lblActivityIcon4 = new Label();
            lblActivityText4 = new Label();
            lblActivityTime4 = new Label();
            sidebarPanel.SuspendLayout();
            profilePanel.SuspendLayout();
            contentPanel.SuspendLayout();
            heroPanel.SuspendLayout();
            totalCarsCard.SuspendLayout();
            availableCarsCard.SuspendLayout();
            rentedCarsCard.SuspendLayout();
            earningsCard.SuspendLayout();
            pendingCard.SuspendLayout();
            vehicleStatusPanel.SuspendLayout();
            earningsOverviewPanel.SuspendLayout();
            quickActionsPanel.SuspendLayout();
            recentBookingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentBookings).BeginInit();
            activityPanel.SuspendLayout();
            activityItem1.SuspendLayout();
            activityItem2.SuspendLayout();
            activityItem3.SuspendLayout();
            activityItem4.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(19, 45, 76);
            sidebarPanel.Controls.Add(lblBrandIcon);
            sidebarPanel.Controls.Add(lblBrand);
            sidebarPanel.Controls.Add(lblBrandSubtitle);
            sidebarPanel.Controls.Add(profilePanel);
            sidebarPanel.Controls.Add(btnDashboard);
            sidebarPanel.Controls.Add(btnMyCars);
            sidebarPanel.Controls.Add(btnOwnerBookings);
            sidebarPanel.Controls.Add(btnEarnings);
            sidebarPanel.Controls.Add(btnOffers);
            sidebarPanel.Controls.Add(btnSettings);
            sidebarPanel.Controls.Add(btnLogout);
            sidebarPanel.Controls.Add(lblSidebarQuote);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(243, 987);
            sidebarPanel.TabIndex = 0;
            // 
            // lblBrandIcon
            // 
            lblBrandIcon.Font = new Font("Segoe UI Emoji", 34F);
            lblBrandIcon.ForeColor = Color.FromArgb(0, 140, 255);
            lblBrandIcon.Location = new Point(76, 18);
            lblBrandIcon.Name = "lblBrandIcon";
            lblBrandIcon.Size = new Size(91, 60);
            lblBrandIcon.TabIndex = 0;
            lblBrandIcon.Text = "🚗";
            lblBrandIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBrand
            // 
            lblBrand.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(20, 78);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(203, 35);
            lblBrand.TabIndex = 1;
            lblBrand.Text = "CAR RENTAL";
            lblBrand.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblBrandSubtitle
            // 
            lblBrandSubtitle.Font = new Font("Segoe UI", 10F);
            lblBrandSubtitle.ForeColor = Color.FromArgb(190, 210, 232);
            lblBrandSubtitle.Location = new Point(20, 112);
            lblBrandSubtitle.Name = "lblBrandSubtitle";
            lblBrandSubtitle.Size = new Size(203, 28);
            lblBrandSubtitle.TabIndex = 2;
            lblBrandSubtitle.Text = "Owner Panel";
            lblBrandSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // profilePanel
            // 
            profilePanel.BackColor = Color.Transparent;
            profilePanel.Controls.Add(lblProfileIcon);
            profilePanel.Controls.Add(lblOwnerName);
            profilePanel.Controls.Add(lblOwnerRole);
            profilePanel.Location = new Point(20, 145);
            profilePanel.Name = "profilePanel";
            profilePanel.Size = new Size(203, 105);
            profilePanel.TabIndex = 0;
            // 
            // lblProfileIcon
            // 
            lblProfileIcon.Font = new Font("Segoe UI Emoji", 34F);
            lblProfileIcon.ForeColor = Color.White;
            lblProfileIcon.Location = new Point(4, 13);
            lblProfileIcon.Name = "lblProfileIcon";
            lblProfileIcon.Size = new Size(65, 65);
            lblProfileIcon.TabIndex = 0;
            lblProfileIcon.Text = "👤";
            lblProfileIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOwnerName
            // 
            lblOwnerName.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblOwnerName.ForeColor = Color.White;
            lblOwnerName.Location = new Point(72, 21);
            lblOwnerName.Name = "lblOwnerName";
            lblOwnerName.Size = new Size(125, 28);
            lblOwnerName.TabIndex = 1;
            lblOwnerName.Text = "Owner Name";
            // 
            // lblOwnerRole
            // 
            lblOwnerRole.Font = new Font("Segoe UI", 9F);
            lblOwnerRole.ForeColor = Color.FromArgb(190, 210, 232);
            lblOwnerRole.Location = new Point(72, 50);
            lblOwnerRole.Name = "lblOwnerRole";
            lblOwnerRole.Size = new Size(125, 25);
            lblOwnerRole.TabIndex = 2;
            lblOwnerRole.Text = "Car Owner";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(21, 108, 190);
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 125, 205);
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 10F);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(10, 270);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(223, 50);
            btnDashboard.TabIndex = 3;
            btnDashboard.Text = "⌂    Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnMyCars
            // 
            btnMyCars.BackColor = Color.Transparent;
            btnMyCars.FlatAppearance.BorderSize = 0;
            btnMyCars.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 108, 175);
            btnMyCars.FlatStyle = FlatStyle.Flat;
            btnMyCars.Font = new Font("Segoe UI", 10F);
            btnMyCars.ForeColor = Color.White;
            btnMyCars.Location = new Point(10, 330);
            btnMyCars.Name = "btnMyCars";
            btnMyCars.Size = new Size(223, 50);
            btnMyCars.TabIndex = 4;
            btnMyCars.Text = "🚗   Manage My Cars";
            btnMyCars.TextAlign = ContentAlignment.MiddleLeft;
            btnMyCars.UseVisualStyleBackColor = false;
            btnMyCars.Click += btnMyCars_Click;
            // 
            // btnOwnerBookings
            // 
            btnOwnerBookings.BackColor = Color.Transparent;
            btnOwnerBookings.FlatAppearance.BorderSize = 0;
            btnOwnerBookings.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 108, 175);
            btnOwnerBookings.FlatStyle = FlatStyle.Flat;
            btnOwnerBookings.Font = new Font("Segoe UI", 10F);
            btnOwnerBookings.ForeColor = Color.White;
            btnOwnerBookings.Location = new Point(10, 390);
            btnOwnerBookings.Name = "btnOwnerBookings";
            btnOwnerBookings.Size = new Size(223, 50);
            btnOwnerBookings.TabIndex = 5;
            btnOwnerBookings.Text = "▣    View Bookings";
            btnOwnerBookings.TextAlign = ContentAlignment.MiddleLeft;
            btnOwnerBookings.UseVisualStyleBackColor = false;
            btnOwnerBookings.Click += btnOwnerBookings_Click;
            // 
            // btnEarnings
            // 
            btnEarnings.BackColor = Color.Transparent;
            btnEarnings.FlatAppearance.BorderSize = 0;
            btnEarnings.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 108, 175);
            btnEarnings.FlatStyle = FlatStyle.Flat;
            btnEarnings.Font = new Font("Segoe UI", 10F);
            btnEarnings.ForeColor = Color.White;
            btnEarnings.Location = new Point(10, 450);
            btnEarnings.Name = "btnEarnings";
            btnEarnings.Size = new Size(223, 50);
            btnEarnings.TabIndex = 6;
            btnEarnings.Text = "▥    Earnings";
            btnEarnings.TextAlign = ContentAlignment.MiddleLeft;
            btnEarnings.UseVisualStyleBackColor = false;
            btnEarnings.Click += btnEarnings_Click;
            // 
            // btnOffers
            // 
            btnOffers.BackColor = Color.Transparent;
            btnOffers.FlatAppearance.BorderSize = 0;
            btnOffers.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 108, 175);
            btnOffers.FlatStyle = FlatStyle.Flat;
            btnOffers.Font = new Font("Segoe UI", 10F);
            btnOffers.ForeColor = Color.White;
            btnOffers.Location = new Point(10, 510);
            btnOffers.Name = "btnOffers";
            btnOffers.Size = new Size(223, 50);
            btnOffers.TabIndex = 7;
            btnOffers.Text = "◆    My Offers";
            btnOffers.TextAlign = ContentAlignment.MiddleLeft;
            btnOffers.UseVisualStyleBackColor = false;
            btnOffers.Click += btnOffers_Click;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.Transparent;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 108, 175);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI", 10F);
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(10, 600);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(223, 50);
            btnSettings.TabIndex = 8;
            btnSettings.Text = "⚙    Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Transparent;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatAppearance.MouseOverBackColor = Color.FromArgb(175, 45, 55);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(10, 660);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(223, 50);
            btnLogout.TabIndex = 9;
            btnLogout.Text = "◉    Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // lblSidebarQuote
            // 
            lblSidebarQuote.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            lblSidebarQuote.ForeColor = Color.FromArgb(110, 165, 210);
            lblSidebarQuote.Location = new Point(25, 875);
            lblSidebarQuote.Name = "lblSidebarQuote";
            lblSidebarQuote.Size = new Size(193, 55);
            lblSidebarQuote.TabIndex = 10;
            lblSidebarQuote.Text = "Drive Together\r\nfor a Better Tomorrow";
            lblSidebarQuote.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            contentPanel.BackColor = Color.FromArgb(244, 248, 252);
            contentPanel.Controls.Add(heroPanel);
            contentPanel.Controls.Add(totalCarsCard);
            contentPanel.Controls.Add(availableCarsCard);
            contentPanel.Controls.Add(rentedCarsCard);
            contentPanel.Controls.Add(earningsCard);
            contentPanel.Controls.Add(pendingCard);
            contentPanel.Controls.Add(vehicleStatusPanel);
            contentPanel.Controls.Add(earningsOverviewPanel);
            contentPanel.Controls.Add(quickActionsPanel);
            contentPanel.Controls.Add(recentBookingsPanel);
            contentPanel.Controls.Add(activityPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(243, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1293, 987);
            contentPanel.TabIndex = 1;
            // 
            // heroPanel
            // 
            heroPanel.BackColor = Color.FromArgb(239, 247, 255);
            heroPanel.Controls.Add(lblPageTitle);
            heroPanel.Controls.Add(lblWelcome);
            heroPanel.Controls.Add(lblSubtitle);
            heroPanel.Controls.Add(lblHeroCarIcon);
            heroPanel.Location = new Point(0, 0);
            heroPanel.Name = "heroPanel";
            heroPanel.Size = new Size(1293, 170);
            heroPanel.TabIndex = 0;
            // 
            // lblPageTitle
            // 
            lblPageTitle.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(11, 30, 70);
            lblPageTitle.Location = new Point(30, 35);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(850, 55);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Welcome back, Owner! 👋";
            // 
            // lblWelcome
            // 
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(100, 23);
            lblWelcome.TabIndex = 1;
            lblWelcome.Visible = false;
            // 
            // lblSubtitle
            // 
            lblSubtitle.Font = new Font("Segoe UI", 11F);
            lblSubtitle.ForeColor = Color.FromArgb(47, 73, 115);
            lblSubtitle.Location = new Point(31, 91);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(700, 30);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Manage your cars, track bookings and grow your business.";
            // 
            // lblHeroCarIcon
            // 
            lblHeroCarIcon.Font = new Font("Segoe UI Emoji", 66F);
            lblHeroCarIcon.ForeColor = Color.FromArgb(20, 80, 130);
            lblHeroCarIcon.Location = new Point(1010, 27);
            lblHeroCarIcon.Name = "lblHeroCarIcon";
            lblHeroCarIcon.Size = new Size(230, 110);
            lblHeroCarIcon.TabIndex = 3;
            lblHeroCarIcon.Text = "🚗";
            lblHeroCarIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // totalCarsCard
            // 
            totalCarsCard.BackColor = Color.FromArgb(225, 241, 255);
            totalCarsCard.Controls.Add(lblTotalCarsIcon);
            totalCarsCard.Controls.Add(lblTotalCarsTitle);
            totalCarsCard.Controls.Add(lblTotalCars);
            totalCarsCard.Controls.Add(lblTotalCarsDescription);
            totalCarsCard.Location = new Point(25, 185);
            totalCarsCard.Name = "totalCarsCard";
            totalCarsCard.Size = new Size(220, 145);
            totalCarsCard.TabIndex = 1;
            // 
            // lblTotalCarsIcon
            // 
            lblTotalCarsIcon.Font = new Font("Segoe UI Emoji", 23F);
            lblTotalCarsIcon.ForeColor = Color.FromArgb(0, 115, 230);
            lblTotalCarsIcon.Location = new Point(13, 6);
            lblTotalCarsIcon.Name = "lblTotalCarsIcon";
            lblTotalCarsIcon.Size = new Size(55, 48);
            lblTotalCarsIcon.TabIndex = 0;
            lblTotalCarsIcon.Text = "🚗";
            lblTotalCarsIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalCarsTitle
            // 
            lblTotalCarsTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalCarsTitle.ForeColor = Color.FromArgb(0, 115, 230);
            lblTotalCarsTitle.Location = new Point(78, 20);
            lblTotalCarsTitle.Name = "lblTotalCarsTitle";
            lblTotalCarsTitle.Size = new Size(130, 25);
            lblTotalCarsTitle.TabIndex = 1;
            lblTotalCarsTitle.Text = "Total Cars";
            // 
            // lblTotalCars
            // 
            lblTotalCars.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblTotalCars.ForeColor = Color.FromArgb(11, 30, 70);
            lblTotalCars.Location = new Point(78, 48);
            lblTotalCars.Name = "lblTotalCars";
            lblTotalCars.Size = new Size(125, 50);
            lblTotalCars.TabIndex = 2;
            lblTotalCars.Text = "0";
            // 
            // lblTotalCarsDescription
            // 
            lblTotalCarsDescription.Font = new Font("Segoe UI", 8.5F);
            lblTotalCarsDescription.ForeColor = Color.FromArgb(42, 70, 110);
            lblTotalCarsDescription.Location = new Point(16, 111);
            lblTotalCarsDescription.Name = "lblTotalCarsDescription";
            lblTotalCarsDescription.Size = new Size(190, 25);
            lblTotalCarsDescription.TabIndex = 3;
            lblTotalCarsDescription.Text = "All registered vehicles";
            // 
            // availableCarsCard
            // 
            availableCarsCard.BackColor = Color.FromArgb(225, 250, 240);
            availableCarsCard.Controls.Add(lblAvailableCarsIcon);
            availableCarsCard.Controls.Add(lblAvailableCarsTitle);
            availableCarsCard.Controls.Add(lblAvailableCars);
            availableCarsCard.Controls.Add(lblAvailableCarsDescription);
            availableCarsCard.Location = new Point(267, 185);
            availableCarsCard.Name = "availableCarsCard";
            availableCarsCard.Size = new Size(220, 145);
            availableCarsCard.TabIndex = 2;
            // 
            // lblAvailableCarsIcon
            // 
            lblAvailableCarsIcon.Font = new Font("Segoe UI", 27F, FontStyle.Bold);
            lblAvailableCarsIcon.ForeColor = Color.FromArgb(0, 150, 75);
            lblAvailableCarsIcon.Location = new Point(4, 2);
            lblAvailableCarsIcon.Name = "lblAvailableCarsIcon";
            lblAvailableCarsIcon.Size = new Size(41, 50);
            lblAvailableCarsIcon.TabIndex = 0;
            lblAvailableCarsIcon.Text = "✓";
            lblAvailableCarsIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAvailableCarsTitle
            // 
            lblAvailableCarsTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAvailableCarsTitle.ForeColor = Color.FromArgb(0, 150, 75);
            lblAvailableCarsTitle.Location = new Point(78, 20);
            lblAvailableCarsTitle.Name = "lblAvailableCarsTitle";
            lblAvailableCarsTitle.Size = new Size(130, 25);
            lblAvailableCarsTitle.TabIndex = 1;
            lblAvailableCarsTitle.Text = "Available Cars";
            // 
            // lblAvailableCars
            // 
            lblAvailableCars.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblAvailableCars.ForeColor = Color.FromArgb(11, 30, 70);
            lblAvailableCars.Location = new Point(43, 45);
            lblAvailableCars.Name = "lblAvailableCars";
            lblAvailableCars.Size = new Size(125, 50);
            lblAvailableCars.TabIndex = 2;
            lblAvailableCars.Text = "0";
            // 
            // lblAvailableCarsDescription
            // 
            lblAvailableCarsDescription.Font = new Font("Segoe UI", 8.5F);
            lblAvailableCarsDescription.ForeColor = Color.FromArgb(42, 70, 110);
            lblAvailableCarsDescription.Location = new Point(16, 111);
            lblAvailableCarsDescription.Name = "lblAvailableCarsDescription";
            lblAvailableCarsDescription.Size = new Size(190, 25);
            lblAvailableCarsDescription.TabIndex = 3;
            lblAvailableCarsDescription.Text = "Ready for rent";
            // 
            // rentedCarsCard
            // 
            rentedCarsCard.BackColor = Color.FromArgb(255, 243, 224);
            rentedCarsCard.Controls.Add(lblRentedCarsIcon);
            rentedCarsCard.Controls.Add(lblRentedCarsTitle);
            rentedCarsCard.Controls.Add(lblRentedCars);
            rentedCarsCard.Controls.Add(lblRentedCarsDescription);
            rentedCarsCard.Location = new Point(509, 185);
            rentedCarsCard.Name = "rentedCarsCard";
            rentedCarsCard.Size = new Size(220, 145);
            rentedCarsCard.TabIndex = 3;
            // 
            // lblRentedCarsIcon
            // 
            lblRentedCarsIcon.Font = new Font("Segoe UI", 27F);
            lblRentedCarsIcon.ForeColor = Color.FromArgb(245, 105, 0);
            lblRentedCarsIcon.Location = new Point(3, 0);
            lblRentedCarsIcon.Name = "lblRentedCarsIcon";
            lblRentedCarsIcon.Size = new Size(55, 55);
            lblRentedCarsIcon.TabIndex = 0;
            lblRentedCarsIcon.Text = "◷";
            lblRentedCarsIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRentedCarsTitle
            // 
            lblRentedCarsTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRentedCarsTitle.ForeColor = Color.FromArgb(245, 105, 0);
            lblRentedCarsTitle.Location = new Point(78, 20);
            lblRentedCarsTitle.Name = "lblRentedCarsTitle";
            lblRentedCarsTitle.Size = new Size(130, 25);
            lblRentedCarsTitle.TabIndex = 1;
            lblRentedCarsTitle.Text = "Currently Rented";
            // 
            // lblRentedCars
            // 
            lblRentedCars.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblRentedCars.ForeColor = Color.FromArgb(11, 30, 70);
            lblRentedCars.Location = new Point(32, 48);
            lblRentedCars.Name = "lblRentedCars";
            lblRentedCars.Size = new Size(125, 50);
            lblRentedCars.TabIndex = 2;
            lblRentedCars.Text = "0";
            // 
            // lblRentedCarsDescription
            // 
            lblRentedCarsDescription.Font = new Font("Segoe UI", 8.5F);
            lblRentedCarsDescription.ForeColor = Color.FromArgb(42, 70, 110);
            lblRentedCarsDescription.Location = new Point(16, 111);
            lblRentedCarsDescription.Name = "lblRentedCarsDescription";
            lblRentedCarsDescription.Size = new Size(190, 25);
            lblRentedCarsDescription.TabIndex = 3;
            lblRentedCarsDescription.Text = "In active bookings";
            // 
            // earningsCard
            // 
            earningsCard.BackColor = Color.FromArgb(239, 232, 255);
            earningsCard.Controls.Add(lblEarningsIcon);
            earningsCard.Controls.Add(lblEarningsTitle);
            earningsCard.Controls.Add(lblTotalEarnings);
            earningsCard.Controls.Add(lblEarningsDescription);
            earningsCard.Location = new Point(751, 185);
            earningsCard.Name = "earningsCard";
            earningsCard.Size = new Size(220, 145);
            earningsCard.TabIndex = 4;
            // 
            // lblEarningsIcon
            // 
            lblEarningsIcon.Font = new Font("Segoe UI", 27F, FontStyle.Bold);
            lblEarningsIcon.ForeColor = Color.FromArgb(105, 55, 220);
            lblEarningsIcon.Location = new Point(3, 0);
            lblEarningsIcon.Name = "lblEarningsIcon";
            lblEarningsIcon.Size = new Size(38, 60);
            lblEarningsIcon.TabIndex = 0;
            lblEarningsIcon.Text = "৳";
            lblEarningsIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEarningsTitle
            // 
            lblEarningsTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblEarningsTitle.ForeColor = Color.FromArgb(105, 55, 220);
            lblEarningsTitle.Location = new Point(47, 14);
            lblEarningsTitle.Name = "lblEarningsTitle";
            lblEarningsTitle.Size = new Size(130, 25);
            lblEarningsTitle.TabIndex = 1;
            lblEarningsTitle.Text = "Total Earnings";
            // 
            // lblTotalEarnings
            // 
            lblTotalEarnings.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTotalEarnings.ForeColor = Color.FromArgb(11, 30, 70);
            lblTotalEarnings.Location = new Point(16, 50);
            lblTotalEarnings.Name = "lblTotalEarnings";
            lblTotalEarnings.Size = new Size(192, 48);
            lblTotalEarnings.TabIndex = 2;
            lblTotalEarnings.Text = "৳0";
            // 
            // lblEarningsDescription
            // 
            lblEarningsDescription.Font = new Font("Segoe UI", 8.5F);
            lblEarningsDescription.ForeColor = Color.FromArgb(42, 70, 110);
            lblEarningsDescription.Location = new Point(16, 111);
            lblEarningsDescription.Name = "lblEarningsDescription";
            lblEarningsDescription.Size = new Size(190, 25);
            lblEarningsDescription.TabIndex = 3;
            lblEarningsDescription.Text = "From completed bookings";
            // 
            // pendingCard
            // 
            pendingCard.BackColor = Color.FromArgb(255, 231, 236);
            pendingCard.Controls.Add(lblPendingIcon);
            pendingCard.Controls.Add(lblPendingTitle);
            pendingCard.Controls.Add(lblPendingBookings);
            pendingCard.Controls.Add(lblPendingDescription);
            pendingCard.Location = new Point(993, 185);
            pendingCard.Name = "pendingCard";
            pendingCard.Size = new Size(220, 145);
            pendingCard.TabIndex = 5;
            // 
            // lblPendingIcon
            // 
            lblPendingIcon.Font = new Font("Segoe UI", 24F);
            lblPendingIcon.ForeColor = Color.FromArgb(220, 45, 85);
            lblPendingIcon.Location = new Point(16, 14);
            lblPendingIcon.Name = "lblPendingIcon";
            lblPendingIcon.Size = new Size(55, 50);
            lblPendingIcon.TabIndex = 0;
            lblPendingIcon.Text = "▤";
            lblPendingIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPendingTitle
            // 
            lblPendingTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPendingTitle.ForeColor = Color.FromArgb(220, 45, 85);
            lblPendingTitle.Location = new Point(78, 20);
            lblPendingTitle.Name = "lblPendingTitle";
            lblPendingTitle.Size = new Size(130, 25);
            lblPendingTitle.TabIndex = 1;
            lblPendingTitle.Text = "Pending Amount";
            // 
            // lblPendingBookings
            // 
            lblPendingBookings.Font = new Font("Segoe UI", 23F, FontStyle.Bold);
            lblPendingBookings.ForeColor = Color.FromArgb(11, 30, 70);
            lblPendingBookings.Location = new Point(78, 48);
            lblPendingBookings.Name = "lblPendingBookings";
            lblPendingBookings.Size = new Size(125, 50);
            lblPendingBookings.TabIndex = 2;
            lblPendingBookings.Text = "0";
            // 
            // lblPendingDescription
            // 
            lblPendingDescription.Font = new Font("Segoe UI", 8.5F);
            lblPendingDescription.ForeColor = Color.FromArgb(42, 70, 110);
            lblPendingDescription.Location = new Point(16, 111);
            lblPendingDescription.Name = "lblPendingDescription";
            lblPendingDescription.Size = new Size(190, 25);
            lblPendingDescription.TabIndex = 3;
            lblPendingDescription.Text = "Awaiting payment";
            // 
            // vehicleStatusPanel
            // 
            vehicleStatusPanel.BackColor = Color.White;
            vehicleStatusPanel.BorderStyle = BorderStyle.FixedSingle;
            vehicleStatusPanel.Controls.Add(lblVehicleStatusTitle);
            vehicleStatusPanel.Controls.Add(lblVehicleStatusSubtitle);
            vehicleStatusPanel.Controls.Add(vehicleChartPanel);
            vehicleStatusPanel.Controls.Add(lblAvailableLegend);
            vehicleStatusPanel.Controls.Add(lblAvailableLegendValue);
            vehicleStatusPanel.Controls.Add(lblRentedLegend);
            vehicleStatusPanel.Controls.Add(lblRentedLegendValue);
            vehicleStatusPanel.Controls.Add(lblInactiveLegend);
            vehicleStatusPanel.Controls.Add(lblInactiveLegendValue);
            vehicleStatusPanel.Location = new Point(25, 350);
            vehicleStatusPanel.Name = "vehicleStatusPanel";
            vehicleStatusPanel.Size = new Size(445, 285);
            vehicleStatusPanel.TabIndex = 6;
            // 
            // lblVehicleStatusTitle
            // 
            lblVehicleStatusTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblVehicleStatusTitle.ForeColor = Color.FromArgb(11, 30, 70);
            lblVehicleStatusTitle.Location = new Point(18, 14);
            lblVehicleStatusTitle.Name = "lblVehicleStatusTitle";
            lblVehicleStatusTitle.Size = new Size(390, 32);
            lblVehicleStatusTitle.TabIndex = 0;
            lblVehicleStatusTitle.Text = "Vehicle Status Overview";
            // 
            // lblVehicleStatusSubtitle
            // 
            lblVehicleStatusSubtitle.Font = new Font("Segoe UI", 9F);
            lblVehicleStatusSubtitle.ForeColor = Color.FromArgb(86, 112, 150);
            lblVehicleStatusSubtitle.Location = new Point(19, 45);
            lblVehicleStatusSubtitle.Name = "lblVehicleStatusSubtitle";
            lblVehicleStatusSubtitle.Size = new Size(390, 25);
            lblVehicleStatusSubtitle.TabIndex = 1;
            lblVehicleStatusSubtitle.Text = "A quick look at your fleet status";
            // 
            // vehicleChartPanel
            // 
            vehicleChartPanel.Location = new Point(12, 75);
            vehicleChartPanel.Name = "vehicleChartPanel";
            vehicleChartPanel.Size = new Size(220, 190);
            vehicleChartPanel.TabIndex = 0;
            vehicleChartPanel.Paint += vehicleChartPanel_Paint;
            // 
            // lblAvailableLegend
            // 
            lblAvailableLegend.Font = new Font("Segoe UI", 9F);
            lblAvailableLegend.ForeColor = Color.FromArgb(25, 50, 100);
            lblAvailableLegend.Location = new Point(245, 104);
            lblAvailableLegend.Name = "lblAvailableLegend";
            lblAvailableLegend.Size = new Size(100, 25);
            lblAvailableLegend.TabIndex = 2;
            lblAvailableLegend.Text = "●  Available";
            // 
            // lblAvailableLegendValue
            // 
            lblAvailableLegendValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAvailableLegendValue.ForeColor = Color.FromArgb(11, 30, 70);
            lblAvailableLegendValue.Location = new Point(345, 104);
            lblAvailableLegendValue.Name = "lblAvailableLegendValue";
            lblAvailableLegendValue.Size = new Size(85, 25);
            lblAvailableLegendValue.TabIndex = 3;
            lblAvailableLegendValue.Text = "0 (0%)";
            // 
            // lblRentedLegend
            // 
            lblRentedLegend.Font = new Font("Segoe UI", 9F);
            lblRentedLegend.ForeColor = Color.FromArgb(25, 50, 100);
            lblRentedLegend.Location = new Point(245, 145);
            lblRentedLegend.Name = "lblRentedLegend";
            lblRentedLegend.Size = new Size(100, 25);
            lblRentedLegend.TabIndex = 4;
            lblRentedLegend.Text = "●  Rented";
            // 
            // lblRentedLegendValue
            // 
            lblRentedLegendValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRentedLegendValue.ForeColor = Color.FromArgb(11, 30, 70);
            lblRentedLegendValue.Location = new Point(345, 145);
            lblRentedLegendValue.Name = "lblRentedLegendValue";
            lblRentedLegendValue.Size = new Size(85, 25);
            lblRentedLegendValue.TabIndex = 5;
            lblRentedLegendValue.Text = "0 (0%)";
            // 
            // lblInactiveLegend
            // 
            lblInactiveLegend.Font = new Font("Segoe UI", 9F);
            lblInactiveLegend.ForeColor = Color.FromArgb(25, 50, 100);
            lblInactiveLegend.Location = new Point(245, 186);
            lblInactiveLegend.Name = "lblInactiveLegend";
            lblInactiveLegend.Size = new Size(100, 25);
            lblInactiveLegend.TabIndex = 6;
            lblInactiveLegend.Text = "●  Inactive";
            // 
            // lblInactiveLegendValue
            // 
            lblInactiveLegendValue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblInactiveLegendValue.ForeColor = Color.FromArgb(11, 30, 70);
            lblInactiveLegendValue.Location = new Point(345, 186);
            lblInactiveLegendValue.Name = "lblInactiveLegendValue";
            lblInactiveLegendValue.Size = new Size(85, 25);
            lblInactiveLegendValue.TabIndex = 7;
            lblInactiveLegendValue.Text = "0 (0%)";
            // 
            // earningsOverviewPanel
            // 
            earningsOverviewPanel.BackColor = Color.White;
            earningsOverviewPanel.BorderStyle = BorderStyle.FixedSingle;
            earningsOverviewPanel.Controls.Add(lblEarningsOverviewTitle);
            earningsOverviewPanel.Controls.Add(lblEarningsOverviewSubtitle);
            earningsOverviewPanel.Controls.Add(cmbEarningsPeriod);
            earningsOverviewPanel.Controls.Add(earningsChartPanel);
            earningsOverviewPanel.Location = new Point(485, 350);
            earningsOverviewPanel.Name = "earningsOverviewPanel";
            earningsOverviewPanel.Size = new Size(410, 285);
            earningsOverviewPanel.TabIndex = 7;
            // 
            // lblEarningsOverviewTitle
            // 
            lblEarningsOverviewTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblEarningsOverviewTitle.ForeColor = Color.FromArgb(11, 30, 70);
            lblEarningsOverviewTitle.Location = new Point(18, 14);
            lblEarningsOverviewTitle.Name = "lblEarningsOverviewTitle";
            lblEarningsOverviewTitle.Size = new Size(230, 32);
            lblEarningsOverviewTitle.TabIndex = 0;
            lblEarningsOverviewTitle.Text = "Earnings Overview";
            // 
            // lblEarningsOverviewSubtitle
            // 
            lblEarningsOverviewSubtitle.Font = new Font("Segoe UI", 9F);
            lblEarningsOverviewSubtitle.ForeColor = Color.FromArgb(86, 112, 150);
            lblEarningsOverviewSubtitle.Location = new Point(19, 45);
            lblEarningsOverviewSubtitle.Name = "lblEarningsOverviewSubtitle";
            lblEarningsOverviewSubtitle.Size = new Size(300, 25);
            lblEarningsOverviewSubtitle.TabIndex = 1;
            lblEarningsOverviewSubtitle.Text = "Your earnings from completed bookings";
            // 
            // cmbEarningsPeriod
            // 
            cmbEarningsPeriod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEarningsPeriod.Font = new Font("Segoe UI", 9F);
            cmbEarningsPeriod.FormattingEnabled = true;
            cmbEarningsPeriod.Items.AddRange(new object[] { "This Month", "Last Month", "This Year" });
            cmbEarningsPeriod.Location = new Point(260, 14);
            cmbEarningsPeriod.Name = "cmbEarningsPeriod";
            cmbEarningsPeriod.Size = new Size(125, 28);
            cmbEarningsPeriod.TabIndex = 0;
            cmbEarningsPeriod.SelectedIndexChanged += cmbEarningsPeriod_SelectedIndexChanged;
            // 
            // earningsChartPanel
            // 
            earningsChartPanel.BackColor = Color.White;
            earningsChartPanel.Location = new Point(18, 78);
            earningsChartPanel.Name = "earningsChartPanel";
            earningsChartPanel.Size = new Size(375, 190);
            earningsChartPanel.TabIndex = 1;
            earningsChartPanel.Paint += earningsChartPanel_Paint;
            // 
            // quickActionsPanel
            // 
            quickActionsPanel.BackColor = Color.White;
            quickActionsPanel.BorderStyle = BorderStyle.FixedSingle;
            quickActionsPanel.Controls.Add(lblQuickActionsTitle);
            quickActionsPanel.Controls.Add(btnAddNewCar);
            quickActionsPanel.Controls.Add(btnManageCars);
            quickActionsPanel.Controls.Add(btnViewBookings);
            quickActionsPanel.Controls.Add(btnViewEarnings);
            quickActionsPanel.Location = new Point(910, 350);
            quickActionsPanel.Name = "quickActionsPanel";
            quickActionsPanel.Size = new Size(358, 285);
            quickActionsPanel.TabIndex = 8;
            // 
            // lblQuickActionsTitle
            // 
            lblQuickActionsTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblQuickActionsTitle.ForeColor = Color.FromArgb(11, 30, 70);
            lblQuickActionsTitle.Location = new Point(18, 14);
            lblQuickActionsTitle.Name = "lblQuickActionsTitle";
            lblQuickActionsTitle.Size = new Size(300, 32);
            lblQuickActionsTitle.TabIndex = 0;
            lblQuickActionsTitle.Text = "Quick Actions";
            // 
            // btnAddNewCar
            // 
            btnAddNewCar.BackColor = Color.FromArgb(30, 140, 245);
            btnAddNewCar.FlatAppearance.BorderSize = 0;
            btnAddNewCar.FlatStyle = FlatStyle.Flat;
            btnAddNewCar.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAddNewCar.ForeColor = Color.White;
            btnAddNewCar.Location = new Point(14, 53);
            btnAddNewCar.Name = "btnAddNewCar";
            btnAddNewCar.Size = new Size(158, 95);
            btnAddNewCar.TabIndex = 1;
            btnAddNewCar.Text = "⊕\r\nAdd New Car\r\nList a new vehicle";
            btnAddNewCar.UseVisualStyleBackColor = false;
            btnAddNewCar.Click += btnAddNewCar_Click;
            // 
            // btnManageCars
            // 
            btnManageCars.BackColor = Color.FromArgb(10, 180, 105);
            btnManageCars.FlatAppearance.BorderSize = 0;
            btnManageCars.FlatStyle = FlatStyle.Flat;
            btnManageCars.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnManageCars.ForeColor = Color.White;
            btnManageCars.Location = new Point(184, 53);
            btnManageCars.Name = "btnManageCars";
            btnManageCars.Size = new Size(158, 95);
            btnManageCars.TabIndex = 2;
            btnManageCars.Text = "🚗\r\nManage My Cars\r\nView & edit vehicles";
            btnManageCars.UseVisualStyleBackColor = false;
            btnManageCars.Click += btnMyCars_Click;
            // 
            // btnViewBookings
            // 
            btnViewBookings.BackColor = Color.FromArgb(120, 65, 235);
            btnViewBookings.FlatAppearance.BorderSize = 0;
            btnViewBookings.FlatStyle = FlatStyle.Flat;
            btnViewBookings.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnViewBookings.ForeColor = Color.White;
            btnViewBookings.Location = new Point(14, 160);
            btnViewBookings.Name = "btnViewBookings";
            btnViewBookings.Size = new Size(158, 95);
            btnViewBookings.TabIndex = 3;
            btnViewBookings.Text = "▣\r\nView Bookings\r\nCheck rental bookings";
            btnViewBookings.UseVisualStyleBackColor = false;
            btnViewBookings.Click += btnOwnerBookings_Click;
            // 
            // btnViewEarnings
            // 
            btnViewEarnings.BackColor = Color.FromArgb(255, 110, 35);
            btnViewEarnings.FlatAppearance.BorderSize = 0;
            btnViewEarnings.FlatStyle = FlatStyle.Flat;
            btnViewEarnings.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnViewEarnings.ForeColor = Color.White;
            btnViewEarnings.Location = new Point(184, 160);
            btnViewEarnings.Name = "btnViewEarnings";
            btnViewEarnings.Size = new Size(158, 95);
            btnViewEarnings.TabIndex = 4;
            btnViewEarnings.Text = "▥\r\nView Earnings\r\nSee detailed report";
            btnViewEarnings.UseVisualStyleBackColor = false;
            btnViewEarnings.Click += btnEarnings_Click;
            // 
            // recentBookingsPanel
            // 
            recentBookingsPanel.BackColor = Color.White;
            recentBookingsPanel.BorderStyle = BorderStyle.FixedSingle;
            recentBookingsPanel.Controls.Add(lblRecentBookingsTitle);
            recentBookingsPanel.Controls.Add(lblRecentBookingsSubtitle);
            recentBookingsPanel.Controls.Add(btnViewAllBookings);
            recentBookingsPanel.Controls.Add(dgvRecentBookings);
            recentBookingsPanel.Location = new Point(25, 655);
            recentBookingsPanel.Name = "recentBookingsPanel";
            recentBookingsPanel.Size = new Size(870, 310);
            recentBookingsPanel.TabIndex = 9;
            // 
            // lblRecentBookingsTitle
            // 
            lblRecentBookingsTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblRecentBookingsTitle.ForeColor = Color.FromArgb(11, 30, 70);
            lblRecentBookingsTitle.Location = new Point(18, 14);
            lblRecentBookingsTitle.Name = "lblRecentBookingsTitle";
            lblRecentBookingsTitle.Size = new Size(250, 32);
            lblRecentBookingsTitle.TabIndex = 0;
            lblRecentBookingsTitle.Text = "Recent Bookings";
            // 
            // lblRecentBookingsSubtitle
            // 
            lblRecentBookingsSubtitle.Font = new Font("Segoe UI", 9F);
            lblRecentBookingsSubtitle.ForeColor = Color.FromArgb(86, 112, 150);
            lblRecentBookingsSubtitle.Location = new Point(19, 45);
            lblRecentBookingsSubtitle.Name = "lblRecentBookingsSubtitle";
            lblRecentBookingsSubtitle.Size = new Size(400, 25);
            lblRecentBookingsSubtitle.TabIndex = 1;
            lblRecentBookingsSubtitle.Text = "Latest rental bookings for your vehicles";
            // 
            // btnViewAllBookings
            // 
            btnViewAllBookings.BackColor = Color.Transparent;
            btnViewAllBookings.FlatAppearance.BorderSize = 0;
            btnViewAllBookings.FlatStyle = FlatStyle.Flat;
            btnViewAllBookings.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnViewAllBookings.ForeColor = Color.FromArgb(0, 115, 230);
            btnViewAllBookings.Location = new Point(695, 15);
            btnViewAllBookings.Name = "btnViewAllBookings";
            btnViewAllBookings.Size = new Size(155, 35);
            btnViewAllBookings.TabIndex = 2;
            btnViewAllBookings.Text = "View All Bookings →";
            btnViewAllBookings.UseVisualStyleBackColor = false;
            btnViewAllBookings.Click += btnOwnerBookings_Click;
            // 
            // dgvRecentBookings
            // 
            dgvRecentBookings.AllowUserToAddRows = false;
            dgvRecentBookings.AllowUserToDeleteRows = false;
            dgvRecentBookings.AllowUserToResizeRows = false;
            dgvRecentBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecentBookings.BackgroundColor = Color.White;
            dgvRecentBookings.BorderStyle = BorderStyle.None;
            dgvRecentBookings.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRecentBookings.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvRecentBookings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvRecentBookings.ColumnHeadersHeight = 40;
            dgvRecentBookings.EnableHeadersVisualStyles = false;
            dgvRecentBookings.GridColor = Color.FromArgb(224, 232, 240);
            dgvRecentBookings.Location = new Point(18, 75);
            dgvRecentBookings.MultiSelect = false;
            dgvRecentBookings.Name = "dgvRecentBookings";
            dgvRecentBookings.ReadOnly = true;
            dgvRecentBookings.RowHeadersVisible = false;
            dgvRecentBookings.RowHeadersWidth = 51;
            dgvRecentBookings.RowTemplate.Height = 38;
            dgvRecentBookings.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecentBookings.Size = new Size(834, 215);
            dgvRecentBookings.TabIndex = 2;
            dgvRecentBookings.CellContentClick += dgvRecentBookings_CellContentClick;
            // 
            // activityPanel
            // 
            activityPanel.BackColor = Color.White;
            activityPanel.BorderStyle = BorderStyle.FixedSingle;
            activityPanel.Controls.Add(lblActivityTitle);
            activityPanel.Controls.Add(btnViewAllActivity);
            activityPanel.Controls.Add(activityItem1);
            activityPanel.Controls.Add(activityItem2);
            activityPanel.Controls.Add(activityItem3);
            activityPanel.Controls.Add(activityItem4);
            activityPanel.Location = new Point(910, 655);
            activityPanel.Name = "activityPanel";
            activityPanel.Size = new Size(358, 310);
            activityPanel.TabIndex = 10;
            // 
            // lblActivityTitle
            // 
            lblActivityTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblActivityTitle.ForeColor = Color.FromArgb(11, 30, 70);
            lblActivityTitle.Location = new Point(18, 14);
            lblActivityTitle.Name = "lblActivityTitle";
            lblActivityTitle.Size = new Size(220, 32);
            lblActivityTitle.TabIndex = 0;
            lblActivityTitle.Text = "Recent Activity";
            // 
            // btnViewAllActivity
            // 
            btnViewAllActivity.BackColor = Color.Transparent;
            btnViewAllActivity.FlatAppearance.BorderSize = 0;
            btnViewAllActivity.FlatStyle = FlatStyle.Flat;
            btnViewAllActivity.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnViewAllActivity.ForeColor = Color.FromArgb(0, 115, 230);
            btnViewAllActivity.Location = new Point(275, 15);
            btnViewAllActivity.Name = "btnViewAllActivity";
            btnViewAllActivity.Size = new Size(65, 30);
            btnViewAllActivity.TabIndex = 1;
            btnViewAllActivity.Text = "View All";
            btnViewAllActivity.UseVisualStyleBackColor = false;
            // 
            // activityItem1
            // 
            activityItem1.BackColor = Color.White;
            activityItem1.Controls.Add(lblActivityIcon1);
            activityItem1.Controls.Add(lblActivityText1);
            activityItem1.Controls.Add(lblActivityTime1);
            activityItem1.Location = new Point(10, 55);
            activityItem1.Name = "activityItem1";
            activityItem1.Size = new Size(330, 52);
            activityItem1.TabIndex = 2;
            // 
            // lblActivityIcon1
            // 
            lblActivityIcon1.Font = new Font("Segoe UI Emoji", 16F);
            lblActivityIcon1.ForeColor = Color.FromArgb(0, 120, 230);
            lblActivityIcon1.Location = new Point(5, 4);
            lblActivityIcon1.Name = "lblActivityIcon1";
            lblActivityIcon1.Size = new Size(42, 42);
            lblActivityIcon1.TabIndex = 0;
            lblActivityIcon1.Text = "🚗";
            lblActivityIcon1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActivityText1
            // 
            lblActivityText1.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblActivityText1.ForeColor = Color.FromArgb(20, 45, 80);
            lblActivityText1.Location = new Point(52, 5);
            lblActivityText1.Name = "lblActivityText1";
            lblActivityText1.Size = new Size(190, 38);
            lblActivityText1.TabIndex = 1;
            lblActivityText1.Text = "New booking received";
            // 
            // lblActivityTime1
            // 
            lblActivityTime1.Font = new Font("Segoe UI", 7.5F);
            lblActivityTime1.ForeColor = Color.FromArgb(80, 105, 140);
            lblActivityTime1.Location = new Point(242, 13);
            lblActivityTime1.Name = "lblActivityTime1";
            lblActivityTime1.Size = new Size(75, 25);
            lblActivityTime1.TabIndex = 2;
            lblActivityTime1.Text = "Recent";
            lblActivityTime1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // activityItem2
            // 
            activityItem2.BackColor = Color.White;
            activityItem2.Controls.Add(lblActivityIcon2);
            activityItem2.Controls.Add(lblActivityText2);
            activityItem2.Controls.Add(lblActivityTime2);
            activityItem2.Location = new Point(10, 112);
            activityItem2.Name = "activityItem2";
            activityItem2.Size = new Size(330, 52);
            activityItem2.TabIndex = 3;
            // 
            // lblActivityIcon2
            // 
            lblActivityIcon2.Font = new Font("Segoe UI Emoji", 16F);
            lblActivityIcon2.ForeColor = Color.FromArgb(105, 55, 220);
            lblActivityIcon2.Location = new Point(5, 4);
            lblActivityIcon2.Name = "lblActivityIcon2";
            lblActivityIcon2.Size = new Size(42, 42);
            lblActivityIcon2.TabIndex = 0;
            lblActivityIcon2.Text = "৳";
            lblActivityIcon2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActivityText2
            // 
            lblActivityText2.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblActivityText2.ForeColor = Color.FromArgb(20, 45, 80);
            lblActivityText2.Location = new Point(52, 5);
            lblActivityText2.Name = "lblActivityText2";
            lblActivityText2.Size = new Size(190, 38);
            lblActivityText2.TabIndex = 1;
            // 
            // lblActivityTime2
            // 
            lblActivityTime2.Font = new Font("Segoe UI", 7.5F);
            lblActivityTime2.ForeColor = Color.FromArgb(80, 105, 140);
            lblActivityTime2.Location = new Point(242, 13);
            lblActivityTime2.Name = "lblActivityTime2";
            lblActivityTime2.Size = new Size(75, 25);
            lblActivityTime2.TabIndex = 2;
            lblActivityTime2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // activityItem3
            // 
            activityItem3.BackColor = Color.White;
            activityItem3.Controls.Add(lblActivityIcon3);
            activityItem3.Controls.Add(lblActivityText3);
            activityItem3.Controls.Add(lblActivityTime3);
            activityItem3.Location = new Point(10, 169);
            activityItem3.Name = "activityItem3";
            activityItem3.Size = new Size(330, 52);
            activityItem3.TabIndex = 4;
            // 
            // lblActivityIcon3
            // 
            lblActivityIcon3.Font = new Font("Segoe UI Emoji", 16F);
            lblActivityIcon3.ForeColor = Color.FromArgb(0, 120, 230);
            lblActivityIcon3.Location = new Point(5, 4);
            lblActivityIcon3.Name = "lblActivityIcon3";
            lblActivityIcon3.Size = new Size(42, 42);
            lblActivityIcon3.TabIndex = 0;
            lblActivityIcon3.Text = "🚗";
            lblActivityIcon3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActivityText3
            // 
            lblActivityText3.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblActivityText3.ForeColor = Color.FromArgb(20, 45, 80);
            lblActivityText3.Location = new Point(52, 5);
            lblActivityText3.Name = "lblActivityText3";
            lblActivityText3.Size = new Size(190, 38);
            lblActivityText3.TabIndex = 1;
            // 
            // lblActivityTime3
            // 
            lblActivityTime3.Font = new Font("Segoe UI", 7.5F);
            lblActivityTime3.ForeColor = Color.FromArgb(80, 105, 140);
            lblActivityTime3.Location = new Point(242, 13);
            lblActivityTime3.Name = "lblActivityTime3";
            lblActivityTime3.Size = new Size(75, 25);
            lblActivityTime3.TabIndex = 2;
            lblActivityTime3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // activityItem4
            // 
            activityItem4.BackColor = Color.White;
            activityItem4.Controls.Add(lblActivityIcon4);
            activityItem4.Controls.Add(lblActivityText4);
            activityItem4.Controls.Add(lblActivityTime4);
            activityItem4.Location = new Point(10, 226);
            activityItem4.Name = "activityItem4";
            activityItem4.Size = new Size(330, 52);
            activityItem4.TabIndex = 5;
            // 
            // lblActivityIcon4
            // 
            lblActivityIcon4.Font = new Font("Segoe UI Emoji", 16F);
            lblActivityIcon4.ForeColor = Color.FromArgb(245, 150, 30);
            lblActivityIcon4.Location = new Point(5, 4);
            lblActivityIcon4.Name = "lblActivityIcon4";
            lblActivityIcon4.Size = new Size(42, 42);
            lblActivityIcon4.TabIndex = 0;
            lblActivityIcon4.Text = "◆";
            lblActivityIcon4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblActivityText4
            // 
            lblActivityText4.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblActivityText4.ForeColor = Color.FromArgb(20, 45, 80);
            lblActivityText4.Location = new Point(52, 5);
            lblActivityText4.Name = "lblActivityText4";
            lblActivityText4.Size = new Size(190, 38);
            lblActivityText4.TabIndex = 1;
            // 
            // lblActivityTime4
            // 
            lblActivityTime4.Font = new Font("Segoe UI", 7.5F);
            lblActivityTime4.ForeColor = Color.FromArgb(80, 105, 140);
            lblActivityTime4.Location = new Point(242, 13);
            lblActivityTime4.Name = "lblActivityTime4";
            lblActivityTime4.Size = new Size(75, 25);
            lblActivityTime4.TabIndex = 2;
            lblActivityTime4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // OwnerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 248, 252);
            ClientSize = new Size(1536, 987);
            Controls.Add(contentPanel);
            Controls.Add(sidebarPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "OwnerDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Rental Management System";
            Load += OwnerDashboardForm_Load;
            sidebarPanel.ResumeLayout(false);
            profilePanel.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            heroPanel.ResumeLayout(false);
            totalCarsCard.ResumeLayout(false);
            availableCarsCard.ResumeLayout(false);
            rentedCarsCard.ResumeLayout(false);
            earningsCard.ResumeLayout(false);
            pendingCard.ResumeLayout(false);
            vehicleStatusPanel.ResumeLayout(false);
            earningsOverviewPanel.ResumeLayout(false);
            quickActionsPanel.ResumeLayout(false);
            recentBookingsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentBookings).EndInit();
            activityPanel.ResumeLayout(false);
            activityItem1.ResumeLayout(false);
            activityItem2.ResumeLayout(false);
            activityItem3.ResumeLayout(false);
            activityItem4.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
