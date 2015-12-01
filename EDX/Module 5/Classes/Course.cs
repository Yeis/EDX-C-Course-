using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_5.Classes
{
    class Course
    {
        //Constructors 
        public Course()
        {

        }

        //Member variables
        private Student[] students = new Student[3];
        private Teacher[] teachers = new Teacher[3];
        //public properties
        public Student[] Students { get { return students; }  set { students = value; } }
        public Teacher[] Teachers { get { return teachers; } set { teachers = value; } }

    }
}
