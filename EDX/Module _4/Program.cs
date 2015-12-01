using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module__4
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] Students = new Student[5];
            for (int i = 0; i < Students.Length; i++)
            {
                GetStudentInformation(Students[i]);
            }
        }
         public struct Student
        {
            public string FirstName;
            public string LastName;
            public DateTime BirthDate;
            public string Address_1;
            public string Address_2;
            public string City;
            public string State;
            public int ZipCode;
            public string Country;
        }
        public struct Teacher
        {
            string FirstName;
            string LastName;
            DateTime BirthDate;
            string Address_1;
            string Address_2;
            string City;
            string State;
            int ZipCode;
            string Country;
        }
        public struct program
        {
            string ProgramName;
            string DepartmentHead;

        }
        public struct Degree
        {
            string DegreeName;
            int Credits_Required;
        }
        static DateTime ValidateBirthDay(string date)
        {
            try
            {
                return DateTime.Parse(date);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }

        }
        static void PrintStudentDetails(string first, string last, DateTime birthday, int Zipcode, string city)
        {
            Console.WriteLine("--------------------  STUDENT ----------------------------");
            Console.WriteLine("{0} {1} was born on: {2} in {3} \n Zipcode: {4}", first, last, birthday, city, Zipcode);
        }
        static void GetStudentInformation(Student _student)
        {
            Console.WriteLine("Enter the student's first name: ");
            _student.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            _student.LastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthdate");
            _student.BirthDate = ValidateBirthDay(Console.ReadLine());
            Console.WriteLine("Enter the student's zipcode");
            _student .ZipCode= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student's city");
            _student.City = Console.ReadLine();
            PrintStudentDetails(_student.FirstName, _student.LastName, _student.BirthDate, _student.ZipCode, _student.City);

        }
    }
}
