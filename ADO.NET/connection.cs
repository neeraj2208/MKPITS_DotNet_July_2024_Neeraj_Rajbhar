using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "server=.\\SQLEXPRESS;integrated security=true;database=Sample";
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    MessageBox.Show("Connection Successful");
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = DatabaseCollection.Connect();
            if (con != null)
            {
                MessageBox.Show("Successfully Connected");
                con.Close();
            }
            else
            {
                MessageBox.Show("Could not connect to SQL Server");
            }
        }
    }

    public static class DatabaseCollection
    {
        public static SqlConnection Connect()
        {
            string connectionString = "server=.\\SQLEXPRESS;integrated security=true;database=Sample";
            try
            {
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                return con;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}");
                return null;
            }
        }
    }
}
