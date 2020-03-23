using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Euler
{
    public class LargestProductInGrid
    {
        public static long CalculateLargestProduct(int[][] intMatrix, int adjacentNumbers)
        {
            long largestProduct = int.MinValue;
            string separationString = string.Empty;

            for (int i = 0; i < intMatrix[0].Length; i++)
            {
                long tempRowResult = LargestProductInSeries.FindLargestProduct(adjacentNumbers, string.Join(separationString, intMatrix[i]));

                int[] currentCoulmn = intMatrix.Select(row => row[i]).ToArray();
                long tempColumnResult = LargestProductInSeries.FindLargestProduct(adjacentNumbers, string.Join(separationString, currentCoulmn));



                if (tempRowResult > largestProduct)
                {
                    largestProduct = tempRowResult;
                }
                if (tempColumnResult > largestProduct)
                {
                    largestProduct = tempColumnResult;
                }
            }
            return largestProduct;
        }
    }
}
