using System;

namespace Calculator
{
    class Calculator
    {
        private double num1;
        private double num2;


        public Calculator()
        {
            num1 = 0;
            num2 = 0;
        }
        public double Number1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public double Number2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public double DoOperation(string op)
        {
            double result = double.NaN; // Default value is "not-a-number", in case of an error

            switch (op)
            {
                case "a":
                    result = num1 + num2;
                    break;
                case "s":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                default:
                    break;
            }
            return result;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Calculator myCalc = new Calculator();

            bool exitApp = false;


            //Display Concole calculator app title
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

                string op = Console.ReadLine().ToLower();

                try
                {
                    double result = myCalc.DoOperation(op);

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
        static double getDoubleFromUser()
        {
            string num;
            double cleanNum;
            
            num = Console.ReadLine();

            while (!double.TryParse(num, out cleanNum))
            {
                Console.Write("This is not valid input. Please enter a numeric value: ");
                num = Console.ReadLine();
            }
            return cleanNum;
        }
    }


}

