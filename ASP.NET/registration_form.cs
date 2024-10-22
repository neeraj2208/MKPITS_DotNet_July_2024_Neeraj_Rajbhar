using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Registration_Form
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            string name = TextBox1.Text;
            string Password = TextBox2.Text;
            string Address = TextBox3.Text;
            sb.Append("Name: " + name+"<br>");
            sb.Append("Password: " + Password + "<br>");
            sb.Append("Address: " + Address + "<br>");
            string Hobby = null;
            if(CheckBox1.Checked)
            {
                Hobby = "Cricket";
            }
            if(CheckBox2.Checked)
            {
                Hobby = Hobby + " " + "Football";
            }
            if(CheckBox3.Checked)
            {
                Hobby = Hobby + " " + "Basketball";
            }
            sb.Append("Hobby: " + Hobby + "<br>");
            string Gender = null;
            if(RadioButton1.Checked)
            {
                Gender = "Male";
            }
            else if(RadioButton2.Checked)
            {
                Gender = "Female";
            }
            sb.Append("Gender: " + Gender+"<br>");
            sb.Append("State: " + DropDownList1.Text+"<br>");
            sb.Append("City: " + DropDownList2.Text + "<br>");
           
            string cou = null;
            foreach(ListItem li in ListBox1.Items)
            {
                if(li.Selected)
                {
                    cou = cou + li.Value + "<br>";
                }
            }
            sb.Append("Courses: " + cou + "<br>");
            Label1.Text = sb.ToString();
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = DropDownList1.Text;
            DropDownList2.Items.Clear();
            switch(s)
            {
                case "Maharashtra":
                    DropDownList2.Items.Add("Nagpur");
                    DropDownList2.Items.Add("Pune");
                    break;
                case "Delhi":
                    DropDownList2.Items.Add("Del");
                    DropDownList2.Items.Add("rajnagar");
                    break;

            }
        }
    }
}