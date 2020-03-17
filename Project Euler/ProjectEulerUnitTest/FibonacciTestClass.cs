using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerUnitTest
{
    [TestClass]
    public class FibonacciTestClass
    {
        [TestMethod]
        public void FibonacciNumberGenerationTest()
        {
            int upperLimit = 100;

            List<int> fibonnaciSequence = Fibonacci.GenerateFibonacciNumbers(upperLimit);

            Assert.AreEqual(10, fibonnaciSequence.Count);
        }

        [TestMethod]
        public void FibonacciNumberGenerationTimeTest()
        {
            int upperLimit = 123456;

            List<int> fibonnaciSequence = Fibonacci.GenerateFibonacciNumbers(upperLimit);
        }

        [TestMethod]
        public void FibonacciNumberGenerationValueTest()
        {
            int upperLimit = 100;

            List<int> fibonnaciSequence = Fibonacci.GenerateFibonacciNumbers(upperLimit);

            Assert.AreEqual(89, fibonnaciSequence[^1]);
        }

        [TestMethod]
        public void SumOfEvenFibonacciNumbersTest()
        {
            int upperLimit = 10;

            int sum = Fibonacci.SumOfEvenFibonacciNumbers(upperLimit);

            Assert.AreEqual(10, sum);
        }

        [TestMethod]
        public void SumOfEvenFibonacciNumbersTest2()
        {
            int upperLimit = 50;

            int sum = Fibonacci.SumOfEvenFibonacciNumbers(upperLimit);

            Assert.AreEqual(44, sum);
        }
    }
}
