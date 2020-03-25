using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerUnitTest
{
    [TestClass]
    public class HighlyDivisibleTriangleNumberTestClass
    {
        [TestMethod]
        public void GenerateTriangleNumbersTest()
        {
            int triangleNumber = 3;

            long thirdTriangleNumber = 6;
            long calc = HighlyDivisibleTriangleNumber.CalculateTriangleNumber(triangleNumber);

            Assert.AreEqual(thirdTriangleNumber, calc);
        }

        [TestMethod]
        public void GenerateTriangleNumbersTestTwo()
        {
            int triangleNumber = 10;

            long tenthTriangleNumber = 55;

            long calc = HighlyDivisibleTriangleNumber.CalculateTriangleNumber(triangleNumber);

            Assert.AreEqual(tenthTriangleNumber, calc);
        }

        [TestMethod]
        public void GenerateTriangleNumbersSizeTest()
        {
            int triangleNumber = 12345678;

            HighlyDivisibleTriangleNumber.CalculateTriangleNumber(triangleNumber);
        }

        [TestMethod]
        public void GetNumberOfDivisibles()
        {
            int triangle = 3;

            int divisibles = 2;

            int calculated = HighlyDivisibleTriangleNumber.CalculateNumberOfDivisibles(triangle);

            Assert.AreEqual(divisibles, calculated);
        }

        [TestMethod]
        public void GetNumberOfDivisblesTwo()
        {
            int triangle = 6;

            int divisibles = 4;

            int calculated = HighlyDivisibleTriangleNumber.CalculateNumberOfDivisibles(triangle);

            Assert.AreEqual(divisibles, calculated);
        }

        [TestMethod]
        public void GetNumberOfDivisiblesNotOnlyPrimes()
        {
            int triangle = 36;
            int divisibles = 8;

            int calculated = HighlyDivisibleTriangleNumber.CalculateNumberOfDivisibles(triangle);

            Assert.AreEqual(divisibles, calculated);
        }
    }
}
