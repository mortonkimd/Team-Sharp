using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bistro_Shelves
{
    public partial class CountsHistory : Form
    {
        public CountsHistory()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source =SIKEISHAS-PC\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security = True");
        SqlCommand command = new SqlCommand();

        private void btGetRecords_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                command.Connection = connection;

                //dateHistory1.Value    dateHistory2.Value
                command.CommandText = "SELECT * FROM BistroShelvesParRecords WHERE SetParDate BETWEEN '" + dateHistory1.Value + "' AND '" + dateHistory2.Value + "';";

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }

        }

        private void btNavInvCounts1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventoryCounts f2 = new FormInventoryCounts();
            f2.ShowDialog();
        }

        private void btNavInvCounts2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventoryCounts f2 = new FormInventoryCounts();
            f2.ShowDialog();
        }

        private void btNavEstimate2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstimateOrders f4 = new EstimateOrders();
            f4.ShowDialog();
        }

        private void btNavEstimate1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstimateOrders f4 = new EstimateOrders();
            f4.ShowDialog();
        }

        private void btNavSetPar1_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetParLevels f3 = new SetParLevels();
            f3.ShowDialog();
        }

        private void btNavSetPar2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SetParLevels f3 = new SetParLevels();
            f3.ShowDialog();
        }
    }
}
