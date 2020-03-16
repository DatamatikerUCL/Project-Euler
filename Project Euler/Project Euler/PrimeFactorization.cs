using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler
{
    public class PrimeFactorization
    {
        public static List<int> Factorize(long numberToFactorize)
        {
            int p = 2;
            List<int> primeFactors = new List<int>();

            while(numberToFactorize >= p * p)
            {
                if (numberToFactorize % p == 0)
                {
                    primeFactors.Add(p);
                    numberToFactorize /= p;
                }
                else
                {
                    p++;
                }
            }

            primeFactors.Add((int) numberToFactorize);
            return primeFactors;
        }
    }
}
