using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_6.Classes
{
    class Teacher:Person
    {
        public Teacher(string firstname, string lastname, DateTime birthdate, string address1, string address2, string city, string state, int zip, string country):
            base(firstname,lastname,birthdate,address1,address2,city,state,zip,country)
        {

        }
        public Teacher():base()
        {

        }
        public void GradeTest(int input)
        {
            Console.WriteLine("Grading Test ");
            Console.WriteLine("Test Result: {0} points ",input);
        }

    }
}
