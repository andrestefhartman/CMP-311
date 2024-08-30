using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    class Calculator2Model //Model class containing all data and operations
    {
        private double num1;
        private double num2;


        public Calculator2Model() // Constructor that initializes both numbers to 0
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

    }//end of model class
}
