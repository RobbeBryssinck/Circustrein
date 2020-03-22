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

            Train train = LoadTrain(animals);
            PrintWagons(train);
        }

        public static Train LoadTrain(List<Animal> animals)
        {
            Train train = new Train();
            int wagonIndex = 0;

            while (animals.Count != 0)
            {
                animals = train.AddWagon(wagonIndex, animals);

                for (int i = animals.Count - 1; i >= 0; i--)
                {
                    if (train.IsAnimalTooBig(wagonIndex, animals[i]))
                        continue;

                    if (train.IsAnimalCompatible(wagonIndex, animals[i]))
                    {
                        train.AddAnimalToWagon(wagonIndex, animals[i], animals);
                    }
                }
                wagonIndex += 1;
            }
            return train;
        }

        public static void PrintWagons(Train train)
        {
            foreach (Wagon wagon in train.Wagons)
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
