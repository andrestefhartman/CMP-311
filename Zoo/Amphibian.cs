using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Amphibian : Animal
    {
        bool poisonous;

        public Amphibian()
        {
            poisonous = false;
        }

        public bool Poisonous
        {
            get { return poisonous; }
            set { poisonous = value; }
        }
    }
}
