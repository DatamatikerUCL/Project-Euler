using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler
{
    public class PythagoreanTriplet
    {
        public static long CalculateTripletWithSum(int sumOfTriplet)
        {
            for (int a = 1; a <= sumOfTriplet / 3; a++)
            {
                for (int b = a + 1; b < sumOfTriplet / 2; b++)
                {
                    int c = sumOfTriplet - a - b;
                    if (a*a + b*b == c*c)
                    {
                        return a * b * c;
                    }
                }
            }

            throw new Exception();
        }
    }
}
