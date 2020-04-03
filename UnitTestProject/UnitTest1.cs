using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;
using System;
using System.Collections.Generic;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LoadTrain()
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal(AnimalSize.Big, AnimalFood.Carnivore));
            animals.Add(new Animal(AnimalSize.Medium, AnimalFood.Herbivore));
            animals.Add(new Animal(AnimalSize.Big, AnimalFood.Herbivore));

            Train train = new Train();
            train.LoadTrain(animals);
            IReadOnlyList<Animal> loadedAnimals = train.GetAnimals();

            Assert.IsTrue(loadedAnimals[0].Size == AnimalSize.Big & loadedAnimals[0].Food == AnimalFood.Carnivore);
            Assert.IsTrue(loadedAnimals[1].Size == AnimalSize.Medium & loadedAnimals[1].Food == AnimalFood.Herbivore);
            Assert.IsTrue(loadedAnimals[2].Size == AnimalSize.Big & loadedAnimals[2].Food == AnimalFood.Herbivore);
        }
    }
}
