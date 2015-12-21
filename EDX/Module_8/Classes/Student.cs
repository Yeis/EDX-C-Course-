using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8.Classes
{
    class Student:Person
    {
        //Prpoerties
        public Stack<int> Grades = new Stack<int>();
      
        //Constructors
        public Student(string firstname, string lastname, DateTime birthdate, string address1, string address2, string city, string state, int zip, string country):
            base(firstname,lastname,birthdate,address1,address2,city,state,zip,country)
        {

        }
        public Student():base()
        {

        }

        public void TakeTest(string Test)
        {
            Console.WriteLine("Taking  Test ");
            Console.WriteLine("The test is: {0} ",Test);
        }
      

    }
}
