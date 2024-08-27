using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMarks_OOP
{
        public class Student
        {
            public int RollNo;
            public int Sub1;
            public int Sub2;
            public int Sub3;
            public int Total;
            public double Percentage;

            public Student()
            {  
                RollNo = 0;
                Sub1 = 0;
                Sub2 = 0;
                Sub3 = 0;
                Total = 0;
                Percentage = 0.0;
            } 
            private void CalculateTotalAndPercentage()
            {
                Total = Sub1 + Sub2 + Sub3;
                Percentage = Total / 3.0; 
            }
            public void DisplayStudentDetails()
            {
               
                Console.WriteLine( string.Format("{0,-7} {1,5} {2,5} {3,5} {4,5} {5,10:F2}", RollNo, Sub1, Sub2, Sub3, Total, Percentage));
            }
            public void SetDetails(int rollNo, int sub1, int sub2, int sub3)
            {
                RollNo = rollNo;
                Sub1 = sub1;
                Sub2 = sub2;
                Sub3 = sub3;
                CalculateTotalAndPercentage();
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                
                Student[] students = new Student[4];

                students[0] = new Student();
                students[0].SetDetails(1, 30, 25, 45);

                students[1] = new Student();
                students[1].SetDetails(2, 25, 20, 25);

                students[2] = new Student();
                students[2].SetDetails(3, 20, 15, 35);

                students[3] = new Student();
                students[3].SetDetails(4, 35, 30, 40);


                Console.WriteLine(string.Format("{0,-7} {1,5} {2,5} {3,5} {4,5} {5,10}",
                                "Roll No", "Sub1", "Sub2", "Sub3", "Total", "Percentage"));

                foreach (var student in students)
                {
                    student.DisplayStudentDetails();
                }

                Console.ReadLine();
            }
        }
    }



