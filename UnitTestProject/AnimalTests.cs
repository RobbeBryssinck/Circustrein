using Microsoft.VisualStudio.TestTools.UnitTesting;
using Circustrein;
using System;
using System.Collections.Generic;
using System.Text;

namespace Circustrein.Tests
{
    [TestClass()]
    public class AnimalTests
    {
        [TestMethod()]
        public void IsAnimalDangerous_SmallCarnivoreWithBigCarnivore_IsTrue()
        {
            // Arrange
            Animal animal = new Animal(AnimalSize.Small, AnimalFood.Carnivore);
            Animal wagonAnimal = new Animal(AnimalSize.Big, AnimalFood.Carnivore);

            // Act
            bool isAnimalDangerous = animal.IsAnimalDangerous(wagonAnimal);

            //Assert
            Assert.IsTrue(isAnimalDangerous);
        }

        [TestMethod()]
        public void IsAnimalDangerous_SmallCarnivoreWithSmallCarnivore_IsTrue()
        {
            // Arrange
            Animal animal = new Animal(AnimalSize.Small, AnimalFood.Carnivore);
            Animal wagonAnimal = new Animal(AnimalSize.Small, AnimalFood.Carnivore);

            // Act
            bool isAnimalDangerous = animal.IsAnimalDangerous(wagonAnimal);

            //Assert
            Assert.IsTrue(isAnimalDangerous);
        }

        [TestMethod()]
        public void IsAnimalDangerous_SmallCarnivoreWithSmallHerbivore_IsTrue()
        {
            // Arrange
            Animal animal = new Animal(AnimalSize.Small, AnimalFood.Carnivore);
            Animal wagonAnimal = new Animal(AnimalSize.Small, AnimalFood.Herbivore);

            // Act
            bool isAnimalDangerous = animal.IsAnimalDangerous(wagonAnimal);

            //Assert
            Assert.IsTrue(isAnimalDangerous);
        }

        [TestMethod()]
        public void IsAnimalDangerous_SmallHerbivoreWithSmallHerbivore_IsFalse()
        {
            // Arrange
            Animal animal = new Animal(AnimalSize.Small, AnimalFood.Herbivore);
            Animal wagonAnimal = new Animal(AnimalSize.Small, AnimalFood.Herbivore);

            // Act
            bool isAnimalDangerous = animal.IsAnimalDangerous(wagonAnimal);

            //Assert
            Assert.IsFalse(isAnimalDangerous);
        }

        [TestMethod()]
        public void IsAnimalDangerous_SmallHerbivoreWithBigHerbivore_IsFalse()
        {
            // Arrange
            Animal animal = new Animal(AnimalSize.Small, AnimalFood.Herbivore);
            Animal wagonAnimal = new Animal(AnimalSize.Big, AnimalFood.Herbivore);

            // Act
            bool isAnimalDangerous = animal.IsAnimalDangerous(wagonAnimal);

            //Assert
            Assert.IsFalse(isAnimalDangerous);
        }

        [TestMethod()]
        public void IsAnimalDangerous_MediumHerbivoreWithBigCarnivore_IsTrue()
        {
            // Arrange
            Animal animal = new Animal(AnimalSize.Medium, AnimalFood.Herbivore);
            Animal wagonAnimal = new Animal(AnimalSize.Big, AnimalFood.Carnivore);

            // Act
            bool isAnimalDangerous = animal.IsAnimalDangerous(wagonAnimal);

            //Assert
            Assert.IsTrue(isAnimalDangerous);
        }

        [TestMethod()]
        public void IsAnimalDangerous_MediumHerbivoreWithSmallCarnivore_IsFalse()
        {
            // Arrange
            Animal animal = new Animal(AnimalSize.Medium, AnimalFood.Herbivore);
            Animal wagonAnimal = new Animal(AnimalSize.Small, AnimalFood.Carnivore);

            // Act
            bool isAnimalDangerous = animal.IsAnimalDangerous(wagonAnimal);

            //Assert
            Assert.IsFalse(isAnimalDangerous);
        }
    }
}