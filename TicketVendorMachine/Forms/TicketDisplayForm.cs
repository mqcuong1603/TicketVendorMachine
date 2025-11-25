using System;
using System.Drawing;
using System.Windows.Forms;
using TicketVendorMachine.Models;
using QRCoder;

namespace TicketVendorMachine.Forms
{
    public partial class TicketDisplayForm : Form
    {
        private string ticketCode;
        private Destination destination;

        public TicketDisplayForm(string code, Destination dest)
        {
            InitializeComponent();
            ticketCode = code;
            destination = dest;
            DisplayTicket();
        }

        private void DisplayTicket()
        {
            lblTicketCode.Text = $"{ticketCode}";
            lblDestination.Text = $"📍 Destination: {destination.DestinationName}";
            lblPrice.Text = $"💰 Price: {destination.Price:N0} VND";
            lblIssueDate.Text = $"🕒 Issued: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";

            // Generate barcode/QR for ticket
            GenerateTicketBarcode();
        }

        private void GenerateTicketBarcode()
        {
            try
            {
                QRCodeGenerator qrGenerator = new QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(ticketCode, QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap barcodeImage = qrCode.GetGraphic(10);

                pictureBoxBarcode.Image = barcodeImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating barcode: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // Disable button during print
            btnPrint.Enabled = false;
            btnPrint.Text = "PRINTING...";

            try
            {
                MessageBox.Show(
                    "🖨️ Printing Your Ticket\n\n" +
                    $"Ticket Code: {ticketCode}\n" +
                    $"Destination: {destination.DestinationName}\n" +
                    $"Price: {destination.Price:N0} VND\n" +
                    $"Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}\n\n" +
                    "✓ Print completed successfully!\n\n" +
                    "(This is a printer simulation)",
                    "Print Ticket",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            finally
            {
                btnPrint.Enabled = true;
                btnPrint.Text = "PRINT TICKET";
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Thank you for using our Ticket Vendor Machine!\n\n" +
                "Would you like to return to the main menu?",
                "Return to Main Menu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();

                // Show main form if it's hidden
                foreach (Form form in Application.OpenForms)
                {
                    if (form is MainForm)
                    {
                        form.Show();
                        form.BringToFront();
                        break;
                    }
                }
            }
        }
    }
}