using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Project_Euler;

namespace ProjectEulerUnitTest
{
    [TestClass]
    public class MultiplesTestClass
    {
        [TestMethod]
        public void SumOfMultiples()
        {
            int firstMultiple = 3;
            int secondMultiple = 7;

            List<int> multiples = new List<int> { firstMultiple, secondMultiple };

            int lowerBoundary = 0;
            int upperBoundary = 10;

            int result = Multiples.SumOfMultiples(multiples, lowerBoundary, upperBoundary);

            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void SumOfMultiples2()
        {
            List<int> multiples = new List<int> { 2, 5, 7 };

            int lowerBoundary = 0;
            int upperBoundary = 10;

            int result = Multiples.SumOfMultiples(multiples, lowerBoundary, upperBoundary);

            Assert.AreEqual(32, result);
        }
    }
}
