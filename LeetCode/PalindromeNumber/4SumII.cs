using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    /// <summary>
    /// https://leetcode.com/problems/4sum-ii/submissions/
    /// </summary>
    public class _4SumIISolution
    {
        public int FourSumCount(int[] A, int[] B, int[] C, int[] D)
        {
            var dict = new Dictionary<int, int>();
            var res = 0;

            for (int a = 0; a < A.Length; a++)
                for (int b = 0; b < B.Length; b++)
                {
                    if (dict.ContainsKey(A[a] + B[b]))
                        ++dict[A[a] + B[b]];
                    else
                        dict.Add(A[a] + B[b], 1);
                }


            for (int c = 0; c < C.Length; c++)
                for (int d = 0; d < D.Length; d++)
                {
                    if (dict.ContainsKey(-(C[c] + D[d])))
                        res = res + dict[-(C[c] + D[d])];
                }

            return res;
        }
    }
}
