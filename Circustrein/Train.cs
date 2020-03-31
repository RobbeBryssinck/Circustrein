using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Train
    {
        // Properties
        List<Wagon> Wagons { get; set; }

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
                    if (IsAnimalTooBig(wagonIndex, animals[i]))
                        continue;

                    if (IsAnimalCompatible(wagonIndex, animals[i]))
                    {
                        AddAnimalToWagon(wagonIndex, animals[i]);
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
            Wagons[wagonIndex].UsedSize = animal.Size;
        }

        public bool IsAnimalTooBig(int wagonIndex, Animal animal)
        {
            if (Wagons[wagonIndex].UsedSize + animal.Size > 10)
                return true;
            else
                return false;
        }

        public bool IsAnimalCompatible(int wagonIndex, Animal animal)
        {
            bool compatible = true;

            foreach (Animal wagonAnimal in Wagons[wagonIndex].Animals)
            {
                if (wagonAnimal.Food == "Carnivore" && wagonAnimal.Size >= animal.Size)
                {
                    compatible = false;
                    break;
                }
                if (animal.Food == "Carnivore" && wagonAnimal.Size <= animal.Size)
                {
                    compatible = false;
                    break;
                }
            }

            return compatible;
        }

        public void AddAnimalToWagon(int wagonIndex, Animal animal)
        {
            Wagons[wagonIndex].AddAnimal(animal);
        }

        public List<Wagon> GetWagons()
        {
            return Wagons;
        }
    }
}
