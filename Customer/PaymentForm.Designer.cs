using System.Drawing;
using System.Windows.Forms;

namespace CarRentalManagementSystem.Customer
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;

        private Panel headerPanel;
        private Button btnBack;
        private Label lblPageTitle;
        private Label lblSubtitle;

        private Panel mainPanel;
        private Panel bookingInfoPanel;
        private Label lblBookingTitle;
        private Label lblBookingID;
        private Label lblCar;
        private Label lblDates;
        private Label lblAmount;

        private Panel paymentPanel;
        private Label lblPaymentTitle;
        private Label lblPaymentMethod;
        private ComboBox cmbPaymentMethod;

        private Panel cardFieldsPanel;
        private Label lblCardNumber;
        private TextBox txtCardNumber;
        private Label lblCardHolder;
        private TextBox txtCardHolder;
        private Label lblExpiry;
        private TextBox txtExpiry;
        private Label lblCVV;
        private TextBox txtCVV;

        private Panel mobileFieldsPanel;
        private Label lblMobileProvider;
        private ComboBox cmbMobileProvider;
        private Label lblMobileNumber;
        private TextBox txtMobileNumber;
        private Label lblMobilePin;
        private TextBox txtMobilePin;

        private Label lblSecureNote;
        private Button btnPay;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            headerPanel = new Panel();
            btnBack = new Button();
            lblPageTitle = new Label();
            lblSubtitle = new Label();
            mainPanel = new Panel();
            bookingInfoPanel = new Panel();
            lblBookingTitle = new Label();
            lblBookingID = new Label();
            lblCar = new Label();
            lblDates = new Label();
            lblAmount = new Label();
            paymentPanel = new Panel();
            lblPaymentTitle = new Label();
            lblPaymentMethod = new Label();
            cmbPaymentMethod = new ComboBox();
            cardFieldsPanel = new Panel();
            lblCardNumber = new Label();
            txtCardNumber = new TextBox();
            lblCardHolder = new Label();
            txtCardHolder = new TextBox();
            lblExpiry = new Label();
            txtExpiry = new TextBox();
            lblCVV = new Label();
            txtCVV = new TextBox();
            mobileFieldsPanel = new Panel();
            lblMobileProvider = new Label();
            cmbMobileProvider = new ComboBox();
            lblMobileNumber = new Label();
            txtMobileNumber = new TextBox();
            lblMobilePin = new Label();
            txtMobilePin = new TextBox();
            lblSecureNote = new Label();
            btnPay = new Button();
            btnCancel = new Button();
            headerPanel.SuspendLayout();
            mainPanel.SuspendLayout();
            bookingInfoPanel.SuspendLayout();
            paymentPanel.SuspendLayout();
            cardFieldsPanel.SuspendLayout();
            mobileFieldsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // headerPanel
            // 
            headerPanel.BackColor = Color.FromArgb(15, 39, 72);
            headerPanel.Controls.Add(btnBack);
            headerPanel.Controls.Add(lblPageTitle);
            headerPanel.Controls.Add(lblSubtitle);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1180, 86);
            headerPanel.TabIndex = 1;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(25, 22);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(100, 42);
            btnBack.TabIndex = 0;
            btnBack.Text = "←  Back";
            btnBack.UseVisualStyleBackColor = false;
           
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblPageTitle.ForeColor = Color.White;
            lblPageTitle.Location = new Point(500, 12);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(274, 46);
            lblPageTitle.TabIndex = 1;
            lblPageTitle.Text = "Secure Payment";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 9.5F);
            lblSubtitle.ForeColor = Color.FromArgb(210, 222, 237);
            lblSubtitle.Location = new Point(452, 54);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(239, 21);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Complete your payment securely";
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.FromArgb(244, 248, 252);
            mainPanel.Controls.Add(bookingInfoPanel);
            mainPanel.Controls.Add(paymentPanel);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 86);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(35, 25, 35, 25);
            mainPanel.Size = new Size(1180, 704);
            mainPanel.TabIndex = 0;
            // 
            // bookingInfoPanel
            // 
            bookingInfoPanel.BackColor = Color.White;
            bookingInfoPanel.Controls.Add(lblBookingTitle);
            bookingInfoPanel.Controls.Add(lblBookingID);
            bookingInfoPanel.Controls.Add(lblCar);
            bookingInfoPanel.Controls.Add(lblDates);
            bookingInfoPanel.Controls.Add(lblAmount);
            bookingInfoPanel.Location = new Point(35, 25);
            bookingInfoPanel.Name = "bookingInfoPanel";
            bookingInfoPanel.Size = new Size(1110, 145);
            bookingInfoPanel.TabIndex = 0;
            // 
            // lblBookingTitle
            // 
            lblBookingTitle.AutoSize = true;
            lblBookingTitle.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblBookingTitle.ForeColor = Color.FromArgb(15, 39, 72);
            lblBookingTitle.Location = new Point(25, 20);
            lblBookingTitle.Name = "lblBookingTitle";
            lblBookingTitle.Size = new Size(203, 30);
            lblBookingTitle.TabIndex = 0;
            lblBookingTitle.Text = "Booking Summary";
            // 
            // lblBookingID
            // 
            lblBookingID.AutoSize = true;
            lblBookingID.Font = new Font("Segoe UI", 9.5F);
            lblBookingID.ForeColor = Color.FromArgb(82, 95, 111);
            lblBookingID.Location = new Point(25, 62);
            lblBookingID.Name = "lblBookingID";
            lblBookingID.Size = new Size(99, 21);
            lblBookingID.TabIndex = 1;
            lblBookingID.Text = "Booking ID: -";
            // 
            // lblCar
            // 
            lblCar.AutoSize = true;
            lblCar.Font = new Font("Segoe UI", 9.5F);
            lblCar.ForeColor = Color.FromArgb(82, 95, 111);
            lblCar.Location = new Point(220, 62);
            lblCar.Name = "lblCar";
            lblCar.Size = new Size(47, 21);
            lblCar.TabIndex = 2;
            lblCar.Text = "Car: -";
            // 
            // lblDates
            // 
            lblDates.AutoSize = true;
            lblDates.Font = new Font("Segoe UI", 9.5F);
            lblDates.ForeColor = Color.FromArgb(82, 95, 111);
            lblDates.Location = new Point(25, 98);
            lblDates.Name = "lblDates";
            lblDates.Size = new Size(110, 21);
            lblDates.TabIndex = 3;
            lblDates.Text = "Rental Dates: -";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            lblAmount.ForeColor = Color.FromArgb(30, 136, 255);
            lblAmount.Location = new Point(830, 55);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(140, 40);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Total: ৳0";
            // 
            // paymentPanel
            // 
            paymentPanel.BackColor = Color.White;
            paymentPanel.Controls.Add(lblPaymentTitle);
            paymentPanel.Controls.Add(lblPaymentMethod);
            paymentPanel.Controls.Add(cmbPaymentMethod);
            paymentPanel.Controls.Add(cardFieldsPanel);
            paymentPanel.Controls.Add(mobileFieldsPanel);
            paymentPanel.Controls.Add(lblSecureNote);
            paymentPanel.Controls.Add(btnPay);
            paymentPanel.Controls.Add(btnCancel);
            paymentPanel.Location = new Point(35, 195);
            paymentPanel.Name = "paymentPanel";
            paymentPanel.Size = new Size(1110, 525);
            paymentPanel.TabIndex = 1;
            // 
            // lblPaymentTitle
            // 
            lblPaymentTitle.AutoSize = true;
            lblPaymentTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblPaymentTitle.ForeColor = Color.FromArgb(15, 39, 72);
            lblPaymentTitle.Location = new Point(25, 20);
            lblPaymentTitle.Name = "lblPaymentTitle";
            lblPaymentTitle.Size = new Size(204, 35);
            lblPaymentTitle.TabIndex = 0;
            lblPaymentTitle.Text = "Payment Details";
            // 
            // lblPaymentMethod
            // 
            lblPaymentMethod.AutoSize = true;
            lblPaymentMethod.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPaymentMethod.ForeColor = Color.FromArgb(55, 65, 81);
            lblPaymentMethod.Location = new Point(25, 70);
            lblPaymentMethod.Name = "lblPaymentMethod";
            lblPaymentMethod.Size = new Size(202, 21);
            lblPaymentMethod.TabIndex = 1;
            lblPaymentMethod.Text = "Choose Payment Method";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.Font = new Font("Segoe UI", 10F);
            cmbPaymentMethod.Items.AddRange(new object[] { "Credit Card", "Debit Card", "Mobile Banking" });
            cmbPaymentMethod.Location = new Point(25, 98);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(310, 31);
            cmbPaymentMethod.TabIndex = 2;
            // 
            // cardFieldsPanel
            // 
            cardFieldsPanel.BackColor = Color.FromArgb(248, 250, 253);
            cardFieldsPanel.Controls.Add(lblCardNumber);
            cardFieldsPanel.Controls.Add(txtCardNumber);
            cardFieldsPanel.Controls.Add(lblCardHolder);
            cardFieldsPanel.Controls.Add(txtCardHolder);
            cardFieldsPanel.Controls.Add(lblExpiry);
            cardFieldsPanel.Controls.Add(txtExpiry);
            cardFieldsPanel.Controls.Add(lblCVV);
            cardFieldsPanel.Controls.Add(txtCVV);
            cardFieldsPanel.Location = new Point(25, 145);
            cardFieldsPanel.Name = "cardFieldsPanel";
            cardFieldsPanel.Size = new Size(1060, 205);
            cardFieldsPanel.TabIndex = 3;
            // 
            // lblCardNumber
            // 
            lblCardNumber.AutoSize = true;
            lblCardNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCardNumber.ForeColor = Color.FromArgb(55, 65, 81);
            lblCardNumber.Location = new Point(22, 20);
            lblCardNumber.Name = "lblCardNumber";
            lblCardNumber.Size = new Size(112, 21);
            lblCardNumber.TabIndex = 0;
            lblCardNumber.Text = "Card Number";
            // 
            // txtCardNumber
            // 
            txtCardNumber.Font = new Font("Segoe UI", 10F);
            txtCardNumber.Location = new Point(22, 48);
            txtCardNumber.MaxLength = 19;
            txtCardNumber.Name = "txtCardNumber";
            txtCardNumber.Size = new Size(475, 30);
            txtCardNumber.TabIndex = 1;
            // 
            // lblCardHolder
            // 
            lblCardHolder.AutoSize = true;
            lblCardHolder.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCardHolder.ForeColor = Color.FromArgb(55, 65, 81);
            lblCardHolder.Location = new Point(530, 20);
            lblCardHolder.Name = "lblCardHolder";
            lblCardHolder.Size = new Size(151, 21);
            lblCardHolder.TabIndex = 2;
            lblCardHolder.Text = "Card Holder Name";
            // 
            // txtCardHolder
            // 
            txtCardHolder.Font = new Font("Segoe UI", 10F);
            txtCardHolder.Location = new Point(530, 48);
            txtCardHolder.Name = "txtCardHolder";
            txtCardHolder.Size = new Size(490, 30);
            txtCardHolder.TabIndex = 3;
            // 
            // lblExpiry
            // 
            lblExpiry.AutoSize = true;
            lblExpiry.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblExpiry.ForeColor = Color.FromArgb(55, 65, 81);
            lblExpiry.Location = new Point(22, 105);
            lblExpiry.Name = "lblExpiry";
            lblExpiry.Size = new Size(132, 21);
            lblExpiry.TabIndex = 4;
            lblExpiry.Text = "Expiry (MM/YY)";
            // 
            // txtExpiry
            // 
            txtExpiry.Font = new Font("Segoe UI", 10F);
            txtExpiry.Location = new Point(22, 133);
            txtExpiry.MaxLength = 5;
            txtExpiry.Name = "txtExpiry";
            txtExpiry.Size = new Size(190, 30);
            txtExpiry.TabIndex = 5;
            // 
            // lblCVV
            // 
            lblCVV.AutoSize = true;
            lblCVV.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblCVV.ForeColor = Color.FromArgb(55, 65, 81);
            lblCVV.Location = new Point(235, 105);
            lblCVV.Name = "lblCVV";
            lblCVV.Size = new Size(42, 21);
            lblCVV.TabIndex = 6;
            lblCVV.Text = "CVV";
            // 
            // txtCVV
            // 
            txtCVV.Font = new Font("Segoe UI", 10F);
            txtCVV.Location = new Point(235, 133);
            txtCVV.MaxLength = 4;
            txtCVV.Name = "txtCVV";
            txtCVV.PasswordChar = '*';
            txtCVV.Size = new Size(120, 30);
            txtCVV.TabIndex = 7;
            // 
            // mobileFieldsPanel
            // 
            mobileFieldsPanel.BackColor = Color.FromArgb(248, 250, 253);
            mobileFieldsPanel.Controls.Add(lblMobileProvider);
            mobileFieldsPanel.Controls.Add(cmbMobileProvider);
            mobileFieldsPanel.Controls.Add(lblMobileNumber);
            mobileFieldsPanel.Controls.Add(txtMobileNumber);
            mobileFieldsPanel.Controls.Add(lblMobilePin);
            mobileFieldsPanel.Controls.Add(txtMobilePin);
            mobileFieldsPanel.Location = new Point(25, 145);
            mobileFieldsPanel.Name = "mobileFieldsPanel";
            mobileFieldsPanel.Size = new Size(1060, 205);
            mobileFieldsPanel.TabIndex = 4;
            mobileFieldsPanel.Visible = false;
            // 
            // lblMobileProvider
            // 
            lblMobileProvider.AutoSize = true;
            lblMobileProvider.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblMobileProvider.ForeColor = Color.FromArgb(55, 65, 81);
            lblMobileProvider.Location = new Point(22, 20);
            lblMobileProvider.Name = "lblMobileProvider";
            lblMobileProvider.Size = new Size(200, 21);
            lblMobileProvider.TabIndex = 0;
            lblMobileProvider.Text = "Mobile Banking Provider";
            // 
            // cmbMobileProvider
            // 
            cmbMobileProvider.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMobileProvider.Font = new Font("Segoe UI", 10F);
            cmbMobileProvider.Items.AddRange(new object[] { "bKash", "Nagad", "Rocket" });
            cmbMobileProvider.Location = new Point(22, 48);
            cmbMobileProvider.Name = "cmbMobileProvider";
            cmbMobileProvider.Size = new Size(300, 31);
            cmbMobileProvider.TabIndex = 1;
            // 
            // lblMobileNumber
            // 
            lblMobileNumber.AutoSize = true;
            lblMobileNumber.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblMobileNumber.ForeColor = Color.FromArgb(55, 65, 81);
            lblMobileNumber.Location = new Point(355, 20);
            lblMobileNumber.Name = "lblMobileNumber";
            lblMobileNumber.Size = new Size(131, 21);
            lblMobileNumber.TabIndex = 2;
            lblMobileNumber.Text = "Mobile Number";
            // 
            // txtMobileNumber
            // 
            txtMobileNumber.Font = new Font("Segoe UI", 10F);
            txtMobileNumber.Location = new Point(355, 48);
            txtMobileNumber.MaxLength = 15;
            txtMobileNumber.Name = "txtMobileNumber";
            txtMobileNumber.Size = new Size(300, 30);
            txtMobileNumber.TabIndex = 3;
            // 
            // lblMobilePin
            // 
            lblMobilePin.AutoSize = true;
            lblMobilePin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblMobilePin.ForeColor = Color.FromArgb(55, 65, 81);
            lblMobilePin.Location = new Point(688, 20);
            lblMobilePin.Name = "lblMobilePin";
            lblMobilePin.Size = new Size(38, 21);
            lblMobilePin.TabIndex = 4;
            lblMobilePin.Text = "PIN";
            // 
            // txtMobilePin
            // 
            txtMobilePin.Font = new Font("Segoe UI", 10F);
            txtMobilePin.Location = new Point(688, 48);
            txtMobilePin.MaxLength = 6;
            txtMobilePin.Name = "txtMobilePin";
            txtMobilePin.PasswordChar = '*';
            txtMobilePin.Size = new Size(150, 30);
            txtMobilePin.TabIndex = 5;
            // 
            // lblSecureNote
            // 
            lblSecureNote.AutoSize = true;
            lblSecureNote.Font = new Font("Segoe UI", 9F);
            lblSecureNote.ForeColor = Color.FromArgb(82, 95, 111);
            lblSecureNote.Location = new Point(25, 365);
            lblSecureNote.Name = "lblSecureNote";
            lblSecureNote.Size = new Size(396, 20);
            lblSecureNote.TabIndex = 5;
            lblSecureNote.Text = "Secure payment • Your payment details are handled safely.";
            // 
            // btnPay
            // 
            btnPay.BackColor = Color.FromArgb(30, 136, 255);
            btnPay.Cursor = Cursors.Hand;
            btnPay.FlatAppearance.BorderSize = 0;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(25, 410);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(280, 52);
            btnPay.TabIndex = 6;
            btnPay.Text = "Pay Now";
            btnPay.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(210, 218, 228);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = Color.FromArgb(55, 65, 81);
            btnCancel.Location = new Point(325, 410);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(160, 52);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(244, 248, 252);
            ClientSize = new Size(1180, 790);
            Controls.Add(mainPanel);
            Controls.Add(headerPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PaymentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Payment";
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            mainPanel.ResumeLayout(false);
            bookingInfoPanel.ResumeLayout(false);
            bookingInfoPanel.PerformLayout();
            paymentPanel.ResumeLayout(false);
            paymentPanel.PerformLayout();
            cardFieldsPanel.ResumeLayout(false);
            cardFieldsPanel.PerformLayout();
            mobileFieldsPanel.ResumeLayout(false);
            mobileFieldsPanel.PerformLayout();
            ResumeLayout(false);
        }
    }
}
