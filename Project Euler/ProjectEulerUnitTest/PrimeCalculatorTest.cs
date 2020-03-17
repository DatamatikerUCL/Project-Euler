﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerUnitTest
{
    [TestClass]
    public class PrimeCalculatorTest
    {
        [TestMethod]
        public void PrimeCalculatorTestOne()
        {
            int firstPrime = 2;
            int calculatedPrime = PrimeCalculator.CalculatePrime(1);

            Assert.AreEqual(firstPrime, calculatedPrime);
        }

        [TestMethod]
        public void PrimeCalculatorTestTwo()
        {
            int thirdPrime = 5;
            int calculatedPrime = PrimeCalculator.CalculatePrime(3);

            Assert.AreEqual(thirdPrime, calculatedPrime);
        }

        [TestMethod]
        public void IsPrimeTestOne()
        {
            int prime = 2;

            Assert.IsTrue(PrimeCalculator.IsPrime(prime));
        }

        [TestMethod]
        public void IsNotPrimeTest()
        {
            int notPrime = 9;

            Assert.IsFalse(PrimeCalculator.IsPrime(notPrime));
        }

        [TestMethod]
        public void PrimeTimeTest()
        {
            int primeToCalculate = 10001;

            PrimeCalculator.CalculatePrime(primeToCalculate);
        }
    }
}
