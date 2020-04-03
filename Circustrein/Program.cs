using System;
using System.Collections.Generic;

namespace Circustrein
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal(AnimalSize.Small, AnimalFood.Herbivore));
            animals.Add(new Animal(AnimalSize.Big, AnimalFood.Carnivore));
            animals.Add(new Animal(AnimalSize.Medium, AnimalFood.Herbivore));
            animals.Add(new Animal(AnimalSize.Big, AnimalFood.Herbivore));
            animals.Add(new Animal(AnimalSize.Medium, AnimalFood.Carnivore));
            animals.Add(new Animal(AnimalSize.Medium, AnimalFood.Carnivore));
            animals.Add(new Animal(AnimalSize.Small, AnimalFood.Herbivore));
            animals.Add(new Animal(AnimalSize.Medium, AnimalFood.Herbivore));
            animals.Add(new Animal(AnimalSize.Big, AnimalFood.Herbivore));
            animals.Add(new Animal(AnimalSize.Small, AnimalFood.Carnivore));

            Train train = new Train();
            train.LoadTrain(animals);
            PrintWagons(train);
        }

        public static void PrintWagons(Train train)
        {
            IReadOnlyList<Wagon> wagons = train.GetWagons();

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
