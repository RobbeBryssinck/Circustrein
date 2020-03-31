using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public enum AnimalSize
    {
        Small = 1,
        Medium = 3,
        Big = 5
    }

    public class Animal
    {
        // Properties
        public AnimalSize Size { get; }
        public string Food { get; }

        // Methods
        public Animal(AnimalSize size, string food)
        {
            Size = size;
            Food = food;
        }

        public bool IsAnimalCompatible(Animal wagonAnimal)
        {
            if (wagonAnimal.Food == "Carnivore" && wagonAnimal.Size >= Size || Food == "Carnivore" && wagonAnimal.Size <= Size)
                return true;
            return false;
        }
    }
}
