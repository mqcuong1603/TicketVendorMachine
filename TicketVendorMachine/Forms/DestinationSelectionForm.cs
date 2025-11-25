using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using TicketVendorMachine.Models;
using TicketVendorMachine.DataAccess;

namespace TicketVendorMachine.Forms
{
    public partial class DestinationSelectionForm : Form
    {
        private List<Destination> destinations;

        public DestinationSelectionForm()
        {
            InitializeComponent();
            btnSelectDestination.Enabled = false; // Disable until selection
            LoadDestinations();
        }

        private void LoadDestinations()
        {
            destinations = new List<Destination>();

            // Show loading message
            lblSelectedDestination.Text = "Loading destinations...";
            lblSelectedDestination.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            lblSelectedPrice.Text = "";

            string query = "SELECT * FROM Destinations WHERE IsActive = 1";

            try
            {
                using (var conn = DatabaseHelper.GetConnection())
                {
                    conn.Open();
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                destinations.Add(new Destination
                                {
                                    DestinationID = (int)reader["DestinationID"],
                                    DestinationName = reader["DestinationName"].ToString(),
                                    Price = (decimal)reader["Price"],
                                    RouteCode = reader["RouteCode"].ToString()
                                });
                            }
                        }
                    }
                }

                // Bind to ListBox
                listBoxDestinations.DataSource = destinations;
                listBoxDestinations.DisplayMember = "DestinationName";

                // Update status
                if (destinations.Count > 0)
                {
                    lblSelectedDestination.Text = $"{destinations.Count} destinations available";
                    lblSelectedDestination.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
                    lblSelectedPrice.Text = "Select a destination from the list";
                    lblSelectedPrice.ForeColor = System.Drawing.Color.FromArgb(127, 140, 141);
                }
                else
                {
                    lblSelectedDestination.Text = "No destinations available";
                    lblSelectedDestination.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
                    lblSelectedPrice.Text = "Please contact support";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Unable to load destinations.\n\nError Details: {ex.Message}\n\nPlease try again or contact support.",
                    "Loading Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                lblSelectedDestination.Text = "Error loading destinations";
                lblSelectedDestination.ForeColor = System.Drawing.Color.FromArgb(231, 76, 60);
                btnSelectDestination.Enabled = false;
            }
        }

        private void listBoxDestinations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDestinations.SelectedItem != null)
            {
                var selected = (Destination)listBoxDestinations.SelectedItem;
                lblSelectedDestination.Text = $"✓ {selected.DestinationName}";
                lblSelectedDestination.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
                lblSelectedPrice.Text = $"{selected.Price:N0} VND";
                lblSelectedPrice.ForeColor = System.Drawing.Color.FromArgb(46, 204, 113);
                btnSelectDestination.Enabled = true;
            }
            else
            {
                btnSelectDestination.Enabled = false;
            }
        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            if (listBoxDestinations.SelectedItem != null)
            {
                // Disable button to prevent double-click
                btnSelectDestination.Enabled = false;
                btnSelectDestination.Text = "LOADING...";
                btnBack.Enabled = false;

                try
                {
                    var selected = (Destination)listBoxDestinations.SelectedItem;
                    PaymentForm paymentForm = new PaymentForm(selected);
                    this.Hide();
                    paymentForm.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        $"An error occurred.\n\nError: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    btnSelectDestination.Enabled = true;
                    btnSelectDestination.Text = "SELECT DESTINATION";
                    btnBack.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show(
                    "Please select a destination from the list before continuing.",
                    "No Selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}