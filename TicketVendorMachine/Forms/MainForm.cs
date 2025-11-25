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
                lblStatus.Text = "✓ System Ready - Database Connected";
                lblStatus.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
                btnStart.Enabled = true;
            }
            else
            {
                lblStatus.Text = "✗ System Error - Database Connection Failed";
                lblStatus.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
                btnStart.Enabled = false;
                MessageBox.Show(
                    "Unable to connect to the database.\nPlease check the database connection and try again.",
                    "Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Disable button to prevent double-click
            btnStart.Enabled = false;
            btnStart.Text = "LOADING...";

            try
            {
                DestinationSelectionForm destForm = new DestinationSelectionForm();
                this.Hide();
                destForm.ShowDialog();
                this.Show();
            }
            finally
            {
                // Re-enable button
                btnStart.Enabled = true;
                btnStart.Text = "START";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to exit the application?",
                "Exit Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
