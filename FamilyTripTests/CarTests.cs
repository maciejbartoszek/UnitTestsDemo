using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestsDemo.Interfaces;
using UnitTestsDemo.Classes;
using Moq;

namespace FamilyTripTests
{
	[TestClass]
	public class CarTests
	{
		// TODO: Zadanie nr 4
		// Zainicjalizuj powtarzające się dane używane w dotychczasowych testach w odpowiedniej metodzie inicjalizującej każdy test
		// Wskazówka: Użyj odpowiedniego atrybutu testów używanego w MSTest framework
		// (https://blogs.msdn.microsoft.com/nnaderi/2007/02/01/comparing-the-mstest-and-nunit-frameworks/)

        public void TestInit()
        {
        }

		[TestMethod]
		public void ShouldPackLuggageToTheTrunkReturnTrueWhenTrunkSizeIsEnoughForLuggage()
		{
			// TODO: Zadanie nr 1
			// Napisz test jednostkowy sprawdzający metodę „PackLuggageToTheTrunk” czy zwraca „true” gdy bagaż nie przekracza rozmiaru bagażnika samochodu

			// Given

			// When

			// Then
		}

		[TestMethod]
		public void ShouldPackLuggageToTheTrunkReturnFalseWhenTrunkSizeIsNotEnoughForLuggage()
		{
			// TODO: Zadanie nr 2
			// Napisz test jednostkowy sprawdzający metodę „PackLuggageToTheTrunk” czy zwraca „false” gdy bagaż przekracza rozmiar bagażnika samochodu

			// Given

			// When

			// Then
		}

		[TestMethod]
		public void ShouldThrowExceptionWhenLuggageListIsNull()
		{
			// TODO: Zadanie nr 3
			// Napisz test jednostkowy sprawdzający metodę „PackLuggageToTheTrunk” czy rzuca wyjątek gdy podany parametr jest nieprawidłowy
            // Wskazówka: Użyj odpowiedniego dekoratora testu, zamiast sekcji Then

			// Given

			// When

			// Then
		}

		[TestMethod]
		public void ShouldCallPackMethodAsManyTimesAsLuggageCount()
		{
			// TODO: Zadanie nr 8
			// Napisz test jednostkowy sprawdzający czy metoda „PackItem” została wywołana tyle razy ile jest bagażu
			// Wskazówka: Moq pozwala na zweryfikowanie czy dana metoda została wywołana po wykonaniu się kodu innej metody.
			// Użyj odpowiednią metodę na zamockowanej zależności

			// Given

			// When

			// Then
		}

		[TestMethod]
		public void ShouldPackLuggageToTheTrunkReturnTrueWhenTrunkSizeIsEnoughForLuggage_DataDriven()
		{
			// TODO: Zadanie nr 9
			// Napisz test jednostkowy z zadania nr 1 w stylu Data-Driven Testing
			// Wskazówka: Data - Driven Testing: https://en.wikipedia.org/wiki/Data-driven_testing. W folderze TestData jest przygotowany plik xml.
			// https://www.rhyous.com/2015/05/11/row-tests-or-paramerterized-tests-mstest-xml/

			// Given

			// When

			// Then
		}
	}
}
