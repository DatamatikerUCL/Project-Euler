using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_Euler
{
    public class SumSquareDifference
    {
        public static int CalculateSumOfSquares(List<int> numbersToSum)
        {
            return numbersToSum.Sum(i => i*i);
        }

        public static int CalculateSquareOfSums(List<int> numbersToSum)
        {
            int sum = numbersToSum.Sum(i => i);
   
            return sum * sum;
        }

        public static int CalculateSumSquareDifference(int lowerBoundary, int upperBoundary)
        {

            List<int> numbers = new List<int>();
            for (int i = lowerBoundary; i <= upperBoundary; i++)
            {
                numbers.Add(i);
            }

            return CalculateSquareOfSums(numbers) - CalculateSumOfSquares(numbers);
        }
    }
}
