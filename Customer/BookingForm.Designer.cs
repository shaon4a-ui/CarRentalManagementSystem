using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customer
{
    partial class BookingForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerPanel;
        private Button btnBack;
        private Label lblPageTitle;
        private Label lblSubtitle;

        private Panel mainPanel;
        private Panel carInfoPanel;
        private PictureBox picCar;
        private Label lblCarName;
        private Label lblCarType;
        private Label lblCarSeats;
        private Label lblCarLocation;
        private Label lblPricePerDay;

        private Panel bookingPanel;
        private Label lblBookingTitle;
        private Label lblStartDate;
        private DateTimePicker dtpStartDate;
        private Label lblReturnDate;
        private DateTimePicker dtpReturnDate;
        private Label lblAvailability;
        private Label lblDaysTitle;
        private Label lblDays;
        private Label lblTotalTitle;
        private Label lblTotal;

        private Panel summaryPanel;
        private Label lblSummaryTitle;
        private Label lblSummaryCar;
        private Label lblSummaryDates;
        private Label lblSummaryDuration;
        private Label lblSummaryAmount;

        private Button btnConfirmBooking;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            headerPanel = new Panel();
            btnBack = new Button();
            lblPageTitle = new Label();
            lblSubtitle = new Label();

            mainPanel = new Panel();
            carInfoPanel = new Panel();
            picCar = new PictureBox();
            lblCarName = new Label();
            lblCarType = new Label();
            lblCarSeats = new Label();
            lblCarLocation = new Label();
            lblPricePerDay = new Label();

            bookingPanel = new Panel();
            lblBookingTitle = new Label();
            lblStartDate = new Label();
            dtpStartDate = new DateTimePicker();
            lblReturnDate = new Label();
            dtpReturnDate = new DateTimePicker();
            lblAvailability = new Label();
            lblDaysTitle = new Label();
            lblDays = new Label();
            lblTotalTitle = new Label();
            lblTotal = new Label();

            summaryPanel = new Panel();
            lblSummaryTitle = new Label();
            lblSummaryCar = new Label();
            lblSummaryDates = new Label();
            lblSummaryDuration = new Label();
            lblSummaryAmount = new Label();

            btnConfirmBooking = new Button();
            btnCancel = new Button();

            headerPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            carInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            bookingPanel.SuspendLayout();
            summaryPanel.SuspendLayout();
            SuspendLayout();

            // BookingForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 248, 252);
            ClientSize = new Size(1180, 820);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "BookingForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book a Car";

            // Header
            headerPanel.BackColor = Color.FromArgb(15, 39, 72);
            headerPanel.Controls.Add(btnBack);
            headerPanel.Controls.Add(lblPageTitle);
            headerPanel.Controls.Add(lblSubtitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Size = new Size(1180, 86);

            btnBack.BackColor = Color.Transparent;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(25, 22);
            btnBack.Size = new Size(100, 42);
            btnBack.Text = "←  Back";
            btnBack.UseVisualStyleBackColor = false;

            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(490, 12);
            lblPageTitle.Text = "Book a Car";

            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(210, 222, 237);
            lblSubtitle.Location = new Point(418, 54);
            lblSubtitle.Text = "Choose your rental dates and confirm your booking";

            // Main
            mainPanel.BackColor = Color.FromArgb(244, 248, 252);
            mainPanel.Controls.Add(carInfoPanel);
            mainPanel.Controls.Add(bookingPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Padding = new Padding(35, 30, 35, 30);

            // Car card
            carInfoPanel.BackColor = Color.White;
            carInfoPanel.Controls.Add(picCar);
            carInfoPanel.Controls.Add(lblCarName);
            carInfoPanel.Controls.Add(lblCarType);
            carInfoPanel.Controls.Add(lblCarSeats);
            carInfoPanel.Controls.Add(lblCarLocation);
            carInfoPanel.Controls.Add(lblPricePerDay);
            carInfoPanel.Location = new Point(35, 30);
            carInfoPanel.Size = new Size(530, 674);

            picCar.BackColor = Color.FromArgb(239, 244, 250);
            picCar.Location = new Point(22, 22);
            picCar.Name = "picCar";
            picCar.Size = new Size(486, 330);
            picCar.SizeMode = PictureBoxSizeMode.Zoom;
            picCar.TabStop = false;

            lblCarName.AutoSize = false;
            lblCarName.Font = new Font("Segoe UI", 21F, FontStyle.Bold);
            lblCarName.ForeColor = Color.FromArgb(15, 39, 72);
            lblCarName.Location = new Point(22, 370);
            lblCarName.Size = new Size(486, 45);
            lblCarName.Text = "Toyota Corolla";

            lblCarType.AutoSize = true;
            lblCarType.Font = new Font("Segoe UI", 10F);
            lblCarType.ForeColor = Color.FromArgb(82, 95, 111);
            lblCarType.Location = new Point(22, 425);
            lblCarType.Text = "Type: Sedan";

            lblCarSeats.AutoSize = true;
            lblCarSeats.Font = new Font("Segoe UI", 10F);
            lblCarSeats.ForeColor = Color.FromArgb(82, 95, 111);
            lblCarSeats.Location = new Point(275, 425);
            lblCarSeats.Text = "Seats: 5";

            lblCarLocation.AutoSize = true;
            lblCarLocation.Font = new Font("Segoe UI", 10F);
            lblCarLocation.ForeColor = Color.FromArgb(82, 95, 111);
            lblCarLocation.Location = new Point(22, 460);
            lblCarLocation.Text = "Location: Dhaka";

            lblPricePerDay.AutoSize = true;
            lblPricePerDay.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblPricePerDay.ForeColor = Color.FromArgb(30, 136, 255);
            lblPricePerDay.Location = new Point(22, 505);
            lblPricePerDay.Text = "৳2,500 / day";

            // Booking card
            bookingPanel.BackColor = Color.White;
            bookingPanel.Controls.Add(lblBookingTitle);
            bookingPanel.Controls.Add(lblStartDate);
            bookingPanel.Controls.Add(dtpStartDate);
            bookingPanel.Controls.Add(lblReturnDate);
            bookingPanel.Controls.Add(dtpReturnDate);
            bookingPanel.Controls.Add(lblAvailability);
            bookingPanel.Controls.Add(lblDaysTitle);
            bookingPanel.Controls.Add(lblDays);
            bookingPanel.Controls.Add(lblTotalTitle);
            bookingPanel.Controls.Add(lblTotal);
            bookingPanel.Controls.Add(summaryPanel);
            bookingPanel.Controls.Add(btnConfirmBooking);
            bookingPanel.Controls.Add(btnCancel);
            bookingPanel.Location = new Point(595, 30);
            bookingPanel.Size = new Size(550, 674);

            lblBookingTitle.AutoSize = true;
            lblBookingTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblBookingTitle.ForeColor = Color.FromArgb(15, 39, 72);
            lblBookingTitle.Location = new Point(28, 24);
            lblBookingTitle.Text = "Rental Details";

            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStartDate.ForeColor = Color.FromArgb(55, 65, 81);
            lblStartDate.Location = new Point(28, 78);
            lblStartDate.Text = "Rental Start Date";

            dtpStartDate.Font = new Font("Segoe UI", 10F);
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(28, 108);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(494, 30);
            dtpStartDate.Value = DateTime.Today;
            dtpStartDate.MinDate = DateTime.Today;

            lblReturnDate.AutoSize = true;
            lblReturnDate.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblReturnDate.ForeColor = Color.FromArgb(55, 65, 81);
            lblReturnDate.Location = new Point(28, 157);
            lblReturnDate.Text = "Rental Return Date";

            dtpReturnDate.Font = new Font("Segoe UI", 10F);
            dtpReturnDate.Format = DateTimePickerFormat.Short;
            dtpReturnDate.Location = new Point(28, 187);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(494, 30);
            dtpReturnDate.Value = DateTime.Today.AddDays(1);
            dtpReturnDate.MinDate = DateTime.Today;

            lblAvailability.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAvailability.ForeColor = Color.FromArgb(22, 163, 74);
            lblAvailability.Location = new Point(28, 230);
            lblAvailability.Size = new Size(494, 28);
            lblAvailability.Text = "Checking availability...";

            lblDaysTitle.AutoSize = true;
            lblDaysTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblDaysTitle.ForeColor = Color.FromArgb(82, 95, 111);
            lblDaysTitle.Location = new Point(28, 270);
            lblDaysTitle.Text = "Rental Duration";

            lblDays.AutoSize = true;
            lblDays.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDays.ForeColor = Color.FromArgb(15, 39, 72);
            lblDays.Location = new Point(180, 267);
            lblDays.Text = "1 day";

            lblTotalTitle.AutoSize = true;
            lblTotalTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTotalTitle.ForeColor = Color.FromArgb(82, 95, 111);
            lblTotalTitle.Location = new Point(28, 307);
            lblTotalTitle.Text = "Total Amount";

            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(30, 136, 255);
            lblTotal.Location = new Point(180, 300);
            lblTotal.Text = "৳2,500";

            // Summary
            summaryPanel.BackColor = Color.FromArgb(244, 248, 252);
            summaryPanel.Controls.Add(lblSummaryTitle);
            summaryPanel.Controls.Add(lblSummaryCar);
            summaryPanel.Controls.Add(lblSummaryDates);
            summaryPanel.Controls.Add(lblSummaryDuration);
            summaryPanel.Controls.Add(lblSummaryAmount);
            summaryPanel.Location = new Point(28, 350);
            summaryPanel.Size = new Size(494, 100);

            lblSummaryTitle.AutoSize = true;
            lblSummaryTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSummaryTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblSummaryTitle.Location = new Point(14, 9);
            lblSummaryTitle.Text = "BOOKING SUMMARY";

            lblSummaryCar.AutoSize = true;
            lblSummaryCar.Font = new Font("Segoe UI", 9F);
            lblSummaryCar.ForeColor = Color.FromArgb(55, 65, 81);
            lblSummaryCar.Location = new Point(14, 31);
            lblSummaryCar.Text = "Car: -";

            lblSummaryDates.AutoSize = true;
            lblSummaryDates.Font = new Font("Segoe UI", 9F);
            lblSummaryDates.ForeColor = Color.FromArgb(55, 65, 81);
            lblSummaryDates.Location = new Point(14, 56);
            lblSummaryDates.Text = "Dates: -";

            lblSummaryDuration.AutoSize = true;
            lblSummaryDuration.Font = new Font("Segoe UI", 9F);
            lblSummaryDuration.ForeColor = Color.FromArgb(55, 65, 81);
            lblSummaryDuration.Location = new Point(270, 31);
            lblSummaryDuration.Text = "Duration: -";

            lblSummaryAmount.AutoSize = true;
            lblSummaryAmount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSummaryAmount.ForeColor = Color.FromArgb(30, 136, 255);
            lblSummaryAmount.Location = new Point(270, 56);
            lblSummaryAmount.Text = "Amount: ৳0";

            btnConfirmBooking.BackColor = Color.FromArgb(30, 136, 255);
            btnConfirmBooking.Cursor = Cursors.Hand;
            btnConfirmBooking.FlatAppearance.BorderSize = 0;
            btnConfirmBooking.FlatStyle = FlatStyle.Flat;
            btnConfirmBooking.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnConfirmBooking.ForeColor = Color.White;
            btnConfirmBooking.Location = new Point(28, 490);
            btnConfirmBooking.Name = "btnConfirmBooking";
            btnConfirmBooking.Size = new Size(310, 54);
            btnConfirmBooking.Text = "Continue to Payment";
            btnConfirmBooking.UseVisualStyleBackColor = false;
            btnConfirmBooking.Click += btnConfirmBooking_Click;

            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(210, 218, 228);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(55, 65, 81);
            btnCancel.Location = new Point(352, 490);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(170, 54);
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;

            Controls.Add(mainPanel);
            Controls.Add(headerPanel);

            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            carInfoPanel.ResumeLayout(false);
            carInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            bookingPanel.ResumeLayout(false);
            bookingPanel.PerformLayout();
            summaryPanel.ResumeLayout(false);
            summaryPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}
