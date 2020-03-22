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
                    if (train.IsAnimalTooBig(wagonIndex, i, animals))
                        continue;

                    int compatible = 1;
                    foreach (Animal wagonAnimal in train.Wagons[wagonIndex].Animals)
                    {
                        if (wagonAnimal.Food == "Carnivore" && wagonAnimal.Size >= train.Animals[i].Size)
                        {
                            compatible = 0;
                            break;
                        }
                        if (train.Animals[i].Food == "Carnivore" && wagonAnimal.Size <= train.Animals[i].Size)
                        {
                            compatible = 0;
                            break;
                        }
                    }

                    if (compatible == 1)
                    {
                        train.Wagons[wagonIndex].AddAnimal(train.Animals[i]);
                        train.Wagons[wagonIndex].UsedSize += train.Animals[i].Size;
                        train.Animals.RemoveAt(i);
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
