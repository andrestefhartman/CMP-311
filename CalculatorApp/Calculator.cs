// Calculator app with ability to add, subtract, divide or muliply two numbers.

using System;

namespace Calculator
{
    class Calculator
    {

        private double num1;
        private double num2;

        
        public Calculator() // Constructor that initializes both numbers to 0
        {
            num1 = 0;
            num2 = 0;
        }

        
        public double Number1  // Property for num1 to declare the accessor and mutator
        {
            get { return num1; }
            set { num1 = value; }
        }

        public double Number2  // Property for num2 to declare the accessor and mutator
        {
            get { return num2; }
            set { num2 = value; }
        }

        public double DoOperation(string op) // Public Method to do an operation
        {
            double result = double.NaN; // Default value is "not-a-number", in case of an error

            switch (op)  // Switch to determine which operation should be done
            {   
                case "a":  // Add
                    result = num1 + num2;
                    break;

                case "s":  // Subtract
                    result = num1 - num2;
                    break;

                case "m":  // Multiply
                    result = num1 * num2;
                    break;

                case "d": // Divide
                    if (num2 != 0)  // if function to prevent dividing by 0
                    {
                        result = num1 / num2;
                    }
                    break;

                default:
                    break;
            }
            return result;
        }
    } // End of calculator class


    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalc = new Calculator();  // Create an instance of Calculator

            bool exitApp = false;  // Boolean used to exit the app 


            //Display Console calculator app title
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!exitApp)
            {
                //Get the first number from user
                Console.Write("First Number: ");
                myCalc.Number1 = getDoubleFromUser();

                //Get the second number from user
                Console.Write("Second Number: ");
                myCalc.Number2 = getDoubleFromUser();


                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                // Get operation
                string op = Console.ReadLine().ToLower();


               
                try
                {
                    double result = myCalc.DoOperation(op);

                    //Check to see if an operation was done
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation can not be performed");

                    }
                    else
                    {
                        Console.WriteLine("Your result: {0:0.##}\n", result);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") exitApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }
        static double getDoubleFromUser()  //Function to get a double from the User
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
    } // End of main program


}

