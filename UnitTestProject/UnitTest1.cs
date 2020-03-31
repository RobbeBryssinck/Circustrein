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
            animals.Add(new Animal(5, "Carnivore"));
            animals.Add(new Animal(3, "Herbivore"));
            animals.Add(new Animal(5, "Herbivore"));

            Train train = new Train();
            train.LoadTrain(animals);

            List<Wagon> wagons = train.GetWagons();
            Assert.IsTrue(wagons[0].Animals[0].Size == 5 & wagons[0].Animals[0].Food == "Carnivore");
            Assert.IsTrue(wagons[1].Animals[0].Size == 3 & wagons[1].Animals[0].Food == "Herbivore");
            Assert.IsTrue(wagons[1].Animals[1].Size == 5 & wagons[1].Animals[1].Food == "Herbivore");
        }
    }
}
