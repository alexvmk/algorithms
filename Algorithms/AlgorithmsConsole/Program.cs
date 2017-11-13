using System;
using System.Collections.Generic;
using Algorithms;

namespace AlgorithmsConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var firstArg = string.Empty;
            if (args != null && args.Length > 0 && int.TryParse(args[0], out var algoritmNum))
            {
                switch (algoritmNum)
                {
                    case 1:
                        RunMaxNearestNumberInArray();
                    break;
                    default:
                        Console.WriteLine("There are no algoritms for this number");
                    break;
                }
            }
            else
            {
                Console.WriteLine("Choose the algoritm you wanna to run (1 - MaxNearestNumberInArray, 2 - MatrixLayerRotation, 3 - PigBank, 4 - QuickSort)!");
            }

            Console.WriteLine("Press the key to end!");
            Console.ReadKey();
        }

        private static void RunMaxNearestNumberInArray()
        {
            Console.WriteLine("You chose MaxNearestNumberInArray algoritm");
            var algoritm = new MaxNearestNumberInArray();
            var inputArray = new List<int> {1, 5, 6, 8, 7, 9, 1, 9, 4, 5, 3};
            var result = algoritm.CalcSecondMaxNumber(inputArray);

            Console.WriteLine($"The result of the algoritm execution is {result}");
        }
    }
}
