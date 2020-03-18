using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    class Wagon
    {
        // Properties
        public int Size { get; } = 10;
        public int UsedSize { get; set; }
        public List<Animal> Animals { get; set; }

        // Methods
        public Wagon()
        {
            Animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }
    }
}
