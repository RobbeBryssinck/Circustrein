using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;
using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein.Tests
{
    [TestClass()]
    public class WagonTests
    {
        [TestMethod()]
        public void AddAnimal_1BigCarnivoreWithBigHerbivore_IsFalse()
        {
            // Arrange
            Wagon wagon = new Wagon();
            wagon.AddAnimal(new Animal(AnimalSize.Big, AnimalFood.Carnivore));

            // Act
            bool isAdded = wagon.AddAnimal(new Animal(AnimalSize.Big, AnimalFood.Herbivore));

            //Assert
            Assert.IsFalse(isAdded);
        }

        [TestMethod()]
        public void AddAnimal_2SmallCarnivoreWithBigHerbivore_IsTrue()
        {
            // Arrange
            Wagon wagon = new Wagon();
            wagon.AddAnimal(new Animal(AnimalSize.Small, AnimalFood.Carnivore));
            wagon.AddAnimal(new Animal(AnimalSize.Small, AnimalFood.Carnivore));

            // Act
            bool isAdded = wagon.AddAnimal(new Animal(AnimalSize.Big, AnimalFood.Herbivore));

            //Assert
            Assert.IsTrue(isAdded);
        }

        [TestMethod()]
        public void AddAnimal_3MediumCarnivoreWithSmallHerbivore_IsFalse()
        {
            // Arrange
            Wagon wagon = new Wagon();
            wagon.AddAnimal(new Animal(AnimalSize.Medium, AnimalFood.Carnivore));
            wagon.AddAnimal(new Animal(AnimalSize.Medium, AnimalFood.Carnivore));
            wagon.AddAnimal(new Animal(AnimalSize.Medium, AnimalFood.Carnivore));

            // Act
            bool isAdded = wagon.AddAnimal(new Animal(AnimalSize.Small, AnimalFood.Herbivore));

            //Assert
            Assert.IsFalse(isAdded);
        }

        [TestMethod()]
        public void AddAnimal_3MediumHerbivoreWithSmallHerbivore_IsTrue()
        {
            // Arrange
            Wagon wagon = new Wagon();
            wagon.AddAnimal(new Animal(AnimalSize.Medium, AnimalFood.Herbivore));
            wagon.AddAnimal(new Animal(AnimalSize.Medium, AnimalFood.Herbivore));
            wagon.AddAnimal(new Animal(AnimalSize.Medium, AnimalFood.Herbivore));

            // Act
            bool isAdded = wagon.AddAnimal(new Animal(AnimalSize.Small, AnimalFood.Herbivore));

            //Assert
            Assert.IsTrue(isAdded);
        }

        [TestMethod()]
        public void AddAnimal_3MediumHerbivoreWithMediumHerbivore_IsFalse()
        {
            // Arrange
            Wagon wagon = new Wagon();
            wagon.AddAnimal(new Animal(AnimalSize.Medium, AnimalFood.Herbivore));
            wagon.AddAnimal(new Animal(AnimalSize.Medium, AnimalFood.Herbivore));
            wagon.AddAnimal(new Animal(AnimalSize.Medium, AnimalFood.Herbivore));

            // Act
            bool isAdded = wagon.AddAnimal(new Animal(AnimalSize.Medium, AnimalFood.Herbivore));

            //Assert
            Assert.IsFalse(isAdded);
        }
    }
}