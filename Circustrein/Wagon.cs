using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    class Wagon
    {
        // Fields
        private int size = 10;

        // Properties
        public int Size { get { return size; } }
        public List<Animal> Animals { get; set; }
        
        // Methods
        public void AddAnimal(Animal animal)
        {
            Animals.Add(animal);
        }
    }
}
