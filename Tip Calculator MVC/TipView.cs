using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TipCalculator
{
    class TipView
    {
        public TipView()
        {
            Console.WriteLine("Welcome to the tip Calculator");
            Console.WriteLine();
        }

        public double GetBill()
        {
            
            Console.Write("Please Enter your Bill: ");
            
            return GetDouble();
        }

        public double GetPercent()
        {
            double percent;
            Console.Write("Enter percentage(%) to tip");
            percent = GetDouble();

            return percent;

        }

        public double GetDouble()
        {
            double bill;
            string userBill = "";
            userBill = Console.ReadLine();

            while(!double.TryParse(userBill, out bill))
            {
                Console.Write("This is not valid input, Please try again: ");
                userBill = Console.ReadLine();
            }

            return bill;

        }

        public void PrintTip(double tip)
        {
            Console.WriteLine("Your Tip: $ ");
        }


    }
}
