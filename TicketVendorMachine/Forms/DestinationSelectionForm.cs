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
            LoadDestinations();
        }

        private void LoadDestinations()
        {
            destinations = new List<Destination>();

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
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading destinations: {ex.Message}", "Error");
            }
        }

        private void listBoxDestinations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxDestinations.SelectedItem != null)
            {
                var selected = (Destination)listBoxDestinations.SelectedItem;
                lblSelectedDestination.Text = $"Selected: {selected.DestinationName}";
                lblSelectedPrice.Text = $"Price: {selected.Price:N0} VND";
            }
        }

        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            if (listBoxDestinations.SelectedItem != null)
            {
                var selected = (Destination)listBoxDestinations.SelectedItem;
                PaymentForm paymentForm = new PaymentForm(selected);
                this.Hide();
                paymentForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a destination!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}