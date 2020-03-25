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
            intMatrix[1] = new int[] { 0, 0, 0 };
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

        [TestMethod]
        public void LargestProductInDiagonalTestTwo()
        {
            int[][] intMatrix = new int[3][];
            intMatrix[0] = new int[] { 1, 10, 2};
            intMatrix[1] = new int[] { 1, 2, 3 };
            intMatrix[2] = new int[] { 0, 2, 0 };

            long largestProduct = 30;
            int adjacentNumbers = 2;

            long calculatedProduct = LargestProductInGrid.CalculateLargestProduct(intMatrix, adjacentNumbers);

            Assert.AreEqual(largestProduct, calculatedProduct);
        }

        [TestMethod]
        public void LargestProductInDiagonalTestThree()
        {
            int[][] intMatrix = new int[3][];
            intMatrix[0] = new int[] { 1, 1, 2 };
            intMatrix[1] = new int[] { 10, 0, 2 };
            intMatrix[2] = new int[] { 0, 5, 2 };

            long largestProduct = 50;
            int adjacentNumbers = 2;

            long calculatedProduct = LargestProductInGrid.CalculateLargestProduct(intMatrix, adjacentNumbers);

            Assert.AreEqual(largestProduct, calculatedProduct);
        }

        [TestMethod]
        public void LargestProductInDiagonalTestFour()
        {
            int[][] intMatrix = new int[5][];

            intMatrix[0] = new int[] { 12, 50, 10, 2, 69 };
            intMatrix[1] = new int[] { 10, 51, 23, 59, 1 };
            intMatrix[2] = new int[] { 10, 1, 5, 50, 8 };
            intMatrix[3] = new int[] { 2, 56, 23, 23, 56 };
            intMatrix[4] = new int[] { 12, 4, 456, 23, 256 };

            int adjacentNumbers = 3;
            long largestProduct = 456 * 23 * 256;

            long calculatedProduct = LargestProductInGrid.CalculateLargestProduct(intMatrix, adjacentNumbers);

            Assert.AreEqual(largestProduct, calculatedProduct);
        }
    }
}
