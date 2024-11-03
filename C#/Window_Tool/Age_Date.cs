using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Age_Date
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string age = dateTimePicker1.Text;
            MessageBox.Show("Date of birth: " + age);
            int year = dateTimePicker1.Value.Year;
            MessageBox.Show("Birthday Year:" + year);
            int current = DateTime.Now.Year;
            MessageBox.Show("Current year: " + current);
            int differnce = current - Convert.ToInt32(year);
            MessageBox.Show("Your age is: " + differnce);
        }
    }
}