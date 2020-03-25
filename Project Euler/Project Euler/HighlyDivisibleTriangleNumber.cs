using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace Project_Euler
{
    public class HighlyDivisibleTriangleNumber
    {
        public static long CalculateTriangleNumber(int triangleNumber)
        {
            long result = 1;

            for (int i = 2; i <= triangleNumber; i++)
            {
                result += i;
            }

            return result;
        }

        public static int CalculateNumberOfDivisibles(int triangle)
        {
            List<int> primeFactors = PrimeFactorization.Factorize(triangle);

            return 2;
        }
    }
}
