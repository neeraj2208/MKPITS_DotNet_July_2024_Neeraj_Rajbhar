using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Employe_Details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            string Gender="";
            if(radioButton1.Checked)
            {
                Gender = radioButton1.Text;
            }
            else
            {
                Gender = radioButton2.Text;
            }

            string str = "server=.\\SQLEXPRESS ;integrated security= true;database=Sample";

            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                string insert = "insert into Employee values('" + textBox1.Text + "','" + textBox2.Text + "','"+Gender+"','" + textBox3.Text + "','" + richTextBox1.Text + "')";
                SqlCommand command = new SqlCommand(insert, con);
                command.ExecuteNonQuery();
                con.Close();
                label7.Text = "Insered Successful";
                textBox1.Clear();
                textBox2.Clear();
                richTextBox1.Clear();
                textBox3.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (radioButton1.Checked)
            {
                Gender = radioButton1.Text;
            }
            else
            {
                Gender = radioButton2.Text;
            }

            string str = "server=.\\SQLEXPRESS ;integrated security= true;database=Sample";

            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                string insert = "update Employee set City='" + textBox2.Text + "',Gender='" + Gender + "',Contact='" + textBox3.Text + "',Address='" + richTextBox1.Text + "'where Name='" + textBox1.Text + "'";
                SqlCommand command = new SqlCommand(insert, con);
                command.ExecuteNonQuery();
                con.Close();
                label7.Text = "Update Successful";
                textBox1.Clear();
                textBox2.Clear();
                richTextBox1.Clear();
                textBox3.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            catch (Exception ex)    
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Gender = "";
            if (radioButton1.Checked)
            {
                Gender = radioButton1.Text;
            }
            else
            {
                Gender = radioButton2.Text;
            }

            string str = "server=.\\SQLEXPRESS ;integrated security= true;database=Sample";

            SqlConnection con = new SqlConnection(str);
            try
            {
                con.Open();
                string insert = "delete from Employee where City='" + textBox2.Text + "' or Gender='" + Gender + "' or Contact='" + textBox3.Text + "' or Address='" + richTextBox1.Text + "' or Name='" + textBox1.Text + "'";
                SqlCommand command = new SqlCommand(insert, con);
                command.ExecuteNonQuery();
                con.Close();
                label7.Text = "Delete Successful";
                textBox1.Clear();
                textBox2.Clear();
                richTextBox1.Clear();
                textBox3.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}