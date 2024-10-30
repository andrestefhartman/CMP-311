using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICost eventCost = new Birthday(01, "Sally's b-day", 25);
            ProductService productService1 = new ProductService(eventCost);
            Console.WriteLine($"Event cost: {productService1.Cost("d")}");
            Console.ReadLine();
        }

    }
}