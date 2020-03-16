using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Euler
{
    public class Multiples
    {
        public static int SumOfMultiples(List<int> multiples, int startNumber, int endNumber)
        {
            int sum = 0;

            for (int i = startNumber; i < endNumber; i++)
            {
                foreach (int number in multiples)
                {
                    if (i%number == 0)
                    {
                        sum += i;
                        break;
                    }
                }
            }

            return sum;
        }
    }
}