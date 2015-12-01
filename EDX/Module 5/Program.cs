using Module_5.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initial Setup
            var student1 = new Student();
            var student2 = new Student();
            var student3 = new Student();
            var course = new Course("Programming with C#");
            course.Students = new Student[] { student1, student2, student3 };
            var teacher = new Teacher();
            course.Teachers = new Teacher[] { teacher };
            var degree = new Degree("Bachelor of Computer Science", 49);
            course.

            //Final OutPut
        }
    }
}
