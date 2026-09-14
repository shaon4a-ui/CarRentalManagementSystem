using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;
using CarRentalManagementSystem.Models;

namespace CarRentalManagementSystem.Customer
{
    public partial class BrowseCarsForm : Form
    {
        private int userID;

        private List<Vehicle> allVehicles = new List<Vehicle>();


        private List<Vehicle> filteredVehicles = new List<Vehicle>();


        public BrowseCarsForm(int userID)
        {
            InitializeComponent();

            this.userID = userID;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadCars();
        }

        private void LoadCars()
        {
            try
            {
                allVehicles = GetAvailableVehicles();


                filteredVehicles = new List<Vehicle>(allVehicles);


                DisplayCars();

                //displayed 
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load cars from the database.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private List<Vehicle> GetAvailableVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();   // creating empty list


            using SqlConnection connection = new DatabaseHelper().GetConnection();


            connection.Open();

            string query = @"
                SELECT VehicleID, OwnerID, Brand, Model, Year, VehicleType, Seats,
                       PricePerDay, AvailabilityStatus, Description, ImagePath, Location,
                       TransmissionType, DriveType, LuggageCapacity, SlidingDoors, GroundClearance
                FROM Vehicles
                WHERE AvailabilityStatus = 'Available'
                ORDER BY VehicleID";

            using SqlCommand command = new SqlCommand(query, connection);

            using SqlDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string vehicleType = reader["VehicleType"]?.ToString() ?? "";


                Vehicle vehicle = vehicleType.Trim() switch

                {
                        "Sedan" => new Sedan(),
                        "SUV" => new SUV(),
                        "Van" => new Van(),
                        "Luxury" => new Luxury(),

                        _ => throw new InvalidOperationException("Unknown vehicle type: " + vehicleType)


                };

                vehicle.VehicleID = Convert.ToInt32(reader["VehicleID"]);



                vehicle.OwnerID = Convert.ToInt32(reader["OwnerID"]);
                


                vehicle.Brand = reader["Brand"]?.ToString() ?? "";


                vehicle.Model = reader["Model"]?.ToString() ?? "";


                vehicle.Year = Convert.ToInt32(reader["Year"]);



                vehicle.VehicleType = vehicleType;


                vehicle.Seats = Convert.ToInt32(reader["Seats"]);



                vehicle.PricePerDay = Convert.ToDecimal(reader["PricePerDay"]);



                vehicle.AvailabilityStatus = reader["AvailabilityStatus"]?.ToString() ?? "";


                vehicle.Description = reader["Description"]?.ToString() ?? "";


                vehicle.ImagePath = reader["ImagePath"]?.ToString() ?? "";


                vehicle.Location = reader["Location"]?.ToString() ?? "";


                if (vehicle is Sedan sedan)
                {
                    sedan.TransmissionType = reader["TransmissionType"]?.ToString() ?? "";

                }
                else if (vehicle is SUV suv)
                {
                    suv.DriveType = reader["DriveType"]?.ToString() ?? "";

                }
                else if (vehicle is Van van)
                {
                    if (reader["LuggageCapacity"] != DBNull.Value)
                    {
                        van.LuggageCapacity = Convert.ToDecimal(reader["LuggageCapacity"]);


                    }

                    if (reader["SlidingDoors"] != DBNull.Value)
                    {
                        van.SlidingDoors = Convert.ToInt32(reader["SlidingDoors"]);


                    }
                }

                vehicles.Add(vehicle);
            }

            return vehicles;
        }

        private void DisplayCars()
        {
            Panel[] cards =
            {
                card1,
                card2,
                card3,
                card4,
                card5,
                card6
            };

            PictureBox[] pictures =
            {
                picCar1,
                picCar2,
                picCar3,
                picCar4,
                picCar5,
                picCar6
            };

            Label[] names =
            {
                lblCarName1,
                lblCarName2,
                lblCarName3,
                lblCarName4,
                lblCarName5,
                lblCarName6
            };

            Label[] information =
            {
                lblCarInfo1,
                lblCarInfo2,
                lblCarInfo3,
                lblCarInfo4,
                lblCarInfo5,
                lblCarInfo6
            };

            Label[] locations =
            {
                lblCarLocation1,
                lblCarLocation2,
                lblCarLocation3,
                lblCarLocation4,
                lblCarLocation5,
                lblCarLocation6
            };

            Label[] availability =
            {
                lblCarAvailability1,
                lblCarAvailability2,
                lblCarAvailability3,
                lblCarAvailability4,
                lblCarAvailability5,
                lblCarAvailability6
            };

            Label[] prices =
            {
                lblCarPrice1,
                lblCarPrice2,
                lblCarPrice3,
                lblCarPrice4,
                lblCarPrice5,
                lblCarPrice6
            };

            Button[] detailsButtons =
            {
                btnDetails1,
                btnDetails2,
                btnDetails3,
                btnDetails4,
                btnDetails5,
                btnDetails6
            };

            for (int i = 0; i < cards.Length; i++)
            {
                cards[i].Visible = false;
                detailsButtons[i].Tag = null;
                pictures[i].Image = null;
            }

            if (filteredVehicles.Count == 0)
            {
                lblResults.Text = "0 cars found";


                lblNoCars.Visible = true;

                return;
            }

            lblResults.Text = $"{filteredVehicles.Count} car(s) available";


            lblNoCars.Visible = false;

            int displayCount = Math.Min(filteredVehicles.Count, cards.Length);




            for (int i = 0; i < displayCount; i++)


            {
                Vehicle vehicle = filteredVehicles[i];


                names[i].Text = $"{vehicle.Brand} {vehicle.Model}";


                information[i].Text =
                    $"{vehicle.VehicleType}  •  " +
                    $"{vehicle.Seats} Seats  •  " +
                    $"{vehicle.Year}";

                locations[i].Text = $"Location: {vehicle.Location}";


                availability[i].Text = "● Available";


                prices[i].Text = $"৳{vehicle.PricePerDay:N0} / day";


                LoadCarImage(pictures[i], vehicle.ImagePath);



                detailsButtons[i].Tag = vehicle;


                cards[i].Visible = true;
            }

            carsFlowPanel.AutoScrollPosition = new Point(0, 0);


            if (filteredVehicles.Count > cards.Length)

            {
                lblResults.Text = $"{filteredVehicles.Count} car(s) available  •  " + $"Showing first {cards.Length}";


            }
        }

        private void LoadCarImage(PictureBox pictureBox, string imagePath)


        {
            try
            {
                pictureBox.Image = null;

                if (string.IsNullOrWhiteSpace(imagePath))

                {
                    return;
                }

                string cleanPath = imagePath.Replace("/", Path.DirectorySeparatorChar.ToString()).Replace("\\", Path.DirectorySeparatorChar.ToString());


                string fullPath = Path.Combine(Application.StartupPath, cleanPath);




                if (!File.Exists(fullPath))
                {
                    return;
                }

                using (FileStream stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))   //opens the image file for reading




                {
                    using (Image originalImage = Image.FromStream(stream))

                    {
                        pictureBox.Image = new Bitmap(originalImage);            

                    }
                }
            }
            catch
            {
                pictureBox.Image = null;
            }
        }

        // SEARCH

        private void btnSearch_Click(object sender, EventArgs e)


        {
            ApplySearchAndFilters();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)


        {
            if (e.KeyCode == Keys.Enter)
            {
                ApplySearchAndFilters();

                e.SuppressKeyPress = true;
            }
        }

        // APPLY FILTERS

        private void btnApplyFilters_Click(
            object sender,
            EventArgs e)
        {
            ApplySearchAndFilters();
        }

        private void ApplySearchAndFilters()
        {
            IEnumerable<Vehicle> results =
                allVehicles;

            // Search by car name

            string searchText =
                txtSearch.Text.Trim();

            if (!string.IsNullOrWhiteSpace(
                searchText))
            {
                results =
                    results.Where(v =>
                        v.Brand.Contains(
                            searchText,
                            StringComparison.OrdinalIgnoreCase)
                        ||
                        v.Model.Contains(
                            searchText,
                            StringComparison.OrdinalIgnoreCase));
            }

            // Brand

            string selectedBrand =
                cmbBrand.SelectedItem?.ToString()
                ?? "All Brands";

            if (selectedBrand != "All Brands")
            {
                results =
                    results.Where(v =>
                        v.Brand.Equals(
                            selectedBrand,
                            StringComparison.OrdinalIgnoreCase));
            }

            // Vehicle Type

            string selectedType =
                cmbVehicleType.SelectedItem?.ToString()
                ?? "All Types";

            if (selectedType != "All Types")
            {
                results =
                    results.Where(v =>
                        v.VehicleType.Equals(
                            selectedType,
                            StringComparison.OrdinalIgnoreCase));
            }

            // Seats

            string selectedSeats =
                cmbSeats.SelectedItem?.ToString()
                ?? "All Seats";

            if (selectedSeats != "All Seats")
            {
                int seats =
                    ExtractNumber(
                        selectedSeats);

                results =
                    results.Where(v =>
                        v.Seats == seats);
            }

            // Maximum Price

            string selectedPrice =
                cmbMaxPrice.SelectedItem?.ToString()
                ?? "Any Price";

            decimal? maximumPrice =
                GetMaximumPrice(
                    selectedPrice);

            if (maximumPrice.HasValue)
            {
                results =
                    results.Where(v =>
                        v.PricePerDay <=
                        maximumPrice.Value);
            }

            // Location

            string selectedLocation =
                cmbLocation.SelectedItem?.ToString()
                ?? "All Locations";

            if (selectedLocation !=
                "All Locations")
            {
                results =
                    results.Where(v =>
                        v.Location.Equals(
                            selectedLocation,
                            StringComparison.OrdinalIgnoreCase));
            }

            filteredVehicles =
                results.ToList();

            DisplayCars();
        }

        // SEAT NUMBER

        private int ExtractNumber(
            string text)
        {
            string number = "";

            foreach (char character in text)
            {
                if (char.IsDigit(character))
                {
                    number += character;
                }
            }

            if (int.TryParse(
                number,
                out int result))
            {
                return result;
            }

            return 0;
        }

        // PRICE

        private decimal? GetMaximumPrice(
            string option)
        {
            switch (option)
            {
                case "Under ৳3,000":
                    return 3000;

                case "Under ৳5,000":
                    return 5000;

                case "Under ৳7,000":
                    return 7000;

                case "Under ৳10,000":
                    return 10000;

                case "Under ৳15,000":
                    return 15000;

                default:
                    return null;
            }
        }

        // RESET FILTERS

        private void btnResetFilters_Click(
            object sender,
            EventArgs e)
        {
            txtSearch.Clear();

            cmbBrand.SelectedIndex = 0;
            cmbVehicleType.SelectedIndex = 0;
            cmbSeats.SelectedIndex = 0;
            cmbMaxPrice.SelectedIndex = 0;
            cmbLocation.SelectedIndex = 0;

            filteredVehicles =
                new List<Vehicle>(
                    allVehicles);

            DisplayCars();
        }

        // VIEW DETAILS

        private void ViewDetails_Click(
            object sender,
            EventArgs e)
        {
            Button button =
                sender as Button;

            if (button == null)
            {
                return;
            }

            Vehicle vehicle =
                button.Tag as Vehicle;

            if (vehicle == null)
            {
                return;
            }

            CarDetailsForm detailsForm =
                new CarDetailsForm(
                    vehicle,
                    userID);

            detailsForm.ShowDialog();
        }

        // BACK

        private void btnBack_Click(
            object sender,
            EventArgs e)
        {
            this.Close();
        }

        
    }
}