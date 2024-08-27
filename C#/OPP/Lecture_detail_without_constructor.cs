using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_detail_without_constructor__oop
{
    public class Lecture
    {
        public string LecturerName;
        public string SubjectName;
        public string CourseName;
        public int NumberOfLecturers;

        public void details(string lecturerName, string subjectName, string courseName, int numberOfLecturers)
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

            lectures[0] = new Lecture();
            lectures[0].details("NEERAJ", "Mathematics", "Engineering", 22);

            lectures[1] = new Lecture();
            lectures[1].details("NIRAJ", "Physics", "Science", 22);

            lectures[2] = new Lecture();
            lectures[2].details("DHIRAJ", "Chemistry", "Medical", 22);

            lectures[3] = new Lecture();
            lectures[3].details("SURAJ", "mechanics", "civil", 22);

            lectures[4] = new Lecture();
            lectures[4].details("DEERAJ", "Computer Science", "Information Technology", 22);



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
