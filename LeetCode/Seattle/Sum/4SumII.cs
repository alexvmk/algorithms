// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle
{
    /// <summary
    /// Given four lists A, B, C, D of integer values, compute how many tuples (i, j, k, l) there are such that A[i] + B[j] + C[k] + D[l] is zero.
    /// To make problem a bit easier, all A, B, C, D have same length of N where 0 ≤ N ≤ 500.
    /// All integers are in the range of -228 to 228 - 1 and the result is guaranteed to be at most 231 - 1.
    /// https://leetcode.com/problems/4sum-ii/
    /// </summary>
    public class _4SumII
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

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class _4SumIITests
    {
        public _4SumIITests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Calc4SumII()
        {
            // Given array nums = [1, 0, -1, 0, -2, 2], and target = 0.

            // A solution set is:
            // [
            //  [-1,  0, 0, 1],
            //  [-2, -1, 1, 2],
            //  [-2,  0, 0, 2]
            // ]

        }
    }
}
