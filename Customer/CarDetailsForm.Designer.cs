using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customer
{
    partial class CarDetailsForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerPanel;
        private Label lblBack;
        private Label lblPageTitle;

        private Panel imagePanel;
        private PictureBox picCar;

        private Panel detailsPanel;
        private Label lblCarName;
        private Label lblCarType;
        private Label lblYear;
        private Label lblPrice;
        private Label lblStatus;
        private Label lblDescriptionTitle;
        private Label lblDescription;

        private Panel specPanel;
        private Label lblSpecTitle;
        private Label lblSpecType;
        private Label lblSpecYear;
        private Label lblSpecStatus;

        private Button btnBookNow;
        private Button btnClose;

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
            lblBack = new Label();
            lblPageTitle = new Label();

            imagePanel = new Panel();
            picCar = new PictureBox();

            detailsPanel = new Panel();
            lblCarName = new Label();
            lblCarType = new Label();
            lblYear = new Label();
            lblPrice = new Label();
            lblStatus = new Label();
            lblDescriptionTitle = new Label();
            lblDescription = new Label();

            specPanel = new Panel();
            lblSpecTitle = new Label();
            lblSpecType = new Label();
            lblSpecYear = new Label();
            lblSpecStatus = new Label();

            btnBookNow = new Button();
            btnClose = new Button();

            headerPanel.SuspendLayout();
            imagePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            detailsPanel.SuspendLayout();
            specPanel.SuspendLayout();
            SuspendLayout();

            // CarDetailsForm
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 248, 252);
            ClientSize = new Size(1180, 820);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CarDetailsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Details";

            // Header
            headerPanel.BackColor = Color.FromArgb(15, 39, 72);
            headerPanel.Controls.Add(lblBack);
            headerPanel.Controls.Add(lblPageTitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1180, 86);

            lblBack.AutoSize = true;
            lblBack.Cursor = Cursors.Hand;
            lblBack.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            lblBack.ForeColor = Color.White;
            lblBack.Location = new Point(28, 29);
            lblBack.Name = "lblBack";
            lblBack.Text = "←  Back";
            lblBack.Click += lblBack_Click;

            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(475, 23);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Text = "Car Details";

            // Image card
            imagePanel.BackColor = Color.White;
            imagePanel.Controls.Add(picCar);
            imagePanel.Location = new Point(35, 120);
            imagePanel.Name = "imagePanel";
            imagePanel.Padding = new Padding(18);
            imagePanel.Size = new Size(550, 625);

            picCar.BackColor = Color.FromArgb(239, 244, 250);
            picCar.Dock = DockStyle.Top;
            picCar.Location = new Point(18, 18);
            picCar.Name = "picCar";
            picCar.Size = new Size(514, 400);
            picCar.SizeMode = PictureBoxSizeMode.Zoom;
            picCar.TabStop = false;

            // Details card
            detailsPanel.BackColor = Color.White;
            detailsPanel.Controls.Add(lblCarName);
            detailsPanel.Controls.Add(lblCarType);
            detailsPanel.Controls.Add(lblYear);
            detailsPanel.Controls.Add(lblPrice);
            detailsPanel.Controls.Add(lblStatus);
            detailsPanel.Controls.Add(specPanel);
            detailsPanel.Controls.Add(lblDescriptionTitle);
            detailsPanel.Controls.Add(lblDescription);
            detailsPanel.Controls.Add(btnBookNow);
            detailsPanel.Controls.Add(btnClose);
            detailsPanel.Location = new Point(615, 120);
            detailsPanel.Name = "detailsPanel";
            detailsPanel.Padding = new Padding(28);
            detailsPanel.Size = new Size(530, 625);

            lblCarName.AutoSize = false;
            lblCarName.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblCarName.ForeColor = Color.FromArgb(15, 39, 72);
            lblCarName.Location = new Point(28, 25);
            lblCarName.Name = "lblCarName";
            lblCarName.Size = new Size(474, 55);
            lblCarName.Text = "Toyota Corolla";

            lblCarType.AutoSize = true;
            lblCarType.Font = new Font("Segoe UI", 10.5F);
            lblCarType.ForeColor = Color.FromArgb(95, 110, 128);
            lblCarType.Location = new Point(30, 82);
            lblCarType.Name = "lblCarType";
            lblCarType.Text = "Sedan";

            // Existing logic still writes lblYear. Keep it as a hidden compatibility label.
            lblYear.AutoSize = true;
            lblYear.Location = new Point(0, 0);
            lblYear.Name = "lblYear";
            lblYear.Text = "Year: 2024";
            lblYear.Visible = false;

            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblPrice.ForeColor = Color.FromArgb(30, 136, 255);
            lblPrice.Location = new Point(28, 116);
            lblPrice.Name = "lblPrice";
            lblPrice.Text = "৳2,500 / day";

            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblStatus.ForeColor = Color.FromArgb(22, 163, 74);
            lblStatus.Location = new Point(330, 121);
            lblStatus.Name = "lblStatus";
            lblStatus.Text = "● Available";

            // Vehicle information
            specPanel.BackColor = Color.FromArgb(244, 248, 252);
            specPanel.Controls.Add(lblSpecTitle);
            specPanel.Controls.Add(lblSpecType);
            specPanel.Controls.Add(lblSpecYear);
            specPanel.Controls.Add(lblSpecStatus);
            specPanel.Location = new Point(28, 160);
            specPanel.Name = "specPanel";
            specPanel.Size = new Size(474, 82);

            lblSpecTitle.AutoSize = true;
            lblSpecTitle.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold);
            lblSpecTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblSpecTitle.Location = new Point(15, 10);
            lblSpecTitle.Text = "VEHICLE INFORMATION";

            lblSpecType.AutoSize = true;
            lblSpecType.Font = new Font("Segoe UI", 9.5F);
            lblSpecType.ForeColor = Color.FromArgb(55, 65, 81);
            lblSpecType.Location = new Point(15, 40);
            lblSpecType.Text = "Type: Sedan";

            lblSpecYear.AutoSize = true;
            lblSpecYear.Font = new Font("Segoe UI", 9.5F);
            lblSpecYear.ForeColor = Color.FromArgb(55, 65, 81);
            lblSpecYear.Location = new Point(170, 40);
            lblSpecYear.Text = "Year: 2024";

            lblSpecStatus.AutoSize = true;
            lblSpecStatus.Font = new Font("Segoe UI", 9.5F);
            lblSpecStatus.ForeColor = Color.FromArgb(55, 65, 81);
            lblSpecStatus.Location = new Point(300, 40);
            lblSpecStatus.Text = "Status: Available";

            lblDescriptionTitle.AutoSize = true;
            lblDescriptionTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblDescriptionTitle.ForeColor = Color.FromArgb(15, 39, 72);
            lblDescriptionTitle.Location = new Point(28, 262);
            lblDescriptionTitle.Name = "lblDescriptionTitle";
            lblDescriptionTitle.Text = "About this car";

            lblDescription.AutoSize = false;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.FromArgb(82, 95, 111);
            lblDescription.Location = new Point(28, 296);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(474, 100);
            lblDescription.Text = "Comfortable and reliable vehicle.";

            btnBookNow.BackColor = Color.FromArgb(30, 136, 255);
            btnBookNow.Cursor = Cursors.Hand;
            btnBookNow.FlatAppearance.BorderSize = 0;
            btnBookNow.FlatStyle = FlatStyle.Flat;
            btnBookNow.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnBookNow.ForeColor = Color.White;
            btnBookNow.Location = new Point(28, 505);
            btnBookNow.Name = "btnBookNow";
            btnBookNow.Size = new Size(280, 52);
            btnBookNow.Text = "Book This Car";
            btnBookNow.UseVisualStyleBackColor = false;
            btnBookNow.Click += btnBookNow_Click;

            btnClose.BackColor = Color.White;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(210, 218, 228);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(55, 65, 81);
            btnClose.Location = new Point(324, 505);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(178, 52);
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;

            Controls.Add(detailsPanel);
            Controls.Add(imagePanel);
            Controls.Add(headerPanel);

            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            imagePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            detailsPanel.ResumeLayout(false);
            detailsPanel.PerformLayout();
            specPanel.ResumeLayout(false);
            specPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}
