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
                long tempRowResult = LargestProductInSeries.FindLargestProduct(adjacentNumbers, intMatrix[i]);

                int[] currentCoulmn = intMatrix.Select(row => row[i]).ToArray();
                long tempColumnResult = LargestProductInSeries.FindLargestProduct(adjacentNumbers, currentCoulmn);


                largestProduct = Math.Max(Math.Max(tempColumnResult, tempRowResult), largestProduct);
            }

            long largestDiagonal = CalculateLargestDiagonal(intMatrix, adjacentNumbers);

            return largestProduct;
        }

        private static long CalculateLargestDiagonal(int[][] intMatrix, int adjacentNumbers)
        {
            int[] diagonal = new int[intMatrix[0].Length];

            for (int i = 0; i < intMatrix[0].Length; i++)
            {
                diagonal[i] = intMatrix[i][i];
            }

            long largestProduct = LargestProductInSeries.FindLargestProduct(adjacentNumbers, diagonal);

            for (int i = 1; i < intMatrix[0].Length - adjacentNumbers; i++)
            {
                for (int j = 0; j < intMatrix[0].Length - i; j++)
                {
                    diagonal[j] = intMatrix[i][j];

                }
            }

            return largestProduct;
        }
    }
}
