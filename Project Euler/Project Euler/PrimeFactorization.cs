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

        public static void FactorizeRecursively(int v, ref List<int> primeFactors)
        {
            int i = 2;
            if (v == 1)
            {
                return;
            }

            while (v % i != 0)
            {
                i++;
            }

            primeFactors.Add(i);
            FactorizeRecursively(v / i, ref primeFactors);

        }
    }
}
