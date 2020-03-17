using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler
{
    public class PalindromeProduct
    {
        public static bool IsProductPalindrome(int factorOne, int factorTwo)
        {
            string productString = (factorOne * factorTwo).ToString();

            bool isPalindrome = PalindromeHelper(productString);
            return isPalindrome;
        }

        public static bool IsProductPalindrome(long product)
        {
            string productString = product.ToString();

            return PalindromeHelper(productString);
        }

        private static bool PalindromeHelper(string productString)
        {
            if (productString.Length == 0)
            {
                return true;
            }
            if (productString.Length == 1)
            {
                return true;
            }
            if (productString[0] != productString[^1])
            {
                return false;
            }

            return PalindromeHelper(productString[1..^1]);
        }

        public static int LargestPalindromeProduct(int digits)
        {
            int product = int.MinValue;

            for (int i = (int)Math.Pow(10, digits - 1); i <= (int)Math.Pow(10, digits) - 1; i++)
            {
                for (int j = (int) Math.Pow(10, digits - 1)  ; j <= (int)Math.Pow(10, digits) - 1; j++)
                {
                    if (IsProductPalindrome(j * i) && j * i > product)
                    {
                        product = j * i;
                    }
                }
            }

            return product;
        }

        public static int LargestNumberWithAmountOfDigits(int numberOfDigits)
        {
            return (int)Math.Pow(10, numberOfDigits) - 1;
        }
    }
}
