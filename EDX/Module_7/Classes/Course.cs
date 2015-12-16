using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6.Classes
{
    class Course
    {
        //Constructors 
        public Course()
        {

        }
        public Course(string _name)
        {
            this.Name = _name;
        }

        //Member variables
        private string name;
        private ArrayList students = new ArrayList();
        private ArrayList teachers = new ArrayList();
        //public properties
        public ArrayList Students { get { return students; }  set { students = value; } }
        public ArrayList Teachers { get { return teachers; } set { teachers = value; } }
        public string Name { get { return name; } set { name = value; } }

        //Methods
        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }
        public void AddTeacher(Teacher teacher)
        {
            this.Teachers.Add(teacher);
        }
    }
}
