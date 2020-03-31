using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Train
    {
        // Properties
        private List<Wagon> Wagons { get; set; }

        // Methods
        public Train()
        {
            Wagons = new List<Wagon>();
        }

        public void LoadTrain(List<Animal> animals)
        {
            int wagonIndex = 0;

            while (animals.Count != 0)
            {
                AddWagon(wagonIndex, animals[0]);
                animals.RemoveAt(0);

                for (int i = animals.Count - 1; i >= 0; i--)
                {
                    if (Wagons[wagonIndex].IsAnimalTooBig(animals[i]))
                        continue;

                    if (Wagons[wagonIndex].IsAnimalCompatible(animals[i]))
                    {
                        Wagons[wagonIndex].AddAnimal(animals[i]);
                        animals.Remove(animals[i]);
                    }
                }
                wagonIndex += 1;
            }
        }

        public void AddWagon(int wagonIndex, Animal animal)
        {
            Wagons.Add(new Wagon());
            Wagons[wagonIndex].AddAnimal(animal);
        }

        public List<Wagon> GetWagons()
        {
            return Wagons;
        }

        public List<Animal> GetAnimals()
        {
            List<Animal> animals = new List<Animal>();

            foreach (Wagon wagon in Wagons)
            {
                foreach (Animal animal in wagon.GetAnimals())
                {
                    animals.Add(animal);
                }
            }

            return animals;
        }
    }
}
