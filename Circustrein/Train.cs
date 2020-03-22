using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Train
    {
        // Properties
        List<Wagon> Wagons { get; set; }
        int WagonIndex { get; } = 0;

        // Methods
        public Train()
        {
            Wagons = new List<Wagon>();
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }

        public List<Animal> AddWagon(int wagonIndex, List<Animal> animals)
        {
            Wagons.Add(new Wagon());

            Wagons[wagonIndex].AddAnimal(animals[0]);
            Wagons[wagonIndex].UsedSize = animals[0].Size;
            animals.RemoveAt(0);
            
            return animals;
        }

        public bool IsAnimalTooBig(int wagonIndex, int animalIndex, List<Animal> animals)
        {
            if (Wagons[wagonIndex].UsedSize + animals[animalIndex].Size > 10)
                return true;
            else
                return false;
        }
    }
}
