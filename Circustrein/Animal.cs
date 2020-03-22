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

    public class Animal
    {
        // Properties
        public int Size { get; }
        public string Food { get; }

        // Methods
        public Animal(int size, string food)
        {
            Size = size;
            Food = food;
        }
    }
}
