using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    /*
    enum AnimalSize
    {
        Small = 1,
        Medium = 3,
        Big = 5
    }
    */

    class Animal
    {
        // Fields
        private int size;
        private string food;

        // Properties
        public int Size { get { return size; } }
        public string Food { get { return food; } }
        
        // Methods
        public Animal(int size, string food)
        {
            this.size = size;
            this.food = food;
        }
    }
}
