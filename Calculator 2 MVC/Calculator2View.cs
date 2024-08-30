using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Calculator2View //View class that interacts with the user
    {
        public Calculator2View()
        {
            //Pretty programming
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
        }

        public double GetNum(string NumberID) //Method to get a number from the user that takes a string "first" or "second"
        {
                         
            Console.Write($"Enter {NumberID} number: ");

            return GetDoubleFromUser();
        }
        

        public double GetDoubleFromUser()  //Method to get a double from the User
        {
            string num;
            double cleanNum;

            num = Console.ReadLine();


            //Check to see if input is a double
            while (!double.TryParse(num, out cleanNum))
            {
                Console.Write("This is not valid input. Please enter a numeric value: ");
                num = Console.ReadLine();
            }
            return cleanNum;
        }

        
        public string GetOperationFromUser() //Method to get operation from user
        {
            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            // Get operation
            string op = Console.ReadLine().ToLower();

            return op;
        }

        public bool AppController() //Method to continue or exit the app
        {
            bool exitApp = false;
            Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
            if (Console.ReadLine() == "n") exitApp = true;

            return exitApp;
        }

        public void OperationFail() //Method: Operation fail or invalid operator
        {
            Console.WriteLine("This operation can not be performed");
        }

        public void OperationException(Exception e) //Method: Exception
        {
            Console.WriteLine("An exception occurred trying to do the math.\n - Details: " + e.Message);
        }

        public void Result(double result) //Method: Print result
        {
            Console.WriteLine("Your result: {0:0.##}\n", result);
        }
    }//end of view class
}
