using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerUnitTest
{
    [TestClass]
    public class PythagoreanTripletTest
    {
        [TestMethod]
        public void PythagoreanTripletTestOne()
        {
            int a = 3;
            int b = 4;
            int c = 5;
            int sumOfTriplet = a + b + c;

            long productOfTriplet = a * b * c;

            long calcProduct = PythagoreanTriplet.CalculateTripletWithSum(sumOfTriplet);

            Assert.AreEqual(productOfTriplet, calcProduct);
        }

        [TestMethod]
        public void PythagoreanTripletTestTwo()
        {
            int a = 5;
            int b = 12;
            int c = 13;
            int sumOfTriplet = a + b + c;

            long productOfTriplet = a * b * c;

            long calcProduct = PythagoreanTriplet.CalculateTripletWithSum(sumOfTriplet);

            Assert.AreEqual(productOfTriplet, calcProduct);
        }
    }
}
