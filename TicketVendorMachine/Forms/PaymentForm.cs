using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TicketVendorMachine.Models;
using TicketVendorMachine.DataAccess;
using QRCoder;
using Microsoft.VisualBasic;

namespace TicketVendorMachine.Forms
{
    public partial class PaymentForm : Form
    {
        private Destination selectedDestination;

        public PaymentForm(Destination destination)
        {
            InitializeComponent();
            selectedDestination = destination;
            DisplayDestinationInfo();
        }

        private void DisplayDestinationInfo()
        {
            lblDestination.Text = $"Destination: {selectedDestination.DestinationName}";
            lblPrice.Text = $"Price: {selectedDestination.Price:N0} VND";
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            // Disable buttons during processing
            btnCreditCard.Enabled = false;
            btnQRCode.Enabled = false;
            btnBack.Enabled = false;

            try
            {
                // Show credit card input dialog
                string cardNumber = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter your Credit Card Number:\n\n(16 digits, no spaces)\n\nExample: 1234567890123456",
                    "Credit Card Payment",
                    "");

                if (!string.IsNullOrEmpty(cardNumber))
                {
                    // Remove spaces and dashes
                    cardNumber = cardNumber.Replace(" ", "").Replace("-", "");

                    // Validate card number (basic check)
                    if (cardNumber.Length == 16 && long.TryParse(cardNumber, out _))
                    {
                        ProcessPayment("CreditCard", cardNumber);
                    }
                    else
                    {
                        MessageBox.Show(
                            "Invalid credit card number!\n\nPlease enter exactly 16 digits.\nExample: 1234567890123456",
                            "Invalid Card Number",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        // Re-enable buttons
                        btnCreditCard.Enabled = true;
                        btnQRCode.Enabled = true;
                        btnBack.Enabled = true;
                    }
                }
                else
                {
                    // User cancelled - re-enable buttons
                    btnCreditCard.Enabled = true;
                    btnQRCode.Enabled = true;
                    btnBack.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCreditCard.Enabled = true;
                btnQRCode.Enabled = true;
                btnBack.Enabled = true;
            }
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            // Disable buttons during processing
            btnCreditCard.Enabled = false;
            btnQRCode.Enabled = false;
            btnBack.Enabled = false;

            GenerateQRCode();
        }

        private void GenerateQRCode()
        {
            try
            {
                // Hide payment panel
                panelPayment.Visible = false;

                // Show QR code
                pictureBoxQR.Visible = true;
                lblQRInstruction.Visible = true;
                lblQRInstruction.Text = "📱 Scan QR Code with Your Payment App\n\nSupported: Momo / ZaloPay / VNPay";
                lblQRInstruction.ForeColor = Color.FromArgb(52, 152, 219);

                // Generate QR Code
                string paymentInfo = $"AMOUNT:{selectedDestination.Price}|DEST:{selectedDestination.DestinationName}|CODE:{GenerateTicketCode()}";

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(paymentInfo, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                pictureBoxQR.Image = qrCodeImage;

                // Show countdown timer
                int countdown = 5;
                Timer countdownTimer = new Timer();
                countdownTimer.Interval = 1000; // 1 second
                countdownTimer.Tick += (s, e) =>
                {
                    countdown--;
                    if (countdown > 0)
                    {
                        lblQRInstruction.Text = $"📱 Scan QR Code with Your Payment App\n\nSupported: Momo / ZaloPay / VNPay\n\n⏱ Processing payment in {countdown} seconds...";
                    }
                    else
                    {
                        countdownTimer.Stop();
                        lblQRInstruction.Text = "✓ Processing payment...";
                        lblQRInstruction.ForeColor = Color.FromArgb(46, 204, 113);
                    }
                };
                countdownTimer.Start();

                // Simulate payment processing after 5 seconds
                Timer timer = new Timer();
                timer.Interval = 5000; // 5 seconds
                timer.Tick += (s, e) =>
                {
                    timer.Stop();
                    countdownTimer.Stop();
                    ProcessPayment("QRCode", paymentInfo);
                };
                timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to generate QR code.\n\nError: {ex.Message}\n\nPlease try again or use a different payment method.",
                    "QR Code Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                // Re-enable buttons
                panelPayment.Visible = true;
                btnCreditCard.Enabled = true;
                btnQRCode.Enabled = true;
                btnBack.Enabled = true;
            }
        }

        private void ProcessPayment(string paymentMethod, string paymentInfo)
        {
            try
            {
                string ticketCode = GenerateTicketCode();

                // Save ticket to database
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    string query = @"INSERT INTO Tickets (DestinationID, TicketCode, Price, PaymentMethod, PaymentStatus, TransactionID, IssueDate)
                                    VALUES (@DestinationID, @TicketCode, @Price, @PaymentMethod, @PaymentStatus, @TransactionID, @IssueDate)";

                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DestinationID", selectedDestination.DestinationID);
                        cmd.Parameters.AddWithValue("@TicketCode", ticketCode);
                        cmd.Parameters.AddWithValue("@Price", selectedDestination.Price);
                        cmd.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                        cmd.Parameters.AddWithValue("@PaymentStatus", "Completed");
                        cmd.Parameters.AddWithValue("@TransactionID", paymentInfo);
                        cmd.Parameters.AddWithValue("@IssueDate", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(
                    $"✓ Payment Successful!\n\n" +
                    $"Ticket Code: {ticketCode}\n" +
                    $"Destination: {selectedDestination.DestinationName}\n" +
                    $"Amount Paid: {selectedDestination.Price:N0} VND\n" +
                    $"Payment Method: {paymentMethod}\n\n" +
                    $"Your ticket is ready!",
                    "Payment Successful",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // Open ticket display form
                TicketDisplayForm ticketForm = new TicketDisplayForm(ticketCode, selectedDestination);
                this.Hide();
                ticketForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Payment Processing Failed\n\n" +
                    $"Error Details: {ex.Message}\n\n" +
                    $"Your payment has not been charged.\n" +
                    $"Please try again or contact support.",
                    "Payment Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                // Re-enable buttons
                panelPayment.Visible = true;
                pictureBoxQR.Visible = false;
                lblQRInstruction.Visible = false;
                btnCreditCard.Enabled = true;
                btnQRCode.Enabled = true;
                btnBack.Enabled = true;
            }
        }

        private string GenerateTicketCode()
        {
            return $"TKT{DateTime.Now:yyyyMMddHHmmss}{new Random().Next(1000, 9999)}";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}