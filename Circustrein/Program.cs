using System;
using System.Collections.Generic;

namespace Circustrein
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal(AnimalSize.Small, "Herbivore"));
            animals.Add(new Animal(AnimalSize.Big, "Carnivore"));
            animals.Add(new Animal(AnimalSize.Medium, "Herbivore"));
            animals.Add(new Animal(AnimalSize.Big, "Herbivore"));
            animals.Add(new Animal(AnimalSize.Medium, "Carnivore"));
            animals.Add(new Animal(AnimalSize.Medium, "Carnivore"));
            animals.Add(new Animal(AnimalSize.Small, "Herbivore"));
            animals.Add(new Animal(AnimalSize.Medium, "Herbivore"));
            animals.Add(new Animal(AnimalSize.Big, "Herbivore"));
            animals.Add(new Animal(AnimalSize.Small, "Carnivore"));

            Train train = new Train();
            train.LoadTrain(animals);
            PrintWagons(train);
        }

        public static void PrintWagons(Train train)
        {
            List<Wagon> wagons = train.GetWagons();

            foreach (Wagon wagon in wagons)
            {
                Console.WriteLine("---------------New wagon---------------");
                foreach (Animal animal in wagon.GetAnimals())
                {
                    Console.WriteLine(animal.Food + animal.Size.ToString());
                }
            }
        }
    }
}
