 -------------View code--------------

@model List<employee_mvc.Models.StudentDetails>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <title>Student List</title>
</head>
<body>
    <h2>Student List</h2>
    <table class="table table-bordered">
        <thead>
            <tr>
                <th>Name</th>
                <th>Email</th>
                <th>Age</th>
                <th>Course</th>
                <th>Address</th>
                <th>Phone Number</th>
                <th>Gender</th>
            </tr>
        </thead>
        <tbody>
            @foreach (var student in Model)
            {
                <tr>
                    <td>@student.Name</td>
                    <td>@student.Email</td>
                    <td>@student.Age</td>
                    <td>@student.Course</td>
                    <td>@student.Address</td>
                    <td>@student.PhoneNumber</td>
                    <td>@student.Gender</td>
                </tr>
            }
        </tbody>
    </table>
</body>
</html>

----------------controller code--------------------
using employee_mvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace employee_mvc.Controllers
{
    public class StudentFormController : Controller
    {

        public ActionResult ListStudent()
        {
            List<StudentDetails> stud = StudentDetails.getAll();
            return View(stud);

        }
    }
}

-------------------model code----------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace employee_mvc.Models
{
    public class StudentDetails
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }

        public static List<StudentDetails> getAll()
        {
            List<StudentDetails> stud = new List<StudentDetails>()
            {
                new StudentDetails
                {
                    Name = "Neeraj",
                    Email = "rajbharneeraj@gmail.com",
                    Age = 22,
                    Course = "Dotnet Developer",
                    Address = "Pune",
                    PhoneNumber = "1234567890",
                    Gender = "Male"
                },
                new StudentDetails
                {
                    Name = "Suraj rajbhar",
                    Email = "rajbharneeraj@gmail.com",
                    Age = 24,
                    Course = "Java Developer",
                    Address = "Nagpur",
                    PhoneNumber = "1234567890",
                    Gender = "Male"
                },
                new StudentDetails
                {
                    Name = "yaseen",
                    Email = "example.com",
                    Age = 23,
                    Course = "Python Developer",
                    Address = "Mumbai",
                    PhoneNumber = "1234567890",
                    Gender = "Male"
                }
            };
            return stud;
        }
    }
}
