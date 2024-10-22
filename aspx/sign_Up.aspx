using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Collections;
using System.Xml.Linq;

namespace Amazon_web
{
    public partial class account_list : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }
        protected void btnSave_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9886DUR\\SQLEXPRESS;Initial Catalog=userdetails;Integrated Security=True;");
            con.Open();
            string query = "Insert Into Users (Name, MobileNumber, Password) VALUES ('" + txtName.Text + "','" + txtMobile.Text + "', '" + txtPassword.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("Data Submited Successfully");
            BindGrid();
        }

        private void BindGrid()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9886DUR\\SQLEXPRESS;Initial Catalog=userdetails;Integrated Security=True;");
            con.Open();
            string query = ("Select * From Users");
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            gvUsers.DataSource = dt;
            gvUsers.DataBind();
            con.Close();
        }

        protected void gvUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvUsers_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            gvUsers.EditIndex = e.NewEditIndex;
            BindGrid();
        }

        protected void gvUsers_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            GridViewRow row = gvUsers.Rows[e.RowIndex];
            int userId = Convert.ToInt32(gvUsers.DataKeys[e.RowIndex].Values[0]);
            string name = (row.Cells[1].Controls[0] as System.Web.UI.WebControls.TextBox).Text;
            string mobileNumber = (row.Cells[2].Controls[0] as System.Web.UI.WebControls.TextBox).Text;
            string password = (row.Cells[3].Controls[0] as System.Web.UI.WebControls.TextBox).Text;


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9886DUR\\SQLEXPRESS;Initial Catalog=userdetails;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Users SET Name=@Name, MobileNumber=@MobileNumber, Password=@Password WHERE UserId=@UserId", con);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@MobileNumber", mobileNumber);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@UserId", userId);

            cmd.ExecuteNonQuery();
            con.Close();
            gvUsers.EditIndex = -1;
            BindGrid();
        }


        protected void gvUsers_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            int userId = Convert.ToInt32(gvUsers.DataKeys[e.RowIndex].Values[0]);
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9886DUR\\SQLEXPRESS;Initial Catalog=userdetails;Integrated Security=True;");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE FROM Users WHERE UserId=@UserId", con);
            cmd.Parameters.AddWithValue("@UserId", userId);
            cmd.ExecuteNonQuery();
            con.Close();
            BindGrid();
        }

        public void ClearFields()
        {
            txtName.Text = "";
            txtMobile.Text = "";
            txtPassword.Text = "";
        }

        protected void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtPassword_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void txtMobile_TextChanged1(object sender, EventArgs e)
        {

        }

        protected void txtName_TextChanged1(object sender, EventArgs e)
        {

        }
    }
}