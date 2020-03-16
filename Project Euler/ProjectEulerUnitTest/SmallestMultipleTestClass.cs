using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerUnitTest
{
    [TestClass]
    public class SmallestMultipleTestClass
    {
        [TestMethod]
        public void SmallestMultipleTest()
        {
            int lowerBoundary = 1;
            int upperBoundary = 10;

            int result = SmallestMultiple.CalculateSmallestMultiple(lowerBoundary, upperBoundary);

            Assert.AreEqual(2520, result);
        }

        [TestMethod]
        public void SmallestMultipleTestTwo()
        {
            int lowerBoundary = 1;
            int upperBoundary = 3;

            int result = SmallestMultiple.CalculateSmallestMultiple(lowerBoundary, upperBoundary);

            Assert.AreEqual(6, result);
        }
    }
}
