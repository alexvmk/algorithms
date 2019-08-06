using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //----------------PalindromeNumber
            var sln = new PalindromeNumber.PalindromeNumberSolution();
            Console.WriteLine(sln.IsPalindrome(12312));

            //----------------4SumII
            int[] A = new int[] { 1, 2 };
            int[] B = new int[] { -2, 1 };
            int[] C = new int[] { -1, 2 };
            int[] D = new int[] { 0, 2 };
            var sum4Sln = new _4SumIISolution();
            Console.WriteLine(sum4Sln.FourSumCount(A, B, C, D));
        }
    }
}
