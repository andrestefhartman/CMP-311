using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class ZooView
    {
        public ZooView()
        {
            Console.WriteLine("Welcome to your Zoo ");
            Console.WriteLine("____________________");
        }

        public string Menu()
        {
            string menuSelection = "";

            Console.WriteLine("What would you like to do?");

            Console.WriteLine("1 - add mammal");
            Console.WriteLine("2 - add reptile");
            Console.WriteLine("3 - add amphibian");
            Console.WriteLine("4 - view Animals");
            Console.WriteLine("5 - view Mammals");
            Console.WriteLine("6 - view Reptiles");
            Console.WriteLine("7 - view Amphibians");
            Console.WriteLine("x - Exit app");
            Console.Write("Your choice: ");
            menuSelection = Console.ReadLine().ToLower();

            return menuSelection;
        }

        public Mammal GetMammal()
        {
            Mammal mammal = new Mammal();
            bool friendly;
            string friendlyness = "";
            

            mammal.Species = GetSpecies();
            mammal.Sex = GetSex();
            mammal.Age = GetAge();
            mammal.Diet(GetDiet());

            Console.Write("Is this mammal friendly? (y/n): ");

            bool exitLoop = false;

            while (!exitLoop)
            {
                friendlyness = Console.ReadLine();

                if(friendlyness == "y")
                {
                    mammal.Friendly = true;
                    exitLoop = true;
                }
                else if (friendlyness == "n")
                {
                    mammal.Friendly = false;
                    exitLoop = true;
                }
                else
                {
                    Console.Write("Invalid input, try again: ");
                }
            }


            return mammal;


        }

        public Reptile GetReptile()
        {
            Reptile reptile = new Reptile();
            string venomousness = "";

            reptile.Species = GetSpecies();
            reptile.Sex = GetSex();
            reptile.Age = GetAge();

            Console.Write("Is this reptile venomous? (y/n): ");

            bool exitLoop = false;

            while (!exitLoop)
            {
                venomousness = Console.ReadLine();

                if (venomousness == "y")
                {
                    reptile.Venomous = true;
                    exitLoop = true;
                }
                else if (venomousness == "n")
                {
                    reptile.Venomous = false;
                    exitLoop = true;
                }
                else
                {
                    Console.Write("Invalid input, try again: ");
                }
            }

            return reptile;


        }

        public Amphibian GetAmphibian()
        {
            Amphibian amphibian = new Amphibian();
            string poisonousness = "";

            amphibian.Species = GetSpecies();
            amphibian.Sex = GetSex();
            amphibian.Age = GetAge();

            Console.Write("Is this amphibian poisonous? (y/n): ");

            bool exitLoop = false;

            while (!exitLoop)
            {
                poisonousness = Console.ReadLine();

                if (poisonousness == "y")
                {
                    amphibian.Poisonous = true;
                    exitLoop = true;
                }
                else if (poisonousness == "n")
                {
                    amphibian.Poisonous = false;
                    exitLoop = true;
                }
                else
                {
                    Console.Write("Invalid input, try again: ");
                }
            }

            return amphibian;
        }



        private string GetSpecies()
        {
            string species;
            Console.Write("Enter species: ");
            species = Console.ReadLine();

            return species;

        }

        private string GetSex()
        {
            string sex;
            Console.Write("Enter sex (m or f): ");
            sex = Console.ReadLine().ToLower();

            return sex;
        }

        private int GetAge()
        {
            string age = "";
            Console.Write("Enter age: ");
            age = Console.ReadLine();

            int intAge;

            while (!int.TryParse(age, out intAge))
            {
                Console.Write("Invalid input, enter a number: ");
                age = Console.ReadLine();

            }

            return intAge;

        }

        private string GetDiet()
        {
            string diet = "";
            Console.WriteLine("Choose diet:");
            Console.WriteLine("h - herbivore");
            Console.WriteLine("c - carnivore");
            Console.WriteLine("o - omnivore");
            Console.Write("Your choice: ");
            diet = Console.ReadLine().ToLower();

            while(diet != "h" && diet != "c" && diet != "o")
            {
                Console.Write("Invalid input, try again: ");
                diet = Console.ReadLine().ToLower();
            }

            return diet;

        }

        public void PrintAnimals(List<Animal> animals)
        {
            foreach(Animal item in animals)
            {
                Console.WriteLine($"{item.Species} {item.Sex} {item.Age}");
                
            }
        }

        public void PrintMammals(List<Mammal> mammals)
        {
            foreach (Mammal item in mammals)
            {
                Console.WriteLine($"{item.Species} {item.Sex} {item.Age} {item.Diet()} friendly: {item.Friendly}");

            }
        }

        public void PrintReptiles(List<Reptile> reptiles)
        {
            foreach (Reptile item in reptiles)
            {
                Console.WriteLine($"{item.Species} {item.Sex} {item.Age} venomous: {item.Venomous}");

            }
        }

        public void PrintAmphibians(List<Amphibian> amphibians)
        {
            foreach (Amphibian item in amphibians)
            {
                Console.WriteLine($"{item.Species} {item.Sex} {item.Age} Posionous: {item.Poisonous}");

            }
        }

        public void InvalidInput()
        {
            Console.WriteLine("Invalid input");
            Console.WriteLine();
        }
    }
}
