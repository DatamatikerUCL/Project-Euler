using System;

namespace Project_Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of multiples:");
            Console.WriteLine(Multiples.SumOfMultiples(new System.Collections.Generic.List<int> { 3, 5 }, 0, 1000));

            Console.WriteLine("Even Fibonnaci numbers:");
            Console.WriteLine(Fibonacci.SumOfEvenFibonacciNumbers(4000000));

            Console.WriteLine("Largest prime factor:");
            Console.WriteLine(PrimeFactorization.Factorize(600851475143)[^1]);

            Console.WriteLine("Larges palindrome product:");
            Console.WriteLine(PalindromeProduct.LargestPalindromeProduct(3));

            Console.WriteLine("Smallest multiple:");
            Console.WriteLine(SmallestMultiple.CalculateSmallestMultiple(1, 20));
        }
    }
}
