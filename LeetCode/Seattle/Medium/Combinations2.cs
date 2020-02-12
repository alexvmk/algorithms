// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Seattle.Medium
{
    /// <summary>
    /// Combinations2.
    /// https://leetcode.com/problems/combination-sum-ii/.
    /// </summary>
    public class Combinations2
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {            
            var result = new List<IList<int>>();
            return result;
        }

        private void BackTrack(int i, List<IList<int>> result, List<int> comb, int n, int k)
        {
            // end of the execution stack and add result into output list:
            if (comb.Count() == k)
            {
                result.Add(comb.ToList());
                return;
            }

            for (int j = i; j <= n; j++)
            {
                comb.Add(j);
                BackTrack(j + 1, result, comb, n, k);
                comb.RemoveAt(comb.Count - 1);
            }
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class Combinations2Tests
    {
        public Combinations2Tests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Combine()
        {
            var algorithm = new Combinations();
            var res = algorithm.Combine(0, 0);
            Assert.Empty(res);

            res = algorithm.Combine(1, 0);
            Assert.Empty(res);

            res = algorithm.Combine(0, 1);
            Assert.Empty(res);

            res = algorithm.Combine(1, 2);
            Assert.Empty(res);

            // output: [ [1], [2] ]
            res = algorithm.Combine(2, 1);
            Assert.Equal(2, res.Count);
            Assert.Equal(1, res[0].Count);
            Assert.Contains(1, res[0]);
            Assert.Equal(1, res[1].Count);
            Assert.Contains(2, res[1]);

            // output:
            // Input: n = 4, k = 2
            // Output:
            // [
            //   [1,2],
            //   [1,3],
            //   [1,4],
            //   [2,3],
            //   [2,4],
            //   [3,4],
            // ]
            res = algorithm.Combine(4, 2);
            Assert.Equal(6, res.Count);
            Assert.Equal(2, res[0].Count);
            Assert.Contains(1, res[0]);
            Assert.Contains(2, res[0]);

            Assert.Equal(2, res[1].Count);
            Assert.Contains(1, res[1]);
            Assert.Contains(3, res[1]);

            Assert.Equal(2, res[2].Count);
            Assert.Contains(1, res[2]);
            Assert.Contains(4, res[2]);

            Assert.Equal(2, res[3].Count);
            Assert.Contains(2, res[3]);
            Assert.Contains(3, res[3]);

            Assert.Equal(2, res[4].Count);
            Assert.Contains(2, res[4]);
            Assert.Contains(4, res[4]);

            Assert.Equal(2, res[2].Count);
            Assert.Contains(3, res[5]);
            Assert.Contains(4, res[5]);
        }
    }
}
