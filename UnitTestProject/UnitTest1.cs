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
            animals.Add(new Animal(AnimalSize.Big, "Carnivore"));
            animals.Add(new Animal(AnimalSize.Medium, "Herbivore"));
            animals.Add(new Animal(AnimalSize.Big, "Herbivore"));

            Train train = new Train();
            train.LoadTrain(animals);
            List<Animal> loadedAnimals = train.GetAnimals();

            Assert.IsTrue(loadedAnimals[0].Size == AnimalSize.Big & loadedAnimals[0].Food == "Carnivore");
            Assert.IsTrue(loadedAnimals[1].Size == AnimalSize.Medium & loadedAnimals[1].Food == "Herbivore");
            Assert.IsTrue(loadedAnimals[2].Size == AnimalSize.Big & loadedAnimals[2].Food == "Herbivore");
        }
    }
}
