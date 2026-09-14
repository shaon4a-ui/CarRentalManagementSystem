using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using CarRentalManagementSystem.Database;

namespace CarRentalManagementSystem.Customer
{
    public partial class PaymentForm : Form
    {
        private int bookingID;
        private decimal amount;
        private string carName;
        private DateTime startDate;
        private DateTime endDate;

        private bool paymentCompleted = false;

        // =========================================================
        // CONSTRUCTOR
        // =========================================================

        public PaymentForm()
        {
            InitializeComponent();

            // Wire each button exactly once.
            btnPay.Click += btnPay_Click;
            btnCancel.Click += btnCancel_Click;
            btnBack.Click += btnBack_Click;
        }

        public PaymentForm(
            int bookingID,
            decimal amount,
            string carName,
            DateTime startDate,
            DateTime endDate) : this()
        {
            this.bookingID = bookingID;
            this.amount = amount;
            this.carName = carName;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        // =========================================================
        // FORM LOAD
        // =========================================================

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (cmbPaymentMethod.Items.Count > 0)
            {
                cmbPaymentMethod.SelectedIndex = 0;
            }

            lblBookingID.Text = $"Booking ID: {bookingID}";
            lblCar.Text = $"Car: {carName}";
            lblDates.Text =
                $"Rental Dates: {startDate:dd/MM/yyyy} - {endDate:dd/MM/yyyy}";
            lblAmount.Text = $"Total: ৳{amount:N0}";

            UpdatePaymentFields();
        }

        // =========================================================
        // PAYMENT METHOD CHANGE
        // =========================================================

        private void cmbPaymentMethod_SelectedIndexChanged(
            object sender,
            EventArgs e)
        {
            UpdatePaymentFields();
        }

        private void UpdatePaymentFields()
        {
            bool mobile =
                cmbPaymentMethod.SelectedItem?.ToString() == "Mobile Banking";

            cardFieldsPanel.Visible = !mobile;
            mobileFieldsPanel.Visible = mobile;
        }

        // =========================================================
        // BACK BUTTON
        // =========================================================

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        // =========================================================
        // CANCEL BUTTON
        // =========================================================

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        // =========================================================
        // PAY BUTTON
        // =========================================================

        private void btnPay_Click(object sender, EventArgs e)
        {
            string paymentMethod =
                cmbPaymentMethod.SelectedItem?.ToString();

            // -----------------------------------------------------
            // PAYMENT METHOD VALIDATION
            // -----------------------------------------------------

            if (string.IsNullOrWhiteSpace(paymentMethod))
            {
                MessageBox.Show(
                    "Please select a payment method.",
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            // -----------------------------------------------------
            // CARD VALIDATION
            // -----------------------------------------------------

            if (paymentMethod == "Credit Card" ||
                paymentMethod == "Debit Card")
            {
                if (string.IsNullOrWhiteSpace(txtCardNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtCardHolder.Text) ||
                    string.IsNullOrWhiteSpace(txtExpiry.Text) ||
                    string.IsNullOrWhiteSpace(txtCVV.Text))
                {
                    MessageBox.Show(
                        "Please complete the card payment information.",
                        "Payment Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            // -----------------------------------------------------
            // MOBILE BANKING VALIDATION
            // -----------------------------------------------------

            else if (paymentMethod == "Mobile Banking")
            {
                if (cmbMobileProvider.SelectedIndex < 0 ||
                    string.IsNullOrWhiteSpace(txtMobileNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtMobilePin.Text))
                {
                    MessageBox.Show(
                        "Please complete the mobile banking information.",
                        "Payment Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }
            }

            // -----------------------------------------------------
            // PROCESS PAYMENT
            // -----------------------------------------------------

            try
            {
                btnPay.Enabled = false;

                DatabaseHelper databaseHelper =
                    new DatabaseHelper();

                using (SqlConnection connection =
                       databaseHelper.GetConnection())
                {
                    connection.Open();

                    using (SqlTransaction transaction =
                           connection.BeginTransaction())
                    {
                        try
                        {
                            // -------------------------------------------------
                            // CHECK WHETHER THIS BOOKING IS ALREADY PAID
                            // -------------------------------------------------

                            string checkQuery = @"
                                SELECT COUNT(*)
                                FROM Payments
                                WHERE BookingID = @BookingID
                                  AND PaymentStatus = 'Paid'";

                            using (SqlCommand checkCommand =
                                   new SqlCommand(
                                       checkQuery,
                                       connection,
                                       transaction))
                            {
                                checkCommand.Parameters.AddWithValue(
                                    "@BookingID",
                                    bookingID);

                                int existingPayment =
                                    Convert.ToInt32(
                                        checkCommand.ExecuteScalar());

                                if (existingPayment > 0)
                                {
                                    transaction.Rollback();

                                    SetPaymentCompleted();

                                    MessageBox.Show(
                                        "This booking has already been paid.",
                                        "Already Paid",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                                    return;
                                }
                            }

                            // -------------------------------------------------
                            // INSERT PAYMENT
                            // -------------------------------------------------

                            string paymentQuery = @"
                                INSERT INTO Payments
                                (
                                    BookingID,
                                    Amount,
                                    PaymentMethod,
                                    PaymentStatus
                                )
                                OUTPUT INSERTED.PaymentID
                                VALUES
                                (
                                    @BookingID,
                                    @Amount,
                                    @PaymentMethod,
                                    @PaymentStatus
                                )";

                            int paymentID;

                            using (SqlCommand paymentCommand =
                                   new SqlCommand(
                                       paymentQuery,
                                       connection,
                                       transaction))
                            {
                                paymentCommand.Parameters.AddWithValue(
                                    "@BookingID",
                                    bookingID);

                                paymentCommand.Parameters.AddWithValue(
                                    "@Amount",
                                    amount);

                                paymentCommand.Parameters.AddWithValue(
                                    "@PaymentMethod",
                                    paymentMethod);

                                paymentCommand.Parameters.AddWithValue(
                                    "@PaymentStatus",
                                    "Paid");

                                paymentID =
                                    Convert.ToInt32(
                                        paymentCommand.ExecuteScalar());
                            }

                            // IMPORTANT:
                            // Payment does NOT confirm the booking.
                            //
                            // PaymentStatus = Paid
                            // BookingStatus = Pending
                            //
                            // Owner must confirm the booking.

                            transaction.Commit();

                            SetPaymentCompleted();

                            MessageBox.Show(
                                $"Payment successful!\n\n" +
                                $"Payment ID: {paymentID}\n" +
                                $"Booking ID: {bookingID}\n" +
                                $"Car: {carName}\n" +
                                $"Amount: ৳{amount:N0}\n" +
                                $"Payment Method: {paymentMethod}\n" +
                                $"Payment Status: Paid\n" +
                                $"Booking Status: Pending\n\n" +
                                $"Please wait for the owner to confirm your booking.",
                                "Payment Successful",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                btnPay.Enabled = true;

                MessageBox.Show(
                    "Could not process the payment.\n\n" +
                    ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                btnPay.Enabled = true;

                MessageBox.Show(
                    "An unexpected error occurred.\n\n" +
                    ex.Message,
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // =========================================================
        // PAYMENT COMPLETED UI
        // =========================================================

        private void SetPaymentCompleted()
        {
            paymentCompleted = true;

            btnPay.Text = "✓ Paid";
            btnPay.Enabled = false;

            cmbPaymentMethod.Enabled = false;

            txtCardNumber.Enabled = false;
            txtCardHolder.Enabled = false;
            txtExpiry.Enabled = false;
            txtCVV.Enabled = false;

            cmbMobileProvider.Enabled = false;
            txtMobileNumber.Enabled = false;
            txtMobilePin.Enabled = false;

            lblSubtitle.Text =
                "Payment completed successfully";
        }
    }
}