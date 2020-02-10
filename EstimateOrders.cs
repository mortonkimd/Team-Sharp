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

        private void btEstimate_Click(object sender, EventArgs e)
        {
            estimateOrder();
        }

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

            //Counts Units
            for (int i = 0; i < productCodesArray.GetLength(0); i++)
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

            //Par Cases
            for (int i = 0; i < productCodesArray.GetLength(0); i++)
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

            //Par Units
            for (int i = 0; i < productCodesArray.GetLength(0); i++)
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

            //Estimate Cases
            for (int i = 0; i < productCodesArray.GetLength(0); i++)
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT (SELECT Cases FROM BistroShelvesParRecords WHERE SetParDate = (SELECT MAX(SetParDate) FROM BistroShelvesParRecords) AND ProductCode =" + productCodesArray[i] + ") - " +
                    "(SELECT Cases FROM BistroShelvesCountRecords WHERE CountDate = (SELECT MAX(CountDate) FROM BistroShelvesCountRecords) AND ProductCode =" + productCodesArray[i] + ") AS Estimation;";

            SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())

                {
                    if (i == 0) { lbEstimationCases1.Text = reader["Estimation"].ToString(); }
                    else if (i == 1) { lbEstimationCases2.Text = reader["Estimation"].ToString(); }
                    else if (i == 2) { lbEstimationCases3.Text = reader["Estimation"].ToString(); }
                    else if (i == 3) { lbEstimationCases4.Text = reader["Estimation"].ToString(); }
                    else if (i == 4) { lbEstimationCases5.Text = reader["Estimation"].ToString(); }
                    else if (i == 5) { lbEstimationCases6.Text = reader["Estimation"].ToString(); }
                    else if (i == 6) { lbEstimationCases7.Text = reader["Estimation"].ToString(); }
                    else if (i == 7) { lbEstimationCases8.Text = reader["Estimation"].ToString(); }
                    else if (i == 8) { lbEstimationCases9.Text = reader["Estimation"].ToString(); }
                    else if (i == 9) { lbEstimationCases10.Text = reader["Estimation"].ToString(); }
                    else if (i == 10) { lbEstimationCases11.Text = reader["Estimation"].ToString(); }
                    else if (i == 11) { lbEstimationCases12.Text = reader["Estimation"].ToString(); }
                    else if (i == 12) { lbEstimationCases13.Text = reader["Estimation"].ToString(); }
                    else if (i == 13) { lbEstimationCases14.Text = reader["Estimation"].ToString(); }
                    else if (i == 14) { lbEstimationCases15.Text = reader["Estimation"].ToString(); }
                    else if (i == 15) { lbEstimationCases16.Text = reader["Estimation"].ToString(); }
                    else if (i == 16) { lbEstimationCases17.Text = reader["Estimation"].ToString(); }
                    else if (i == 17) { lbEstimationCases18.Text = reader["Estimation"].ToString(); }
                    else if (i == 18) { lbEstimationCases19.Text = reader["Estimation"].ToString(); }
                    else if (i == 19) { lbEstimationCases20.Text = reader["Estimation"].ToString(); }
                    else if (i == 20) { lbEstimationCases21.Text = reader["Estimation"].ToString(); }
                    else if (i == 21) { lbEstimationCases22.Text = reader["Estimation"].ToString(); }
                    else if (i == 22) { lbEstimationCases23.Text = reader["Estimation"].ToString(); }
                    else if (i == 23) { lbEstimationCases24.Text = reader["Estimation"].ToString(); }
                    else if (i == 24) { lbEstimationCases25.Text = reader["Estimation"].ToString(); }
                    else if (i == 25) { lbEstimationCases26.Text = reader["Estimation"].ToString(); }
                    else if (i == 26) { lbEstimationCases27.Text = reader["Estimation"].ToString(); }
                    else if (i == 27) { lbEstimationCases28.Text = reader["Estimation"].ToString(); }
                    else if (i == 28) { lbEstimationCases29.Text = reader["Estimation"].ToString(); }
                    else if (i == 29) { lbEstimationCases30.Text = reader["Estimation"].ToString(); }
                    else if (i == 30) { lbEstimationCases31.Text = reader["Estimation"].ToString(); }
                    else if (i == 31) { lbEstimationCases32.Text = reader["Estimation"].ToString(); }
                    else if (i == 32) { lbEstimationCases33.Text = reader["Estimation"].ToString(); }
                    else if (i == 33) { lbEstimationCases34.Text = reader["Estimation"].ToString(); }
                    else if (i == 34) { lbEstimationCases35.Text = reader["Estimation"].ToString(); }
                    else if (i == 35) { lbEstimationCases36.Text = reader["Estimation"].ToString(); }
                    else if (i == 36) { lbEstimationCases37.Text = reader["Estimation"].ToString(); }
                    else if (i == 37) { lbEstimationCases38.Text = reader["Estimation"].ToString(); }
                    else if (i == 38) { lbEstimationCases39.Text = reader["Estimation"].ToString(); }
                    else if (i == 39) { lbEstimationCases40.Text = reader["Estimation"].ToString(); }
                    else if (i == 40) { lbEstimationCases41.Text = reader["Estimation"].ToString(); }
                    else if (i == 41) { lbEstimationCases42.Text = reader["Estimation"].ToString(); }
                    else if (i == 42) { lbEstimationCases43.Text = reader["Estimation"].ToString(); }
                }

                reader.Close();
                connection.Close();
            }

            //Estimate Units
            for (int i = 0; i < productCodesArray.GetLength(0); i++)
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT (SELECT Units FROM BistroShelvesParRecords WHERE SetParDate = (SELECT MAX(SetParDate) FROM BistroShelvesParRecords) AND ProductCode =" + productCodesArray[i] + ") - " +
                    "(SELECT Units FROM BistroShelvesCountRecords WHERE CountDate = (SELECT MAX(CountDate) FROM BistroShelvesCountRecords) AND ProductCode =" + productCodesArray[i] + ") AS Estimation;";

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())

                {
                    if (i == 0) { lbEstimationUnits1.Text = reader["Estimation"].ToString(); }
                    else if (i == 1) { lbEstimationUnits2.Text = reader["Estimation"].ToString(); }
                    else if (i == 2) { lbEstimationUnits3.Text = reader["Estimation"].ToString(); }
                    else if (i == 3) { lbEstimationUnits4.Text = reader["Estimation"].ToString(); }
                    else if (i == 4) { lbEstimationUnits5.Text = reader["Estimation"].ToString(); }
                    else if (i == 5) { lbEstimationUnits6.Text = reader["Estimation"].ToString(); }
                    else if (i == 6) { lbEstimationUnits7.Text = reader["Estimation"].ToString(); }
                    else if (i == 7) { lbEstimationUnits8.Text = reader["Estimation"].ToString(); }
                    else if (i == 8) { lbEstimationUnits9.Text = reader["Estimation"].ToString(); }
                    else if (i == 9) { lbEstimationUnits10.Text = reader["Estimation"].ToString(); }
                    else if (i == 10) { lbEstimationUnits11.Text = reader["Estimation"].ToString(); }
                    else if (i == 11) { lbEstimationUnits12.Text = reader["Estimation"].ToString(); }
                    else if (i == 12) { lbEstimationUnits13.Text = reader["Estimation"].ToString(); }
                    else if (i == 13) { lbEstimationUnits14.Text = reader["Estimation"].ToString(); }
                    else if (i == 14) { lbEstimationUnits15.Text = reader["Estimation"].ToString(); }
                    else if (i == 15) { lbEstimationUnits16.Text = reader["Estimation"].ToString(); }
                    else if (i == 16) { lbEstimationUnits17.Text = reader["Estimation"].ToString(); }
                    else if (i == 17) { lbEstimationUnits18.Text = reader["Estimation"].ToString(); }
                    else if (i == 18) { lbEstimationUnits19.Text = reader["Estimation"].ToString(); }
                    else if (i == 19) { lbEstimationUnits20.Text = reader["Estimation"].ToString(); }
                    else if (i == 20) { lbEstimationUnits21.Text = reader["Estimation"].ToString(); }
                    else if (i == 21) { lbEstimationUnits22.Text = reader["Estimation"].ToString(); }
                    else if (i == 22) { lbEstimationUnits23.Text = reader["Estimation"].ToString(); }
                    else if (i == 23) { lbEstimationUnits24.Text = reader["Estimation"].ToString(); }
                    else if (i == 24) { lbEstimationUnits25.Text = reader["Estimation"].ToString(); }
                    else if (i == 25) { lbEstimationUnits26.Text = reader["Estimation"].ToString(); }
                    else if (i == 26) { lbEstimationUnits27.Text = reader["Estimation"].ToString(); }
                    else if (i == 27) { lbEstimationUnits28.Text = reader["Estimation"].ToString(); }
                    else if (i == 28) { lbEstimationUnits29.Text = reader["Estimation"].ToString(); }
                    else if (i == 29) { lbEstimationUnits30.Text = reader["Estimation"].ToString(); }
                    else if (i == 30) { lbEstimationUnits31.Text = reader["Estimation"].ToString(); }
                    else if (i == 31) { lbEstimationUnits32.Text = reader["Estimation"].ToString(); }
                    else if (i == 32) { lbEstimationUnits33.Text = reader["Estimation"].ToString(); }
                    else if (i == 33) { lbEstimationUnits34.Text = reader["Estimation"].ToString(); }
                    else if (i == 34) { lbEstimationUnits35.Text = reader["Estimation"].ToString(); }
                    else if (i == 35) { lbEstimationUnits36.Text = reader["Estimation"].ToString(); }
                    else if (i == 36) { lbEstimationUnits37.Text = reader["Estimation"].ToString(); }
                    else if (i == 37) { lbEstimationUnits38.Text = reader["Estimation"].ToString(); }
                    else if (i == 38) { lbEstimationUnits39.Text = reader["Estimation"].ToString(); }
                    else if (i == 39) { lbEstimationUnits40.Text = reader["Estimation"].ToString(); }
                    else if (i == 40) { lbEstimationUnits41.Text = reader["Estimation"].ToString(); }
                    else if (i == 41) { lbEstimationUnits42.Text = reader["Estimation"].ToString(); }
                    else if (i == 42) { lbEstimationUnits43.Text = reader["Estimation"].ToString(); }
                }

                reader.Close();
                connection.Close();
            }
        }

        private void btInventoryCounts2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventoryCounts f1 = new FormInventoryCounts();
            f1.ShowDialog();
        }

        private void btInventoryCounts1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormInventoryCounts f1 = new FormInventoryCounts();
            f1.ShowDialog();
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
