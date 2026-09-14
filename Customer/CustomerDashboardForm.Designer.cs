using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customer
{
    partial class CustomerDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel sidebarPanel;
        private Label lblLogo;
        private Label lblSystemName;
        private Label lblProfileIcon;
        private Label lblProfileName;
        private Label lblProfileRole;
        private Panel profileSeparator;

        private Button btnDashboard;
        private Button btnBrowseCarsNav;
        private Button btnMyBookingsNav;
        private Button btnMyPaymentsNav;
        private Label lblChangePasswordIcon;
        private Label lblChangePassword;
        private Label lblDeleteAccountIcon;
        private Label lblDeleteAccount;
        private Button btnLogout;

        private Panel contentPanel;
        private Label lblCustomer;
        private Label lblWelcome;
        private Label lblSubtitle;
        private Label lblDate;

        private Panel heroPanel;
        private Label lblHeroTitle;
        private Label lblHeroSubtitle;
        private Button btnHeroBrowse;
        private Label lblHeroCarIcon;

        private Panel cardAvailable;
        private Panel cardBookings;
        private Panel cardActive;
        private Panel cardFavorites;

        private Label lblAvailableCarsTitle;
        private Label lblAvailableCarsValue;
        private Label lblAvailableCarsSub;
        private Label lblBookingsTitle;
        private Label lblBookingsValue;
        private Label lblBookingsSub;
        private Label lblActiveRentalsTitle;
        private Label lblActiveRentalsValue;
        private Label lblActiveRentalsSub;
        private Label lblFavoritesTitle;
        private Label lblFavoritesValue;
        private Label lblFavoritesSub;

        private Panel featuredPanel;
        private Label lblFeaturedTitle;
        private Label lblFeaturedSubtitle;
        private Button btnFeaturedViewAll;

        private Panel featuredCard1;
        private Panel featuredCard2;
        private Panel featuredCard3;

        private Label lblFeaturedIcon1;
        private Label lblFeaturedName1;
        private Label lblFeaturedInfo1;
        private Label lblFeaturedPrice1;
        private Button btnFeatured1;

        private Label lblFeaturedIcon2;
        private Label lblFeaturedName2;
        private Label lblFeaturedInfo2;
        private Label lblFeaturedPrice2;
        private Button btnFeatured2;

        private Label lblFeaturedIcon3;
        private Label lblFeaturedName3;
        private Label lblFeaturedInfo3;
        private Label lblFeaturedPrice3;
        private Button btnFeatured3;

        private Panel recentPanel;
        private Label lblRecentTitle;
        private Button btnRecentViewAll;

        private Panel recentRow1;
        private Panel recentRow2;
        private Panel recentRow3;

        private Label lblRecentCar1;
        private Label lblRecentDate1;
        private Label lblRecentAmount1;
        private Label lblRecentStatus1;

        private Label lblRecentCar2;
        private Label lblRecentDate2;
        private Label lblRecentAmount2;
        private Label lblRecentStatus2;

        private Label lblRecentCar3;
        private Label lblRecentDate3;
        private Label lblRecentAmount3;
        private Label lblRecentStatus3;

        private Panel promoPanel;
        private Label lblPromoTitle;
        private Label lblPromoText;
        private Button btnPromoBrowse;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            sidebarPanel = new Panel();
            lblLogo = new Label();
            lblSystemName = new Label();
            lblProfileIcon = new Label();
            lblProfileName = new Label();
            lblProfileRole = new Label();
            profileSeparator = new Panel();
            btnDashboard = new Button();
            btnBrowseCarsNav = new Button();
            btnMyBookingsNav = new Button();
            btnMyPaymentsNav = new Button();
            lblChangePasswordIcon = new Label();
            lblChangePassword = new Label();
            lblDeleteAccountIcon = new Label();
            lblDeleteAccount = new Label();
            btnLogout = new Button();
            contentPanel = new Panel();
            lblCustomer = new Label();
            lblWelcome = new Label();
            lblSubtitle = new Label();
            lblDate = new Label();
            heroPanel = new Panel();
            lblHeroTitle = new Label();
            lblHeroSubtitle = new Label();
            btnHeroBrowse = new Button();
            lblHeroCarIcon = new Label();
            cardAvailable = new Panel();
            lblAvailableCarsTitle = new Label();
            lblAvailableCarsValue = new Label();
            lblAvailableCarsSub = new Label();
            cardBookings = new Panel();
            lblBookingsTitle = new Label();
            lblBookingsValue = new Label();
            lblBookingsSub = new Label();
            cardActive = new Panel();
            lblActiveRentalsTitle = new Label();
            lblActiveRentalsValue = new Label();
            lblActiveRentalsSub = new Label();
            cardFavorites = new Panel();
            lblFavoritesTitle = new Label();
            lblFavoritesValue = new Label();
            lblFavoritesSub = new Label();
            featuredPanel = new Panel();
            lblFeaturedTitle = new Label();
            lblFeaturedSubtitle = new Label();
            btnFeaturedViewAll = new Button();
            featuredCard1 = new Panel();
            lblFeaturedIcon1 = new Label();
            lblFeaturedName1 = new Label();
            lblFeaturedInfo1 = new Label();
            lblFeaturedPrice1 = new Label();
            btnFeatured1 = new Button();
            featuredCard2 = new Panel();
            lblFeaturedIcon2 = new Label();
            lblFeaturedName2 = new Label();
            lblFeaturedInfo2 = new Label();
            lblFeaturedPrice2 = new Label();
            btnFeatured2 = new Button();
            featuredCard3 = new Panel();
            lblFeaturedIcon3 = new Label();
            lblFeaturedName3 = new Label();
            lblFeaturedInfo3 = new Label();
            lblFeaturedPrice3 = new Label();
            btnFeatured3 = new Button();
            recentPanel = new Panel();
            lblRecentTitle = new Label();
            btnRecentViewAll = new Button();
            recentRow1 = new Panel();
            lblRecentCar1 = new Label();
            lblRecentDate1 = new Label();
            lblRecentAmount1 = new Label();
            lblRecentStatus1 = new Label();
            recentRow2 = new Panel();
            lblRecentCar2 = new Label();
            lblRecentDate2 = new Label();
            lblRecentAmount2 = new Label();
            lblRecentStatus2 = new Label();
            recentRow3 = new Panel();
            lblRecentCar3 = new Label();
            lblRecentDate3 = new Label();
            lblRecentAmount3 = new Label();
            lblRecentStatus3 = new Label();
            promoPanel = new Panel();
            lblPromoTitle = new Label();
            lblPromoText = new Label();
            btnPromoBrowse = new Button();
            sidebarPanel.SuspendLayout();
            contentPanel.SuspendLayout();
            heroPanel.SuspendLayout();
            cardAvailable.SuspendLayout();
            cardBookings.SuspendLayout();
            cardActive.SuspendLayout();
            cardFavorites.SuspendLayout();
            featuredPanel.SuspendLayout();
            featuredCard1.SuspendLayout();
            featuredCard2.SuspendLayout();
            featuredCard3.SuspendLayout();
            recentPanel.SuspendLayout();
            recentRow1.SuspendLayout();
            recentRow2.SuspendLayout();
            recentRow3.SuspendLayout();
            promoPanel.SuspendLayout();
            SuspendLayout();
            // 
            // sidebarPanel
            // 
            sidebarPanel.BackColor = Color.FromArgb(15, 39, 72);
            sidebarPanel.Controls.Add(lblLogo);
            sidebarPanel.Controls.Add(lblSystemName);
            sidebarPanel.Controls.Add(lblProfileIcon);
            sidebarPanel.Controls.Add(lblProfileName);
            sidebarPanel.Controls.Add(lblProfileRole);
            sidebarPanel.Controls.Add(profileSeparator);
            sidebarPanel.Controls.Add(btnDashboard);
            sidebarPanel.Controls.Add(btnBrowseCarsNav);
            sidebarPanel.Controls.Add(btnMyBookingsNav);
            sidebarPanel.Controls.Add(btnMyPaymentsNav);
            sidebarPanel.Controls.Add(lblChangePasswordIcon);
            sidebarPanel.Controls.Add(lblChangePassword);
            sidebarPanel.Controls.Add(lblDeleteAccountIcon);
            sidebarPanel.Controls.Add(lblDeleteAccount);
            sidebarPanel.Controls.Add(btnLogout);
            sidebarPanel.Dock = DockStyle.Left;
            sidebarPanel.Location = new Point(0, 0);
            sidebarPanel.Name = "sidebarPanel";
            sidebarPanel.Size = new Size(245, 900);
            sidebarPanel.TabIndex = 0;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Segoe UI Emoji", 28F);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(88, 18);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(92, 63);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "🚗";
            // 
            // lblSystemName
            // 
            lblSystemName.AutoSize = true;
            lblSystemName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblSystemName.ForeColor = Color.White;
            lblSystemName.Location = new Point(52, 79);
            lblSystemName.Name = "lblSystemName";
            lblSystemName.Size = new Size(165, 35);
            lblSystemName.TabIndex = 1;
            lblSystemName.Text = "CAR RENTAL";
            // 
            // lblProfileIcon
            // 
            lblProfileIcon.BackColor = Color.FromArgb(231, 238, 247);
            lblProfileIcon.Font = new Font("Segoe UI Emoji", 36F);
            lblProfileIcon.ForeColor = Color.FromArgb(71, 85, 105);
            lblProfileIcon.Location = new Point(75, 122);
            lblProfileIcon.Name = "lblProfileIcon";
            lblProfileIcon.Size = new Size(96, 96);
            lblProfileIcon.TabIndex = 2;
            lblProfileIcon.Text = "👤";
            lblProfileIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProfileName
            // 
            lblProfileName.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblProfileName.ForeColor = Color.White;
            lblProfileName.Location = new Point(15, 228);
            lblProfileName.Name = "lblProfileName";
            lblProfileName.Size = new Size(215, 30);
            lblProfileName.TabIndex = 3;
            lblProfileName.Text = "Customer Name";
            lblProfileName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblProfileRole
            // 
            lblProfileRole.Font = new Font("Segoe UI", 9.5F);
            lblProfileRole.ForeColor = Color.FromArgb(190, 207, 226);
            lblProfileRole.Location = new Point(15, 258);
            lblProfileRole.Name = "lblProfileRole";
            lblProfileRole.Size = new Size(215, 25);
            lblProfileRole.TabIndex = 4;
            lblProfileRole.Text = "Customer";
            lblProfileRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // profileSeparator
            // 
            profileSeparator.BackColor = Color.FromArgb(75, 103, 133);
            profileSeparator.Location = new Point(22, 296);
            profileSeparator.Name = "profileSeparator";
            profileSeparator.Size = new Size(201, 1);
            profileSeparator.TabIndex = 5;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.FromArgb(30, 120, 205);
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(8, 315);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Padding = new Padding(15, 0, 0, 0);
            btnDashboard.Size = new Size(229, 43);
            btnDashboard.TabIndex = 6;
            btnDashboard.Text = "⌂   Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnBrowseCarsNav
            // 
            btnBrowseCarsNav.BackColor = Color.Transparent;
            btnBrowseCarsNav.Cursor = Cursors.Hand;
            btnBrowseCarsNav.FlatAppearance.BorderSize = 0;
            btnBrowseCarsNav.FlatStyle = FlatStyle.Flat;
            btnBrowseCarsNav.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBrowseCarsNav.ForeColor = Color.White;
            btnBrowseCarsNav.Location = new Point(8, 365);
            btnBrowseCarsNav.Name = "btnBrowseCarsNav";
            btnBrowseCarsNav.Padding = new Padding(15, 0, 0, 0);
            btnBrowseCarsNav.Size = new Size(229, 43);
            btnBrowseCarsNav.TabIndex = 7;
            btnBrowseCarsNav.Text = "🚗   Browse Cars";
            btnBrowseCarsNav.TextAlign = ContentAlignment.MiddleLeft;
            btnBrowseCarsNav.UseVisualStyleBackColor = false;
            btnBrowseCarsNav.Click += btnBrowseCars_Click;
            // 
            // btnMyBookingsNav
            // 
            btnMyBookingsNav.BackColor = Color.Transparent;
            btnMyBookingsNav.Cursor = Cursors.Hand;
            btnMyBookingsNav.FlatAppearance.BorderSize = 0;
            btnMyBookingsNav.FlatStyle = FlatStyle.Flat;
            btnMyBookingsNav.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnMyBookingsNav.ForeColor = Color.White;
            btnMyBookingsNav.Location = new Point(8, 415);
            btnMyBookingsNav.Name = "btnMyBookingsNav";
            btnMyBookingsNav.Padding = new Padding(15, 0, 0, 0);
            btnMyBookingsNav.Size = new Size(229, 43);
            btnMyBookingsNav.TabIndex = 8;
            btnMyBookingsNav.Text = "▣   My Bookings";
            btnMyBookingsNav.TextAlign = ContentAlignment.MiddleLeft;
            btnMyBookingsNav.UseVisualStyleBackColor = false;
            btnMyBookingsNav.Click += btnMyBookings_Click;
            // 
            // btnMyPaymentsNav
            // 
            btnMyPaymentsNav.BackColor = Color.Transparent;
            btnMyPaymentsNav.Cursor = Cursors.Hand;
            btnMyPaymentsNav.FlatAppearance.BorderSize = 0;
            btnMyPaymentsNav.FlatStyle = FlatStyle.Flat;
            btnMyPaymentsNav.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnMyPaymentsNav.ForeColor = Color.White;
            btnMyPaymentsNav.Location = new Point(8, 465);
            btnMyPaymentsNav.Name = "btnMyPaymentsNav";
            btnMyPaymentsNav.Padding = new Padding(15, 0, 0, 0);
            btnMyPaymentsNav.Size = new Size(229, 43);
            btnMyPaymentsNav.TabIndex = 9;
            btnMyPaymentsNav.Text = "▤   My Payments";
            btnMyPaymentsNav.TextAlign = ContentAlignment.MiddleLeft;
            btnMyPaymentsNav.UseVisualStyleBackColor = false;
            btnMyPaymentsNav.Click += btnMyPayments_Click;
            // 
            // lblChangePasswordIcon
            // 
            lblChangePasswordIcon.AutoSize = true;
            lblChangePasswordIcon.Font = new Font("Segoe UI Emoji", 16F);
            lblChangePasswordIcon.ForeColor = Color.White;
            lblChangePasswordIcon.Location = new Point(0, 666);
            lblChangePasswordIcon.Name = "lblChangePasswordIcon";
            lblChangePasswordIcon.Size = new Size(52, 36);
            lblChangePasswordIcon.TabIndex = 10;
            lblChangePasswordIcon.Text = "🔐";
            // 
            // lblChangePassword
            // 
            lblChangePassword.Cursor = Cursors.Hand;
            lblChangePassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblChangePassword.ForeColor = Color.White;
            lblChangePassword.Location = new Point(63, 667);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(160, 35);
            lblChangePassword.TabIndex = 11;
            lblChangePassword.Text = "Change Password";
            lblChangePassword.TextAlign = ContentAlignment.MiddleLeft;
            lblChangePassword.Click += lblChangePassword_Click;
            // 
            // lblDeleteAccountIcon
            // 
            lblDeleteAccountIcon.AutoSize = true;
            lblDeleteAccountIcon.Font = new Font("Segoe UI Emoji", 16F);
            lblDeleteAccountIcon.ForeColor = Color.White;
            lblDeleteAccountIcon.Location = new Point(0, 719);
            lblDeleteAccountIcon.Name = "lblDeleteAccountIcon";
            lblDeleteAccountIcon.Size = new Size(52, 36);
            lblDeleteAccountIcon.TabIndex = 12;
            lblDeleteAccountIcon.Text = "🗑";
            // 
            // lblDeleteAccount
            // 
            lblDeleteAccount.Cursor = Cursors.Hand;
            lblDeleteAccount.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDeleteAccount.ForeColor = Color.White;
            lblDeleteAccount.Location = new Point(63, 724);
            lblDeleteAccount.Name = "lblDeleteAccount";
            lblDeleteAccount.Size = new Size(160, 35);
            lblDeleteAccount.TabIndex = 13;
            lblDeleteAccount.Text = "Delete Account";
            lblDeleteAccount.TextAlign = ContentAlignment.MiddleLeft;
            lblDeleteAccount.Click += lblDeleteAccount_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(28, 55, 91);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(22, 810);
            btnLogout.Name = "btnLogout";
            btnLogout.Padding = new Padding(20, 0, 0, 0);
            btnLogout.Size = new Size(201, 45);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "⇥   Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // contentPanel
            // 
            contentPanel.AutoScroll = true;
            contentPanel.BackColor = Color.FromArgb(244, 248, 252);
            contentPanel.Controls.Add(lblCustomer);
            contentPanel.Controls.Add(lblWelcome);
            contentPanel.Controls.Add(lblSubtitle);
            contentPanel.Controls.Add(lblDate);
            contentPanel.Controls.Add(heroPanel);
            contentPanel.Controls.Add(cardAvailable);
            contentPanel.Controls.Add(cardBookings);
            contentPanel.Controls.Add(cardActive);
            contentPanel.Controls.Add(cardFavorites);
            contentPanel.Controls.Add(featuredPanel);
            contentPanel.Controls.Add(recentPanel);
            contentPanel.Controls.Add(promoPanel);
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(245, 0);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(1125, 900);
            contentPanel.TabIndex = 1;
            // 
            // lblCustomer
            // 
            lblCustomer.AutoSize = true;
            lblCustomer.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblCustomer.ForeColor = Color.FromArgb(30, 80, 130);
            lblCustomer.Location = new Point(30, 20);
            lblCustomer.Name = "lblCustomer";
            lblCustomer.Size = new Size(139, 20);
            lblCustomer.TabIndex = 0;
            lblCustomer.Text = "CUSTOMER PANEL";
            // 
            // lblWelcome
            // 
            lblWelcome.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblWelcome.ForeColor = Color.FromArgb(15, 39, 72);
            lblWelcome.Location = new Point(28, 41);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(600, 42);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome Back! 👋";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(83, 108, 137);
            lblSubtitle.Location = new Point(32, 86);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(380, 21);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Find, book, and enjoy the perfect car for your journey.";
            // 
            // lblDate
            // 
            lblDate.Font = new Font("Segoe UI", 8F);
            lblDate.ForeColor = Color.FromArgb(83, 108, 137);
            lblDate.Location = new Point(971, 20);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(70, 40);
            lblDate.TabIndex = 5;
            lblDate.Text = "10 Sep\r\n2026";
            lblDate.TextAlign = ContentAlignment.MiddleRight;
            // 
            // heroPanel
            // 
            heroPanel.BackColor = Color.FromArgb(24, 69, 108);
            heroPanel.Controls.Add(lblHeroTitle);
            heroPanel.Controls.Add(lblHeroSubtitle);
            heroPanel.Controls.Add(btnHeroBrowse);
            heroPanel.Controls.Add(lblHeroCarIcon);
            heroPanel.Location = new Point(30, 118);
            heroPanel.Name = "heroPanel";
            heroPanel.Size = new Size(1070, 145);
            heroPanel.TabIndex = 6;
            // 
            // lblHeroTitle
            // 
            lblHeroTitle.AutoSize = true;
            lblHeroTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblHeroTitle.ForeColor = Color.White;
            lblHeroTitle.Location = new Point(30, 24);
            lblHeroTitle.Name = "lblHeroTitle";
            lblHeroTitle.Size = new Size(366, 46);
            lblHeroTitle.TabIndex = 0;
            lblHeroTitle.Text = "Let the Journey Begin";
            // 
            // lblHeroSubtitle
            // 
            lblHeroSubtitle.AutoSize = true;
            lblHeroSubtitle.Font = new Font("Segoe UI", 10F);
            lblHeroSubtitle.ForeColor = Color.FromArgb(224, 237, 249);
            lblHeroSubtitle.Location = new Point(32, 62);
            lblHeroSubtitle.Name = "lblHeroSubtitle";
            lblHeroSubtitle.Size = new Size(413, 23);
            lblHeroSubtitle.TabIndex = 1;
            lblHeroSubtitle.Text = "Explore a wide range of cars for your next adventure.";
            // 
            // btnHeroBrowse
            // 
            btnHeroBrowse.BackColor = Color.FromArgb(30, 136, 255);
            btnHeroBrowse.FlatAppearance.BorderSize = 0;
            btnHeroBrowse.FlatStyle = FlatStyle.Flat;
            btnHeroBrowse.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnHeroBrowse.ForeColor = Color.White;
            btnHeroBrowse.Location = new Point(32, 94);
            btnHeroBrowse.Name = "btnHeroBrowse";
            btnHeroBrowse.Size = new Size(140, 36);
            btnHeroBrowse.TabIndex = 2;
            btnHeroBrowse.Text = "Browse Cars →";
            btnHeroBrowse.UseVisualStyleBackColor = false;
            btnHeroBrowse.Click += btnHeroBrowse_Click;
            // 
            // lblHeroCarIcon
            // 
            lblHeroCarIcon.Font = new Font("Segoe UI Emoji", 44F);
            lblHeroCarIcon.ForeColor = Color.White;
            lblHeroCarIcon.Location = new Point(820, 25);
            lblHeroCarIcon.Name = "lblHeroCarIcon";
            lblHeroCarIcon.Size = new Size(200, 95);
            lblHeroCarIcon.TabIndex = 3;
            lblHeroCarIcon.Text = "🚙";
            lblHeroCarIcon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cardAvailable
            // 
            cardAvailable.BackColor = Color.FromArgb(225, 239, 255);
            cardAvailable.Controls.Add(lblAvailableCarsTitle);
            cardAvailable.Controls.Add(lblAvailableCarsValue);
            cardAvailable.Controls.Add(lblAvailableCarsSub);
            cardAvailable.Location = new Point(30, 278);
            cardAvailable.Name = "cardAvailable";
            cardAvailable.Size = new Size(255, 90);
            cardAvailable.TabIndex = 7;
            // 
            // lblAvailableCarsTitle
            // 
            lblAvailableCarsTitle.AutoSize = true;
            lblAvailableCarsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAvailableCarsTitle.ForeColor = Color.FromArgb(15, 91, 160);
            lblAvailableCarsTitle.Location = new Point(15, 10);
            lblAvailableCarsTitle.Name = "lblAvailableCarsTitle";
            lblAvailableCarsTitle.Size = new Size(137, 20);
            lblAvailableCarsTitle.TabIndex = 0;
            lblAvailableCarsTitle.Text = "🚗  Available Cars";
            // 
            // lblAvailableCarsValue
            // 
            lblAvailableCarsValue.AutoSize = true;
            lblAvailableCarsValue.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblAvailableCarsValue.ForeColor = Color.FromArgb(15, 39, 72);
            lblAvailableCarsValue.Location = new Point(15, 34);
            lblAvailableCarsValue.Name = "lblAvailableCarsValue";
            lblAvailableCarsValue.Size = new Size(38, 45);
            lblAvailableCarsValue.TabIndex = 1;
            lblAvailableCarsValue.Text = "0";
            // 
            // lblAvailableCarsSub
            // 
            lblAvailableCarsSub.AutoSize = true;
            lblAvailableCarsSub.Font = new Font("Segoe UI", 7.5F);
            lblAvailableCarsSub.ForeColor = Color.FromArgb(72, 97, 124);
            lblAvailableCarsSub.Location = new Point(149, 67);
            lblAvailableCarsSub.Name = "lblAvailableCarsSub";
            lblAvailableCarsSub.Size = new Size(90, 17);
            lblAvailableCarsSub.TabIndex = 2;
            lblAvailableCarsSub.Text = "Ready to Rent";
            // 
            // cardBookings
            // 
            cardBookings.BackColor = Color.FromArgb(225, 249, 239);
            cardBookings.Controls.Add(lblBookingsTitle);
            cardBookings.Controls.Add(lblBookingsValue);
            cardBookings.Controls.Add(lblBookingsSub);
            cardBookings.Location = new Point(300, 278);
            cardBookings.Name = "cardBookings";
            cardBookings.Size = new Size(255, 90);
            cardBookings.TabIndex = 8;
            // 
            // lblBookingsTitle
            // 
            lblBookingsTitle.AutoSize = true;
            lblBookingsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblBookingsTitle.ForeColor = Color.FromArgb(15, 120, 80);
            lblBookingsTitle.Location = new Point(15, 10);
            lblBookingsTitle.Name = "lblBookingsTitle";
            lblBookingsTitle.Size = new Size(122, 20);
            lblBookingsTitle.TabIndex = 0;
            lblBookingsTitle.Text = "▣  My Bookings";
            // 
            // lblBookingsValue
            // 
            lblBookingsValue.AutoSize = true;
            lblBookingsValue.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblBookingsValue.ForeColor = Color.FromArgb(15, 39, 72);
            lblBookingsValue.Location = new Point(15, 34);
            lblBookingsValue.Name = "lblBookingsValue";
            lblBookingsValue.Size = new Size(38, 45);
            lblBookingsValue.TabIndex = 1;
            lblBookingsValue.Text = "0";
            // 
            // lblBookingsSub
            // 
            lblBookingsSub.AutoSize = true;
            lblBookingsSub.Font = new Font("Segoe UI", 7.5F);
            lblBookingsSub.ForeColor = Color.FromArgb(72, 97, 124);
            lblBookingsSub.Location = new Point(159, 67);
            lblBookingsSub.Name = "lblBookingsSub";
            lblBookingsSub.Size = new Size(93, 17);
            lblBookingsSub.TabIndex = 2;
            lblBookingsSub.Text = "Total Bookings";
            // 
            // cardActive
            // 
            cardActive.BackColor = Color.FromArgb(239, 232, 255);
            cardActive.Controls.Add(lblActiveRentalsTitle);
            cardActive.Controls.Add(lblActiveRentalsValue);
            cardActive.Controls.Add(lblActiveRentalsSub);
            cardActive.Location = new Point(570, 278);
            cardActive.Name = "cardActive";
            cardActive.Size = new Size(255, 90);
            cardActive.TabIndex = 9;
            // 
            // lblActiveRentalsTitle
            // 
            lblActiveRentalsTitle.AutoSize = true;
            lblActiveRentalsTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblActiveRentalsTitle.ForeColor = Color.FromArgb(101, 70, 190);
            lblActiveRentalsTitle.Location = new Point(15, 10);
            lblActiveRentalsTitle.Name = "lblActiveRentalsTitle";
            lblActiveRentalsTitle.Size = new Size(131, 20);
            lblActiveRentalsTitle.TabIndex = 0;
            lblActiveRentalsTitle.Text = "◷  Active Rentals";
            // 
            // lblActiveRentalsValue
            // 
            lblActiveRentalsValue.AutoSize = true;
            lblActiveRentalsValue.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblActiveRentalsValue.ForeColor = Color.FromArgb(15, 39, 72);
            lblActiveRentalsValue.Location = new Point(15, 34);
            lblActiveRentalsValue.Name = "lblActiveRentalsValue";
            lblActiveRentalsValue.Size = new Size(38, 45);
            lblActiveRentalsValue.TabIndex = 1;
            lblActiveRentalsValue.Text = "0";
            // 
            // lblActiveRentalsSub
            // 
            lblActiveRentalsSub.AutoSize = true;
            lblActiveRentalsSub.Font = new Font("Segoe UI", 7.5F);
            lblActiveRentalsSub.ForeColor = Color.FromArgb(72, 97, 124);
            lblActiveRentalsSub.Location = new Point(142, 67);
            lblActiveRentalsSub.Name = "lblActiveRentalsSub";
            lblActiveRentalsSub.Size = new Size(98, 17);
            lblActiveRentalsSub.TabIndex = 2;
            lblActiveRentalsSub.Text = "Currently Active";
            // 
            // cardFavorites
            // 
            cardFavorites.BackColor = Color.FromArgb(255, 242, 224);
            cardFavorites.Controls.Add(lblFavoritesTitle);
            cardFavorites.Controls.Add(lblFavoritesValue);
            cardFavorites.Controls.Add(lblFavoritesSub);
            cardFavorites.Location = new Point(840, 278);
            cardFavorites.Name = "cardFavorites";
            cardFavorites.Size = new Size(260, 90);
            cardFavorites.TabIndex = 10;
            // 
            // lblFavoritesTitle
            // 
            lblFavoritesTitle.AutoSize = true;
            lblFavoritesTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFavoritesTitle.ForeColor = Color.FromArgb(180, 105, 10);
            lblFavoritesTitle.Location = new Point(15, 10);
            lblFavoritesTitle.Name = "lblFavoritesTitle";
            lblFavoritesTitle.Size = new Size(95, 20);
            lblFavoritesTitle.TabIndex = 0;
            lblFavoritesTitle.Text = "☆  Favorites";
            // 
            // lblFavoritesValue
            // 
            lblFavoritesValue.AutoSize = true;
            lblFavoritesValue.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblFavoritesValue.ForeColor = Color.FromArgb(15, 39, 72);
            lblFavoritesValue.Location = new Point(10, 29);
            lblFavoritesValue.Name = "lblFavoritesValue";
            lblFavoritesValue.Size = new Size(38, 45);
            lblFavoritesValue.TabIndex = 1;
            lblFavoritesValue.Text = "0";
            // 
            // lblFavoritesSub
            // 
            lblFavoritesSub.AutoSize = true;
            lblFavoritesSub.Font = new Font("Segoe UI", 7.5F);
            lblFavoritesSub.ForeColor = Color.FromArgb(72, 97, 124);
            lblFavoritesSub.Location = new Point(172, 67);
            lblFavoritesSub.Name = "lblFavoritesSub";
            lblFavoritesSub.Size = new Size(73, 17);
            lblFavoritesSub.TabIndex = 2;
            lblFavoritesSub.Text = "Saved Cars";
            // 
            // featuredPanel
            // 
            featuredPanel.BackColor = Color.White;
            featuredPanel.Controls.Add(lblFeaturedTitle);
            featuredPanel.Controls.Add(lblFeaturedSubtitle);
            featuredPanel.Controls.Add(btnFeaturedViewAll);
            featuredPanel.Controls.Add(featuredCard1);
            featuredPanel.Controls.Add(featuredCard2);
            featuredPanel.Controls.Add(featuredCard3);
            featuredPanel.Location = new Point(30, 385);
            featuredPanel.Name = "featuredPanel";
            featuredPanel.Size = new Size(700, 330);
            featuredPanel.TabIndex = 11;
            // 
            // lblFeaturedTitle
            // 
            lblFeaturedTitle.AutoSize = true;
            lblFeaturedTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblFeaturedTitle.ForeColor = Color.FromArgb(15, 39, 72);
            lblFeaturedTitle.Location = new Point(18, 15);
            lblFeaturedTitle.Name = "lblFeaturedTitle";
            lblFeaturedTitle.Size = new Size(199, 30);
            lblFeaturedTitle.TabIndex = 0;
            lblFeaturedTitle.Text = "🔥  Featured Cars";
            // 
            // lblFeaturedSubtitle
            // 
            lblFeaturedSubtitle.AutoSize = true;
            lblFeaturedSubtitle.Font = new Font("Segoe UI", 8.5F);
            lblFeaturedSubtitle.ForeColor = Color.FromArgb(94, 116, 142);
            lblFeaturedSubtitle.Location = new Point(19, 42);
            lblFeaturedSubtitle.Name = "lblFeaturedSubtitle";
            lblFeaturedSubtitle.Size = new Size(274, 20);
            lblFeaturedSubtitle.TabIndex = 1;
            lblFeaturedSubtitle.Text = "Popular vehicles ready for your next trip.";
            // 
            // btnFeaturedViewAll
            // 
            btnFeaturedViewAll.BackColor = Color.Transparent;
            btnFeaturedViewAll.FlatAppearance.BorderSize = 0;
            btnFeaturedViewAll.FlatStyle = FlatStyle.Flat;
            btnFeaturedViewAll.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnFeaturedViewAll.ForeColor = Color.FromArgb(20, 103, 190);
            btnFeaturedViewAll.Location = new Point(615, 12);
            btnFeaturedViewAll.Name = "btnFeaturedViewAll";
            btnFeaturedViewAll.Size = new Size(70, 30);
            btnFeaturedViewAll.TabIndex = 2;
            btnFeaturedViewAll.Text = "View All";
            btnFeaturedViewAll.UseVisualStyleBackColor = false;
            btnFeaturedViewAll.Click += btnFeaturedBrowse_Click;
            // 
            // featuredCard1
            // 
            featuredCard1.BackColor = Color.FromArgb(249, 251, 254);
            featuredCard1.Controls.Add(lblFeaturedIcon1);
            featuredCard1.Controls.Add(lblFeaturedName1);
            featuredCard1.Controls.Add(lblFeaturedInfo1);
            featuredCard1.Controls.Add(lblFeaturedPrice1);
            featuredCard1.Controls.Add(btnFeatured1);
            featuredCard1.Location = new Point(18, 72);
            featuredCard1.Name = "featuredCard1";
            featuredCard1.Size = new Size(210, 245);
            featuredCard1.TabIndex = 3;
            // 
            // lblFeaturedIcon1
            // 
            lblFeaturedIcon1.Font = new Font("Segoe UI Emoji", 31F);
            lblFeaturedIcon1.Location = new Point(10, 8);
            lblFeaturedIcon1.Name = "lblFeaturedIcon1";
            lblFeaturedIcon1.Size = new Size(190, 65);
            lblFeaturedIcon1.TabIndex = 0;
            lblFeaturedIcon1.Text = "🚘";
            lblFeaturedIcon1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFeaturedName1
            // 
            lblFeaturedName1.AutoSize = true;
            lblFeaturedName1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFeaturedName1.ForeColor = Color.FromArgb(15, 39, 72);
            lblFeaturedName1.Location = new Point(14, 78);
            lblFeaturedName1.Name = "lblFeaturedName1";
            lblFeaturedName1.Size = new Size(125, 23);
            lblFeaturedName1.TabIndex = 1;
            lblFeaturedName1.Text = "Toyota Corolla";
            
            // 
            // lblFeaturedInfo1
            // 
            lblFeaturedInfo1.AutoSize = true;
            lblFeaturedInfo1.Font = new Font("Segoe UI", 8F);
            lblFeaturedInfo1.ForeColor = Color.FromArgb(84, 105, 130);
            lblFeaturedInfo1.Location = new Point(14, 104);
            lblFeaturedInfo1.Name = "lblFeaturedInfo1";
            lblFeaturedInfo1.Size = new Size(100, 19);
            lblFeaturedInfo1.TabIndex = 2;
            lblFeaturedInfo1.Text = "Sedan  •  2023";
            // 
            // lblFeaturedPrice1
            // 
            lblFeaturedPrice1.AutoSize = true;
            lblFeaturedPrice1.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblFeaturedPrice1.ForeColor = Color.FromArgb(22, 113, 205);
            lblFeaturedPrice1.Location = new Point(14, 130);
            lblFeaturedPrice1.Name = "lblFeaturedPrice1";
            lblFeaturedPrice1.Size = new Size(123, 25);
            lblFeaturedPrice1.TabIndex = 3;
            lblFeaturedPrice1.Text = "৳3,000 / day";
            // 
            // btnFeatured1
            // 
            btnFeatured1.BackColor = Color.FromArgb(25, 113, 205);
            btnFeatured1.FlatAppearance.BorderSize = 0;
            btnFeatured1.FlatStyle = FlatStyle.Flat;
            btnFeatured1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnFeatured1.ForeColor = Color.White;
            btnFeatured1.Location = new Point(14, 176);
            btnFeatured1.Name = "btnFeatured1";
            btnFeatured1.Size = new Size(180, 36);
            btnFeatured1.TabIndex = 4;
            btnFeatured1.Text = "View Details";
            btnFeatured1.UseVisualStyleBackColor = false;
            btnFeatured1.Click += btnFeaturedBrowse_Click;
            // 
            // featuredCard2
            // 
            featuredCard2.BackColor = Color.FromArgb(249, 251, 254);
            featuredCard2.Controls.Add(lblFeaturedIcon2);
            featuredCard2.Controls.Add(lblFeaturedName2);
            featuredCard2.Controls.Add(lblFeaturedInfo2);
            featuredCard2.Controls.Add(lblFeaturedPrice2);
            featuredCard2.Controls.Add(btnFeatured2);
            featuredCard2.Location = new Point(245, 72);
            featuredCard2.Name = "featuredCard2";
            featuredCard2.Size = new Size(210, 245);
            featuredCard2.TabIndex = 4;
            // 
            // lblFeaturedIcon2
            // 
            lblFeaturedIcon2.Font = new Font("Segoe UI Emoji", 31F);
            lblFeaturedIcon2.Location = new Point(10, 8);
            lblFeaturedIcon2.Name = "lblFeaturedIcon2";
            lblFeaturedIcon2.Size = new Size(190, 65);
            lblFeaturedIcon2.TabIndex = 0;
            lblFeaturedIcon2.Text = "🚙";
            lblFeaturedIcon2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFeaturedName2
            // 
            lblFeaturedName2.AutoSize = true;
            lblFeaturedName2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFeaturedName2.ForeColor = Color.FromArgb(15, 39, 72);
            lblFeaturedName2.Location = new Point(14, 78);
            lblFeaturedName2.Name = "lblFeaturedName2";
            lblFeaturedName2.Size = new Size(108, 23);
            lblFeaturedName2.TabIndex = 1;
            lblFeaturedName2.Text = "Honda CR-V";
            // 
            // lblFeaturedInfo2
            // 
            lblFeaturedInfo2.AutoSize = true;
            lblFeaturedInfo2.Font = new Font("Segoe UI", 8F);
            lblFeaturedInfo2.ForeColor = Color.FromArgb(84, 105, 130);
            lblFeaturedInfo2.Location = new Point(14, 104);
            lblFeaturedInfo2.Name = "lblFeaturedInfo2";
            lblFeaturedInfo2.Size = new Size(89, 19);
            lblFeaturedInfo2.TabIndex = 2;
            lblFeaturedInfo2.Text = "SUV  •  2023";
            // 
            // lblFeaturedPrice2
            // 
            lblFeaturedPrice2.AutoSize = true;
            lblFeaturedPrice2.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblFeaturedPrice2.ForeColor = Color.FromArgb(22, 113, 205);
            lblFeaturedPrice2.Location = new Point(14, 130);
            lblFeaturedPrice2.Name = "lblFeaturedPrice2";
            lblFeaturedPrice2.Size = new Size(123, 25);
            lblFeaturedPrice2.TabIndex = 3;
            lblFeaturedPrice2.Text = "৳4,500 / day";
            // 
            // btnFeatured2
            // 
            btnFeatured2.BackColor = Color.FromArgb(25, 113, 205);
            btnFeatured2.FlatAppearance.BorderSize = 0;
            btnFeatured2.FlatStyle = FlatStyle.Flat;
            btnFeatured2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnFeatured2.ForeColor = Color.White;
            btnFeatured2.Location = new Point(14, 176);
            btnFeatured2.Name = "btnFeatured2";
            btnFeatured2.Size = new Size(180, 36);
            btnFeatured2.TabIndex = 4;
            btnFeatured2.Text = "View Details";
            btnFeatured2.UseVisualStyleBackColor = false;
            btnFeatured2.Click += btnFeaturedBrowse_Click;
            // 
            // featuredCard3
            // 
            featuredCard3.BackColor = Color.FromArgb(249, 251, 254);
            featuredCard3.Controls.Add(lblFeaturedIcon3);
            featuredCard3.Controls.Add(lblFeaturedName3);
            featuredCard3.Controls.Add(lblFeaturedInfo3);
            featuredCard3.Controls.Add(lblFeaturedPrice3);
            featuredCard3.Controls.Add(btnFeatured3);
            featuredCard3.Location = new Point(472, 72);
            featuredCard3.Name = "featuredCard3";
            featuredCard3.Size = new Size(210, 245);
            featuredCard3.TabIndex = 5;
            // 
            // lblFeaturedIcon3
            // 
            lblFeaturedIcon3.Font = new Font("Segoe UI Emoji", 31F);
            lblFeaturedIcon3.Location = new Point(10, 8);
            lblFeaturedIcon3.Name = "lblFeaturedIcon3";
            lblFeaturedIcon3.Size = new Size(190, 65);
            lblFeaturedIcon3.TabIndex = 0;
            lblFeaturedIcon3.Text = "🚗";
            lblFeaturedIcon3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFeaturedName3
            // 
            lblFeaturedName3.AutoSize = true;
            lblFeaturedName3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFeaturedName3.ForeColor = Color.FromArgb(15, 39, 72);
            lblFeaturedName3.Location = new Point(14, 78);
            lblFeaturedName3.Name = "lblFeaturedName3";
            lblFeaturedName3.Size = new Size(121, 23);
            lblFeaturedName3.TabIndex = 1;
            lblFeaturedName3.Text = "BMW 3 Series";
            // 
            // lblFeaturedInfo3
            // 
            lblFeaturedInfo3.AutoSize = true;
            lblFeaturedInfo3.Font = new Font("Segoe UI", 8F);
            lblFeaturedInfo3.ForeColor = Color.FromArgb(84, 105, 130);
            lblFeaturedInfo3.Location = new Point(14, 104);
            lblFeaturedInfo3.Name = "lblFeaturedInfo3";
            lblFeaturedInfo3.Size = new Size(104, 19);
            lblFeaturedInfo3.TabIndex = 2;
            lblFeaturedInfo3.Text = "Luxury  •  2023";
            // 
            // lblFeaturedPrice3
            // 
            lblFeaturedPrice3.AutoSize = true;
            lblFeaturedPrice3.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblFeaturedPrice3.ForeColor = Color.FromArgb(22, 113, 205);
            lblFeaturedPrice3.Location = new Point(14, 130);
            lblFeaturedPrice3.Name = "lblFeaturedPrice3";
            lblFeaturedPrice3.Size = new Size(123, 25);
            lblFeaturedPrice3.TabIndex = 3;
            lblFeaturedPrice3.Text = "৳6,000 / day";
            // 
            // btnFeatured3
            // 
            btnFeatured3.BackColor = Color.FromArgb(25, 113, 205);
            btnFeatured3.FlatAppearance.BorderSize = 0;
            btnFeatured3.FlatStyle = FlatStyle.Flat;
            btnFeatured3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            btnFeatured3.ForeColor = Color.White;
            btnFeatured3.Location = new Point(14, 176);
            btnFeatured3.Name = "btnFeatured3";
            btnFeatured3.Size = new Size(180, 36);
            btnFeatured3.TabIndex = 4;
            btnFeatured3.Text = "View Details";
            btnFeatured3.UseVisualStyleBackColor = false;
            btnFeatured3.Click += btnFeaturedBrowse_Click;
            // 
            // recentPanel
            // 
            recentPanel.BackColor = Color.White;
            recentPanel.Controls.Add(lblRecentTitle);
            recentPanel.Controls.Add(btnRecentViewAll);
            recentPanel.Controls.Add(recentRow1);
            recentPanel.Controls.Add(recentRow2);
            recentPanel.Controls.Add(recentRow3);
            recentPanel.Location = new Point(750, 385);
            recentPanel.Name = "recentPanel";
            recentPanel.Size = new Size(350, 330);
            recentPanel.TabIndex = 12;
            // 
            // lblRecentTitle
            // 
            lblRecentTitle.AutoSize = true;
            lblRecentTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblRecentTitle.ForeColor = Color.FromArgb(15, 39, 72);
            lblRecentTitle.Location = new Point(16, 15);
            lblRecentTitle.Name = "lblRecentTitle";
            lblRecentTitle.Size = new Size(216, 30);
            lblRecentTitle.TabIndex = 0;
            lblRecentTitle.Text = "◷  Recent Bookings";
            // 
            // btnRecentViewAll
            // 
            btnRecentViewAll.BackColor = Color.Transparent;
            btnRecentViewAll.FlatAppearance.BorderSize = 0;
            btnRecentViewAll.FlatStyle = FlatStyle.Flat;
            btnRecentViewAll.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnRecentViewAll.ForeColor = Color.FromArgb(20, 103, 190);
            btnRecentViewAll.Location = new Point(265, 12);
            btnRecentViewAll.Name = "btnRecentViewAll";
            btnRecentViewAll.Size = new Size(70, 30);
            btnRecentViewAll.TabIndex = 1;
            btnRecentViewAll.Text = "View All";
            btnRecentViewAll.UseVisualStyleBackColor = false;
            btnRecentViewAll.Click += btnRecentViewAll_Click;
            // 
            // recentRow1
            // 
            recentRow1.BackColor = Color.FromArgb(249, 251, 254);
            recentRow1.Controls.Add(lblRecentCar1);
            recentRow1.Controls.Add(lblRecentDate1);
            recentRow1.Controls.Add(lblRecentAmount1);
            recentRow1.Controls.Add(lblRecentStatus1);
            recentRow1.Location = new Point(15, 55);
            recentRow1.Name = "recentRow1";
            recentRow1.Size = new Size(320, 72);
            recentRow1.TabIndex = 2;
            // 
            // lblRecentCar1
            // 
            lblRecentCar1.AutoSize = true;
            lblRecentCar1.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblRecentCar1.ForeColor = Color.FromArgb(15, 39, 72);
            lblRecentCar1.Location = new Point(12, 9);
            lblRecentCar1.Name = "lblRecentCar1";
            lblRecentCar1.Size = new Size(91, 20);
            lblRecentCar1.TabIndex = 0;
            lblRecentCar1.Text = "No booking";
            // 
            // lblRecentDate1
            // 
            lblRecentDate1.AutoSize = true;
            lblRecentDate1.Font = new Font("Segoe UI", 7.5F);
            lblRecentDate1.ForeColor = Color.FromArgb(84, 105, 130);
            lblRecentDate1.Location = new Point(12, 35);
            lblRecentDate1.Name = "lblRecentDate1";
            lblRecentDate1.Size = new Size(118, 17);
            lblRecentDate1.TabIndex = 1;
            lblRecentDate1.Text = "No recent booking";
            // 
            // lblRecentAmount1
            // 
            lblRecentAmount1.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblRecentAmount1.ForeColor = Color.FromArgb(15, 39, 72);
            lblRecentAmount1.Location = new Point(225, 9);
            lblRecentAmount1.Name = "lblRecentAmount1";
            lblRecentAmount1.Size = new Size(82, 22);
            lblRecentAmount1.TabIndex = 2;
            lblRecentAmount1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRecentStatus1
            // 
            lblRecentStatus1.BackColor = Color.FromArgb(218, 247, 232);
            lblRecentStatus1.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblRecentStatus1.ForeColor = Color.FromArgb(12, 122, 74);
            lblRecentStatus1.Location = new Point(225, 36);
            lblRecentStatus1.Name = "lblRecentStatus1";
            lblRecentStatus1.Size = new Size(82, 21);
            lblRecentStatus1.TabIndex = 3;
            lblRecentStatus1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // recentRow2
            // 
            recentRow2.BackColor = Color.FromArgb(249, 251, 254);
            recentRow2.Controls.Add(lblRecentCar2);
            recentRow2.Controls.Add(lblRecentDate2);
            recentRow2.Controls.Add(lblRecentAmount2);
            recentRow2.Controls.Add(lblRecentStatus2);
            recentRow2.Location = new Point(15, 132);
            recentRow2.Name = "recentRow2";
            recentRow2.Size = new Size(320, 72);
            recentRow2.TabIndex = 3;
            // 
            // lblRecentCar2
            // 
            lblRecentCar2.AutoSize = true;
            lblRecentCar2.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblRecentCar2.ForeColor = Color.FromArgb(15, 39, 72);
            lblRecentCar2.Location = new Point(12, 9);
            lblRecentCar2.Name = "lblRecentCar2";
            lblRecentCar2.Size = new Size(91, 20);
            lblRecentCar2.TabIndex = 0;
            lblRecentCar2.Text = "No booking";
            // 
            // lblRecentDate2
            // 
            lblRecentDate2.AutoSize = true;
            lblRecentDate2.Font = new Font("Segoe UI", 7.5F);
            lblRecentDate2.ForeColor = Color.FromArgb(84, 105, 130);
            lblRecentDate2.Location = new Point(12, 35);
            lblRecentDate2.Name = "lblRecentDate2";
            lblRecentDate2.Size = new Size(118, 17);
            lblRecentDate2.TabIndex = 1;
            lblRecentDate2.Text = "No recent booking";
            // 
            // lblRecentAmount2
            // 
            lblRecentAmount2.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblRecentAmount2.ForeColor = Color.FromArgb(15, 39, 72);
            lblRecentAmount2.Location = new Point(225, 9);
            lblRecentAmount2.Name = "lblRecentAmount2";
            lblRecentAmount2.Size = new Size(82, 22);
            lblRecentAmount2.TabIndex = 2;
            lblRecentAmount2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRecentStatus2
            // 
            lblRecentStatus2.BackColor = Color.FromArgb(218, 247, 232);
            lblRecentStatus2.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblRecentStatus2.ForeColor = Color.FromArgb(12, 122, 74);
            lblRecentStatus2.Location = new Point(225, 36);
            lblRecentStatus2.Name = "lblRecentStatus2";
            lblRecentStatus2.Size = new Size(82, 21);
            lblRecentStatus2.TabIndex = 3;
            lblRecentStatus2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // recentRow3
            // 
            recentRow3.BackColor = Color.FromArgb(249, 251, 254);
            recentRow3.Controls.Add(lblRecentCar3);
            recentRow3.Controls.Add(lblRecentDate3);
            recentRow3.Controls.Add(lblRecentAmount3);
            recentRow3.Controls.Add(lblRecentStatus3);
            recentRow3.Location = new Point(15, 209);
            recentRow3.Name = "recentRow3";
            recentRow3.Size = new Size(320, 72);
            recentRow3.TabIndex = 4;
            // 
            // lblRecentCar3
            // 
            lblRecentCar3.AutoSize = true;
            lblRecentCar3.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblRecentCar3.ForeColor = Color.FromArgb(15, 39, 72);
            lblRecentCar3.Location = new Point(12, 9);
            lblRecentCar3.Name = "lblRecentCar3";
            lblRecentCar3.Size = new Size(91, 20);
            lblRecentCar3.TabIndex = 0;
            lblRecentCar3.Text = "No booking";
            // 
            // lblRecentDate3
            // 
            lblRecentDate3.AutoSize = true;
            lblRecentDate3.Font = new Font("Segoe UI", 7.5F);
            lblRecentDate3.ForeColor = Color.FromArgb(84, 105, 130);
            lblRecentDate3.Location = new Point(12, 35);
            lblRecentDate3.Name = "lblRecentDate3";
            lblRecentDate3.Size = new Size(118, 17);
            lblRecentDate3.TabIndex = 1;
            lblRecentDate3.Text = "No recent booking";
            // 
            // lblRecentAmount3
            // 
            lblRecentAmount3.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblRecentAmount3.ForeColor = Color.FromArgb(15, 39, 72);
            lblRecentAmount3.Location = new Point(225, 9);
            lblRecentAmount3.Name = "lblRecentAmount3";
            lblRecentAmount3.Size = new Size(82, 22);
            lblRecentAmount3.TabIndex = 2;
            lblRecentAmount3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRecentStatus3
            // 
            lblRecentStatus3.BackColor = Color.FromArgb(218, 247, 232);
            lblRecentStatus3.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            lblRecentStatus3.ForeColor = Color.FromArgb(12, 122, 74);
            lblRecentStatus3.Location = new Point(225, 36);
            lblRecentStatus3.Name = "lblRecentStatus3";
            lblRecentStatus3.Size = new Size(82, 21);
            lblRecentStatus3.TabIndex = 3;
            lblRecentStatus3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // promoPanel
            // 
            promoPanel.BackColor = Color.FromArgb(25, 87, 137);
            promoPanel.Controls.Add(lblPromoTitle);
            promoPanel.Controls.Add(lblPromoText);
            promoPanel.Controls.Add(btnPromoBrowse);
            promoPanel.Location = new Point(30, 735);
            promoPanel.Name = "promoPanel";
            promoPanel.Size = new Size(1070, 105);
            promoPanel.TabIndex = 13;
            // 
            // lblPromoTitle
            // 
            lblPromoTitle.AutoSize = true;
            lblPromoTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblPromoTitle.ForeColor = Color.White;
            lblPromoTitle.Location = new Point(20, 18);
            lblPromoTitle.Name = "lblPromoTitle";
            lblPromoTitle.Size = new Size(255, 28);
            lblPromoTitle.TabIndex = 0;
            lblPromoTitle.Text = "Ready for Your Next Trip?";
            // 
            // lblPromoText
            // 
            lblPromoText.Font = new Font("Segoe UI", 8.5F);
            lblPromoText.ForeColor = Color.FromArgb(224, 237, 249);
            lblPromoText.Location = new Point(20, 48);
            lblPromoText.Name = "lblPromoText";
            lblPromoText.Size = new Size(720, 32);
            lblPromoText.TabIndex = 1;
            lblPromoText.Text = "Discover new destinations with our wide selection of vehicles.";
            // 
            // btnPromoBrowse
            // 
            btnPromoBrowse.BackColor = Color.White;
            btnPromoBrowse.FlatAppearance.BorderSize = 0;
            btnPromoBrowse.FlatStyle = FlatStyle.Flat;
            btnPromoBrowse.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnPromoBrowse.ForeColor = Color.FromArgb(25, 87, 137);
            btnPromoBrowse.Location = new Point(900, 32);
            btnPromoBrowse.Name = "btnPromoBrowse";
            btnPromoBrowse.Size = new Size(145, 36);
            btnPromoBrowse.TabIndex = 2;
            btnPromoBrowse.Text = "Browse Cars →";
            btnPromoBrowse.UseVisualStyleBackColor = false;
            btnPromoBrowse.Click += btnPromoBrowse_Click;
            // 
            // CustomerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 248, 252);
            ClientSize = new Size(1370, 900);
            Controls.Add(contentPanel);
            Controls.Add(sidebarPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CustomerDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Dashboard - Car Rental Management System";
            sidebarPanel.ResumeLayout(false);
            sidebarPanel.PerformLayout();
            contentPanel.ResumeLayout(false);
            contentPanel.PerformLayout();
            heroPanel.ResumeLayout(false);
            heroPanel.PerformLayout();
            cardAvailable.ResumeLayout(false);
            cardAvailable.PerformLayout();
            cardBookings.ResumeLayout(false);
            cardBookings.PerformLayout();
            cardActive.ResumeLayout(false);
            cardActive.PerformLayout();
            cardFavorites.ResumeLayout(false);
            cardFavorites.PerformLayout();
            featuredPanel.ResumeLayout(false);
            featuredPanel.PerformLayout();
            featuredCard1.ResumeLayout(false);
            featuredCard1.PerformLayout();
            featuredCard2.ResumeLayout(false);
            featuredCard2.PerformLayout();
            featuredCard3.ResumeLayout(false);
            featuredCard3.PerformLayout();
            recentPanel.ResumeLayout(false);
            recentPanel.PerformLayout();
            recentRow1.ResumeLayout(false);
            recentRow1.PerformLayout();
            recentRow2.ResumeLayout(false);
            recentRow2.PerformLayout();
            recentRow3.ResumeLayout(false);
            recentRow3.PerformLayout();
            promoPanel.ResumeLayout(false);
            promoPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
    }

}