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
            long product = Slice(arrayToCheck, 0, adjacentDigits);
            long largestProduct = product;

            for (int i = adjacentDigits; i <= arrayToCheck.Length - adjacentDigits +1; i++)
            {
                int pre = arrayToCheck[i - adjacentDigits];
                int cur = arrayToCheck[i];

                if (pre != 0)
                {
                    product = product * cur / pre;
                }
                else
                {
                    product = Slice(arrayToCheck, i - adjacentDigits + 1, adjacentDigits);
                }

                largestProduct = Math.Max(product, largestProduct);
            }

            return largestProduct;
        }

        private static long Slice(int[] array, int i, int n)
        {
            long product = 1;

            for (int j = 0; j < n; j++)
            {
                product *= array[i + j];
            }

            return product;
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
