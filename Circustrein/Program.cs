using System;

namespace Circustrein
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();
            train.AddAnimal(new Animal(1, "Herbivore"));
            train.AddAnimal(new Animal(5, "Carnivore"));
            train.AddAnimal(new Animal(3, "Herbivore"));
            train.AddAnimal(new Animal(5, "Herbivore"));
            train.AddAnimal(new Animal(3, "Carnivore"));
            train.AddAnimal(new Animal(3, "Carnivore"));
            train.AddAnimal(new Animal(1, "Herbivore"));
            train.AddAnimal(new Animal(3, "Herbivore"));
            train.AddAnimal(new Animal(5, "Herbivore"));
            train.AddAnimal(new Animal(1, "Carnivore"));

            LoadTrain(train);
            PrintWagons(train);
        }

        public static void LoadTrain(Train train)
        {
            int wagonIndex = 0;
            while (train.Animals.Count != 0)
            {
                train.AddWagon(new Wagon());
                train.Wagons[wagonIndex].AddAnimal(train.Animals[0]);
                train.Wagons[wagonIndex].UsedSize = train.Animals[0].Size;
                train.Animals.RemoveAt(0);

                for (int i = train.Animals.Count - 1; i >= 0; i--)
                {
                    int varcheck = train.Wagons[wagonIndex].UsedSize + train.Animals[i].Size;
                    if (varcheck > 10)
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
