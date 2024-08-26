using System;
using System.Collections.Generic;
using System.Linq;


namespace ClassRosterApp
{
    class ClassRosterProgram //Program class
    {
        static void Main(string[] args) //Main function that can add Instructor info, add multiple students, and view the roster
        {
            Instructor classInstructor = new Instructor();
            bool exitApp = false;
            List<Student> studentRoster = new List<Student>();
           

            //Visuals
            Console.WriteLine("Welcome to the class roster app");
            Console.WriteLine("  ___________________________  ");

            //Get Instructor's name from user
            Console.Write("Please enter the instructor's Name: ");
            string name = "";
            name = Console.ReadLine();
            classInstructor.Name = name;

            //Get Instructor's Last name from user
            Console.Write("Please enter the instructor's Last Name: ");
            string lastName = "";
            lastName = Console.ReadLine();
            classInstructor.LastName = lastName;

            //Get Instructor's contact information
            Console.Write("Please enter the instructor's contact information: ");
            string contactInfo = "";
            contactInfo = Console.ReadLine();
            classInstructor.ContactEmail = contactInfo;

            
            //Menu loop to guide program
            while (!exitApp)
            {
                Console.WriteLine();
                Console.WriteLine("Coose an option from the following list:");
                Console.WriteLine("a - Add student");
                Console.WriteLine("b - View class roster");
                Console.WriteLine("x - Exit");
                Console.Write("Your choice: ");

                string userOption = Console.ReadLine().ToLower();

                Console.WriteLine();

                switch (userOption)
                {
                    case "a":
                        studentRoster.Add(AddStudentToRoster()); //Call to the add student function
                        break;

                    case "b":
                        List<Student> copiedRoster = studentRoster.ToList();
                        ViewRoster(copiedRoster, classInstructor); //Call to the view roster function
                        break;

                    case "x":
                        exitApp = true;
                        break;

                    default:
                        Console.WriteLine("Invalid Input, Please try again:");
                        break;

                }

        
            }//end of menu loop

        }//End of main program






        
        static Student AddStudentToRoster() // Function to add student to roster
        {
            Student student = new Student();
            string firstName = "";
            string lastName = "";
            double grade = -1;

            //Get student name
            Console.Write("Enter the student's Name: ");
            firstName = Console.ReadLine();
            student.Name = firstName;

            //Get student last name
            Console.Write("Enter the student's Last Name: ");
            lastName = Console.ReadLine();

            //Verify that a last name was entered
            while (lastName == "")
            {
                Console.Write("Invalid Input, Please try again: ");
                lastName = Console.ReadLine();

            }

            student.LastName = lastName;

            //Get student grade
            Console.Write("Enter the student's grade (0-100): ");
            string enteredGrade = Console.ReadLine();

            bool exitGrade = false;

            //Verify valid input for grade
            while (!exitGrade)
            {


                //Verify grade in numeric
                while (!double.TryParse(enteredGrade, out grade))
                {
                    Console.Write("This is not a valid input, please enter a numeric value (0 - 100): ");
                    enteredGrade = Console.ReadLine();
                }

                //Verify grade is a valid number
                if(grade >= 0.0 && grade <= 100.0)
                {
                    exitGrade = true;
                }
                else
                {
                    Console.Write("This value is not a valid input, please enter a numeric value (0-100): ");
                    enteredGrade = Console.ReadLine();
                }

            }
            student.ClassRank = grade;

            return student;
        }




        static void ViewRoster(List<Student> studentRoster, Instructor classInstructor) //void function to format the student roster
        {
            string userChoice = "";

            Console.WriteLine("In what order would you like to view the roster?");
            Console.WriteLine("1 - regualar");
            Console.WriteLine("2 - alphabetical");
            Console.WriteLine("3 - ClassRank");
            Console.WriteLine("(other) - Cancel");
            Console.Write("Your Choice: ");
            userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    PrintRoster(studentRoster, classInstructor);
                    break;

                case "2":
                    studentRoster.Sort((p1,p2) => p1.LastName.CompareTo(p2.LastName)); //Sort roster by last name
                    PrintRoster(studentRoster, classInstructor);
                    break;

                case "3":
                    studentRoster.Sort((p1,p2) => p2.ClassRank.CompareTo(p1.ClassRank)); //Sort roster by ClassRank
                    PrintRoster(studentRoster, classInstructor);
                    break;

                default:
                    break;

            }


        }




        static void PrintRoster(List<Student> studentRoster, Instructor classInstructor) //void function to print student roster
        {
            Console.WriteLine();
            Console.WriteLine($"Students in {classInstructor.Name} {classInstructor.LastName}'s class:");
            Console.WriteLine();

            foreach (var Student in studentRoster)
            {
                Console.WriteLine($"{Student.Name} {Student.LastName} {Student.ClassRank}");
            }
        }
    }//end of program
}