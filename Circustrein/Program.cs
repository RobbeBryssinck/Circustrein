using System;

namespace Circustrein
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train();
            train.AddAnimal(new Animal(AnimalSize.Small, "Carnivore"));
            train.AddAnimal(new Animal(AnimalSize.Small, "Herbivore"));
            train.AddAnimal(new Animal(AnimalSize.Medium, "Carnivore"));
            train.AddAnimal(new Animal(AnimalSize.Medium, "Carnivore"));
            train.AddAnimal(new Animal(AnimalSize.Medium, "Herbivore"));
            train.AddAnimal(new Animal(AnimalSize.Medium, "Herbivore"));
            train.AddAnimal(new Animal(AnimalSize.Big, "Herbivore"));
            train.AddAnimal(new Animal(AnimalSize.Big, "Herbivore"));
            train.AddAnimal(new Animal(AnimalSize.Big, "Carnivore"));

            SortAnimals(train);
        }

        public static void SortAnimals(Train train)
        {

        }
    }
}
