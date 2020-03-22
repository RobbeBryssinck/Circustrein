using System;
using System.Collections.Generic;

namespace Circustrein
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal(1, "Herbivore"));
            animals.Add(new Animal(5, "Carnivore"));
            animals.Add(new Animal(3, "Herbivore"));
            animals.Add(new Animal(5, "Herbivore"));
            animals.Add(new Animal(3, "Carnivore"));
            animals.Add(new Animal(3, "Carnivore"));
            animals.Add(new Animal(1, "Herbivore"));
            animals.Add(new Animal(3, "Herbivore"));
            animals.Add(new Animal(5, "Herbivore"));
            animals.Add(new Animal(1, "Carnivore"));

            Sorter sorter = new Sorter();
            Train train = sorter.LoadTrain(animals);
            PrintWagons(train);
        }

        public static void PrintWagons(Train train)
        {
            List<Wagon> wagons = train.GetWagons();

            foreach (Wagon wagon in wagons)
            {
                Console.WriteLine("New wagon");
                foreach (Animal animal in wagon.Animals)
                {
                    Console.WriteLine(animal.Food + animal.Size.ToString());
                }
            }
        }
    }
}
