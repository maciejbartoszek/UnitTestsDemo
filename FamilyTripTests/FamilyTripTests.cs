using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestsDemo.Interfaces;
using UnitTestsDemo.Classes;
using Moq;

namespace FamilyTripTests
{
	[TestClass]
	public class FamilyTripTests
	{
        private Mock<ILuggage> familyLuggageMock;
        private Mock<ICar> familyCarMock;

        [TestInitialize]
		public void TestInit()
		{
            familyLuggageMock = new Mock<ILuggage>();
            familyCarMock = new Mock<ICar>();
        }

		[TestMethod]
		public void ShouldPrepareFamilyTripReturnFalseWhenExceptionOccurredDuringPackingLuggage()
		{
            // TODO: Zadanie nr 7
            // Napisz test jednostkowy sprawdzający metodę „PrepareFamilyTrip” czy zwraca „false” gdy metoda użyta do pakowania bagażu zwraca wyjątek

            // Given
            familyLuggageMock.Setup(x => x.Name).Returns("Skies");

            var luggage = new List<ILuggage>
            {
                familyLuggageMock.Object
            };

            familyCarMock.Setup(x => x.CheckFuelLevel()).Returns(100);
            familyCarMock.Setup(x => x.PackLuggageToTheTrunk(It.IsAny<List<ILuggage>>())).Throws<Exception>();

            var familyTrip = new FamilyTrip(familyCarMock.Object, luggage);

            // When
            var result = familyTrip.PrepareFamilyTrip();

            // Then
            Assert.IsFalse(result);
        }

        [TestMethod]
		public void ShouldPrepareFamilyTripReturnFalseWhenFuelLevelIsNotEnough()
		{
            // TODO: Zadanie nr 6
            // Napisz test jednostkowy sprawdzający metodę „PrepareFamilyTrip” czy zwraca „false” gdy poziom paliwa jest niewystarczający

            // Given
            familyLuggageMock.Setup(x => x.Name).Returns("Skies");

            var luggage = new List<ILuggage>
            {
                familyLuggageMock.Object
            };

            familyCarMock.Setup(x => x.CheckFuelLevel()).Returns(10);
            familyCarMock.Setup(x => x.PackLuggageToTheTrunk(It.IsAny<List<ILuggage>>())).Returns(true);

            var familyTrip = new FamilyTrip(familyCarMock.Object, luggage);

            // When
            var result = familyTrip.PrepareFamilyTrip();

            // Then
            Assert.IsFalse(result);
        }

		[TestMethod]
		public void ShouldPrepareFamilyTripReturnTrueWhenAllIsOk()
		{
            // TODO: Zadanie nr 5
            // Napisz test jednostkowy sprawdzający metodę „PrepareFamilyTrip” czy zwraca „true” 
            // gdy wszystkie zależności zwracają wartości umożliwiające pełne przejście przez instrukcje warunkowe
            // Wskazówka: Użyj Moq framework do zamockowania zależności (https://github.com/Moq/moq4/wiki/Quickstart)

            // Given
            familyLuggageMock.Setup(x => x.Name).Returns("Skies");

            var luggage = new List<ILuggage>
            {
                familyLuggageMock.Object
            };

            familyCarMock.Setup(x => x.CheckFuelLevel()).Returns(100);
            familyCarMock.Setup(x => x.PackLuggageToTheTrunk(It.IsAny<List<ILuggage>>())).Returns(true);

            var familyTrip = new FamilyTrip(familyCarMock.Object, luggage);

            // When
            var result = familyTrip.PrepareFamilyTrip();

            // Then
            Assert.IsTrue(result);
        }
	}
}
