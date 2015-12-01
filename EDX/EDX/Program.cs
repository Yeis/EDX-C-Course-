using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDX
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student 
            GetStudentInformation();
            //Teacher
            GetTeacherInformation();
            //Program
            GetProgramInformation();
            //Degree
            GetDegreeInformation();

        }
        static void  Chess()
        {
         
                //Chess Board
               for (int X = 0; X < 8; X++)
               {
                   for (int Z = 0; Z < 8; Z++)
                   {
                       if (Z % 2 == 0 && X % 2 == 0)
                       {
                           Console.Write("X");
                       }
                       else if (Z % 2 == 1 && X % 2 == 0)
                       {
                           Console.Write("O");
                       }
                    else if (Z % 2 == 0 && X % 2 == 1)
                       {
                           Console.Write("O");
                       }
                       else if (Z % 2 == 1 && X % 2 == 1)
                       {
                           Console.Write("X");
                       }
                   }
                    Console.WriteLine("");
                }

            }
        static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthdate");
            DateTime BirthDate = ValidateBirthDay( Console.ReadLine());
            Console.WriteLine("Enter the student's zipcode");
            int ZipCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the student's city");
            string City = Console.ReadLine();
            PrintStudentDetails(firstName, lastName, BirthDate, ZipCode, City);

        }
        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birthdate");
            DateTime BirthDate = ValidateBirthDay(Console.ReadLine());
            Console.WriteLine("Enter the teacher's zipcode");
            int ZipCode = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the teacher's city");
            string City = Console.ReadLine();
        }
        static void GetProgramInformation()
        {
            Console.WriteLine("Enter the program's name: ");
            string Program_Name = Console.ReadLine();
            Console.WriteLine("Enter the program's department head name");
            string Department_Head = Console.ReadLine();
        }
        static void GetDegreeInformation()
        {
            Console.WriteLine("Enter the Degree's name name: ");
            string Degree_Name = Console.ReadLine();
            Console.WriteLine("Enter the Degree's credits:");
            int Credits_Required = int.Parse(Console.ReadLine());
        }
        static DateTime ValidateBirthDay(string date)
        {
            try
            {
                return DateTime.Parse(date);
            }
            catch ( Exception ex)
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
        static void PrintTeacherDetails(string first, string last, DateTime birthday, int Zipcode, string city)
        {
            Console.WriteLine("--------------------  TEACHER ----------------------------");
            Console.WriteLine("{0} {1} was born on: {2} in {3} \n Zipcode: {4}", first, last, birthday, city, Zipcode);
        }
        static void PrintUProgramDetails(string program_name, string department_head)
        {
            Console.WriteLine("--------------------  Program ----------------------------");
            Console.WriteLine("Program'Name: {0} , Department Head: {1}", program_name, department_head);
        }
        static void PrintDegreeDetails(string name, int credits)
        {
            Console.WriteLine("-------------------- DEGREE ----------------------------");
            Console.WriteLine("Degree Name: {0} , Credits: {1}  ", name, credits);
        }

    }
}


