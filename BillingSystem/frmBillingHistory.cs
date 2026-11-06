using BillingSystem.Database;
using MySql.Data.MySqlClient;
using ScottPlot.MultiplotLayouts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BillingSystem
{
    public partial class frmBillingHistory : Form
    {
        private int customerId;
        public frmBillingHistory(int customerId)
        {
            this.customerId = customerId;
            InitializeComponent();
            loadCustomerRecords();
        }

        private void ConfigureDataGridView()
        {
            billRecordDGV.AutoGenerateColumns = false;
            billRecordDGV.Columns["BillingMonth"].DataPropertyName = "BillingMonth";
            billRecordDGV.Columns["PreviousReading"].DataPropertyName = "PreviousReading";
            billRecordDGV.Columns["PresentReading"].DataPropertyName = "PresentReading";
            billRecordDGV.Columns["Consumption"].DataPropertyName = "Consumption";
            billRecordDGV.Columns["Rate"].DataPropertyName = "RatePerCubic";
            billRecordDGV.Columns["TotalAmount"].DataPropertyName = "TotalAmount";
            billRecordDGV.Columns["Status"].DataPropertyName = "Status";
        }

        private void loadCustomerRecords()
        {
            ConfigureDataGridView();
            try
            {
                using (var conn = DatabaseConnection.GetConnection())
                {
                    conn.Open();

                    String fillSql = "SELECT BillingMonth, PreviousReading, PresentReading, " +
                                     "Consumption, RatePerCubic, TotalAmount, Status " +
                                     "FROM Billing " +
                                     "WHERE CustomerID = @CustomerID " +
                                     "ORDER BY BillingMonth DESC;";

                    using (var adapter = new MySqlDataAdapter(fillSql, conn))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@CustomerID", customerId);

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        billRecordDGV.DataSource = dt;

                        if (billRecordDGV.Columns.Count > 0)
                        {
                            billRecordDGV.Columns["BillingMonth"].HeaderText = "Billing Month";
                            billRecordDGV.Columns["PreviousReading"].HeaderText = "Previous Reading";
                            billRecordDGV.Columns["PresentReading"].HeaderText = "Present Reading";
                            billRecordDGV.Columns["Consumption"].HeaderText = "Consumption";
                            billRecordDGV.Columns["Rate"].HeaderText = "Rate";
                            billRecordDGV.Columns["TotalAmount"].HeaderText = "Total Amount";
                            billRecordDGV.Columns["Status"].HeaderText = "Status";
                        }
                    }

                    String getNameSql = "SELECT FullName FROM Customers " +
                                        "WHERE CustomerID = @CustomerID;";
                    using (var cmd = new MySqlCommand(getNameSql, conn))
                    {
                        cmd.Parameters.AddWithValue("@CustomerID", customerId);

                        String customerName = Convert.ToString(cmd.ExecuteScalar());
                        titleLbl.Text = $"Billing History - {customerName}";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading table:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
