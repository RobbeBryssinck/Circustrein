using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Train
    {
        // Properties
        List<Wagon> Wagons { get; set; }

        // Methods
        public Train()
        {
            Wagons = new List<Wagon>();
        }

        public List<Animal> AddWagon(int wagonIndex, List<Animal> animals)
        {
            Wagons.Add(new Wagon());

            Wagons[wagonIndex].AddAnimal(animals[0]);
            Wagons[wagonIndex].UsedSize = animals[0].Size;
            animals.RemoveAt(0);
            
            return animals;
        }

        public bool IsAnimalTooBig(int wagonIndex, Animal animal)
        {
            if (Wagons[wagonIndex].UsedSize + animal.Size > 10)
                return true;
            else
                return false;
        }

        public bool IsAnimalCompatible(int wagonIndex, Animal animal)
        {
            bool compatible = true;

            foreach (Animal wagonAnimal in Wagons[wagonIndex].Animals)
            {
                if (wagonAnimal.Food == "Carnivore" && wagonAnimal.Size >= animal.Size)
                {
                    compatible = false;
                    break;
                }
                if (animal.Food == "Carnivore" && wagonAnimal.Size <= animal.Size)
                {
                    compatible = false;
                    break;
                }
            }

            return compatible;
        }

        public List<Animal> AddAnimalToWagon(int wagonIndex, Animal animal, List<Animal> animals)
        {
            Wagons[wagonIndex].AddAnimal(animal);
            animals.Remove(animal);
            return animals;
        }

        public List<Wagon> GetWagons()
        {
            return Wagons;
        }
    }
}
