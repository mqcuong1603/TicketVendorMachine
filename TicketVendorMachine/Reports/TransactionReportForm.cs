using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using TicketVendorMachine.DataAccess;

namespace TicketVendorMachine.Reports
{
    public partial class TransactionReportForm : Form
    {
        public TransactionReportForm()
        {
            InitializeComponent();
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                lblStatus.Text = "Loading report...";
                lblStatus.ForeColor = System.Drawing.Color.Blue;
                Application.DoEvents();

                string query = @"
                    SELECT 
                        t.TicketID AS 'ID',
                        t.TicketCode AS 'Ticket Code',
                        d.DestinationName AS 'Destination',
                        d.RouteCode AS 'Route',
                        t.Price AS 'Price (VND)',
                        t.PaymentMethod AS 'Payment Method',
                        t.PaymentStatus AS 'Status',
                        CONVERT(VARCHAR, t.IssueDate, 120) AS 'Issue Date'
                    FROM Tickets t
                    INNER JOIN Destinations d ON t.DestinationID = d.DestinationID
                    ORDER BY t.IssueDate DESC";

                using (var conn = DatabaseHelper.GetConnection())
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewReport.DataSource = dt;
                    dataGridViewReport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dataGridViewReport.ReadOnly = true;

                    if (dataGridViewReport.Columns["ID"] != null)
                    {
                        dataGridViewReport.Columns["ID"].Visible = false;
                    }

                    if (dataGridViewReport.Columns["Price (VND)"] != null)
                    {
                        dataGridViewReport.Columns["Price (VND)"].DefaultCellStyle.Format = "N0";
                        dataGridViewReport.Columns["Price (VND)"].DefaultCellStyle.Alignment =
                            DataGridViewContentAlignment.MiddleRight;
                    }

                    if (dataGridViewReport.Columns["Status"] != null)
                    {
                        foreach (DataGridViewRow row in dataGridViewReport.Rows)
                        {
                            if (row.Cells["Status"].Value != null)
                            {
                                string status = row.Cells["Status"].Value.ToString();
                                if (status == "Completed")
                                {
                                    row.Cells["Status"].Style.BackColor = System.Drawing.Color.LightGreen;
                                    row.Cells["Status"].Style.ForeColor = System.Drawing.Color.DarkGreen;
                                }
                                else if (status == "Failed")
                                {
                                    row.Cells["Status"].Style.BackColor = System.Drawing.Color.LightCoral;
                                    row.Cells["Status"].Style.ForeColor = System.Drawing.Color.DarkRed;
                                }
                            }
                        }
                    }

                    lblStatus.Text = $"Ready - {dt.Rows.Count} records loaded";
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatus.Text = "Error loading report";
                lblStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReport();
            MessageBox.Show("Report refreshed successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;
                saveFileDialog.FileName = $"TransactionReport_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog.FileName))
                    {
                        for (int i = 0; i < dataGridViewReport.Columns.Count; i++)
                        {
                            if (dataGridViewReport.Columns[i].Visible)
                            {
                                sw.Write(dataGridViewReport.Columns[i].HeaderText);
                                if (i < dataGridViewReport.Columns.Count - 1)
                                    sw.Write(",");
                            }
                        }
                        sw.WriteLine();

                        foreach (DataGridViewRow row in dataGridViewReport.Rows)
                        {
                            for (int i = 0; i < dataGridViewReport.Columns.Count; i++)
                            {
                                if (dataGridViewReport.Columns[i].Visible)
                                {
                                    if (row.Cells[i].Value != null)
                                        sw.Write(row.Cells[i].Value.ToString());

                                    if (i < dataGridViewReport.Columns.Count - 1)
                                        sw.Write(",");
                                }
                            }
                            sw.WriteLine();
                        }
                    }

                    MessageBox.Show("Report exported successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting report: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Print feature:\n\n" +
                $"Total Records: {dataGridViewReport.Rows.Count}\n\n" +
                "This would send the report to the printer.\n" +
                "(Print simulation only)",
                "Print Report",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fromDate = dateTimePickerFrom.Value.Date;
                DateTime toDate = dateTimePickerTo.Value.Date.AddDays(1).AddSeconds(-1);

                string query = @"
                    SELECT 
                        t.TicketID AS 'ID',
                        t.TicketCode AS 'Ticket Code',
                        d.DestinationName AS 'Destination',
                        d.RouteCode AS 'Route',
                        t.Price AS 'Price (VND)',
                        t.PaymentMethod AS 'Payment Method',
                        t.PaymentStatus AS 'Status',
                        CONVERT(VARCHAR, t.IssueDate, 120) AS 'Issue Date'
                    FROM Tickets t
                    INNER JOIN Destinations d ON t.DestinationID = d.DestinationID
                    WHERE t.IssueDate BETWEEN @FromDate AND @ToDate
                    ORDER BY t.IssueDate DESC";

                using (var conn = DatabaseHelper.GetConnection())
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FromDate", fromDate);
                    cmd.Parameters.AddWithValue("@ToDate", toDate);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridViewReport.DataSource = dt;

                    lblStatus.Text = $"Filtered - {dt.Rows.Count} records from {fromDate:yyyy-MM-dd} to {toDate:yyyy-MM-dd}";
                    lblStatus.ForeColor = System.Drawing.Color.Blue;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering report: {ex.Message}", "Error");
            }
        }
    }
}