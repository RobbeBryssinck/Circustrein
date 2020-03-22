using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Train
    {
        // Properties
        List<Animal> Animals { get; set; }
        List<Wagon> Wagons { get; set; }
        int WagonIndex { get; } = 0;

        // Methods
        public Train()
        {
            Animals = new List<Animal>();
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
    }
}
