using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Reptile : Animal
    {
        bool venomous;

        public Reptile()
        {
            venomous = false;
        }

        public bool Venomous
        {
            get { return venomous; }
            set { venomous = value; }
        }

    }
}
