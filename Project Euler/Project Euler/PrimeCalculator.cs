using System;
using System.Collections.Generic;
using System.Linq;
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
        internal static List<int> CalculatePrimesInSpan(int lowerBoundary, int upperBoundary)
        {
            List<int> primes = new List<int>();

            for (int i = lowerBoundary; i < upperBoundary; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }

            return primes;
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

        public static List<long> SieveOfEratosthenes(long n)
        {
            List<long> primesList = new List<long>();
            bool[] primes = new bool[n + 1];

            for (long i = 0; i < n; i++)
            {
                primes[i] = true;
            }

            for (long j = 2; j <= n; j++)
            {
                if (primes[j] == true)
                {
                    for (long i = j*j; i <= n; i +=j)
                    {
                        primes[i] = false;
                    }
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (primes[i])
                {
                    primesList.Add(i);
                }
            }

            return primesList;
        }

        public static long SummationOfPrimes(long n)
        {
            List<long> primes = SieveOfEratosthenes(n);

            return primes.Sum(i => i);
        }
    }
}
