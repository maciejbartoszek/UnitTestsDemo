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
		[TestInitialize]
		public void TestInit()
		{
		}

		[TestMethod]
		public void ShouldPrepareFamilyTripReturnFalseWhenExceptionOccurredDuringPackingLuggage()
		{
			// TODO: Zadanie nr 7
			// Napisz test jednostkowy sprawdzający metodę „PrepareFamilyTrip” czy zwraca „false” gdy metoda użyta do pakowania bagażu zwraca wyjątek

			// Given

			// When

			// Then
		}

		[TestMethod]
		public void ShouldPrepareFamilyTripReturnFalseWhenFuelLevelIsNotEnough()
		{
			// TODO: Zadanie nr 6
			// Napisz test jednostkowy sprawdzający metodę „PrepareFamilyTrip” czy zwraca „false” gdy poziom paliwa jest niewystarczający

			// Given

			// When

			// Then
		}

		[TestMethod]
		public void ShouldPrepareFamilyTripReturnTrueWhenAllIsOk()
		{
			// TODO: Zadanie nr 5
			// Napisz test jednostkowy sprawdzający metodę „PrepareFamilyTrip” czy zwraca „true” 
			// gdy wszystkie zależności zwracają wartości umożliwiające pełne przejście przez instrukcje warunkowe
			// Wskazówka: Użyj Moq framework do zamockowania zależności (https://github.com/Moq/moq4/wiki/Quickstart)

			// Given

			// When

			// Then
		}
	}
}
