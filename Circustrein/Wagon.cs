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

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
            UsedSize += animal.Size;
        }

        public bool IsAnimalTooBig(Animal animal)
        {
            if (UsedSize + animal.Size > Size)
                return true;
            else
                return false;
        }

        public bool IsAnimalCompatible(Animal animal)
        {
            bool compatible = true;

            foreach (Animal wagonAnimal in Animals)
            {
                if (animal.IsAnimalCompatible(wagonAnimal))
                {
                    compatible = false;
                    break;
                }
            }

            return compatible;
        }

        public List<Animal> GetAnimals()
        {
            return Animals;
        }
    }
}
