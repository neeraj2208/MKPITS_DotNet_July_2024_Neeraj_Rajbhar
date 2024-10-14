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

namespace Registration_Form
{
    public partial class FReg : Form
    {
        public FReg()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFemale.Checked == true)
            {
                chkMale.Checked = false;
            }
            if (chkFemale.Checked)
            {
                chkRes.Select();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMale.Checked == true)
            {
                chkFemale.Checked = false;
            }
            if (chkFemale.Checked)
            {
                chkRes.Select();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void chkRes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRes.Checked == true)
            {
                chkNRes.Checked = false;
                
            }
        }

        private void chkNRes_CheckedChanged(object sender, EventArgs e)
        {
            if(chkNRes.Checked == true)
            {
                chkRes.Checked = false;

            }
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Status="y",Gender="x";
            if (chkRes.Checked == true)
            {
                Status= "Residence";
            }else if (chkNRes.Checked == true)
            {
                Status = "Non-residence";
            }
            if(chkMale.Checked == true)
            {
                Gender = "Male";
            }else if(chkFemale.Checked == true)
            {
                Gender = "Female";
            }
            string BDate = txtD3.Text + txtD4.Text + txtM3.Text + txtM4.Text + txtY5.Text + txtY6.Text + txtY7.Text + txtY8.Text;
            string Date = txtD1.Text + txtD2.Text + txtM1.Text + txtM2.Text + txtY1.Text + txtY2.Text + txtY3.Text + txtY4.Text;
            string Id = txtId1.Text + txtId2.Text + txtId3.Text + txtId4.Text + txtId5.Text + txtId6.Text + txtId7.Text + txtId8.Text;

            SqlConnection con = new SqlConnection("Data Source=ZORO-HOME\\SQLEXPRESS;Initial Catalog=Assignment;Integrated Security=True;");
            con.Open();
            string query = "insert into GlobleCompany(ID,Date,MD,Name,BirthPlace,Gender,DateOfBirth,Address,Status,State,City,Country,MaritalStatus,Nationality,Region,NationalID,IDNo,Email,Phone,ZipCode)values('"+Id+"','"+Date+"','"+txtMDirector.Text+"','"+txtName.Text+"','"+txtPOB.Text+"','"+Gender+ "','"+BDate+"','"+txtAdd.Text+"','" + Status+"','"+txtState.Text+"','"+txtCity.Text+"','"+txtCountry+"','"+txtMStatus.Text+"','"+txtNationalID.Text+"','"+txtRegion.Text+"','"+txtNationalID.Text+"','"+txtIDNo.Text+"','"+txtEmail.Text+"','"+txtPhone+"','"+txtZip.Text+"')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Executed");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txtId1_TextChanged(object sender, EventArgs e)
        {
            if(txtId1.Text.Length > 0)
            {
                txtId2.Select();
            }
        }

        private void txtId2_TextChanged(object sender, EventArgs e)
        {
            if (txtId2.Text.Length > 0)
            {
                txtId3.Select();
            }
        }

        private void txtId3_TextChanged(object sender, EventArgs e)
        {
            if (txtId3.Text.Length > 0)
            {
                txtId4.Select();
            }
        }

        private void txtId4_TextChanged(object sender, EventArgs e)
        {
            if (txtId4.Text.Length > 0)
            {
                txtId5.Select();
            }
        }

        private void txtId5_TextChanged(object sender, EventArgs e)
        {
            if (txtId5.Text.Length > 0)
            {
                txtId6.Select();
            }
        }

        private void txtId6_TextChanged(object sender, EventArgs e)
        {
            if (txtId6.Text.Length > 0)
            {
                txtId7.Select();
            }
        }

        private void txtId7_TextChanged(object sender, EventArgs e)
        {
            if (txtId7.Text.Length > 0)
            {
                txtId8.Select();
            }
        }

        private void txtId8_TextChanged(object sender, EventArgs e)
        {
            if (txtId8.Text.Length > 0)
            {
                txtD1.Select();
            }
        }

        private void txtD1_TextChanged(object sender, EventArgs e)
        {
            if (txtD1.Text.Length > 0)
            {
                txtD2.Select();
            }
        }

        private void txtD2_TextChanged(object sender, EventArgs e)
        {
            if (txtD2.Text.Length > 0)
            {
                txtM1.Select();
            }
        }

        private void txtM1_TextChanged(object sender, EventArgs e)
        {
            if (txtM1.Text.Length > 0)
            {
                txtM2.Select();
            }
        }

        private void txtM2_TextChanged(object sender, EventArgs e)
        {
            if (txtM2.Text.Length > 0)
            {
                txtY1.Select();
            }
        }

        private void txtY1_TextChanged(object sender, EventArgs e)
        {
            if (txtY1.Text.Length > 0)
            {
                txtY2.Select();
            }
        }

        private void txtY2_TextChanged(object sender, EventArgs e)
        {
            if (txtY2.Text.Length > 0)
            {
                txtY3.Select();
            }
        }

        private void txtY3_TextChanged(object sender, EventArgs e)
        {
            if (txtY3.Text.Length > 0)
            {
                txtY4.Select();
            }
        }

        private void txtY4_TextChanged(object sender, EventArgs e)
        {
            if (txtY4.Text.Length > 0)
            {
                txtMDirector.Select();
            }
        }

        private void txtD3_TextChanged(object sender, EventArgs e)
        {
            if (txtD3.Text.Length > 0)
            {
                txtD4.Select();
            }
        }

        private void txtD4_TextChanged(object sender, EventArgs e)
        {
            if (txtD4.Text.Length > 0)
            {
                txtM3.Select();
            }
        }

        private void txtM3_TextChanged(object sender, EventArgs e)
        {
            if (txtM3.Text.Length > 0)
            {
                txtM4.Select();
            }
        }

        private void txtM4_TextChanged(object sender, EventArgs e)
        {
            if (txtM4.Text.Length > 0)
            {
                txtY5.Select();
            }
        }

        private void txtY5_TextChanged(object sender, EventArgs e)
        {
            if (txtY5.Text.Length > 0)
            {
                txtY6.Select();
            }
        }

        private void txtY6_TextChanged(object sender, EventArgs e)
        {
            if (txtY6.Text.Length > 0)
            {
                txtY7.Select();
            }
        }

        private void txtY7_TextChanged(object sender, EventArgs e)
        {
            if (txtY7.Text.Length > 0)
            {
                txtY8.Select();
            }
        }

        private void txtY8_TextChanged(object sender, EventArgs e)
        {
            if (txtY8.Text.Length > 0)
            {
                txtAdd.Select();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId1.Clear();
            txtId2.Clear();
            txtId3.Clear();
            txtId4.Clear();
            txtId5.Clear();
            txtId6.Clear();
            txtId7.Clear();
            txtId8.Clear();
            txtD1.Clear();
            txtD2.Clear();
            txtD3.Clear();
            txtD4.Clear();
            txtM1.Clear();
            txtM2.Clear();
            txtM3.Clear();
            txtM4.Clear();
            txtY1.Clear();
            txtY2.Clear();
            txtY3.Clear();
            txtY4.Clear();
            txtY5.Clear();
            txtY6.Clear();
            txtY7.Clear();
            txtY8.Clear();
            txtName.Clear();
            txtAdd.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtEmail.Clear();
            txtIDNo.Clear();
            txtMDirector.Clear();
            txtMStatus.Clear();
            txtNationalID.Clear();
            txtNationality.Clear();
            txtPhone.Clear();
            txtPOB.Clear();
            txtRegion.Clear();
            txtState.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMDirector_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
