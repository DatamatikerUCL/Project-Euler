using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerUnitTest
{
    [TestClass]
    public class LargestProductInGridTestClass
    {
        [TestMethod]
        public void LargestProductInGridRowTest()
        {
            int[][] intMatrix = new int[2][];
            intMatrix[0] = new int[] { 1, 1 };
            intMatrix[1] = new int[] { 1, 4 };
            int adjacentNumbers = 2;

            long largestProduct = 4;

            long calcProduct = LargestProductInGrid.CalculateLargestProduct(intMatrix, adjacentNumbers);

            Assert.AreEqual(largestProduct, calcProduct);
        }

        [TestMethod]
        public void LargestProductInGridRowTestTwo()
        {
            int[][] intMatrix = new int[3][];
            intMatrix[0] = new int[] { 1, 2, 3 };
            intMatrix[1] = new int[] { 1, 0, 0 };
            intMatrix[2] = new int[] { 10, 0, 0 };
            int adjacentNumbers = 2;

            long largestProduct = 6;

            long calcProduct = LargestProductInGrid.CalculateLargestProduct(intMatrix, adjacentNumbers);

            Assert.AreEqual(largestProduct, calcProduct);

        }

        [TestMethod]
        public void LargestProductInColumnTest()
        {
            int[][] intMatrix = new int[2][];
            intMatrix[0] = new int[] { 1, 2 };
            intMatrix[1] = new int[] { 1, 4 };
            int adjacentNumbers = 2;

            long largestProduct = 8;

            long calcProduct = LargestProductInGrid.CalculateLargestProduct(intMatrix, adjacentNumbers);

            Assert.AreEqual(largestProduct, calcProduct);
        }

        [TestMethod]
        public void LargestProductInColumnRowTestTwo()
        {
            int[][] intMatrix = new int[3][];
            intMatrix[0] = new int[] { 1, 2, 3 };
            intMatrix[1] = new int[] { 1, 0, 6 };
            intMatrix[2] = new int[] { 1, 0, 2 };
            int adjacentNumbers = 2;

            long largestProduct = 18;

            long calcProduct = LargestProductInGrid.CalculateLargestProduct(intMatrix, adjacentNumbers);

            Assert.AreEqual(largestProduct, calcProduct);

        }

        [TestMethod]
        public void LargestProductInDiagonalTest()
        {
            int[][] intMatrix = new int[2][];
            intMatrix[0] = new int[] { 3, 2 };
            intMatrix[1] = new int[] { 1, 4 };
            int adjacentNumbers = 2;

            long largestProduct = 12;

            long calcProduct = LargestProductInGrid.CalculateLargestProduct(intMatrix, adjacentNumbers);

            Assert.AreEqual(largestProduct, calcProduct);
        }

    }
}
