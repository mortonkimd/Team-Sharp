using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bistro_Shelves
{
    public partial class EstimateOrders : Form
    {
        public EstimateOrders()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"Data Source =SIKEISHAS-PC\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security = True");
        SqlCommand command = new SqlCommand();

        private void estimateOrder()
        {
            string[] productCodesArray = new string[43]
{
                "'NWTB-1'",
                "'NWTB-34'",
                "'NWTB-43'",
                "'NWTB-81'",
                "'NWTB-87'",
                "'NWTBGM-19'",
                "'NWTBGM-21'",
                "'NWTBGM-85'",
                "'NWTBGM-86'",
                "'NWTC-82'",
                "'NWTCA-48'",
                "'NWTCFV-17'",
                "'NWTCFV-88'",
                "'NWTCFV-89'",
                "'NWTCFV-90'",
                "'NWTCFV-91'",
                "'NWTCFV-92'",
                "'NWTCFV-93'",
                "'NWTCFV-94'",
                "'NWTCM-40'",
                "'NWTCM-95'",
                "'NWTCM-96'",
                "'NWTCO-3'",
                "'NWTCO-4'",
                "'NWTCO-77'",
                "'NWTCS-83'",
                "'NWTD-72'",
                "'NWTDFN-14'",
                "'NWTDFN-51'",
                "'NWTDFN-7'",
                "'NWTDFN-74'",
                "'NWTDFN-80'",
                "'NWTG-52'",
                "'NWTJP-6'",
                "'NWTO-5'",
                "'NWTP-56'",
                "'NWTP-57'",
                "'NWTS-65'",
                "'NWTS-66'",
                "'NWTS-8'",
                "'NWTSO-41'",
                "'NWTSO-98'",
                "'NWTSO-99'",
};

            //Counts Cases
            for (int i = 0; i < productCodesArray.GetLength(0); i++)
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT Cases FROM BistroShelvesCountRecords " +
                        "WHERE CountDate = (SELECT MAX(CountDate) FROM BistroShelvesCountRecords) AND ProductCode =" + productCodesArray[i];

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        if (i == 0) { lbCountsCases1.Text = reader["Cases"].ToString(); }
                        else if (i == 1) { lbCountsCases2.Text = reader["Cases"].ToString(); }
                        else if (i == 2) { lbCountsCases3.Text = reader["Cases"].ToString(); }
                        else if (i == 3) { lbCountsCases4.Text = reader["Cases"].ToString(); }
                        else if (i == 4) { lbCountsCases5.Text = reader["Cases"].ToString(); }
                        else if (i == 5) { lbCountsCases6.Text = reader["Cases"].ToString(); }
                        else if (i == 6) { lbCountsCases7.Text = reader["Cases"].ToString(); }
                        else if (i == 7) { lbCountsCases8.Text = reader["Cases"].ToString(); }
                        else if (i == 8) { lbCountsCases9.Text = reader["Cases"].ToString(); }
                        else if (i == 9) { lbCountsCases10.Text = reader["Cases"].ToString(); }
                        else if (i == 10) { lbCountsCases11.Text = reader["Cases"].ToString(); }
                        else if (i == 11) { lbCountsCases12.Text = reader["Cases"].ToString(); }
                        else if (i == 12) { lbCountsCases13.Text = reader["Cases"].ToString(); }
                        else if (i == 13) { lbCountsCases14.Text = reader["Cases"].ToString(); }
                        else if (i == 14) { lbCountsCases15.Text = reader["Cases"].ToString(); }
                        else if (i == 15) { lbCountsCases16.Text = reader["Cases"].ToString(); }
                        else if (i == 16) { lbCountsCases17.Text = reader["Cases"].ToString(); }
                        else if (i == 17) { lbCountsCases18.Text = reader["Cases"].ToString(); }
                        else if (i == 18) { lbCountsCases19.Text = reader["Cases"].ToString(); }
                        else if (i == 19) { lbCountsCases20.Text = reader["Cases"].ToString(); }
                        else if (i == 20) { lbCountsCases21.Text = reader["Cases"].ToString(); }
                        else if (i == 21) { lbCountsCases22.Text = reader["Cases"].ToString(); }
                        else if (i == 22) { lbCountsCases23.Text = reader["Cases"].ToString(); }
                        else if (i == 23) { lbCountsCases24.Text = reader["Cases"].ToString(); }
                        else if (i == 24) { lbCountsCases25.Text = reader["Cases"].ToString(); }
                        else if (i == 25) { lbCountsCases26.Text = reader["Cases"].ToString(); }
                        else if (i == 26) { lbCountsCases27.Text = reader["Cases"].ToString(); }
                        else if (i == 27) { lbCountsCases28.Text = reader["Cases"].ToString(); }
                        else if (i == 28) { lbCountsCases29.Text = reader["Cases"].ToString(); }
                        else if (i == 29) { lbCountsCases30.Text = reader["Cases"].ToString(); }
                        else if (i == 30) { lbCountsCases31.Text = reader["Cases"].ToString(); }
                        else if (i == 31) { lbCountsCases32.Text = reader["Cases"].ToString(); }
                        else if (i == 32) { lbCountsCases33.Text = reader["Cases"].ToString(); }
                        else if (i == 33) { lbCountsCases34.Text = reader["Cases"].ToString(); }
                        else if (i == 34) { lbCountsCases35.Text = reader["Cases"].ToString(); }
                        else if (i == 35) { lbCountsCases36.Text = reader["Cases"].ToString(); }
                        else if (i == 36) { lbCountsCases37.Text = reader["Cases"].ToString(); }
                        else if (i == 37) { lbCountsCases38.Text = reader["Cases"].ToString(); }
                        else if (i == 38) { lbCountsCases39.Text = reader["Cases"].ToString(); }
                        else if (i == 39) { lbCountsCases40.Text = reader["Cases"].ToString(); }
                        else if (i == 40) { lbCountsCases41.Text = reader["Cases"].ToString(); }
                        else if (i == 41) { lbCountsCases42.Text = reader["Cases"].ToString(); }
                        else if (i == 42) { lbCountsCases43.Text = reader["Cases"].ToString(); }
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }

            //Counts Units
            for (int i = 0; i < productCodesArray.GetLength(0); i++)
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT Units FROM BistroShelvesCountRecords " +
                        "WHERE CountDate = (SELECT MAX(CountDate) FROM BistroShelvesCountRecords) AND ProductCode =" + productCodesArray[i];

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        if (i == 0) { lbCountsUnits1.Text = reader["Units"].ToString(); }
                        else if (i == 1) { lbCountsUnits2.Text = reader["Units"].ToString(); }
                        else if (i == 2) { lbCountsUnits3.Text = reader["Units"].ToString(); }
                        else if (i == 3) { lbCountsUnits4.Text = reader["Units"].ToString(); }
                        else if (i == 4) { lbCountsUnits5.Text = reader["Units"].ToString(); }
                        else if (i == 5) { lbCountsUnits6.Text = reader["Units"].ToString(); }
                        else if (i == 6) { lbCountsUnits7.Text = reader["Units"].ToString(); }
                        else if (i == 7) { lbCountsUnits8.Text = reader["Units"].ToString(); }
                        else if (i == 8) { lbCountsUnits9.Text = reader["Units"].ToString(); }
                        else if (i == 9) { lbCountsUnits10.Text = reader["Units"].ToString(); }
                        else if (i == 10) { lbCountsUnits11.Text = reader["Units"].ToString(); }
                        else if (i == 11) { lbCountsUnits12.Text = reader["Units"].ToString(); }
                        else if (i == 12) { lbCountsUnits13.Text = reader["Units"].ToString(); }
                        else if (i == 13) { lbCountsUnits14.Text = reader["Units"].ToString(); }
                        else if (i == 14) { lbCountsUnits15.Text = reader["Units"].ToString(); }
                        else if (i == 15) { lbCountsUnits16.Text = reader["Units"].ToString(); }
                        else if (i == 16) { lbCountsUnits17.Text = reader["Units"].ToString(); }
                        else if (i == 17) { lbCountsUnits18.Text = reader["Units"].ToString(); }
                        else if (i == 18) { lbCountsUnits19.Text = reader["Units"].ToString(); }
                        else if (i == 19) { lbCountsUnits20.Text = reader["Units"].ToString(); }
                        else if (i == 20) { lbCountsUnits21.Text = reader["Units"].ToString(); }
                        else if (i == 21) { lbCountsUnits22.Text = reader["Units"].ToString(); }
                        else if (i == 22) { lbCountsUnits23.Text = reader["Units"].ToString(); }
                        else if (i == 23) { lbCountsUnits24.Text = reader["Units"].ToString(); }
                        else if (i == 24) { lbCountsUnits25.Text = reader["Units"].ToString(); }
                        else if (i == 25) { lbCountsUnits26.Text = reader["Units"].ToString(); }
                        else if (i == 26) { lbCountsUnits27.Text = reader["Units"].ToString(); }
                        else if (i == 27) { lbCountsUnits28.Text = reader["Units"].ToString(); }
                        else if (i == 28) { lbCountsUnits29.Text = reader["Units"].ToString(); }
                        else if (i == 29) { lbCountsUnits30.Text = reader["Units"].ToString(); }
                        else if (i == 30) { lbCountsUnits31.Text = reader["Units"].ToString(); }
                        else if (i == 31) { lbCountsUnits32.Text = reader["Units"].ToString(); }
                        else if (i == 32) { lbCountsUnits33.Text = reader["Units"].ToString(); }
                        else if (i == 33) { lbCountsUnits34.Text = reader["Units"].ToString(); }
                        else if (i == 34) { lbCountsUnits35.Text = reader["Units"].ToString(); }
                        else if (i == 35) { lbCountsUnits36.Text = reader["Units"].ToString(); }
                        else if (i == 36) { lbCountsUnits37.Text = reader["Units"].ToString(); }
                        else if (i == 37) { lbCountsUnits38.Text = reader["Units"].ToString(); }
                        else if (i == 38) { lbCountsUnits39.Text = reader["Units"].ToString(); }
                        else if (i == 39) { lbCountsUnits40.Text = reader["Units"].ToString(); }
                        else if (i == 40) { lbCountsUnits41.Text = reader["Units"].ToString(); }
                        else if (i == 41) { lbCountsUnits42.Text = reader["Units"].ToString(); }
                        else if (i == 42) { lbCountsUnits43.Text = reader["Units"].ToString(); }
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }

            //Par Cases
            for (int i = 0; i < productCodesArray.GetLength(0); i++)
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT Cases FROM BistroShelvesParRecords " +
                        "WHERE SetParDate = (SELECT MAX(SetParDate) FROM BistroShelvesParRecords) AND ProductCode =" + productCodesArray[i];

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        if (i == 0) { lbParCases1.Text = reader["Cases"].ToString(); }
                        else if (i == 1) { lbParCases2.Text = reader["Cases"].ToString(); }
                        else if (i == 2) { lbParCases3.Text = reader["Cases"].ToString(); }
                        else if (i == 3) { lbParCases4.Text = reader["Cases"].ToString(); }
                        else if (i == 4) { lbParCases5.Text = reader["Cases"].ToString(); }
                        else if (i == 5) { lbParCases6.Text = reader["Cases"].ToString(); }
                        else if (i == 6) { lbParCases7.Text = reader["Cases"].ToString(); }
                        else if (i == 7) { lbParCases8.Text = reader["Cases"].ToString(); }
                        else if (i == 8) { lbParCases9.Text = reader["Cases"].ToString(); }
                        else if (i == 9) { lbParCases10.Text = reader["Cases"].ToString(); }
                        else if (i == 10) { lbParCases11.Text = reader["Cases"].ToString(); }
                        else if (i == 11) { lbParCases12.Text = reader["Cases"].ToString(); }
                        else if (i == 12) { lbParCases13.Text = reader["Cases"].ToString(); }
                        else if (i == 13) { lbParCases14.Text = reader["Cases"].ToString(); }
                        else if (i == 14) { lbParCases15.Text = reader["Cases"].ToString(); }
                        else if (i == 15) { lbParCases16.Text = reader["Cases"].ToString(); }
                        else if (i == 16) { lbParCases17.Text = reader["Cases"].ToString(); }
                        else if (i == 17) { lbParCases18.Text = reader["Cases"].ToString(); }
                        else if (i == 18) { lbParCases19.Text = reader["Cases"].ToString(); }
                        else if (i == 19) { lbParCases20.Text = reader["Cases"].ToString(); }
                        else if (i == 20) { lbParCases21.Text = reader["Cases"].ToString(); }
                        else if (i == 21) { lbParCases22.Text = reader["Cases"].ToString(); }
                        else if (i == 22) { lbParCases23.Text = reader["Cases"].ToString(); }
                        else if (i == 23) { lbParCases24.Text = reader["Cases"].ToString(); }
                        else if (i == 24) { lbParCases25.Text = reader["Cases"].ToString(); }
                        else if (i == 25) { lbParCases26.Text = reader["Cases"].ToString(); }
                        else if (i == 26) { lbParCases27.Text = reader["Cases"].ToString(); }
                        else if (i == 27) { lbParCases28.Text = reader["Cases"].ToString(); }
                        else if (i == 28) { lbParCases29.Text = reader["Cases"].ToString(); }
                        else if (i == 29) { lbParCases30.Text = reader["Cases"].ToString(); }
                        else if (i == 30) { lbParCases31.Text = reader["Cases"].ToString(); }
                        else if (i == 31) { lbParCases32.Text = reader["Cases"].ToString(); }
                        else if (i == 32) { lbParCases33.Text = reader["Cases"].ToString(); }
                        else if (i == 33) { lbParCases34.Text = reader["Cases"].ToString(); }
                        else if (i == 34) { lbParCases35.Text = reader["Cases"].ToString(); }
                        else if (i == 35) { lbParCases36.Text = reader["Cases"].ToString(); }
                        else if (i == 36) { lbParCases37.Text = reader["Cases"].ToString(); }
                        else if (i == 37) { lbParCases38.Text = reader["Cases"].ToString(); }
                        else if (i == 38) { lbParCases39.Text = reader["Cases"].ToString(); }
                        else if (i == 39) { lbParCases40.Text = reader["Cases"].ToString(); }
                        else if (i == 40) { lbParCases41.Text = reader["Cases"].ToString(); }
                        else if (i == 41) { lbParCases42.Text = reader["Cases"].ToString(); }
                        else if (i == 42) { lbParCases43.Text = reader["Cases"].ToString(); }
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }

            //Par Units
            for (int i = 0; i < productCodesArray.GetLength(0); i++)
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT Units FROM BistroShelvesParRecords " +
                        "WHERE SetParDate = (SELECT MAX(SetParDate) FROM BistroShelvesParRecords) AND ProductCode =" + productCodesArray[i];

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        if (i == 0) { lbParUnits1.Text = reader["Units"].ToString(); }
                        else if (i == 1) { lbParUnits2.Text = reader["Units"].ToString(); }
                        else if (i == 2) { lbParUnits3.Text = reader["Units"].ToString(); }
                        else if (i == 3) { lbParUnits4.Text = reader["Units"].ToString(); }
                        else if (i == 4) { lbParUnits5.Text = reader["Units"].ToString(); }
                        else if (i == 5) { lbParUnits6.Text = reader["Units"].ToString(); }
                        else if (i == 6) { lbParUnits7.Text = reader["Units"].ToString(); }
                        else if (i == 7) { lbParUnits8.Text = reader["Units"].ToString(); }
                        else if (i == 8) { lbParUnits9.Text = reader["Units"].ToString(); }
                        else if (i == 9) { lbParUnits10.Text = reader["Units"].ToString(); }
                        else if (i == 10) { lbParUnits11.Text = reader["Units"].ToString(); }
                        else if (i == 11) { lbParUnits12.Text = reader["Units"].ToString(); }
                        else if (i == 12) { lbParUnits13.Text = reader["Units"].ToString(); }
                        else if (i == 13) { lbParUnits14.Text = reader["Units"].ToString(); }
                        else if (i == 14) { lbParUnits15.Text = reader["Units"].ToString(); }
                        else if (i == 15) { lbParUnits16.Text = reader["Units"].ToString(); }
                        else if (i == 16) { lbParUnits17.Text = reader["Units"].ToString(); }
                        else if (i == 17) { lbParUnits18.Text = reader["Units"].ToString(); }
                        else if (i == 18) { lbParUnits19.Text = reader["Units"].ToString(); }
                        else if (i == 19) { lbParUnits20.Text = reader["Units"].ToString(); }
                        else if (i == 20) { lbParUnits21.Text = reader["Units"].ToString(); }
                        else if (i == 21) { lbParUnits22.Text = reader["Units"].ToString(); }
                        else if (i == 22) { lbParUnits23.Text = reader["Units"].ToString(); }
                        else if (i == 23) { lbParUnits24.Text = reader["Units"].ToString(); }
                        else if (i == 24) { lbParUnits25.Text = reader["Units"].ToString(); }
                        else if (i == 25) { lbParUnits26.Text = reader["Units"].ToString(); }
                        else if (i == 26) { lbParUnits27.Text = reader["Units"].ToString(); }
                        else if (i == 27) { lbParUnits28.Text = reader["Units"].ToString(); }
                        else if (i == 28) { lbParUnits29.Text = reader["Units"].ToString(); }
                        else if (i == 29) { lbParUnits30.Text = reader["Units"].ToString(); }
                        else if (i == 30) { lbParUnits31.Text = reader["Units"].ToString(); }
                        else if (i == 31) { lbParUnits32.Text = reader["Units"].ToString(); }
                        else if (i == 32) { lbParUnits33.Text = reader["Units"].ToString(); }
                        else if (i == 33) { lbParUnits34.Text = reader["Units"].ToString(); }
                        else if (i == 34) { lbParUnits35.Text = reader["Units"].ToString(); }
                        else if (i == 35) { lbParUnits36.Text = reader["Units"].ToString(); }
                        else if (i == 36) { lbParUnits37.Text = reader["Units"].ToString(); }
                        else if (i == 37) { lbParUnits38.Text = reader["Units"].ToString(); }
                        else if (i == 38) { lbParUnits39.Text = reader["Units"].ToString(); }
                        else if (i == 39) { lbParUnits40.Text = reader["Units"].ToString(); }
                        else if (i == 40) { lbParUnits41.Text = reader["Units"].ToString(); }
                        else if (i == 41) { lbParUnits42.Text = reader["Units"].ToString(); }
                        else if (i == 42) { lbParUnits43.Text = reader["Units"].ToString(); }
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }

            //Estimate Cases
            for (int i = 0; i < productCodesArray.GetLength(0); i++)
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT (SELECT Cases FROM BistroShelvesParRecords WHERE SetParDate = " +
                        "(SELECT MAX(SetParDate) FROM BistroShelvesParRecords) AND ProductCode =" + productCodesArray[i] + ") - " +
                        "(SELECT Cases FROM BistroShelvesCountRecords WHERE CountDate = " +
                        "(SELECT MAX(CountDate) FROM BistroShelvesCountRecords) AND ProductCode =" + productCodesArray[i] + ") AS Estimation;";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())

                    {
                        int value = Convert.ToInt32(reader["Estimation"]);

                        if (i == 0)
                        {
                            if (value < 0)
                            { lbEstimationCases1.Text = "0"; }
                            else
                            { lbEstimationCases1.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 1)
                        {
                            if (value < 0)
                            { lbEstimationCases2.Text = "0"; }
                            else { lbEstimationCases2.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 2)
                        {
                            if (value < 0)
                            { lbEstimationCases3.Text = "0"; }
                            else { lbEstimationCases3.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 3)
                        {
                            if (value < 0)
                            { lbEstimationCases4.Text = "0"; }
                            else { lbEstimationCases4.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 4)
                        {
                            if (value < 0)
                            { lbEstimationCases5.Text = "0"; }
                            else { lbEstimationCases5.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 5)
                        {
                            if (value < 0)
                            { lbEstimationCases6.Text = "0"; }
                            else { lbEstimationCases6.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 6)
                        {
                            if (value < 0)
                            { lbEstimationCases7.Text = "0"; }
                            else { lbEstimationCases7.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 7)
                        {
                            if (value < 0)
                            { lbEstimationCases8.Text = "0"; }
                            else { lbEstimationCases8.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 8)
                        {
                            if (value < 0)
                            { lbEstimationCases9.Text = "0"; }
                            else { lbEstimationCases9.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 9)
                        {
                            if (value < 0)
                            { lbEstimationCases10.Text = "0"; }
                            else { lbEstimationCases10.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 10)
                        {
                            if (value < 0)
                            { lbEstimationCases11.Text = "0"; }
                            else { lbEstimationCases11.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 11)
                        {
                            if (value < 0)
                            { lbEstimationCases12.Text = "0"; }
                            else { lbEstimationCases12.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 12)
                        {
                            if (value < 0)
                            { lbEstimationCases13.Text = "0"; }
                            else { lbEstimationCases13.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 13)
                        {
                            if (value < 0)
                            { lbEstimationCases14.Text = "0"; }
                            else { lbEstimationCases14.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 14)
                        {
                            if (value < 0)
                            { lbEstimationCases15.Text = "0"; }
                            else { lbEstimationCases15.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 15)
                        {
                            if (value < 0)
                            { lbEstimationCases16.Text = "0"; }
                            else { lbEstimationCases16.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 16)
                        {
                            if (value < 0)
                            { lbEstimationCases17.Text = "0"; }
                            else { lbEstimationCases17.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 17)
                        {
                            if (value < 0)
                            { lbEstimationCases18.Text = "0"; }
                            else { lbEstimationCases18.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 18)
                        {
                            if (value < 0)
                            { lbEstimationCases19.Text = "0"; }
                            else { lbEstimationCases19.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 19)
                        {
                            if (value < 0)
                            { lbEstimationCases20.Text = "0"; }
                            else { lbEstimationCases20.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 20)
                        {
                            if (value < 0)
                            { lbEstimationCases21.Text = "0"; }
                            else { lbEstimationCases21.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 21)
                        {
                            if (value < 0)
                            { lbEstimationCases22.Text = "0"; }
                            else { lbEstimationCases22.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 22)
                        {
                            if (value < 0)
                            { lbEstimationCases23.Text = "0"; }
                            else { lbEstimationCases23.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 23)
                        {
                            if (value < 0)
                            { lbEstimationCases24.Text = "0"; }
                            else { lbEstimationCases24.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 24)
                        {
                            if (value < 0)
                            { lbEstimationCases25.Text = "0"; }
                            else { lbEstimationCases25.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 25)
                        {
                            if (value < 0)
                            { lbEstimationCases26.Text = "0"; }
                            else { lbEstimationCases26.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 26)
                        {
                            if (value < 0)
                            { lbEstimationCases27.Text = "0"; }
                            else { lbEstimationCases27.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 27)
                        {
                            if (value < 0)
                            { lbEstimationCases28.Text = "0"; }
                            else { lbEstimationCases28.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 28)
                        {
                            if (value < 0)
                            { lbEstimationCases29.Text = "0"; }
                            else { lbEstimationCases29.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 29)
                        {
                            if (value < 0)
                            { lbEstimationCases30.Text = "0"; }
                            else { lbEstimationCases30.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 30)
                        {
                            if (value < 0)
                            { lbEstimationCases31.Text = "0"; }
                            else { lbEstimationCases31.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 31)
                        {
                            if (value < 0)
                            { lbEstimationCases32.Text = "0"; }
                            else { lbEstimationCases32.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 32)
                        {
                            if (value < 0)
                            { lbEstimationCases33.Text = "0"; }
                            else { lbEstimationCases33.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 33)
                        {
                            if (value < 0)
                            { lbEstimationCases34.Text = "0"; }
                            else { lbEstimationCases34.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 34)
                        {
                            if (value < 0)
                            { lbEstimationCases35.Text = "0"; }
                            else { lbEstimationCases35.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 35)
                        {
                            if (value < 0)
                            { lbEstimationCases36.Text = "0"; }
                            else { lbEstimationCases36.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 36)
                        {
                            if (value < 0)
                            { lbEstimationCases37.Text = "0"; }
                            else { lbEstimationCases37.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 37)
                        {
                            if (value < 0)
                            { lbEstimationCases38.Text = "0"; }
                            else { lbEstimationCases38.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 38)
                        {
                            if (value < 0)
                            { lbEstimationCases39.Text = "0"; }
                            else { lbEstimationCases39.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 39)
                        {
                            if (value < 0)
                            { lbEstimationCases40.Text = "0"; }
                            else { lbEstimationCases40.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 40)
                        {
                            if (value < 0)
                            { lbEstimationCases41.Text = "0"; }
                            else { lbEstimationCases41.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 41)
                        {
                            if (value < 0)
                            { lbEstimationCases42.Text = "0"; }
                            else { lbEstimationCases42.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 42)
                        {
                            if (value < 0)
                            { lbEstimationCases43.Text = "0"; }
                            else { lbEstimationCases43.Text = reader["Estimation"].ToString(); }
                        }
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }

            //Estimate Units
            for (int i = 0; i < productCodesArray.GetLength(0); i++)
            {
                try
                {
                    connection.Open();
                    command.Connection = connection;
                    command.CommandText = "SELECT (SELECT Units FROM BistroShelvesParRecords WHERE SetParDate = " +
                        "(SELECT MAX(SetParDate) FROM BistroShelvesParRecords) AND ProductCode =" + productCodesArray[i] + ") - " +
                        "(SELECT Units FROM BistroShelvesCountRecords WHERE CountDate = " +
                        "(SELECT MAX(CountDate) FROM BistroShelvesCountRecords) AND ProductCode =" + productCodesArray[i] + ") AS Estimation;";

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())

                    {
                        int value = Convert.ToInt32(reader["Estimation"]);

                        if (i == 0)
                        {
                            if (value < 0)
                            { lbEstimationUnits1.Text = "0"; }
                            else
                            { lbEstimationUnits1.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 1)
                        {
                            if (value < 0)
                            { lbEstimationUnits2.Text = "0"; }
                            else { lbEstimationUnits2.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 2)
                        {
                            if (value < 0)
                            { lbEstimationUnits3.Text = "0"; }
                            else { lbEstimationUnits3.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 3)
                        {
                            if (value < 0)
                            { lbEstimationUnits4.Text = "0"; }
                            else { lbEstimationUnits4.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 4)
                        {
                            if (value < 0)
                            { lbEstimationUnits5.Text = "0"; }
                            else { lbEstimationUnits5.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 5)
                        {
                            if (value < 0)
                            { lbEstimationUnits6.Text = "0"; }
                            else { lbEstimationUnits6.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 6)
                        {
                            if (value < 0)
                            { lbEstimationUnits7.Text = "0"; }
                            else { lbEstimationUnits7.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 7)
                        {
                            if (value < 0)
                            { lbEstimationUnits8.Text = "0"; }
                            else { lbEstimationUnits8.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 8)
                        {
                            if (value < 0)
                            { lbEstimationUnits9.Text = "0"; }
                            else { lbEstimationUnits9.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 9)
                        {
                            if (value < 0)
                            { lbEstimationUnits10.Text = "0"; }
                            else { lbEstimationUnits10.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 10)
                        {
                            if (value < 0)
                            { lbEstimationUnits11.Text = "0"; }
                            else { lbEstimationUnits11.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 11)
                        {
                            if (value < 0)
                            { lbEstimationUnits12.Text = "0"; }
                            else { lbEstimationUnits12.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 12)
                        {
                            if (value < 0)
                            { lbEstimationUnits13.Text = "0"; }
                            else { lbEstimationUnits13.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 13)
                        {
                            if (value < 0)
                            { lbEstimationUnits14.Text = "0"; }
                            else { lbEstimationUnits14.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 14)
                        {
                            if (value < 0)
                            { lbEstimationUnits15.Text = "0"; }
                            else { lbEstimationUnits15.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 15)
                        {
                            if (value < 0)
                            { lbEstimationUnits16.Text = "0"; }
                            else { lbEstimationUnits16.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 16)
                        {
                            if (value < 0)
                            { lbEstimationUnits17.Text = "0"; }
                            else { lbEstimationUnits17.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 17)
                        {
                            if (value < 0)
                            { lbEstimationUnits18.Text = "0"; }
                            else { lbEstimationUnits18.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 18)
                        {
                            if (value < 0)
                            { lbEstimationUnits19.Text = "0"; }
                            else { lbEstimationUnits19.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 19)
                        {
                            if (value < 0)
                            { lbEstimationUnits20.Text = "0"; }
                            else { lbEstimationUnits20.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 20)
                        {
                            if (value < 0)
                            { lbEstimationUnits21.Text = "0"; }
                            else { lbEstimationUnits21.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 21)
                        {
                            if (value < 0)
                            { lbEstimationUnits22.Text = "0"; }
                            else { lbEstimationUnits22.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 22)
                        {
                            if (value < 0)
                            { lbEstimationUnits23.Text = "0"; }
                            else { lbEstimationUnits23.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 23)
                        {
                            if (value < 0)
                            { lbEstimationUnits24.Text = "0"; }
                            else { lbEstimationUnits24.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 24)
                        {
                            if (value < 0)
                            { lbEstimationUnits25.Text = "0"; }
                            else { lbEstimationUnits25.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 25)
                        {
                            if (value < 0)
                            { lbEstimationUnits26.Text = "0"; }
                            else { lbEstimationUnits26.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 26)
                        {
                            if (value < 0)
                            { lbEstimationUnits27.Text = "0"; }
                            else { lbEstimationUnits27.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 27)
                        {
                            if (value < 0)
                            { lbEstimationUnits28.Text = "0"; }
                            else { lbEstimationUnits28.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 28)
                        {
                            if (value < 0)
                            { lbEstimationUnits29.Text = "0"; }
                            else { lbEstimationUnits29.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 29)
                        {
                            if (value < 0)
                            { lbEstimationUnits30.Text = "0"; }
                            else { lbEstimationUnits30.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 30)
                        {
                            if (value < 0)
                            { lbEstimationUnits31.Text = "0"; }
                            else { lbEstimationUnits31.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 31)
                        {
                            if (value < 0)
                            { lbEstimationUnits32.Text = "0"; }
                            else { lbEstimationUnits32.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 32)
                        {
                            if (value < 0)
                            { lbEstimationUnits33.Text = "0"; }
                            else { lbEstimationUnits33.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 33)
                        {
                            if (value < 0)
                            { lbEstimationUnits34.Text = "0"; }
                            else { lbEstimationUnits34.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 34)
                        {
                            if (value < 0)
                            { lbEstimationUnits35.Text = "0"; }
                            else { lbEstimationUnits35.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 35)
                        {
                            if (value < 0)
                            { lbEstimationUnits36.Text = "0"; }
                            else { lbEstimationUnits36.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 36)
                        {
                            if (value < 0)
                            { lbEstimationUnits37.Text = "0"; }
                            else { lbEstimationUnits37.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 37)
                        {
                            if (value < 0)
                            { lbEstimationUnits38.Text = "0"; }
                            else { lbEstimationUnits38.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 38)
                        {
                            if (value < 0)
                            { lbEstimationUnits39.Text = "0"; }
                            else { lbEstimationUnits39.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 39)
                        {
                            if (value < 0)
                            { lbEstimationUnits40.Text = "0"; }
                            else { lbEstimationUnits40.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 40)
                        {
                            if (value < 0)
                            { lbEstimationUnits41.Text = "0"; }
                            else { lbEstimationUnits41.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 41)
                        {
                            if (value < 0)
                            { lbEstimationUnits42.Text = "0"; }
                            else { lbEstimationUnits42.Text = reader["Estimation"].ToString(); }
                        }
                        else if (i == 42)
                        {
                            if (value < 0)
                            { lbEstimationUnits43.Text = "0"; }
                            else { lbEstimationUnits43.Text = reader["Estimation"].ToString(); }
                        }
                    }

                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    connection.Close();
                }
            }
        }

        private void btNavHistory1_Click_1(object sender, EventArgs e)
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

        private void btInventoryCounts1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventoryCounts f2 = new FormInventoryCounts();
            f2.ShowDialog();
        }
                       
        private void btEstimate_Click(object sender, EventArgs e)
        {
            estimateOrder();
        }

        private void btInventoryCounts2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FormInventoryCounts f2 = new FormInventoryCounts();
            f2.ShowDialog();
        }
    }
}
