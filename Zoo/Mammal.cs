using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Mammal : Animal
    {

        string diet = "";
        bool friendly;

        public Mammal()
        {
            friendly = false;
        }

        public bool Friendly
        {
            get { return friendly; }
            set { friendly = value; }
        }

        public void Diet(string dietSelection)
        {
            switch (dietSelection)
            {
                case "h":
                    diet = "herbivore";
                    break;
                case "c":
                    diet = "carnivore";
                    break;
                case "o":
                    diet = "omnivore";
                    break;
                default:
                    break;

            }
        }

        public string Diet()
        {
            return diet;
        }

        
    }
}
