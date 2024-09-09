using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Animal
    {
        string species = "";
        string sex = "";
        int age;


        public Animal()
        {

        }

        public Animal(string species,string sex, int age)
        {
            this.species = species;
            this.sex = sex;
            this.age = age;
        }

        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        

    }
}
