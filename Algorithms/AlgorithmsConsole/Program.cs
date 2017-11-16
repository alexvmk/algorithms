using System;
using System.Collections.Generic;
using Algorithms;
using Algorithms.Algorithms2017;

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
                    case 2:
                        RunMatrixLayerRotation();
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

        private static void RunMatrixLayerRotation()
        {
            Console.WriteLine("You chose MatrixLayerRotation algoritm");
            var algoritm = new MatrixLayerRotation();
            const int m = 4;
            const int n= 4;
            const int r = 2;
            var inputArray = new int[m][];
            var num = 0;
            var random = new Random();
            for (int x = 0; x < m; x++)
            {
                inputArray[x] = new int[n];
                for (int y = 0; y < n; y++)
                {
                    inputArray[x][y] = random.Next(0, 9);
                }
            }

            Console.WriteLine($"Input matrix:");
            for (int y = 0; y < inputArray.Length; y++)
            {
                Console.WriteLine();
                for (int x = 0; x < inputArray[y].Length; x++)
                {
                    Console.Write($"[{x},{y}] {inputArray[x][y]}     ");
                }
            }
            var result = algoritm.CalcSecondMaxNumber(m,n,r, inputArray);
            Console.WriteLine();
            Console.WriteLine($"The result of the algoritm execution is:");
            for (int y = 0; y < result.Length; y++)
            {
                Console.WriteLine();
                for (int x = 0; x < result[y].Length; x++)
                {
                    Console.Write($"[{x},{y}] {result[x][y]}     ");
                }
            }
            Console.WriteLine();
        }
    }
}
