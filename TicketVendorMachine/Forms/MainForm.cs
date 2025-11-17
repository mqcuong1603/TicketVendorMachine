using System;
using System.Windows.Forms;
using TicketVendorMachine.DataAccess;

namespace TicketVendorMachine.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            TestDatabaseConnection();
        }

        private void TestDatabaseConnection()
        {
            if (DatabaseHelper.TestConnection())
            {
                lblStatus.Text = "✓ Database Connected";
                lblStatus.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                lblStatus.Text = "✗ Database Connection Failed";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            DestinationSelectionForm destForm = new DestinationSelectionForm();
            destForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
