using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler
{
    public class SmallestMultiple
    {
        public static int CalculateSmallestMultiple(int lowerBoundary, int upperBoundary)
        {
            List<int> numbers = new List<int>();
            int result = upperBoundary;
            for (int i = lowerBoundary; i <= upperBoundary; i++)
            {
                numbers.Add(i);
            }

            bool isMultiple;
            do
            {
                isMultiple = true;
                result++;
                foreach (int number in numbers)
                {
                    isMultiple = isMultiple && result % number == 0;
                }
            }
            while (!isMultiple);

            return result;
        }
    }
}
