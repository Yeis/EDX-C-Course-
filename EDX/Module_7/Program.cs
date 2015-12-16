using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Module_6.Classes;
namespace Module_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create 3 Students and a random 
            Random r = new Random();
            var student1 = new Student("Yeis","Gallegos",new DateTime(1993,12,12),"Wolo","Wolo","San Diego","California",123456,"United States");
            var student2 = new Student("Hector", "Garcia", new DateTime(1993, 06, 06), "Wolo", "Wolo", "San Diego", "California",123456, "United States");
            var student3 = new Student("Lucian", "Anderson", new DateTime(1993, 03, 03), "Wolo", "Wolo", "San Diego", "California",12356, "United States");

            for (int j = 0; j < 5; j++)
            {
                student1.Grades.Push(r.Next(11));
                student2.Grades.Push(r.Next(11));
                student3.Grades.Push(r.Next(11));
            }
            
            var course = new Course("Programming with C#");
            course.Students.Add(student1);
            course.Students.Add(student2);
            course.Students.Add(student3);
            var teacher = new Teacher();
            course.AddTeacher(teacher);

            foreach (Student student in course.Students)
            {

            }
            var degree = new Degree("Bachelor of Computer Science", 49);
            degree.Course = course;
            var program = new UProgram("Information Technology", "Will Ferrel");
            program.Degree = degree;

            //Final OutPut
            Console.WriteLine(String.Format("The {0} program contains the {1} degree \n The {2} degree contains the course {3} \n The {4} course contains {5} student(s)", program.ProgramName, program.Degree.DegreeName, program.Degree.DegreeName, program.Degree.Course.Name, program.Degree.Course.Name, program.Degree.Course.Students.Count()));
            Console.ReadLine();
        }
    }
}
