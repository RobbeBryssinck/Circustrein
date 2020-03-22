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
        public void AddAnimalToWagonTest()
        {
            Train train = new Train();
            List<Wagon> localWagons = new List<Wagon>();
            localWagons.Add(new Wagon());
            localWagons[0].AddAnimal(new Animal(1, "Herbivore"));
            train.AddWagon(0, new Animal(1, "Herbivore"));

            List<Wagon> wagons = train.GetWagons();

            CollectionAssert.AreEqual(wagons, localWagons);
        }
    }
}
