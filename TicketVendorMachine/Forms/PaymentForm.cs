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
            // Show credit card input dialog
            string cardNumber = Microsoft.VisualBasic.Interaction.InputBox(
                "Enter Credit Card Number (16 digits):",
                "Credit Card Payment",
                "");

            if (!string.IsNullOrEmpty(cardNumber))
            {
                // Validate card number (basic check)
                if (cardNumber.Length == 16)
                {
                    ProcessPayment("CreditCard", cardNumber);
                }
                else
                {
                    MessageBox.Show("Invalid card number!", "Error");
                }
            }
        }

        private void btnQRCode_Click(object sender, EventArgs e)
        {
            GenerateQRCode();
        }

        private void GenerateQRCode()
        {
            try
            {
                // Hide payment buttons
                btnCreditCard.Visible = false;
                btnQRCode.Visible = false;

                // Show QR code
                pictureBoxQR.Visible = true;
                lblQRInstruction.Text = "Scan this QR code with Momo/ZaloPay/VNPay app";
                lblQRInstruction.ForeColor = Color.Blue;

                // Generate QR Code
                string paymentInfo = $"AMOUNT:{selectedDestination.Price}|DEST:{selectedDestination.DestinationName}|CODE:{GenerateTicketCode()}";

                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(paymentInfo, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20);

                pictureBoxQR.Image = qrCodeImage;

                // Simulate payment processing after 5 seconds
                Timer timer = new Timer();
                timer.Interval = 5000; // 5 seconds
                timer.Tick += (s, e) =>
                {
                    timer.Stop();
                    ProcessPayment("QRCode", paymentInfo);
                };
                timer.Start();

                lblQRInstruction.Text += "\n\nProcessing payment...";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating QR code: {ex.Message}", "Error");
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

                MessageBox.Show($"Payment Successful!\n\nTicket Code: {ticketCode}\nDestination: {selectedDestination.DestinationName}\nPrice: {selectedDestination.Price:N0} VND",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Open ticket display form
                TicketDisplayForm ticketForm = new TicketDisplayForm(ticketCode, selectedDestination);
                this.Hide();
                ticketForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Payment failed: {ex.Message}", "Error");
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