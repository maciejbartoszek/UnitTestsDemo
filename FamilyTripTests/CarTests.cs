using System;
using System.Data;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestsDemo.Interfaces;
using UnitTestsDemo.Classes;
using Moq;
using System.Linq;

namespace FamilyTripTests
{
	[TestClass]
	public class CarTests
	{
        public TestContext TestContext { get; set; }

        private ICar car;

		// TODO: Zadanie nr 4
		// Zainicjalizuj powtarzające się dane używane w dotychczasowych testach w odpowiedniej metodzie inicjalizującej każdy test
		// Wskazówka: Użyj odpowiedniego atrybutu testów używanego w MSTest framework
		// (https://blogs.msdn.microsoft.com/nnaderi/2007/02/01/comparing-the-mstest-and-nunit-frameworks/)

        [TestInitialize]
        public void TestInit()
        {
            var trunk = new CarTrunk(3);
            car = new Car("Citroen Berlingo", trunk);
        }


		[TestMethod]
		public void ShouldPackLuggageToTheTrunkReturnTrueWhenTrunkSizeIsEnoughForLuggage()
		{
            // Given
            var luggage = new List<ILuggage>
            {
                new Luggage("Wooden chest"),
                new Luggage("Muck"),
                new Luggage("Shovel")
            };

            // When
            var result = car.PackLuggageToTheTrunk(luggage);

            // Then
            Assert.IsTrue(result);
		}

		[TestMethod]
		public void ShouldPackLuggageToTheTrunkReturnFalseWhenTrunkSizeIsNotEnoughForLuggage()
		{
            // TODO: Zadanie nr 2
            // Napisz test jednostkowy sprawdzający metodę „PackLuggageToTheTrunk” czy zwraca „false” gdy bagaż przekracza rozmiar bagażnika samochodu

            // Given
            var luggage = new List<ILuggage>
            {
                new Luggage("Wooden chest"),
                new Luggage("Muck"),
                new Luggage("Shovel"),
                new Luggage("Bucket")
            };

            // When
            var result = car.PackLuggageToTheTrunk(luggage);

            // Then
            Assert.IsFalse(result);
        }

		[TestMethod]
        [ExpectedException(typeof(Exception), AllowDerivedTypes = true)]
		public void ShouldThrowExceptionWhenLuggageListIsNull()
		{
            // TODO: Zadanie nr 3
            // Napisz test jednostkowy sprawdzający metodę „PackLuggageToTheTrunk” czy rzuca wyjątek gdy podany parametr jest nieprawidłowy
            // Wskazówka: Użyj odpowiedniego dekoratora testu, zamiast sekcji Then

            // Given
            List<ILuggage> luggage = null;

            // When
            car.PackLuggageToTheTrunk(luggage);
		}

		[TestMethod]
		public void ShouldCallPackMethodAsManyTimesAsLuggageCount()
		{
            // TODO: Zadanie nr 8
            // Napisz test jednostkowy sprawdzający czy metoda „PackItem” została wywołana tyle razy ile jest bagażu
            // Wskazówka: Moq pozwala na zweryfikowanie czy dana metoda została wywołana po wykonaniu się kodu innej metody.
            // Użyj odpowiednią metodę na zamockowanej zależności

            // Given
            var trunkMock = new Mock<ICarTrunk>();
            var calls = 0;
            trunkMock.Setup(x => x.TrunkCapacity).Returns(5);
            trunkMock.Setup(x => x.PackItem(It.IsAny<string>(), It.IsAny<ILuggage>())).Callback(() => calls++);

            var luggage = new List<ILuggage>
            {
                new Luggage("1"),
                new Luggage("2"),
                new Luggage("3")
            };

            var car = new Car("Toyota", trunkMock.Object);

            // When
            car.PackLuggageToTheTrunk(luggage);

            // Then
            Assert.AreEqual(luggage.Count, calls);
        }

		[TestMethod]
        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML", 
            @"TestData\TestData.xml", 
            "testcase", 
            DataAccessMethod.Sequential
        )]
		public void ShouldPackLuggageToTheTrunkReturnTrueWhenTrunkSizeIsEnoughForLuggage_DataDriven()
		{
            // TODO: Zadanie nr 9
            // Napisz test jednostkowy z zadania nr 1 w stylu Data-Driven Testing
            // Wskazówka: Data - Driven Testing: https://en.wikipedia.org/wiki/Data-driven_testing. W folderze TestData jest przygotowany plik xml.
            // https://www.rhyous.com/2015/05/11/row-tests-or-paramerterized-tests-mstest-xml/

            // Given
            var trunkSize = int.Parse((string)TestContext.DataRow["trunksize"]);
            var luggageCount = int.Parse((string)TestContext.DataRow["luggagecount"]);
            var trunk = new CarTrunk(trunkSize);
            var car = new Car("Toyota", trunk);
            var luggage = new List<ILuggage>();
            luggage.AddRange(Enumerable.Repeat<ILuggage>(new Luggage("Item"), luggageCount));

            // When
            var result = car.PackLuggageToTheTrunk(luggage);

            // Then
            Assert.IsTrue(result);
        }
	}
}
