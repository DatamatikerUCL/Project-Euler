using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Euler
{
    public class LargestProductInGrid
    {
        public static long CalculateLargestProduct(int[][] intMatrix, int numbersInProduct)
        {
            long largestProduct = 0;
            int matrixLength = intMatrix[0].Length;

            for (int col = 0; col < matrixLength; col++)
            {
                for (int row = 0; row < matrixLength; row++)
                {
                    long tempProd;

                    // Check vertically
                    if (row <= matrixLength - numbersInProduct)
                    {
                        tempProd = intMatrix[col][row];
                        for (int i = 1; i < numbersInProduct; i++)
                        {
                            tempProd *= intMatrix[col][row + i];
                        }
                        largestProduct = Math.Max(largestProduct, tempProd);
                    }

                    // Check horisontally
                    if (col <= matrixLength - numbersInProduct)
                    {
                        tempProd = intMatrix[col][row];
                        for (int i = 1; i < numbersInProduct; i++)
                        {
                            tempProd *= intMatrix[col + i][row];
                        }
                        largestProduct = Math.Max(largestProduct, tempProd);
                    }

                    // Check diagonally upwards/forwards
                    if (col <= matrixLength - numbersInProduct && row >= numbersInProduct)
                    {
                        tempProd = intMatrix[col][row];
                        for (int i = 1; i < numbersInProduct; i++)
                        {
                            tempProd *= intMatrix[col + i][row - i];
                        }
                        largestProduct = Math.Max(largestProduct, tempProd);
                    }

                    if (row <= matrixLength - numbersInProduct && col <= matrixLength - numbersInProduct )
                    {
                        tempProd = intMatrix[col][row];
                        for (int i = 1; i < numbersInProduct; i++)
                        {
                            tempProd *= intMatrix[col + i][row + i];
                        }
                        largestProduct = Math.Max(largestProduct, tempProd);
                    }
                }
            }

            return largestProduct;
        }

        private static long CalculateLargestDiagonal(int[][] intMatrix, int adjacentNumbers)
        {
            int matrixSize = intMatrix[0].Length;
            int[] diagonal = new int[matrixSize];
            int[] diagonalAbove = new int[matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                diagonal[i] = intMatrix[i][i];
            }

            long largestProduct = LargestProductInSeries.FindLargestProduct(adjacentNumbers, diagonal);

            for (int i = 1; i <= matrixSize - adjacentNumbers; i++)
            {
                for (int j = 0; j < matrixSize - i; j++)
                {
                    diagonal[j] = intMatrix[i+j][j];
                    diagonalAbove[j] = intMatrix[j][i+j];
                }

                long tempProduct = LargestProductInSeries.FindLargestProduct(adjacentNumbers, diagonal);
                long tempProductTwo = LargestProductInSeries.FindLargestProduct(adjacentNumbers, diagonalAbove);

                largestProduct = Math.Max(Math.Max(tempProduct, tempProductTwo), largestProduct);
            
            }

            return largestProduct;
        }
    }
}
