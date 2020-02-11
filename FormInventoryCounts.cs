using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bistro_Shelves
{
    public partial class FormInventoryCounts : Form
    {
        public FormInventoryCounts()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-28THE6N\MSSQLSERVER2017;Initial Catalog=Northwind;Integrated Security=True");
        SqlCommand command = new SqlCommand();

        private void recordCounts()
        {
            string[,] productLine2DArray = new string[43, 4]
            {
                { tbCases1.Text, lbPN1.Text, tbUnits1.Text, lbPC1.Text },
                { tbCases2.Text, lbPN2.Text, tbUnits2.Text, lbPC2.Text },
                { tbCases3.Text, lbPN3.Text, tbUnits3.Text, lbPC3.Text },
                { tbCases4.Text, lbPN4.Text, tbUnits4.Text, lbPC4.Text },
                { tbCases5.Text, lbPN5.Text, tbUnits5.Text, lbPC5.Text },
                { tbCases6.Text, lbPN6.Text, tbUnits6.Text, lbPC6.Text },
                { tbCases7.Text, lbPN7.Text, tbUnits7.Text, lbPC7.Text },
                { tbCases8.Text, lbPN8.Text, tbUnits8.Text, lbPC8.Text },
                { tbCases9.Text, lbPN9.Text, tbUnits9.Text, lbPC9.Text },
                { tbCases10.Text, lbPN10.Text, tbUnits10.Text, lbPC10.Text },
                { tbCases11.Text, lbPN11.Text, tbUnits11.Text, lbPC11.Text },
                { tbCases12.Text, lbPN12.Text, tbUnits12.Text, lbPC12.Text },
                { tbCases13.Text, lbPN13.Text, tbUnits13.Text, lbPC13.Text },
                { tbCases14.Text, lbPN14.Text, tbUnits14.Text, lbPC14.Text },
                { tbCases15.Text, lbPN15.Text, tbUnits15.Text, lbPC15.Text },
                { tbCases16.Text, lbPN16.Text, tbUnits16.Text, lbPC16.Text },
                { tbCases17.Text, lbPN17.Text, tbUnits17.Text, lbPC17.Text },
                { tbCases18.Text, lbPN18.Text, tbUnits18.Text, lbPC18.Text },
                { tbCases19.Text, lbPN19.Text, tbUnits19.Text, lbPC19.Text },
                { tbCases20.Text, lbPN20.Text, tbUnits20.Text, lbPC20.Text },
                { tbCases21.Text, lbPN21.Text, tbUnits21.Text, lbPC21.Text },
                { tbCases22.Text, lbPN22.Text, tbUnits22.Text, lbPC22.Text },
                { tbCases23.Text, lbPN23.Text, tbUnits23.Text, lbPC23.Text },
                { tbCases24.Text, lbPN24.Text, tbUnits24.Text, lbPC24.Text },
                { tbCases25.Text, lbPN25.Text, tbUnits25.Text, lbPC25.Text },
                { tbCases26.Text, lbPN26.Text, tbUnits26.Text, lbPC26.Text },
                { tbCases27.Text, lbPN27.Text, tbUnits27.Text, lbPC27.Text },
                { tbCases28.Text, lbPN28.Text, tbUnits28.Text, lbPC28.Text },
                { tbCases29.Text, lbPN29.Text, tbUnits29.Text, lbPC29.Text },
                { tbCases30.Text, lbPN30.Text, tbUnits30.Text, lbPC30.Text },
                { tbCases31.Text, lbPN31.Text, tbUnits31.Text, lbPC31.Text },
                { tbCases32.Text, lbPN32.Text, tbUnits32.Text, lbPC32.Text },
                { tbCases33.Text, lbPN33.Text, tbUnits33.Text, lbPC33.Text },
                { tbCases34.Text, lbPN34.Text, tbUnits34.Text, lbPC34.Text },
                { tbCases35.Text, lbPN35.Text, tbUnits35.Text, lbPC35.Text },
                { tbCases36.Text, lbPN36.Text, tbUnits36.Text, lbPC36.Text },
                { tbCases37.Text, lbPN37.Text, tbUnits37.Text, lbPC37.Text },
                { tbCases38.Text, lbPN38.Text, tbUnits38.Text, lbPC38.Text },
                { tbCases39.Text, lbPN39.Text, tbUnits39.Text, lbPC39.Text },
                { tbCases40.Text, lbPN40.Text, tbUnits40.Text, lbPC40.Text },
                { tbCases41.Text, lbPN41.Text, tbUnits41.Text, lbPC41.Text },
                { tbCases42.Text, lbPN42.Text, tbUnits42.Text, lbPC42.Text },
                { tbCases43.Text, lbPN43.Text, tbUnits43.Text, lbPC43.Text }
            };

            int blanks = 0;

            for (int i = 0; i < productLine2DArray.GetLength(0); i++)
            {
                if ((productLine2DArray[i, 0] == "") & (productLine2DArray[i, 2] == ""))
                {
                    blanks = blanks + 2;
                }
                else if (productLine2DArray[i, 0] == "")
                {
                    blanks++;
                }
                else if (productLine2DArray[i, 2] == "")
                {
                    blanks++;
                }
            }

            if (blanks > 3)
            {
                MessageBox.Show("Please complete the form.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for (int i = 0; i < productLine2DArray.GetLength(0); i++)
                {
                    if ((productLine2DArray[i, 0] == "") & (productLine2DArray[i, 2] == ""))
                    {
                        MessageBox.Show("Please enter CASES AND UNITS in the " + productLine2DArray[i, 1] + " line.", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (productLine2DArray[i, 0] == "")
                    {
                        MessageBox.Show(productLine2DArray[i, 1] + " CASES must not be EMPTY", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (productLine2DArray[i, 2] == "")
                    {
                        MessageBox.Show(productLine2DArray[i, 1] + " UNITS must not be EMPTY", "MessageBox", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

                if (blanks == 0)
                {
                    try
                    {
                        connection.Open();
                        command.Connection = connection;

                        for (int i = 0; i < productLine2DArray.GetLength(0); i++)
                        {
                            command.CommandText = "insert into BistroShelvesCountRecords (ProductCode, ProductName, Cases, Units, CountDate) " +
                                "values('" + productLine2DArray[i, 3] + "','" + productLine2DArray[i, 1] + "','" + productLine2DArray[i, 0] +
                                "','" + productLine2DArray[i, 2] + "','" + dateTimePicker.Value + "')";
                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Inventory Counts Saved");
                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        connection.Close();
                    }
                }
            }

        }

        private void btRecordCounts_Click_1(object sender, EventArgs e)
        {
            recordCounts();
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
               
        private void btEstimateOrders2_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstimateOrders f4 = new EstimateOrders();
            f4.ShowDialog();
        }

        private void btEstimateOrders1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EstimateOrders f4 = new EstimateOrders();
            f4.ShowDialog();
        }

        private void btNavHistory1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CountsHistory f5 = new CountsHistory();
            f5.ShowDialog();
        }

        private void btNavHistory2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CountsHistory f5 = new CountsHistory();
            f5.ShowDialog();
        }

        private void tbCases1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
