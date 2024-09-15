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
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace global_group_company_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void txtId1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        private void label43_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtId2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId6_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId7_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label62_Click(object sender, EventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label53_Click(object sender, EventArgs e)
        {

        }

        private void chkMale_CheckedChanged(object sender, EventArgs e)
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

        private void chkFemale_CheckedChanged(object sender, EventArgs e)
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

        private void chkRes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkRes.Checked == true)
            {
                chkNRes.Checked = false;

            }
        }

        private void chkNRes_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNRes.Checked == true)
            {
                chkRes.Checked = false;

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
            ComCity.ResetText();
            ComCountry.ResetText();
            txtEmail.Clear();
            txtIDNo.Clear();
            txtMDirector.Clear();
            txtMStatus.Clear();
            txtNationalID.Clear();
            txtNationality.Clear();
            txtPhone.Clear();
            txtPOB.Clear();
            txtRegion.Clear();
            ComState.ResetText();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    string Status = "y", Gender = "x";
        //    if (chkRes.Checked == true)
        //    {
        //        Status = "Residence";
        //    }
        //    else if (chkNRes.Checked == true)
        //    {
        //        Status = "Non-residence";
        //    }
        //    if (chkMale.Checked == true)
        //    {
        //        Gender = "Male";
        //    }
        //    else if (chkFemale.Checked == true)
        //    {
        //        Gender = "Female";
        //    }
        //    string BDate = txtD3.Text + txtD4.Text + txtM3.Text + txtM4.Text + txtY5.Text + txtY6.Text + txtY7.Text + txtY8.Text;
        //    string Date = txtD1.Text + txtD2.Text + txtM1.Text + txtM2.Text + txtY1.Text + txtY2.Text + txtY3.Text + txtY4.Text;
        //    string Id = txtId1.Text + txtId2.Text + txtId3.Text + txtId4.Text + txtId5.Text + txtId6.Text + txtId7.Text + txtId8.Text;

        //    SqlConnection con = new SqlConnection("Data Source=DESKTOP-9886DUR\\SQLEXPRESS;Initial Catalog=db_Student_Info;Integrated Security=True;");
        //    con.Open();
        //    string Insquery = "insert into registration(ID,Date,MDirector,Name,BirthPlace,Gender,DateOfBirth,Address,Status,State,City,Country,MaritalStatus,Nationality,Region,NationalID,IDNo,Email,Phone,ZipCode)values('" + Id + "','" + Date + "','" + txtMDirector.Text + "','" + txtName.Text + "','" + txtPOB.Text + "','" + Gender + "','" + BDate + "','" + txtAdd.Text + "','" + Status + "','" + ComState.Text + "','" + ComCity.Text + "','" + ComCountry.Text + "','" + txtMStatus.Text + "','" + txtNationality.Text + "','" + txtRegion.Text + "','" + txtNationalID.Text + "','" + txtIDNo.Text + "','" + txtEmail.Text + "','" + txtPhone.Text + "','" + txtZip.Text + "')";
        //    SqlCommand cmd = new SqlCommand(Insquery, con);
        //    cmd.ExecuteNonQuery();
        //    MessageBox.Show("Data Inserted Successfully");
        //    con.Close();
        //}
        private void button2_Click(object sender, EventArgs e)
        {
            string Status = "y", Gender = "x";
            if (chkRes.Checked == true)
            {
                Status = "Residence";
            }
            else if (chkNRes.Checked == true)
            {
                Status = "Non-residence";
            }
            if (chkMale.Checked == true)
            {
                Gender = "Male";
            }
            else if (chkFemale.Checked == true)
            {
                Gender = "Female";
            }
            string BDate = txtD3.Text + txtD4.Text + txtM3.Text + txtM4.Text + txtY5.Text + txtY6.Text + txtY7.Text + txtY8.Text;
            string Date = txtD1.Text + txtD2.Text + txtM1.Text + txtM2.Text + txtY1.Text + txtY2.Text + txtY3.Text + txtY4.Text;
            string Id = txtId1.Text + txtId2.Text + txtId3.Text + txtId4.Text + txtId5.Text + txtId6.Text + txtId7.Text + txtId8.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9886DUR\\SQLEXPRESS;Initial Catalog=db_Student_Info;Integrated Security=True;");
            con.Open();
            string Insquery = "INSERT INTO registrationNew(ID, Date, MDirector, Name, BirthPlace, Gender, DateOfBirth, Address, Status, State, City, Country, MaritalStatus, Nationality, Region, NationalID, IDNo, Email, Phone, ZipCode) " +
                              "VALUES ('" + Id + "', '" + Date + "', '" + txtMDirector.Text + "', '" + txtName.Text + "', '" + txtPOB.Text + "', '" + Gender + "', '" + BDate + "', '" + txtAdd.Text + "', '" + Status + "', '" + ComState.Text + "', '" + ComCity.Text + "', '" + ComCountry.Text + "', '" + txtMStatus.Text + "', '" + txtNationality.Text + "', '" + txtRegion.Text + "', '" + txtNationalID.Text + "', '" + txtIDNo.Text + "', '" + txtEmail.Text + "', '" + txtPhone.Text + "', '" + txtZip.Text + "')";
            SqlCommand cmd = new SqlCommand(Insquery, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Inserted Successfully");
            con.Close();
        }



        private void txtY4_TextChanged(object sender, EventArgs e)
        {
            if (txtY4.Text.Length > 0)
            {
                txtMDirector.Select();
            }
        }

        private void txtY3_TextChanged(object sender, EventArgs e)
        {
            if (txtY3.Text.Length > 0)
            {
                txtY4.Select();
            }
        }

        private void txtY2_TextChanged(object sender, EventArgs e)
        {
            if (txtY2.Text.Length > 0)
            {
                txtY3.Select();
            }
        }

        private void txtY1_TextChanged(object sender, EventArgs e)
        {
            if (txtY1.Text.Length > 0)
            {
                txtY2.Select();
            }
        }

        private void txtM2_TextChanged(object sender, EventArgs e)
        {
            if (txtM2.Text.Length > 0)
            {
                txtY1.Select();
            }
        }

        private void txtM1_TextChanged(object sender, EventArgs e)
        {
            if (txtM1.Text.Length > 0)
            {
                txtM2.Select();
            }
        }

        private void txtD2_TextChanged(object sender, EventArgs e)
        {

            if (txtD2.Text.Length > 0)
            {
                txtM1.Select();
            }
        }

        private void txtD1_TextChanged(object sender, EventArgs e)
        {
            if (txtD1.Text.Length > 0)
            {
                txtD2.Select();
            }
        }
        private void ShowData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9886DUR\\SQLEXPRESS;Initial Catalog=db_Student_Info;Integrated Security=True;");
            con.Open();
            string SelectData = "Select * from registrationNew";
            SqlCommand cmd = new SqlCommand(SelectData, con);
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(ds, "registrationNew");
            dgvShow.DataSource = ds.Tables["registrationNew"].DefaultView;

        }

        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMDirector.Text = dgvShow.CurrentRow.Cells[2].Value.ToString();
            txtName.Text = dgvShow.CurrentRow.Cells[3].Value.ToString();
            txtPOB.Text = dgvShow.CurrentRow.Cells[4].Value.ToString();
            txtAdd.Text = dgvShow.CurrentRow.Cells[7].Value.ToString();
            ComCity.Text = dgvShow.CurrentRow.Cells[10].Value.ToString();
            ComState.Text = dgvShow.CurrentRow.Cells[9].Value.ToString();
            ComCountry.Text = dgvShow.CurrentRow.Cells[11].Value.ToString();
            txtMStatus.Text = dgvShow.CurrentRow.Cells[12].Value.ToString();
            txtNationality.Text = dgvShow.CurrentRow.Cells[13].Value.ToString();
            txtRegion.Text = dgvShow.CurrentRow.Cells[14].Value.ToString();
            txtNationalID.Text = dgvShow.CurrentRow.Cells[15].Value.ToString();
            txtIDNo.Text = dgvShow.CurrentRow.Cells[16].Value.ToString();
            txtEmail.Text = dgvShow.CurrentRow.Cells[17].Value.ToString();
            txtPhone.Text = dgvShow.CurrentRow.Cells[18].Value.ToString();
            txtZip.Text = dgvShow.CurrentRow.Cells[19].Value.ToString();

        }

        private void dgvShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void button3_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-9886DUR\\SQLEXPRESS;Initial Catalog=db_Student_Info;Integrated Security=True;"))
            {

                //string Date = DateTime.Now.ToString("yyyy-MM-dd"); 
                //string Gender = "Male"; 
                ////string BDate = DateTime.Now.ToString("yyyy-MM-dd"); 
                string Status = "Active";

                string Name = txtName.Text;
                string MDirector = txtMDirector.Text;
                string BirthPlace = txtPOB.Text;
                string Address = txtAdd.Text;
                string State = ComState.Text;
                string City = ComCity.Text;
                string Country = ComCountry.Text;
                string MaritalStatus = txtMStatus.Text;
                string Nationality = txtNationality.Text;
                string Region = txtRegion.Text;
                string NationalID = txtNationalID.Text;
                string IDNo = txtIDNo.Text;
                string Email = txtEmail.Text;
                string Phone = txtPhone.Text;
                string ZipCode = txtZip.Text;

                string UpdateQuery = "UPDATE registrationNew SET " +
                                     //"Date = '" + Date + "', " +
                                     "MDirector = '" + MDirector + "', " +
                                     "Name = '" + Name + "', " +
                                     "BirthPlace = '" + BirthPlace + "', " +
                                     //"Gender = '" + Gender + "', " +
                                     //"DateOfBirth = '" + BDate + "', " +
                                     "Address = '" + Address + "', " +
                                     "Status = '" + Status + "', " +
                                     "State = '" + State + "', " +
                                     "City = '" + City + "', " +
                                     "Country = '" + Country + "', " +
                                     "MaritalStatus = '" + MaritalStatus + "', " +
                                     "Nationality = '" + Nationality + "', " +
                                     "Region = '" + Region + "', " +
                                     "NationalID = '" + NationalID + "', " +
                                     "IDNo = '" + IDNo + "', " +
                                     "Email = '" + Email + "', " +
                                     "Phone = '" + Phone + "', " +
                                     "ZipCode = '" + ZipCode + "' ";




                using (SqlCommand cmd = new SqlCommand(UpdateQuery, con))
                {
                    try
                    {

                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Rows affected: " + rowsAffected);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void txtD4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtY5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label67_Click_1(object sender, EventArgs e)
        {

        }
        //private void txtId1_TextChanged_1(object sender, EventArgs e)
        //{
        //    if (txtId1.Text.Length > 0)
        //    {
        //        txtId2.Select();
        //    }
        //}

        //private void txtId2_TextChanged_1(object sender, EventArgs e)
        //{

        //    if (txtId2.Text.Length > 0)
        //    {
        //        txtId3.Select();
        //    }
        //}

        //private void txtId3_TextChanged_1(object sender, EventArgs e)
        //{
        //    if (txtId3.Text.Length > 0)
        //    {
        //        txtId4.Select();
        //    }
        //}

        //private void txtId4_TextChanged_1(object sender, EventArgs e)
        //{
        //    if (txtId4.Text.Length > 0)
        //    {
        //        txtId5.Select();
        //    }
        //}



        //private void txtId5_TextChanged_1(object sender, EventArgs e)
        //{

        //    if (txtId5.Text.Length > 0)
        //    {
        //        txtId6.Select();
        //    }
        //}

        //private void txtId6_TextChanged_1(object sender, EventArgs e)
        //{
        //    if (txtId6.Text.Length > 0)
        //    {
        //        txtId7.Select();
        //    }
        //}

        //private void txtId7_TextChanged_1(object sender, EventArgs e)
        //{
        //    if (txtId7.Text.Length > 0)
        //    {
        //        txtId8.Select();
        //    }
        //}

        //private void txtId8_TextChanged_1(object sender, EventArgs e)
        //{
        //    if (txtId8.Text.Length > 0)
        //    {
        //        txtD1.Select();
        //    }
        //}

        //private void txtD3_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtD3.Text.Length > 0)
        //    {
        //        txtD4.Select();
        //    }
        //}

        //private void txtD4_TextChanged(object sender, EventArgs e)
        //{

        //    if (txtD4.Text.Length > 0)
        //    {
        //        txtM3.Select();
        //    }
        //}

        //private void txtM3_TextChanged(object sender, EventArgs e)
        //{

        //    if (txtM3.Text.Length > 0)
        //    {
        //        txtM4.Select();
        //    }
        //}

        //private void txtM4_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtM4.Text.Length > 0)
        //    {
        //        txtY5.Select();
        //    }
        //}

        //private void txtY5_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtY5.Text.Length > 0)
        //    {
        //        txtY6.Select();
        //    }
        //}

        //private void txtY6_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtY6.Text.Length > 0)
        //    {
        //        txtY7.Select();
        //    }
        //}

        //private void txtY7_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtY7.Text.Length > 0)
        //    {
        //        txtY8.Select();
        //    }
        //}

        //private void txtY8_TextChanged(object sender, EventArgs e)
        //{
        //    if (txtY8.Text.Length > 0)
        //    {
        //        txtAdd.Select();
        //    }
        //}

        //private void txtId1_TextChanged_2(object sender, EventArgs e)
        //{

        //}
    }
}

        

    