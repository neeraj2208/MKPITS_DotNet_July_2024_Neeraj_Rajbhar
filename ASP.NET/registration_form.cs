<%@ Page Language = "C#" AutoEventWireup="true" CodeBehind="Sign_Up.aspx.cs" Inherits="Amazon_web.account_list" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Registration</title>
    <style>
        /* Style for the main container */
        body {
            font-family: Arial, sans-serif;
background - color: #f5f5f5;
            margin: 0;
padding: 0;
        }

        .container {
            width: 400px;
margin: 50px auto;
padding: 20px;
background - color: white;
border - radius: 5px;
box - shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
        }

        h2 {
            color: #ff9900;
            text - align: center;
font - weight: normal;
        }

        /* Styling labels and inputs */
        label {
            display: block;
margin - bottom: 10px;
font - weight: bold;
color: #333;
        }

        input[type = "text"], input[type = "password"] {
width: 100 %;
padding: 10px;
    margin - bottom: 15px;
border: 1px solid #ccc;
            border - radius: 4px;
    font - size: 14px;
}

        /* Button style */
        .btn {
            background-color: #ff9900;
            color: white;
padding: 10px 15px;
border: none;
cursor: pointer;
width: 100 %;
font - size: 16px;
border - radius: 4px;
        }

        .btn: hover {
    background - color: #e68a00;
        }

/* Table style */
h3 {
            text-align: center;
color: #333;
            margin - bottom: 10px;
        }

        table {
            width: 100 %;
margin - top: 20px;
border - collapse: collapse;
        }

        th, td {
            padding: 10px;
text - align: left;
border - bottom: 1px solid #ddd;
        }

        th {
            background-color: #f4f4f4;
        }

        /* GridView styles */
        .gridview {
            margin-top: 20px;
background - color: #fff;
            border - collapse: collapse;
width: 100 %;
text - align: left;
        }

        .gridview th, .gridview td {
            padding: 8px 10px;
border: 1px solid #ddd;
        }

        .gridview th
{
    background-color: #f8f8f8;
            font-weight: bold;
}

/* Responsive */
@media(max - width: 600px) {
            .container {
    width: 90 %;
    margin: 20px auto;
    }
}

    </ style >
</ head >
< body >
    < form id = "form1" runat = "server" >
        < div class= "container" >
            < h2 > User Registration </ h2 >

            < !--Name input-- >
            < label for= "txtName" > Name </ label >
            < asp:TextBox ID = "txtName" runat = "server" placeholder = "Enter your name" CssClass = "form-control" OnTextChanged = "txtName_TextChanged1" ></ asp:TextBox >


            < !--Mobile input-- >
            < label for= "txtMobile" > Mobile Number </ label >

            < !--Password input-- >
            < asp:TextBox ID = "txtMobile" runat = "server" placeholder = "Enter your mobile number" CssClass = "form-control" OnTextChanged = "txtMobile_TextChanged1" TextMode = "Phone" ></ asp:TextBox >
            < label for= "txtPassword" > Password </ label >
            < asp:TextBox ID = "txtPassword" runat = "server" TextMode = "Password" placeholder = "Enter your password" CssClass = "form-control" OnTextChanged = "txtPassword_TextChanged1" ></ asp:TextBox >

            < !--Register Button-- >
            < asp:Button ID = "btnSave" runat = "server" Text = "Register" CssClass = "btn" OnClick = "btnSave_Click" />

            < div class= "signin" >
              < p > Already have an account? <a href="Sign_IN.aspx">Sign in</a></p>  

            </div>

            <!-- Registered Users section -->
            <h3>Registered Users</h3>
            <asp:GridView ID = "gvUsers" runat="server" AutoGenerateColumns="False" CssClass="gridview" OnRowEditing="gvUsers_RowEditing"
                OnRowUpdating="gvUsers_RowUpdating" OnRowDeleting="gvUsers_RowDeleting" DataKeyNames="UserId" OnSelectedIndexChanged="gvUsers_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField = "UserId" HeaderText="User ID" ReadOnly="True" />
                    <asp:BoundField DataField = "Name" HeaderText="Name" />
                    <asp:BoundField DataField = "MobileNumber" HeaderText="Mobile Number" />
                    <asp:BoundField DataField = "Password" HeaderText="Password" />
                    <asp:CommandField ShowEditButton = "True" ShowDeleteButton="True" />
                    
                </Columns>
            </asp:GridView >
        </ div >
    </ form >
</ body >
</ html >using System;
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