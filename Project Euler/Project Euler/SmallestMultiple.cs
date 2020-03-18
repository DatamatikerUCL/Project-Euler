using System;
using System.Collections.Generic;

namespace Project_Euler
{
    public class SmallestMultiple
    {
        public static int CalculateSmallestMultiple(int lowerBoundary, int upperBoundary)
        {
            List<int> primesInBoundary = PrimeCalculator.CalculatePrimesInSpan(lowerBoundary, upperBoundary + 1);

            int sqrtUpperBoundary = (int) Math.Sqrt(upperBoundary);
            int answer = 1;

            foreach (int prime in primesInBoundary)
            {
                if (prime <= sqrtUpperBoundary)
                {
                    answer *= (int) Math.Pow(prime, (int)(Math.Log(upperBoundary) / Math.Log(prime)));
                }
                else
                    answer *= prime;
            }

            return answer;
        }
    }
}