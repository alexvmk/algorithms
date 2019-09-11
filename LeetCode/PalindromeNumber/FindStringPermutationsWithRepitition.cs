using System;
using System.Collections.Generic;
using System.Linq;

namespace FindStringPermutationsWithRepitition
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    var inputStr = Console.ReadLine();

        //    if (string.IsNullOrEmpty(inputStr))
        //        Console.WriteLine("empty input");

        //    var outputList = GeneratePermutationsWithRepitition(inputStr);
        //    Console.Write("all possible permutations: ");
        //    outputList.ToList().ForEach(x => Console.Write(x + " "));

        //    Console.ReadKey();
        //}

        public static IEnumerable<string> GeneratePermutationsWithRepitition(string arg)
        {
            var counts = arg.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count()); // calculate counts of characters
            var chars = counts.Keys.ToList(); // get unique characters
            return GenPermWithRepInternal(); // start recursion

            IEnumerable<string> GenPermWithRepInternal() // local method, has access to all variables above =)
            {
                if (chars.All(x => counts[x] == 0)) yield return string.Empty; // exit if no characters left

                foreach (var x in chars.Where(x => counts[x] > 0)) // for all remaining characters
                {                                                 // (cycle will not run, if no characters remain)
                    counts[x]--; // pick char 'x' and decrease its remaining count
                    foreach (var r in GenPermWithRepInternal()) // build remaining results
                        yield return x + r; // return that picked 'x' plus all following results
                    counts[x]++; // put that 'x' character back for future use
                }
            }
        }
    }
}
