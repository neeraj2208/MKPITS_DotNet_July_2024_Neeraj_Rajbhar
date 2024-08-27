using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leture_details_OOPs
{
        public class Lecture
        {
            public string LecturerName;
            public string SubjectName;
            public string CourseName;
            public int NumberOfLecturers;
            
            public Lecture(string lecturerName, string subjectName, string courseName, int numberOfLecturers)
            {
                LecturerName = lecturerName;
                SubjectName = subjectName;
                CourseName = courseName;
                NumberOfLecturers = numberOfLecturers;
            }
            public void DisplayLectureDetails()
            {
                Console.WriteLine("Lecturer Name: " + LecturerName);
                Console.WriteLine("Subject Name: " + SubjectName);
                Console.WriteLine("Course Name: " + CourseName);
                Console.WriteLine("Number of  lecturers: " + NumberOfLecturers);
                Console.WriteLine();
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                
                Lecture[] lectures = new Lecture[5];

                lectures[0] = new Lecture("NEERAJ", "Mathematics", "Engineering",22);
                lectures[1] = new Lecture("NIRAJ", "Physics", "Science", 22);
                lectures[2] = new Lecture("DHIRAJ", "Chemistry", "Medical", 22);
                lectures[3] = new Lecture("SURAJ", "mechanics", "civil", 22);
                lectures[4] = new Lecture("DEERAJ", "Computer Science", "Information Technology", 22);



            for (int i = 0; i < lectures.Length; i++)
            {
                lectures[i].DisplayLectureDetails();
            }

            //foreach (var lecture in lectures)
            //{
            //    lecture.DisplayLectureDetails();
            //}

            Console.ReadLine();
            }
        }
    }


