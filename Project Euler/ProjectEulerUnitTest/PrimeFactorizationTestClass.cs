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
    }
}
