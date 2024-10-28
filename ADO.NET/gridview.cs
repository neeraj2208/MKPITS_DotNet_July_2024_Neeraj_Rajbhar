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

namespace GridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server=.\\SQLEXPRESS ;integrated security= true;database=Sample1";
        SqlConnection con = null;
        SqlCommand cmd = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                string st = "select count(*) from Admin where Username=@Username and Password=@Password";
                cmd = new SqlCommand(st, con);
                cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                cmd.Parameters.AddWithValue("@Password", textBox2.Text);
                con.Open();
                int cnt = Convert.ToInt32(cmd.ExecuteScalar());
                if (cnt > 0)
                {
                    label3.Text = "Successful";
                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();
                }
                else
                    label3.Text = "Invalid";

            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}