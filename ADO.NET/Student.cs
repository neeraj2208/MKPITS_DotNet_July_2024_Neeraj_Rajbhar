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

namespace Student
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentClass s = new StudentClass();
            string Gender = null;
            if(radioButton1.Checked)
            {
                Gender = "Male";
            }
            if(radioButton2.Checked) 
            {
                Gender = "Female";
            }
            string Hobby = null;
            if(checkBox1.Checked)
            {
                Hobby = "Cricket";
            }
            if(checkBox2.Checked)
            {
                if(Hobby!=null)
                {
                    Hobby = Hobby + " " + "Football";
                }
                else
                {
                    Hobby = "Football";
                }
            }
            string result = s.InsertStudent(Convert.ToInt32(textBox1.Text), textBox2.Text, comboBox1.Text, Gender, Hobby, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            cleartext();

        }
        public void cleartext()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            comboBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StudentClass s = new StudentClass();
            string Gender = null;
            if (radioButton1.Checked)
            {
                Gender = "Male";
            }
            if (radioButton2.Checked)
            {
                Gender = "Female";
            }
            string Hobby = null;
            if (checkBox1.Checked)
            {
                Hobby = "Cricket";
            }
            if (checkBox2.Checked)
            {
                if (Hobby != null)
                {
                    Hobby = Hobby + " " + "Football";
                }
                else
                {
                    Hobby = "Football";
                }
            }
            string result = s.UpdateStudent(Convert.ToInt32(textBox1.Text), textBox2.Text, comboBox1.Text, Gender, Hobby, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            cleartext();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            StudentClass s = new StudentClass();
           
            string result = s.DeleteStudent(Convert.ToInt32(textBox1.Text));
            label7.Text = result;
            cleartext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Student> li=new List<Student>();
            StudentClass s=new StudentClass();
            li = s.SearchStudent(Convert.ToInt32(textBox1.Text));
            textBox2.Text = li[0].Name;
            comboBox1.Text = li[0].City;
            string Gender = li[0].Gender;
            if(Gender=="Male")
            {
               radioButton1.Checked = true;
            }
            else if(Gender=="Female")
            {
                radioButton2.Checked = true;
            }
            string Hobby = li[0].Hobby;
            if (Hobby == "Cricket")
            {
                checkBox1.Checked = true;
            }
            if (Hobby=="Football")
            {
                checkBox2.Checked = true;

                if (Hobby != null)
                {
                    Hobby = Hobby + " " + "Football";
                }
                else
                {
                    Hobby = "Football";
                }
            }
            dateTimePicker1.Value.ToShortDateString();


        }
    }
}