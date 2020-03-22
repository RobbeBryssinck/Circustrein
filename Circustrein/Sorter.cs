using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein
{
    public class Sorter
    {
        public Train LoadTrain(List<Animal> animals)
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
    }
}
