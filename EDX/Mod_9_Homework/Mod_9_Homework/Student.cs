using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
    public class Student
    {
        //properties and member variables 
        private string firstname;
        private string lastname;
        private string city;

        public string FirstName
        {
            get { return firstname; }
            set { firstname = value; }
        }
        public string LastName
        {
            get { return lastname; }
            set { lastname = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        //Contrutctors 
        public Student()
        {

        }
        public Student(string first, string last, string city)
        {
            this.FirstName = first;
            this.LastName = last;
            this.City = city;
        }
    }
}
