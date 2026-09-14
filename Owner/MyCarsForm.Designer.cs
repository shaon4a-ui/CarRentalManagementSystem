using System;
using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Owner
{
    partial class MyCarsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel mainPanel;
        private Panel headerPanel;
        private Label lblPageTitle;
        private Label lblSubtitle;
        private Label lblOwnerName;
        private Label lblOwnerRole;

        private Panel filterPanel;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblStatusFilter;
        private ComboBox cmbStatus;
        private Label lblTypeFilter;
        private ComboBox cmbVehicleType;
        private Label lblSort;
        private ComboBox cmbSort;
        private Button btnReset;

        private Panel cardTotal;
        private Panel cardTotalAccent;
        private Label lblTotalIcon;
        private Label lblTotalCarsValue;
        private Label lblTotalCaption;

        private Panel cardAvailable;
        private Panel cardAvailableAccent;
        private Label lblAvailableIcon;
        private Label lblAvailableCarsValue;
        private Label lblAvailableCaption;

        private Panel cardRented;
        private Panel cardRentedAccent;
        private Label lblRentedIcon;
        private Label lblRentedCarsValue;
        private Label lblRentedCaption;

        private Panel cardInactive;
        private Panel cardInactiveAccent;
        private Label lblInactiveIcon;
        private Label lblInactiveCarsValue;
        private Label lblInactiveCaption;

        private Panel fleetPanel;
        private Label lblFleetTitle;
        private Label lblResults;
        private Label lblSortInfo;
        private Button btnAddCar;
        private Button btnViewCar;
        private Button btnEditCar;
        private Button btnRemoveCar;
        private DataGridView dgvCars;
        private DataGridViewImageColumn colImage;
        private DataGridViewTextBoxColumn colVehicleID;
        private DataGridViewTextBoxColumn colBrandModel;
        private DataGridViewTextBoxColumn colVehicleType;
        private DataGridViewTextBoxColumn colYear;
        private DataGridViewTextBoxColumn colSeats;
        private DataGridViewTextBoxColumn colLocation;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            mainPanel = new Panel();
            fleetPanel = new Panel();
            lblFleetTitle = new Label();
            lblResults = new Label();
            lblSortInfo = new Label();
            btnAddCar = new Button();
            btnViewCar = new Button();
            btnEditCar = new Button();
            btnRemoveCar = new Button();
            dgvCars = new DataGridView();
            colImage = new DataGridViewImageColumn();
            colVehicleID = new DataGridViewTextBoxColumn();
            colBrandModel = new DataGridViewTextBoxColumn();
            colVehicleType = new DataGridViewTextBoxColumn();
            colYear = new DataGridViewTextBoxColumn();
            colSeats = new DataGridViewTextBoxColumn();
            colLocation = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            cardInactive = new Panel();
            cardInactiveAccent = new Panel();
            lblInactiveIcon = new Label();
            lblInactiveCarsValue = new Label();
            lblInactiveCaption = new Label();
            cardRented = new Panel();
            cardRentedAccent = new Panel();
            lblRentedIcon = new Label();
            lblRentedCarsValue = new Label();
            lblRentedCaption = new Label();
            cardAvailable = new Panel();
            cardAvailableAccent = new Panel();
            lblAvailableIcon = new Label();
            lblAvailableCarsValue = new Label();
            lblAvailableCaption = new Label();
            cardTotal = new Panel();
            cardTotalAccent = new Panel();
            lblTotalIcon = new Label();
            lblTotalCarsValue = new Label();
            lblTotalCaption = new Label();
            filterPanel = new Panel();
            btnReset = new Button();
            cmbSort = new ComboBox();
            lblSort = new Label();
            cmbVehicleType = new ComboBox();
            lblTypeFilter = new Label();
            cmbStatus = new ComboBox();
            lblStatusFilter = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            lblSearch = new Label();
            headerPanel = new Panel();
            lblOwnerRole = new Label();
            lblOwnerName = new Label();
            lblSubtitle = new Label();
            lblPageTitle = new Label();
            mainPanel.SuspendLayout();
            fleetPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).BeginInit();
            cardInactive.SuspendLayout();
            cardRented.SuspendLayout();
            cardAvailable.SuspendLayout();
            cardTotal.SuspendLayout();
            filterPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(238, 244, 251);
            mainPanel.Controls.Add(fleetPanel);
            mainPanel.Controls.Add(cardInactive);
            mainPanel.Controls.Add(cardRented);
            mainPanel.Controls.Add(cardAvailable);
            mainPanel.Controls.Add(cardTotal);
            mainPanel.Controls.Add(filterPanel);
            mainPanel.Controls.Add(headerPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(26, 22, 26, 22);
            mainPanel.Size = new Size(1280, 760);
            mainPanel.TabIndex = 0;
            // 
            // fleetPanel
            // 
            fleetPanel.BackColor = Color.White;
            fleetPanel.Controls.Add(lblFleetTitle);
            fleetPanel.Controls.Add(lblResults);
            fleetPanel.Controls.Add(lblSortInfo);
            fleetPanel.Controls.Add(btnAddCar);
            fleetPanel.Controls.Add(btnViewCar);
            fleetPanel.Controls.Add(btnEditCar);
            fleetPanel.Controls.Add(btnRemoveCar);
            fleetPanel.Controls.Add(dgvCars);
            fleetPanel.Location = new Point(26, 318);
            fleetPanel.Name = "fleetPanel";
            fleetPanel.Size = new Size(1228, 390);
            fleetPanel.TabIndex = 0;
            // 
            // lblFleetTitle
            // 
            lblFleetTitle.AutoSize = true;
            lblFleetTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblFleetTitle.ForeColor = Color.FromArgb(15, 39, 72);
            lblFleetTitle.Location = new Point(18, 13);
            lblFleetTitle.Name = "lblFleetTitle";
            lblFleetTitle.Size = new Size(166, 32);
            lblFleetTitle.TabIndex = 0;
            lblFleetTitle.Text = "Fleet Vehicles";
            // 
            // lblResults
            // 
            lblResults.AutoSize = true;
            lblResults.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblResults.ForeColor = Color.FromArgb(107, 114, 128);
            lblResults.Location = new Point(155, 18);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(77, 20);
            lblResults.TabIndex = 1;
            lblResults.Text = "0 vehicles";
            // 
            // lblSortInfo
            // 
            lblSortInfo.AutoSize = true;
            lblSortInfo.Font = new Font("Segoe UI", 8.5F);
            lblSortInfo.ForeColor = Color.FromArgb(107, 114, 128);
            lblSortInfo.Location = new Point(365, 20);
            lblSortInfo.Name = "lblSortInfo";
            lblSortInfo.Size = new Size(255, 20);
            lblSortInfo.TabIndex = 2;
            lblSortInfo.Text = "Double-click a vehicle to view details";
            // 
            // btnAddCar
            // 
            btnAddCar.BackColor = Color.FromArgb(16, 185, 129);
            btnAddCar.Cursor = Cursors.Hand;
            btnAddCar.FlatAppearance.BorderSize = 0;
            btnAddCar.FlatStyle = FlatStyle.Flat;
            btnAddCar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnAddCar.ForeColor = Color.White;
            btnAddCar.Location = new Point(728, 9);
            btnAddCar.Name = "btnAddCar";
            btnAddCar.Size = new Size(130, 38);
            btnAddCar.TabIndex = 3;
            btnAddCar.Text = "+ Add Car";
            btnAddCar.UseVisualStyleBackColor = false;
            btnAddCar.Click += btnAddCar_Click;
            // 
            // btnViewCar
            // 
            btnViewCar.BackColor = Color.White;
            btnViewCar.Cursor = Cursors.Hand;
            btnViewCar.FlatAppearance.BorderColor = Color.FromArgb(30, 136, 255);
            btnViewCar.FlatStyle = FlatStyle.Flat;
            btnViewCar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnViewCar.ForeColor = Color.FromArgb(30, 136, 255);
            btnViewCar.Location = new Point(864, 9);
            btnViewCar.Name = "btnViewCar";
            btnViewCar.Size = new Size(105, 38);
            btnViewCar.TabIndex = 4;
            btnViewCar.Text = "View";
            btnViewCar.UseVisualStyleBackColor = false;
            btnViewCar.Click += btnViewCar_Click;
            // 
            // btnEditCar
            // 
            btnEditCar.BackColor = Color.FromArgb(30, 136, 255);
            btnEditCar.Cursor = Cursors.Hand;
            btnEditCar.FlatAppearance.BorderSize = 0;
            btnEditCar.FlatStyle = FlatStyle.Flat;
            btnEditCar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnEditCar.ForeColor = Color.White;
            btnEditCar.Location = new Point(975, 9);
            btnEditCar.Name = "btnEditCar";
            btnEditCar.Size = new Size(105, 38);
            btnEditCar.TabIndex = 5;
            btnEditCar.Text = "Edit";
            btnEditCar.UseVisualStyleBackColor = false;
            btnEditCar.Click += btnEditCar_Click;
            // 
            // btnRemoveCar
            // 
            btnRemoveCar.BackColor = Color.FromArgb(239, 68, 68);
            btnRemoveCar.Cursor = Cursors.Hand;
            btnRemoveCar.FlatAppearance.BorderSize = 0;
            btnRemoveCar.FlatStyle = FlatStyle.Flat;
            btnRemoveCar.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            btnRemoveCar.ForeColor = Color.White;
            btnRemoveCar.Location = new Point(1086, 9);
            btnRemoveCar.Name = "btnRemoveCar";
            btnRemoveCar.Size = new Size(120, 38);
            btnRemoveCar.TabIndex = 6;
            btnRemoveCar.Text = "Remove";
            btnRemoveCar.UseVisualStyleBackColor = false;
            btnRemoveCar.Click += btnRemoveCar_Click;
            // 
            // dgvCars
            // 
            dgvCars.AllowUserToAddRows = false;
            dgvCars.AllowUserToDeleteRows = false;
            dgvCars.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(248, 250, 252);
            dgvCars.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvCars.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCars.BackgroundColor = Color.White;
            dgvCars.BorderStyle = BorderStyle.None;
            dgvCars.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvCars.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(15, 39, 72);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(15, 39, 72);
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dgvCars.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvCars.ColumnHeadersHeight = 38;
            dgvCars.Columns.AddRange(new DataGridViewColumn[] { colImage, colVehicleID, colBrandModel, colVehicleType, colYear, colSeats, colLocation, colPrice, colStatus });
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(55, 65, 81);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(15, 39, 72);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvCars.DefaultCellStyle = dataGridViewCellStyle6;
            dgvCars.EnableHeadersVisualStyles = false;
            dgvCars.GridColor = Color.FromArgb(229, 231, 235);
            dgvCars.Location = new Point(18, 56);
            dgvCars.MultiSelect = false;
            dgvCars.Name = "dgvCars";
            dgvCars.ReadOnly = true;
            dgvCars.RowHeadersVisible = false;
            dgvCars.RowHeadersWidth = 51;
            dgvCars.RowTemplate.Height = 55;
            dgvCars.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCars.Size = new Size(1192, 315);
            dgvCars.TabIndex = 7;
            dgvCars.CellDoubleClick += dgvCars_CellDoubleClick;
            // 
            // colImage
            // 
            colImage.FillWeight = 70F;
            colImage.HeaderText = "Image";
            colImage.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colImage.MinimumWidth = 6;
            colImage.Name = "colImage";
            colImage.ReadOnly = true;
            // 
            // colVehicleID
            // 
            colVehicleID.FillWeight = 45F;
            colVehicleID.HeaderText = "ID";
            colVehicleID.MinimumWidth = 6;
            colVehicleID.Name = "colVehicleID";
            colVehicleID.ReadOnly = true;
            // 
            // colBrandModel
            // 
            colBrandModel.FillWeight = 145F;
            colBrandModel.HeaderText = "Brand / Model";
            colBrandModel.MinimumWidth = 6;
            colBrandModel.Name = "colBrandModel";
            colBrandModel.ReadOnly = true;
            // 
            // colVehicleType
            // 
            colVehicleType.FillWeight = 85F;
            colVehicleType.HeaderText = "Type";
            colVehicleType.MinimumWidth = 6;
            colVehicleType.Name = "colVehicleType";
            colVehicleType.ReadOnly = true;
            // 
            // colYear
            // 
            colYear.FillWeight = 60F;
            colYear.HeaderText = "Year";
            colYear.MinimumWidth = 6;
            colYear.Name = "colYear";
            colYear.ReadOnly = true;
            // 
            // colSeats
            // 
            colSeats.FillWeight = 60F;
            colSeats.HeaderText = "Seats";
            colSeats.MinimumWidth = 6;
            colSeats.Name = "colSeats";
            colSeats.ReadOnly = true;
            // 
            // colLocation
            // 
            colLocation.HeaderText = "Location";
            colLocation.MinimumWidth = 6;
            colLocation.Name = "colLocation";
            colLocation.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.FillWeight = 90F;
            colPrice.HeaderText = "Price / Day";
            colPrice.MinimumWidth = 6;
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.FillWeight = 90F;
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // cardInactive
            // 
            cardInactive.BackColor = Color.White;
            cardInactive.Controls.Add(cardInactiveAccent);
            cardInactive.Controls.Add(lblInactiveIcon);
            cardInactive.Controls.Add(lblInactiveCarsValue);
            cardInactive.Controls.Add(lblInactiveCaption);
            cardInactive.Location = new Point(953, 226);
            cardInactive.Name = "cardInactive";
            cardInactive.Size = new Size(301, 76);
            cardInactive.TabIndex = 1;
            // 
            // cardInactiveAccent
            // 
            cardInactiveAccent.BackColor = Color.FromArgb(239, 68, 68);
            cardInactiveAccent.Location = new Point(0, 0);
            cardInactiveAccent.Name = "cardInactiveAccent";
            cardInactiveAccent.Size = new Size(5, 76);
            cardInactiveAccent.TabIndex = 0;
            // 
            // lblInactiveIcon
            // 
            lblInactiveIcon.AutoSize = true;
            lblInactiveIcon.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblInactiveIcon.ForeColor = Color.FromArgb(239, 68, 68);
            lblInactiveIcon.Location = new Point(18, 14);
            lblInactiveIcon.Name = "lblInactiveIcon";
            lblInactiveIcon.Size = new Size(44, 46);
            lblInactiveIcon.TabIndex = 1;
            lblInactiveIcon.Text = "×";
            // 
            // lblInactiveCarsValue
            // 
            lblInactiveCarsValue.AutoSize = true;
            lblInactiveCarsValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblInactiveCarsValue.ForeColor = Color.FromArgb(15, 39, 72);
            lblInactiveCarsValue.Location = new Point(103, 2);
            lblInactiveCarsValue.Name = "lblInactiveCarsValue";
            lblInactiveCarsValue.Size = new Size(35, 41);
            lblInactiveCarsValue.TabIndex = 2;
            lblInactiveCarsValue.Text = "0";
            // 
            // lblInactiveCaption
            // 
            lblInactiveCaption.AutoSize = true;
            lblInactiveCaption.Font = new Font("Segoe UI", 8.5F);
            lblInactiveCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblInactiveCaption.Location = new Point(93, 43);
            lblInactiveCaption.Name = "lblInactiveCaption";
            lblInactiveCaption.Size = new Size(60, 20);
            lblInactiveCaption.TabIndex = 3;
            lblInactiveCaption.Text = "Inactive";
            // 
            // cardRented
            // 
            cardRented.BackColor = Color.White;
            cardRented.Controls.Add(cardRentedAccent);
            cardRented.Controls.Add(lblRentedIcon);
            cardRented.Controls.Add(lblRentedCarsValue);
            cardRented.Controls.Add(lblRentedCaption);
            cardRented.Location = new Point(644, 226);
            cardRented.Name = "cardRented";
            cardRented.Size = new Size(293, 76);
            cardRented.TabIndex = 2;
            // 
            // cardRentedAccent
            // 
            cardRentedAccent.BackColor = Color.FromArgb(124, 58, 237);
            cardRentedAccent.Location = new Point(0, 0);
            cardRentedAccent.Name = "cardRentedAccent";
            cardRentedAccent.Size = new Size(5, 76);
            cardRentedAccent.TabIndex = 0;
            // 
            // lblRentedIcon
            // 
            lblRentedIcon.AutoSize = true;
            lblRentedIcon.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblRentedIcon.ForeColor = Color.FromArgb(124, 58, 237);
            lblRentedIcon.Location = new Point(18, 13);
            lblRentedIcon.Name = "lblRentedIcon";
            lblRentedIcon.Size = new Size(47, 47);
            lblRentedIcon.TabIndex = 1;
            lblRentedIcon.Text = "↗";
            // 
            // lblRentedCarsValue
            // 
            lblRentedCarsValue.AutoSize = true;
            lblRentedCarsValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblRentedCarsValue.ForeColor = Color.FromArgb(15, 39, 72);
            lblRentedCarsValue.Location = new Point(126, 2);
            lblRentedCarsValue.Name = "lblRentedCarsValue";
            lblRentedCarsValue.Size = new Size(35, 41);
            lblRentedCarsValue.TabIndex = 2;
            lblRentedCarsValue.Text = "0";
            // 
            // lblRentedCaption
            // 
            lblRentedCaption.AutoSize = true;
            lblRentedCaption.Font = new Font("Segoe UI", 8.5F);
            lblRentedCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblRentedCaption.Location = new Point(91, 43);
            lblRentedCaption.Name = "lblRentedCaption";
            lblRentedCaption.Size = new Size(119, 20);
            lblRentedCaption.TabIndex = 3;
            lblRentedCaption.Text = "Currently Rented";
            // 
            // cardAvailable
            // 
            cardAvailable.BackColor = Color.White;
            cardAvailable.Controls.Add(cardAvailableAccent);
            cardAvailable.Controls.Add(lblAvailableIcon);
            cardAvailable.Controls.Add(lblAvailableCarsValue);
            cardAvailable.Controls.Add(lblAvailableCaption);
            cardAvailable.Location = new Point(335, 226);
            cardAvailable.Name = "cardAvailable";
            cardAvailable.Size = new Size(293, 76);
            cardAvailable.TabIndex = 3;
            // 
            // cardAvailableAccent
            // 
            cardAvailableAccent.BackColor = Color.FromArgb(16, 185, 129);
            cardAvailableAccent.Location = new Point(0, 0);
            cardAvailableAccent.Name = "cardAvailableAccent";
            cardAvailableAccent.Size = new Size(5, 76);
            cardAvailableAccent.TabIndex = 0;
            // 
            // lblAvailableIcon
            // 
            lblAvailableIcon.AutoSize = true;
            lblAvailableIcon.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblAvailableIcon.ForeColor = Color.FromArgb(16, 185, 129);
            lblAvailableIcon.Location = new Point(18, 13);
            lblAvailableIcon.Name = "lblAvailableIcon";
            lblAvailableIcon.Size = new Size(47, 47);
            lblAvailableIcon.TabIndex = 1;
            lblAvailableIcon.Text = "✓";
            // 
            // lblAvailableCarsValue
            // 
            lblAvailableCarsValue.AutoSize = true;
            lblAvailableCarsValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblAvailableCarsValue.ForeColor = Color.FromArgb(15, 39, 72);
            lblAvailableCarsValue.Location = new Point(122, 2);
            lblAvailableCarsValue.Name = "lblAvailableCarsValue";
            lblAvailableCarsValue.Size = new Size(35, 41);
            lblAvailableCarsValue.TabIndex = 2;
            lblAvailableCarsValue.Text = "0";
            // 
            // lblAvailableCaption
            // 
            lblAvailableCaption.AutoSize = true;
            lblAvailableCaption.Font = new Font("Segoe UI", 8.5F);
            lblAvailableCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblAvailableCaption.Location = new Point(103, 43);
            lblAvailableCaption.Name = "lblAvailableCaption";
            lblAvailableCaption.Size = new Size(71, 20);
            lblAvailableCaption.TabIndex = 3;
            lblAvailableCaption.Text = "Available";
            // 
            // cardTotal
            // 
            cardTotal.BackColor = Color.White;
            cardTotal.Controls.Add(cardTotalAccent);
            cardTotal.Controls.Add(lblTotalIcon);
            cardTotal.Controls.Add(lblTotalCarsValue);
            cardTotal.Controls.Add(lblTotalCaption);
            cardTotal.Location = new Point(26, 226);
            cardTotal.Name = "cardTotal";
            cardTotal.Size = new Size(293, 76);
            cardTotal.TabIndex = 4;
            // 
            // cardTotalAccent
            // 
            cardTotalAccent.BackColor = Color.FromArgb(30, 136, 255);
            cardTotalAccent.Location = new Point(0, 0);
            cardTotalAccent.Name = "cardTotalAccent";
            cardTotalAccent.Size = new Size(5, 76);
            cardTotalAccent.TabIndex = 0;
            // 
            // lblTotalIcon
            // 
            lblTotalIcon.AutoSize = true;
            lblTotalIcon.Font = new Font("Segoe UI Emoji", 19F);
            lblTotalIcon.ForeColor = Color.FromArgb(30, 136, 255);
            lblTotalIcon.Location = new Point(18, 17);
            lblTotalIcon.Name = "lblTotalIcon";
            lblTotalIcon.Size = new Size(63, 43);
            lblTotalIcon.TabIndex = 1;
            lblTotalIcon.Text = "🚗";
            // 
            // lblTotalCarsValue
            // 
            lblTotalCarsValue.AutoSize = true;
            lblTotalCarsValue.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTotalCarsValue.ForeColor = Color.FromArgb(15, 39, 72);
            lblTotalCarsValue.Location = new Point(127, 2);
            lblTotalCarsValue.Name = "lblTotalCarsValue";
            lblTotalCarsValue.Size = new Size(35, 41);
            lblTotalCarsValue.TabIndex = 2;
            lblTotalCarsValue.Text = "0";
            // 
            // lblTotalCaption
            // 
            lblTotalCaption.AutoSize = true;
            lblTotalCaption.Font = new Font("Segoe UI", 8.5F);
            lblTotalCaption.ForeColor = Color.FromArgb(107, 114, 128);
            lblTotalCaption.Location = new Point(104, 43);
            lblTotalCaption.Name = "lblTotalCaption";
            lblTotalCaption.Size = new Size(74, 20);
            lblTotalCaption.TabIndex = 3;
            lblTotalCaption.Text = "Total Cars";
            // 
            // filterPanel
            // 
            filterPanel.BackColor = Color.White;
            filterPanel.Controls.Add(btnReset);
            filterPanel.Controls.Add(cmbSort);
            filterPanel.Controls.Add(lblSort);
            filterPanel.Controls.Add(cmbVehicleType);
            filterPanel.Controls.Add(lblTypeFilter);
            filterPanel.Controls.Add(cmbStatus);
            filterPanel.Controls.Add(lblStatusFilter);
            filterPanel.Controls.Add(btnSearch);
            filterPanel.Controls.Add(txtSearch);
            filterPanel.Controls.Add(lblSearch);
            filterPanel.Location = new Point(26, 126);
            filterPanel.Name = "filterPanel";
            filterPanel.Size = new Size(1228, 88);
            filterPanel.TabIndex = 5;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.White;
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderColor = Color.FromArgb(209, 213, 219);
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnReset.ForeColor = Color.FromArgb(75, 85, 99);
            btnReset.Location = new Point(1080, 36);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(110, 36);
            btnReset.TabIndex = 0;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // cmbSort
            // 
            cmbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSort.Font = new Font("Segoe UI", 9.5F);
            cmbSort.Items.AddRange(new object[] { "Newest First", "Price: Low to High", "Price: High to Low", "Year: Newest", "Year: Oldest" });
            cmbSort.Location = new Point(709, 39);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(150, 29);
            cmbSort.TabIndex = 1;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
            // 
            // lblSort
            // 
            lblSort.AutoSize = true;
            lblSort.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSort.ForeColor = Color.FromArgb(75, 85, 99);
            lblSort.Location = new Point(709, 13);
            lblSort.Name = "lblSort";
            lblSort.Size = new Size(70, 20);
            lblSort.TabIndex = 2;
            lblSort.Text = "SORT BY";
            // 
            // cmbVehicleType
            // 
            cmbVehicleType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicleType.Font = new Font("Segoe UI", 9.5F);
            cmbVehicleType.Items.AddRange(new object[] { "All Types", "Sedan", "SUV", "Van", "Luxury" });
            cmbVehicleType.Location = new Point(556, 39);
            cmbVehicleType.Name = "cmbVehicleType";
            cmbVehicleType.Size = new Size(135, 29);
            cmbVehicleType.TabIndex = 3;
            cmbVehicleType.SelectedIndexChanged += cmbVehicleType_SelectedIndexChanged;
            // 
            // lblTypeFilter
            // 
            lblTypeFilter.AutoSize = true;
            lblTypeFilter.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblTypeFilter.ForeColor = Color.FromArgb(75, 85, 99);
            lblTypeFilter.Location = new Point(556, 13);
            lblTypeFilter.Name = "lblTypeFilter";
            lblTypeFilter.Size = new Size(107, 20);
            lblTypeFilter.TabIndex = 4;
            lblTypeFilter.Text = "VEHICLE TYPE";
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI", 9.5F);
            cmbStatus.Items.AddRange(new object[] { "All Status", "Available", "Maintenance", "Inactive" });
            cmbStatus.Location = new Point(403, 39);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(135, 29);
            cmbStatus.TabIndex = 5;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblStatusFilter.ForeColor = Color.FromArgb(75, 85, 99);
            lblStatusFilter.Location = new Point(403, 13);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new Size(63, 20);
            lblStatusFilter.TabIndex = 6;
            lblStatusFilter.Text = "STATUS";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(30, 136, 255);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.FlatAppearance.BorderSize = 0;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(293, 36);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 36);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 10F);
            txtSearch.Location = new Point(18, 39);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Brand, model or location...";
            txtSearch.Size = new Size(265, 30);
            txtSearch.TabIndex = 8;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSearch.ForeColor = Color.FromArgb(75, 85, 99);
            lblSearch.Location = new Point(18, 13);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(66, 20);
            lblSearch.TabIndex = 9;
            lblSearch.Text = "SEARCH";
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.White;
            headerPanel.Controls.Add(lblOwnerRole);
            headerPanel.Controls.Add(lblOwnerName);
            headerPanel.Controls.Add(lblSubtitle);
            headerPanel.Controls.Add(lblPageTitle);
            headerPanel.Location = new Point(26, 22);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1228, 92);
            headerPanel.TabIndex = 6;
            // 
            // lblOwnerRole
            // 
            lblOwnerRole.Font = new Font("Segoe UI", 8.5F);
            lblOwnerRole.ForeColor = Color.FromArgb(107, 114, 128);
            lblOwnerRole.Location = new Point(1010, 48);
            lblOwnerRole.Name = "lblOwnerRole";
            lblOwnerRole.Size = new Size(190, 20);
            lblOwnerRole.TabIndex = 0;
            lblOwnerRole.Text = "Vehicle Owner";
            lblOwnerRole.TextAlign = ContentAlignment.TopRight;
            // 
            // lblOwnerName
            // 
            lblOwnerName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblOwnerName.ForeColor = Color.FromArgb(15, 39, 72);
            lblOwnerName.Location = new Point(1010, 22);
            lblOwnerName.Name = "lblOwnerName";
            lblOwnerName.Size = new Size(190, 24);
            lblOwnerName.TabIndex = 1;
            lblOwnerName.Text = "Owner";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblSubtitle.Location = new Point(27, 57);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(331, 21);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Manage and monitor the vehicles in your fleet.";
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.FromArgb(15, 39, 72);
            lblPageTitle.Location = new Point(24, 14);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(161, 50);
            lblPageTitle.TabIndex = 3;
            lblPageTitle.Text = "My Cars";
            // 
            // MyCarsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(238, 244, 251);
            ClientSize = new Size(1280, 760);
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MyCarsForm";
            ShowInTaskbar = false;
            Text = "My Cars";
            Load += MyCarsForm_Load;
            mainPanel.ResumeLayout(false);
            fleetPanel.ResumeLayout(false);
            fleetPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCars).EndInit();
            cardInactive.ResumeLayout(false);
            cardInactive.PerformLayout();
            cardRented.ResumeLayout(false);
            cardRented.PerformLayout();
            cardAvailable.ResumeLayout(false);
            cardAvailable.PerformLayout();
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
