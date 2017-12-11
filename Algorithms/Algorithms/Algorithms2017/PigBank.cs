using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms.Algorithms2017
{
    public class PigBank
    {
        public void Do()
        {
            var values = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).ToArray();
            var n = values[0];
            var m = values[1];
            var coins = Console.ReadLine().Split(' ').Select(e => Convert.ToInt32(e)).OrderBy(e => e).ToArray();
            var ways = new long[m][];
            for (int i = 0; i < m; i++)
            {
                var coin = coins[i];
                ways[i] = new long[n];
                for (int j = 0; j < n; j++)
                {
                    var additional = j + 1 - coin;
                    if (additional < 0)
                    {
                        continue;
                    }
                    if (additional == 0)
                    {
                        ways[i][j]++;
                        continue;
                    }
                    ways[i][j] += ways[i][additional - 1];
                    for (int k = 0; k < i; k++)
                    {
                        ways[i][j] += ways[k][additional - 1];
                    }
                }
            }

            long sum = 0;
            for (var i = 0; i < m; i++)
            {
                sum += ways[i][n - 1];
            }
            Console.WriteLine(sum);
        }
    }
}
