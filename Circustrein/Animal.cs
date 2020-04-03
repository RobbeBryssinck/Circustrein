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

    public enum AnimalFood
    {
        Carnivore = 'c',
        Herbivore = 'h'
    }

    public class Animal
    {
        // Properties
        public AnimalSize Size { get; }
        public AnimalFood Food { get; }

        // Methods
        public Animal(AnimalSize size, AnimalFood food)
        {
            Size = size;
            Food = food;
        }

        public bool IsAnimalDangerous(Animal wagonAnimal)
        {
            if (wagonAnimal.Food == AnimalFood.Carnivore && wagonAnimal.Size >= Size || Food == AnimalFood.Carnivore && wagonAnimal.Size <= Size)
                return true;
            return false;
        }
    }
}
