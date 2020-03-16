using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler
{
    public static class Fibonacci
    {
        public static List<int> GenerateFibonacciNumbers(int upperLimit)
        {
            List<int> returnSequence = new List<int> { 1, 2 };
            int fiboOne = 1;
            int fiboTwo = 2;
            int nextNumber = fiboOne + fiboTwo;

            while(nextNumber < upperLimit)
            {
                returnSequence.Add(nextNumber);
                fiboOne = fiboTwo;
                fiboTwo = nextNumber;
                nextNumber = fiboOne + fiboTwo;
            }

            return returnSequence;
        }

        public static int SumOfEvenFibonacciNumbers(int upperLimit)
        {
            List<int> fibonnaciSequence = GenerateFibonacciNumbers(upperLimit);
            int sum = 0;
            foreach (int fibonnaciNumber in fibonnaciSequence)
            {
                if (fibonnaciNumber % 2 == 0)
                {
                    sum += fibonnaciNumber;
                }
            }
            return sum;
        }
    }
}
