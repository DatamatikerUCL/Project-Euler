using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler
{
    public class LargestProductInSeries
    {
        public static int FindLargestProduct(int adjacentDigits, string stringToCheck)
        {
            int largestProduct = int.MinValue;

            for (int i = 0; i < stringToCheck.Length - adjacentDigits; i++)
            {
                int product = 1;

                for (int j = 0; j < adjacentDigits; j++)
                {
                    product *= int.Parse(stringToCheck[i + j].ToString());
                }

                if (product > largestProduct)
                {
                    largestProduct = product;
                }
            }

            return largestProduct;
        }
    }
}
