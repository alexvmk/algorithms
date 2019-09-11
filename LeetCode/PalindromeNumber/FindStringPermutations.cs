using System;
using System.Collections.Generic;

namespace FindStringPermutations
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var inputStr = Console.ReadLine();

        //    if (string.IsNullOrEmpty(inputStr))
        //        Console.Write("empty input");

        //    var outputList = GetPermutations(inputStr);
        //    Console.Write("all possible permutations: ");
        //    outputList.ForEach(x => Console.Write(x + " "));

        //    Console.ReadKey();
        //}

        private static List<string> GetPermutations(string inputStr)
        {
            var permutations = new List<string>();

            if (inputStr.Length == 0)
            {
                return permutations;
            }

            if (inputStr.Length == 1) // here I missed to check for the single remaining element
            {
                permutations.Add(inputStr[0].ToString());
                return permutations;
            }

            var first = inputStr[0];

            var reminder = inputStr.Substring(1);
            var words = GetPermutations(reminder); // run GetPermutations function recursively for reminder 
            foreach (var word in words)
            {
                for (var i = 0; i <= word.Length; i++)
                {
                    var s = InsertCharAt(word, first, i);
                    permutations.Add(s);
                }
            }
            return permutations;
        }

        private static string InsertCharAt(string word, char c, int i)
        {
            var start = word.Substring(0, i);
            var end = word.Substring(i);
            return start + c + end;
        }
    }
}
