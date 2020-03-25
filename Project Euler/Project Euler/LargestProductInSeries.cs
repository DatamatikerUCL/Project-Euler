using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler
{
    public class LargestProductInSeries
    {
        public static long FindLargestProduct(int adjacentDigits, string stringToCheck)
        {
            long product = Slice(stringToCheck, 0, adjacentDigits);
            long largestProduct = product;


            for (int i = adjacentDigits; i <= stringToCheck.Length - adjacentDigits + 1; i++)
            {
                int pre = int.Parse(stringToCheck[i - adjacentDigits].ToString());
                int cur = int.Parse( stringToCheck[i].ToString());

                if (pre != 0)
                {
                    product = product * cur / pre;
                }
                else
                {
                    product = Slice(stringToCheck, i - adjacentDigits + 1, adjacentDigits);
                }

                largestProduct = Math.Max(product, largestProduct);
            }


            return largestProduct;
        }

        public static long FindLargestProduct(int adjacentDigits, int[] arrayToCheck)
        {
            long largestProduct = int.MinValue;
            

            for (int i = 0; i < arrayToCheck.Length - adjacentDigits + 1; i++)
            {
                long tempProduct = 1;
                for (int j = 0; j < adjacentDigits; j++)
                {
                    tempProduct *= arrayToCheck[i + j];
                }

                if (tempProduct > largestProduct)
                {
                    largestProduct = tempProduct;
                }
            }

            return largestProduct;
        }

        private static long Slice(string str, int i, int n)
        {
            long product = 1;

            for (int j = 0; j < n; j++)
            {
                product *= int.Parse(str[i + j].ToString());
            }

            return product;
        }

    }
}
