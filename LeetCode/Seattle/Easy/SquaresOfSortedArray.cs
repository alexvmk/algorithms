using System;
using System.Collections.Generic;
using System.Text;
using Seattle.DataStructure;
using Xunit;

namespace Seattle.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/squares-of-a-sorted-array/ .
    /// </summary>
    public class SquaresOfSortedArray
    {
        public int[] SortedSquares(int[] a)
        {
            var res = new int[a.Length];
            var i = a.Length - 1;
            var l = 0;
            var r = a.Length - 1;

            while (l < r)
            {
                var lsq = a[l] * a[l];
                var rsq = a[r] * a[r];

                if (lsq > rsq)
                {
                    res[i] = lsq;
                    l++;
                }
                else
                {
                    res[i] = rsq;
                    r--;
                }

                i--;
            }

            res[i] = a[l] * a[l];
            return res;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class SquaresOfSortedArrayTests
    {
        public SquaresOfSortedArrayTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test()
        {
            var algorithm = new SquaresOfSortedArray();
            var r1 = algorithm.SortedSquares(new int[] { -4, -1, 0, 3, 10 });
            Assert.Equal(r1, new int[] { 0, 1, 9, 16, 100 });

            var r2 = algorithm.SortedSquares(new int[] { -7, -3, 2, 3, 11 });
            Assert.Equal(r2, new int[] { 4, 9, 9, 49, 121 });
        }
    }
}
