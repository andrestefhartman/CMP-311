using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class ZooModel
    {
        List<Animal> animals = new List<Animal>();
        List<Mammal> mammals = new List<Mammal>();
        List<Reptile> reptiles = new List<Reptile>();
        List<Amphibian> amphibians = new List<Amphibian>();

        public ZooModel()
        {

        }

        public void AddMammal(Mammal mammal)
        {
            animals.Add(mammal);
            mammals.Add(mammal);
            
        }

        public void addReptile(Reptile reptile)
        {
            animals.Add(reptile);
            reptiles.Add(reptile);

        }

        public void addAmphibian(Amphibian amphibian)
        {
            animals.Add(amphibian);
            amphibians.Add(amphibian);
        }

        public List<Animal> GetAnimals()
        {
            return animals;
        }

        public List<Mammal> GetMammals()
        {
            return mammals;
        }

        public List<Reptile> GetReptiles()
        {
            return reptiles;
        }

        public List<Amphibian> GetAmphibians()
        {
            return amphibians;
        }

    }

    
}
