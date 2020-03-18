using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    class Train
    {
        // Properties
        public List<Animal> Animals { get; set; }
        public List<Wagon> Wagons { get; set; }

        // Methods
        public void AddAnimal(Animal animal)
        {
            Animals = new List<Animal>();
            Wagons = new List<Wagon>();
            Animals.Add(animal);
        }

        public void AddWagon(Wagon wagon)
        {
            Wagons.Add(wagon);
        }
    }
}
