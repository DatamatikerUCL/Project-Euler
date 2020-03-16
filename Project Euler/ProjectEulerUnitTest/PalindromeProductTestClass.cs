using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Euler;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEulerUnitTest
{
    [TestClass]
    public class PalindromeProductTestClass
    {
        [TestMethod]
        public void PalindromeProductTest()
        {
            int factorOne = 91;
            int factorTwo = 99;

            Assert.IsTrue(PalindromeProduct.IsProductPalindrome(factorOne, factorTwo));
        }
            
        [TestMethod]
        public void IsNotAPalindromeTest()
        {
            int factorOne = 12;
            int factorTwo = factorOne;

            Assert.IsFalse(PalindromeProduct.IsProductPalindrome(factorOne, factorTwo));
        }

        [TestMethod]
        public void LargestPalindromeProduct()
        {
            Assert.AreEqual(9009, PalindromeProduct.LargestPalindromeProduct(2));
        }

        [TestMethod]
        public void LargestNumberDigitCalculatorTest()
        {
            Assert.AreEqual(9, PalindromeProduct.LargestNumberWithAmountOfDigits(1));
        }

        [TestMethod]
        public void LargestNumberDigitCalculatorTestTwo()
        {
            Assert.AreEqual(999, PalindromeProduct.LargestNumberWithAmountOfDigits(3));
        }
        
        [TestMethod]
        public void PalindromeProductTestTwo()
        {
            Assert.IsTrue(PalindromeProduct.IsProductPalindrome(9000000000009));
        }
    }
}
