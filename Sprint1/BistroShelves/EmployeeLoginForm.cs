﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Bistro_Shelves
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cancelbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            //Kim's Connection:
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = @"Data Source=DESKTOP-28THE6N\MSSQLSERVER2017;Initial Catalog=Northwind;Integrated Security=True";
            
            SqlConnection SqlConnection = new SqlConnection(@"Data Source=DESKTOP-28THE6N\MSSQLSERVER2017;Initial Catalog=Northwind;Integrated Security=True");
            SqlConnection.Open();
            string username = usernametextBox.Text;
            string password = passwordtextBox.Text;
            SqlCommand cmd = new SqlCommand("select username, password from EmployeeLogin where username='" + usernametextBox.Text + "'and password='" + passwordtextBox.Text + "'", SqlConnection);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            
            if (dt.Rows.Count > 0)

                {
                this.Hide();
                FormInventoryCounts f2 = new FormInventoryCounts();
                f2.ShowDialog();           
                 }
             else
            {
            MessageBox.Show("Invalid Login. Check username and password.");

             }
            SqlConnection.Close();
        }
        
        private void cancelbutton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
