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
            lblTicketCode.Text = $"Ticket Code: {ticketCode}";
            lblDestination.Text = $"Destination: {destination.DestinationName}";
            lblPrice.Text = $"Price: {destination.Price:N0} VND";
            lblIssueDate.Text = $"Issue Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}";

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
            MessageBox.Show(
                "Printing ticket...\n\n" +
                $"Ticket Code: {ticketCode}\n" +
                $"Destination: {destination.DestinationName}\n" +
                $"Price: {destination.Price:N0} VND\n\n" +
                "(This is a printer simulation)",
                "Print Ticket",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to finish and return to main menu?",
                "Confirm",
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