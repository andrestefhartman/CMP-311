using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PricingEngineApp
{
    internal class PricingProgram
    {
        static void Main(string[] args)
        {
            bool holiday = false;
            string holidayInput = "";
            bool exitApp = false;

            Console.WriteLine("Welcome to the Pricing Engine");
            Console.WriteLine("_____________________________");


            
            while (!exitApp)
            {
                Console.Write("Is today a Holiday? (y or n): ");
                holidayInput = Console.ReadLine().ToLower();

                if(holidayInput == "y" || holidayInput == "n")
                {
                    if (holidayInput == "y")
                    {
                        holiday = true;
                    }
                    
                    bool exitLoop = false;
                    PricingEngine engine = new PricingEngine(holiday);

                    while (!exitLoop)
                    {
                        int quantity;
                        decimal price;

                        Console.Write("Enter quantity: ");
                        string quantityStr = Console.ReadLine();
                        while(!int.TryParse(quantityStr, out quantity))
                        {
                            Console.Write("Invalid input, please enter a number: ");
                            quantityStr = Console.ReadLine();
                        }

                        Console.Write("Enter Price: ");
                        string priceStr = Console.ReadLine();
                        while(!decimal.TryParse(priceStr, out price))
                        {
                            Console.Write("Invalid input, please enter a number: ");
                            priceStr = Console.ReadLine();
                        }

                        Console.Write("Your unit price: ");
                        Console.WriteLine($"$ {engine.CalculateUnitPrice(quantity, price)}");

                        Console.Write("Calculate another item? (y or n): ");
                        string addItem = Console.ReadLine();

                        if (addItem == "y")
                        {

                        }
                        else
                        {
                            exitLoop = true;
                            exitApp = true;
                        }
                    }
                    

                }
                else
                {
                    Console.WriteLine("Invalid Input, try again ");
                }
    
               
            }
            




            
        }
    }
}
