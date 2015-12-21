using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8.Classes
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
        private List<Student> students = new List<Student>();
        private List<Teacher> teachers = new List<Teacher>();
        //public properties
        public List<Student> Students { get { return students; }  set { students = value; } }
        public List<Teacher> Teachers { get { return teachers; } set { teachers = value; } }
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
        public void ListStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine("Name: {0} LastName: {1}", student.FirstName, student.LastName);
            }
        }
    }
}
