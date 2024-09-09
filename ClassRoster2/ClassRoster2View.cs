using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoster2
{
    internal class ClassRoster2View
    {
        public ClassRoster2View()
        {
            Console.WriteLine("Welcome to the class roster app");
            Console.WriteLine("_______________________________");
        }

        public List<string> GetInstructorInfo() //Method which gets the instructor's info and returns it as a List
        {
            List<string> instructorInfo = new List<string>();

            instructorInfo.Add(GetInstructorName());
            instructorInfo.Add(GetInstructorLastName());
            instructorInfo.Add(GetInstructorContact());

            return instructorInfo;
        }

        public List<string> AddStudent() //Method which gets a student's info and returns it as a List
        {
            List<string> student = new List<string>();

            student.Add(GetStudentName());
            student.Add(GetStudentLastName());
            student.Add(GetStudentRank());

            return student;
        }



        public string Menu() //Method to get the menu selection from the user
        {
            string menu = "";

            Console.WriteLine();
            Console.WriteLine("Coose an option from the following list:");
            Console.WriteLine("a - Add student");
            Console.WriteLine("b - View class roster");
            Console.WriteLine("x - Exit");
            Console.Write("Your choice: ");
            

            menu = Console.ReadLine().ToLower();

            Console.WriteLine();

            return menu;
        }



        private string GetInstructorName() //Method for instructor name
        {
            string name = "";

            Console.Write("Please Enter the instructor's name: ");
            name = Console.ReadLine();

            return name;
        }

        private string GetInstructorLastName() //Method for instructor last name
        {
            string lastName = "";

            Console.Write("Please Enter the instructor's last name: ");
            lastName = Console.ReadLine();

            return lastName;
        }

        private string GetInstructorContact() //Method for instructor contact info
        {
            string contact = "";

            Console.Write("Please Enter the instructor's contact info: ");
            contact = Console.ReadLine();

            return contact;
        }

        private string GetStudentName() //Method for student name
        {

            string name = "";
            
            Console.Write("Enter the student's name: ");
            name = Console.ReadLine();

            return name;
        }

        private string GetStudentLastName() //Method for student last name
        {
            string lastName = "";

            Console.Write("Enter the student's last name: ");
            lastName = Console.ReadLine();

            return lastName;
        }

        private string GetStudentRank() //Method for student rank
        {
            string rank = "";

            Console.Write("Enter the student's class rank: ");
            rank = Console.ReadLine();

            return rank;
        }

        public void PrintInstructor(List<string> instructor) //Method to print instructor details
        {
            Console.WriteLine($"Prof {instructor[0]} {instructor[1]}'s class:    (contact: {instructor[2]})");
        }

        public void PrintRoster(List<string> roster) //Method to print the student roster
        {
            int i = 0;

            while(i < roster.Count)
            {
                Console.WriteLine($"{roster[i]} {roster[i+1]} {roster[i+2]}");

                i += 3;
            }
        }

        public void InvalidInput()  //Method Alert for invalid input
        {
            Console.WriteLine("_______________________________");
            Console.WriteLine("Invalid Input, please try again");
            Console.WriteLine("_______________________________");

        }

    }
}
