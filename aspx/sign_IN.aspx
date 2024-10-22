using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Amazon_web
{
    public partial class Sign_IN : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string mobileNumber = txtMobile.Text;
            string password = txtPassword.Text;

            SqlConnection con = new SqlConnection("Data Source=DESKTOP-9886DUR\\SQLEXPRESS;Initial Catalog=userdetails;Integrated Security=True;");
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE MobileNumber = @MobileNumber AND Password = @Password", con);
                cmd.Parameters.AddWithValue("@MobileNumber", mobileNumber);
                cmd.Parameters.AddWithValue("@Password", password);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    Session["UserMobile"] = mobileNumber; 
                    Response.Redirect("dashboard.aspx"); 
                }
                else
                {
                   
                    Response.Write("<script>alert('Invalid credentials! Please try again.');</script>");
                }
            }
        }
    }
}
    