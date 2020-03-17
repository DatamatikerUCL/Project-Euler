using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerUnitTest
{
    [TestClass]
    public class PrimeFactorizationTestClass
    {
        [TestMethod]
        public void PrimeFactorizationSizeTest()
        {
            List<int> primeFactors = PrimeFactorization.Factorize(13195);

            Assert.AreEqual(4, primeFactors.Count);
        }

        [TestMethod]
        public void PrimeFactorizationValueTest()
        {
            List<int> primeFactors = PrimeFactorization.Factorize(13195);

            Assert.AreEqual(29, primeFactors[^1]);
        }

        [TestMethod]
        public void PrimeFactorizationValueTest2()
        {
            List<int> primeFactors = PrimeFactorization.Factorize(10);

            Assert.AreEqual(5, primeFactors[^1]);
        }

        [TestMethod]
        public void RecursivePrimeFactorizationSizeTest()
        {
            List<int> primeFactors = new List<int>();
            PrimeFactorization.FactorizeRecursively(13195, ref primeFactors);

            Assert.AreEqual(4, primeFactors.Count);

        }

        [TestMethod]
        public void RecursivePrimeFactorizationValueTest()
        {
            List<int> primeFactors = new List<int>();
            PrimeFactorization.FactorizeRecursively(13195, ref primeFactors);

            Assert.AreEqual(29, primeFactors[^1]);
        }

        [TestMethod]
        public void RecursivePrimeFactorizationValueTest2()
        {
            List<int> primeFactors = new List<int>();
            PrimeFactorization.FactorizeRecursively(10, ref primeFactors);

            Assert.AreEqual(5, primeFactors[^1]);
        }


        [TestMethod]
        public void TimeTestIterativePrimeFactorTest()
        {
            List<int> primeFactors = PrimeFactorization.Factorize(2136549879);
        }

        [TestMethod]
        public void TimeTestRecurvisePrimeFactorTest()
        {
            List<int> primeFactors = new List<int>();

            PrimeFactorization.FactorizeRecursively(2136549879, ref primeFactors);
        }
    }
}
