using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerUnitTest
{
    [TestClass]
    public class SumSquareDifferenceTestClass
    {
        [TestMethod]
        public void SumOfSquaresTestOne()
        {
            List<int> numbersToSum = new List<int>();
            int lowerBoundary = 1;
            int upperBoundary = 10;

            for (int i = lowerBoundary; i < upperBoundary+1; i++)
            {
                numbersToSum.Add(i);
            }
            int expectedResult = 385;
            int calculatedResult = SumSquareDifference.CalculateSumOfSquares(numbersToSum);

            Assert.AreEqual(expectedResult, calculatedResult);
        }

        [TestMethod]
        public void SumOfSquaresTestTwo()
        {
            List<int> numbersToSum = new List<int>();
            int lowerBoundary = 5;
            int upperBoundary = 6;

            for (int i = lowerBoundary; i < upperBoundary + 1; i++)
            {
                numbersToSum.Add(i);
            }
            int expectedResult = 61;
            int calculatedResult = SumSquareDifference.CalculateSumOfSquares(numbersToSum);

            Assert.AreEqual(expectedResult, calculatedResult);
        }

        [TestMethod]
        public void SquareOfSumTestOne()
        {
            List<int> numbersToSum = new List<int>();
            int lowerBoundary = 1;
            int upperBoundary = 10;
            int expectedResult = 3025;

            for (int i = lowerBoundary; i < upperBoundary + 1; i++)
            {
                numbersToSum.Add(i);
            }

            int calculatedResult = SumSquareDifference.CalculateSquareOfSums(numbersToSum);

            Assert.AreEqual(expectedResult, calculatedResult);
        }

        [TestMethod]
        public void SquareOfSumTestTwo()
        {
            List<int> numbersToSum = new List<int>();
            int lowerBoundary = 1;
            int upperBoundary = 5;
            int expectedResult = 225;

            for (int i = lowerBoundary; i < upperBoundary + 1; i++)
            {
                numbersToSum.Add(i);
            }

            int calculatedResult = SumSquareDifference.CalculateSquareOfSums(numbersToSum);

            Assert.AreEqual(expectedResult, calculatedResult);
        }

        [TestMethod]
        public void DifferenceTestOne()
        {
            int lowerBoundary = 1;
            int upperBoundary = 10;
            int expectedResult = 2640;

            int calculatedResult = SumSquareDifference.CalculateSumSquareDifference(lowerBoundary, upperBoundary);

            Assert.AreEqual(expectedResult, calculatedResult);
        }

        [TestMethod]
        public void DifferenceTestTwo()
        {
            int lowerBoundary = 5;
            int upperBoundary = 10;
            int expectedResult = 1670;

            int calculatedResult = SumSquareDifference.CalculateSumSquareDifference(lowerBoundary, upperBoundary);

            Assert.AreEqual(expectedResult, calculatedResult);
        }
    }
}
