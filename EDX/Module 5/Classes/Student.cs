using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_8.Classes
{
    class Student
    {
        //Constructors
        public Student()
        {

        }
        public Student(string firstname, string lastname, DateTime birthdate, string address1, string address2 , string city, string state, int zip , string country )
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.BirthDate = birthdate;
            this.address_1 = address1;
            this.Address_2 = address2;
            this.City = city;
            this.State = state;
            this.ZipCode = zip;
            this.Country = country;
        }
        //Member Variables
        private string Firstname;
        private string lastname;
        private DateTime birthdate;
        private string address_1;
        private string address_2;
        private string city;
        private string state;
        private int zipcode;
        private string country;
        //Properties 
        public string FirstName { get { return Firstname; } set { Firstname = value; } }
        public string LastName { get { return lastname; } set { lastname = value; } }
        public DateTime BirthDate { get { return birthdate; } set { birthdate = value; } }
        public string Address_1 { get { return address_1; } set { address_1 = value; } }
        public string Address_2 { get { return address_2; } set { address_2 = value; } }
        public string City { get { return city; } set { city = value; } }
        public string State { get { return state; } set { state = value; } }
        public int ZipCode { get { return zipcode; } set { zipcode = value; } }
        public string Country { get { return country; } set { country = value; } }



    }
}
