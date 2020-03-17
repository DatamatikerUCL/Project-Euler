using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler
{
    public class PrimeCalculator
    {
        public static int CalculatePrime(int primeToCalculate)
        {
            int primesCalculated = 1;
            int currentPrime = 2;
            int currentNumber = 3;

            while (primesCalculated < primeToCalculate)
            {
                if (IsPrime(currentNumber))
                {
                    currentPrime = currentNumber;
                    primesCalculated++;
                }

                currentNumber++;
            }

            return currentPrime;
        }

        public static bool IsPrime(int prime)
        {
            bool isPrime = true;
            int i = 2;

            while (isPrime && i < prime)
            {

                if (prime % i == 0)
                {
                    isPrime = false;
                }

                i++;

            }

            return isPrime;

        }
    }
}
