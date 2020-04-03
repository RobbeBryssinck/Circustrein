using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Wagon
    {
        // Properties
        private int Size { get; } = 10;
        private int UsedSize { get; set; } = 0;
        private List<Animal> Animals { get; set; }

        // Methods
        public Wagon()
        {
            Animals = new List<Animal>();
        }

        //TODO: combineren van onderste 3 functies
        public bool AddAnimal(Animal animal)
        {
            if (IsAnimalRightSize(animal) && IsAnimalNotDangerous(animal))
            {
                Animals.Add(animal);
                UsedSize += (int)animal.Size;
                return true;
            }
            else
                return false;
        }

        private bool IsAnimalRightSize(Animal animal)
        {
            if (UsedSize + (int)animal.Size <= Size)
                return true;
            else
                return false;
        }

        private bool IsAnimalNotDangerous(Animal animal)
        {
            bool compatible = true;

            foreach (Animal wagonAnimal in Animals)
            {
                if (animal.IsAnimalDangerous(wagonAnimal))
                {
                    compatible = false;
                    break;
                }
            }

            return compatible;
        }

        public IReadOnlyList<Animal> GetAnimals()
        {
            return Animals;
        }
    }
}
