using System;
using System.Data;
using System.Drawing;
using System.IO;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using CarRentalManagementSystem.Database;

namespace CarRentalManagementSystem.Owner
{
    public partial class MyCarsForm : Form
    {
        private readonly int ownerID;
        private readonly DatabaseHelper db = new DatabaseHelper();

        public MyCarsForm(int ownerID)
        {
            InitializeComponent();
            this.ownerID = ownerID;
        }

        private void MyCarsForm_Load(object sender, EventArgs e)
        {
            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;

            if (cmbVehicleType.Items.Count > 0)
                cmbVehicleType.SelectedIndex = 0;

            if (cmbSort.Items.Count > 0)
                cmbSort.SelectedIndex = 0;

            LoadOwnerName();
            LoadCars();
        }

        private void LoadOwnerName()
        {
            try
            {
                using SqlConnection con = db.GetConnection();
                con.Open();

                const string query = @"
                    SELECT FullName, Username
                    FROM Users
                    WHERE UserID = @UserID";

                using SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@UserID", ownerID);

                using SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string fullName = reader["FullName"]?.ToString() ?? "";
                    string username = reader["Username"]?.ToString() ?? "";

                    lblOwnerName.Text =
                        string.IsNullOrWhiteSpace(fullName) ? username : fullName;
                }
            }
            catch
            {
                lblOwnerName.Text = "Owner";
            }
        }

        private void LoadCars()
        {
            try
            {
                using SqlConnection con = db.GetConnection();
                con.Open();

                string sortExpression = "VehicleID DESC";

                if (cmbSort.SelectedItem?.ToString() == "Price: Low to High")
                    sortExpression = "PricePerDay ASC";
                else if (cmbSort.SelectedItem?.ToString() == "Price: High to Low")
                    sortExpression = "PricePerDay DESC";
                else if (cmbSort.SelectedItem?.ToString() == "Year: Newest")
                    sortExpression = "Year DESC";
                else if (cmbSort.SelectedItem?.ToString() == "Year: Oldest")
                    sortExpression = "Year ASC";

                string query = $@"
                    SELECT
                        VehicleID,
                        Brand,
                        Model,
                        VehicleType,
                        Year,
                        Seats,
                        Location,
                        PricePerDay,
                        AvailabilityStatus,
                        ImagePath
                    FROM Vehicles
                    WHERE OwnerID = @OwnerID
                      AND (
                            @Search = ''
                            OR Brand LIKE '%' + @Search + '%'
                            OR Model LIKE '%' + @Search + '%'
                            OR Location LIKE '%' + @Search + '%'
                            OR VehicleType LIKE '%' + @Search + '%'
                          )
                      AND (@Status = 'All Status' OR AvailabilityStatus = @Status)
                      AND (@VehicleType = 'All Types' OR VehicleType = @VehicleType)
                    ORDER BY {sortExpression}";

                using SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@OwnerID", ownerID);
                cmd.Parameters.AddWithValue("@Search", txtSearch.Text.Trim());
                cmd.Parameters.AddWithValue(
                    "@Status",
                    cmbStatus.SelectedItem?.ToString() ?? "All Status");
                cmd.Parameters.AddWithValue(
                    "@VehicleType",
                    cmbVehicleType.SelectedItem?.ToString() ?? "All Types");

                using SqlDataReader reader = cmd.ExecuteReader();

                dgvCars.Rows.Clear();

                while (reader.Read())
                {
                    int rowIndex = dgvCars.Rows.Add();

                    DataGridViewRow row = dgvCars.Rows[rowIndex];

                    row.Cells["colVehicleID"].Value =
                        Convert.ToInt32(reader["VehicleID"]);

                    row.Cells["colImage"].Value =
                        CreateThumbnail(reader["ImagePath"]?.ToString() ?? "");

                    row.Cells["colBrandModel"].Value =
                        $"{reader["Brand"]} {reader["Model"]}";

                    row.Cells["colVehicleType"].Value =
                        reader["VehicleType"]?.ToString() ?? "";

                    row.Cells["colYear"].Value =
                        reader["Year"];

                    row.Cells["colSeats"].Value =
                        reader["Seats"];

                    row.Cells["colLocation"].Value =
                        reader["Location"]?.ToString() ?? "";

                    row.Cells["colPrice"].Value =
                        Convert.ToDecimal(reader["PricePerDay"]).ToString("N0");

                    row.Cells["colStatus"].Value =
                        reader["AvailabilityStatus"]?.ToString() ?? "";
                }

                lblResults.Text =
                    $"{dgvCars.Rows.Count} vehicle{(dgvCars.Rows.Count == 1 ? "" : "s")}";

                LoadStatistics();
                ApplyStatusColors();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load cars.\n\n" + ex.Message,
                    "My Cars",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private Image CreateThumbnail(string imagePath)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(imagePath))
                    return CreatePlaceholderImage();

                string fullPath = imagePath;

                if (!Path.IsPathRooted(fullPath))
                {
                    fullPath = Path.Combine(
                        AppContext.BaseDirectory,
                        imagePath.Replace(
                            "/",
                            Path.DirectorySeparatorChar.ToString()));
                }

                if (!File.Exists(fullPath))
                    return CreatePlaceholderImage();

                using FileStream stream = new FileStream(
                    fullPath,
                    FileMode.Open,
                    FileAccess.Read);

                using Image original = Image.FromStream(stream);

                return new Bitmap(
                    original,
                    new Size(72, 48));
            }
            catch
            {
                return CreatePlaceholderImage();
            }
        }

        private Bitmap CreatePlaceholderImage()
        {
            Bitmap bitmap = new Bitmap(72, 48);

            using Graphics graphics = Graphics.FromImage(bitmap);

            graphics.Clear(Color.FromArgb(238, 244, 251));

            using Font font = new Font(
                "Segoe UI Emoji",
                18F,
                FontStyle.Regular);

            using SolidBrush brush =
                new SolidBrush(Color.FromArgb(30, 136, 255));

            string text = "🚗";

            SizeF size = graphics.MeasureString(text, font);

            graphics.DrawString(
                text,
                font,
                brush,
                (72 - size.Width) / 2,
                (48 - size.Height) / 2);

            return bitmap;
        }

        private void LoadStatistics()
        {
            try
            {
                using SqlConnection con = db.GetConnection();
                con.Open();

                const string totalQuery = @"
                    SELECT COUNT(*)
                    FROM Vehicles
                    WHERE OwnerID = @OwnerID";

                const string availableQuery = @"
                    SELECT COUNT(*)
                    FROM Vehicles
                    WHERE OwnerID = @OwnerID
                      AND AvailabilityStatus = 'Available'";

                const string rentedQuery = @"
                    SELECT COUNT(DISTINCT b.VehicleID)
                    FROM Bookings b
                    INNER JOIN Vehicles v ON b.VehicleID = v.VehicleID
                    WHERE v.OwnerID = @OwnerID
                      AND b.BookingStatus = 'Confirmed'
                      AND b.StartDate <= CAST(GETDATE() AS DATE)
                      AND b.EndDate > CAST(GETDATE() AS DATE)";

                const string inactiveQuery = @"
                    SELECT COUNT(*)
                    FROM Vehicles
                    WHERE OwnerID = @OwnerID
                      AND AvailabilityStatus = 'Inactive'";

                lblTotalCarsValue.Text =
                    ExecuteCount(con, totalQuery).ToString();

                lblAvailableCarsValue.Text =
                    ExecuteCount(con, availableQuery).ToString();

                lblRentedCarsValue.Text =
                    ExecuteCount(con, rentedQuery).ToString();

                lblInactiveCarsValue.Text =
                    ExecuteCount(con, inactiveQuery).ToString();
            }
            catch
            {
                lblTotalCarsValue.Text = "0";
                lblAvailableCarsValue.Text = "0";
                lblRentedCarsValue.Text = "0";
                lblInactiveCarsValue.Text = "0";
            }
        }

        private int ExecuteCount(SqlConnection con, string query)
        {
            using SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@OwnerID", ownerID);

            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        private void ApplyStatusColors()
        {
            foreach (DataGridViewRow row in dgvCars.Rows)
            {
                if (row.Cells["colStatus"].Value == null)
                    continue;

                string status =
                    row.Cells["colStatus"].Value.ToString() ?? "";

                if (status.Equals(
                    "Available",
                    StringComparison.OrdinalIgnoreCase))
                {
                    row.Cells["colStatus"].Style.BackColor =
                        Color.FromArgb(220, 252, 231);

                    row.Cells["colStatus"].Style.ForeColor =
                        Color.FromArgb(22, 101, 52);
                }
                else if (status.Equals(
                    "Maintenance",
                    StringComparison.OrdinalIgnoreCase))
                {
                    row.Cells["colStatus"].Style.BackColor =
                        Color.FromArgb(254, 243, 199);

                    row.Cells["colStatus"].Style.ForeColor =
                        Color.FromArgb(146, 64, 14);
                }
                else
                {
                    row.Cells["colStatus"].Style.BackColor =
                        Color.FromArgb(254, 226, 226);

                    row.Cells["colStatus"].Style.ForeColor =
                        Color.FromArgb(153, 27, 27);
                }

                row.Cells["colStatus"].Style.SelectionBackColor =
                    row.Cells["colStatus"].Style.BackColor;

                row.Cells["colStatus"].Style.SelectionForeColor =
                    row.Cells["colStatus"].Style.ForeColor;
            }
        }

        private int GetSelectedVehicleID()
        {
            if (dgvCars.CurrentRow == null)
                return -1;

            if (dgvCars.CurrentRow.Cells["colVehicleID"].Value == null)
                return -1;

            return Convert.ToInt32(
                dgvCars.CurrentRow.Cells["colVehicleID"].Value);
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            using AddEditCarForm form = new AddEditCarForm(ownerID);

            form.ShowDialog();

            LoadCars();
        }

        private void btnViewCar_Click(object sender, EventArgs e)
        {
            int vehicleID = GetSelectedVehicleID();

            if (vehicleID < 0)
            {
                MessageBox.Show(
                    "Please select a car first.",
                    "View Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            DataGridViewRow row = dgvCars.CurrentRow;

            string brandModel =
                row.Cells["colBrandModel"].Value?.ToString() ?? "";

            string type =
                row.Cells["colVehicleType"].Value?.ToString() ?? "";

            string year =
                row.Cells["colYear"].Value?.ToString() ?? "";

            string seats =
                row.Cells["colSeats"].Value?.ToString() ?? "";

            string location =
                row.Cells["colLocation"].Value?.ToString() ?? "";

            string price =
                row.Cells["colPrice"].Value?.ToString() ?? "";

            string status =
                row.Cells["colStatus"].Value?.ToString() ?? "";

            MessageBox.Show(
                $"Vehicle Details\n\n" +
                $"Car: {brandModel}\n" +
                $"Type: {type}\n" +
                $"Year: {year}\n" +
                $"Seats: {seats}\n" +
                $"Location: {location}\n" +
                $"Price per day: ৳{price}\n" +
                $"Status: {status}",
                "Car Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnEditCar_Click(object sender, EventArgs e)
        {
            int vehicleID = GetSelectedVehicleID();

            if (vehicleID < 0)
            {
                MessageBox.Show(
                    "Please select a car first.",
                    "Edit Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            using AddEditCarForm form =
                new AddEditCarForm(ownerID, vehicleID);

            form.ShowDialog();

            LoadCars();
        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            int vehicleID = GetSelectedVehicleID();

            if (vehicleID < 0)
            {
                MessageBox.Show(
                    "Please select a car first.",
                    "Remove Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            string brandModel =
                dgvCars.CurrentRow.Cells["colBrandModel"].Value?.ToString() ?? "this car";

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to remove {brandModel}?",
                "Remove Car",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            try
            {
                using SqlConnection con = db.GetConnection();
                con.Open();

                const string checkQuery = @"
                    SELECT COUNT(*)
                    FROM Bookings
                    WHERE VehicleID = @VehicleID";

                using SqlCommand checkCmd =
                    new SqlCommand(checkQuery, con);

                checkCmd.Parameters.AddWithValue("@VehicleID", vehicleID);

                int bookingCount =
                    Convert.ToInt32(checkCmd.ExecuteScalar());

                if (bookingCount > 0)
                {
                    MessageBox.Show(
                        "This car has booking records and cannot be deleted.\n\n" +
                        "You can edit the car and change its status to Inactive instead.",
                        "Cannot Remove Car",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                const string deleteQuery = @"
                    DELETE FROM Vehicles
                    WHERE VehicleID = @VehicleID
                      AND OwnerID = @OwnerID";

                using SqlCommand deleteCmd =
                    new SqlCommand(deleteQuery, con);

                deleteCmd.Parameters.AddWithValue("@VehicleID", vehicleID);
                deleteCmd.Parameters.AddWithValue("@OwnerID", ownerID);

                if (deleteCmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show(
                        "Car removed successfully.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    LoadCars();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not remove the car.\n\n" + ex.Message,
                    "Remove Car",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCars();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;

            if (cmbVehicleType.Items.Count > 0)
                cmbVehicleType.SelectedIndex = 0;

            if (cmbSort.Items.Count > 0)
                cmbSort.SelectedIndex = 0;

            LoadCars();
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated)
                LoadCars();
        }

        private void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated)
                LoadCars();
        }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsHandleCreated)
                LoadCars();
        }

        private void dgvCars_CellDoubleClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btnViewCar_Click(sender, e);
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            foreach (DataGridViewRow row in dgvCars.Rows)
            {
                if (row.Cells["colImage"].Value is Image image)
                    image.Dispose();
            }

            base.OnFormClosed(e);
        }

        
    }
}
