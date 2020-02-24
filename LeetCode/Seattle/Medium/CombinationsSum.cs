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
    /// https://leetcode.com/problems/combination-sum/.
    /// https://leetcode.com/problems/combination-sum/discuss/16502/A-general-approach-to-backtracking-questions-in-Java-(Subsets-Permutations-Combination-Sum-Palindrome-Partitioning)
    /// </summary>
    public class CombinationsSum
    {
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            var result = new List<IList<int>>();
            if (candidates == null || candidates.Length == 0)
            {
                return result;
            }

            candidates.ToList<int>().Sort();
            BackTrack(0, result, candidates, new List<int>(), 0, target);
            return result;
        }

        private void BackTrack(int i, List<IList<int>> result, int[] candidates, List<int> currComb, int currSum, int target)
        {
            // end of the execution stack and add result into output list:
            if (currSum == target)
            {
                result.Add(currComb.ToList());
                return;
            }

            if (currSum > target)
            {
                return;
            }

            for (int j = i; j < candidates.Length; j++)
            {
                currComb.Add(candidates[j]);
                BackTrack(j, result, candidates, currComb, currSum + candidates[j], target);
                currComb.RemoveAt(currComb.Count - 1);
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
            var algorithm = new CombinationsSum();
            var res = algorithm.CombinationSum2(null, 8);
            Assert.Empty(res);

            res = algorithm.CombinationSum2(new int[] { }, 2);
            Assert.Empty(res);

            res = algorithm.CombinationSum2(new int[] { 1 }, 1);
            Assert.Equal(1, res.Count);
            Assert.Equal(1, res[0].Count);
            Assert.Contains(1, res[0]);

            res = algorithm.CombinationSum2(new int[] { 2 }, 1);
            Assert.Empty(res);

            // output: [ [1, 1] ]
            res = algorithm.CombinationSum2(new int[] { 1 }, 2);
            Assert.Equal(1, res.Count);
            Assert.Equal(2, res[0].Count);
            Assert.Equal(1, res[0][0]);
            Assert.Equal(1, res[0][1]);

            // Input: candidates = [2,3,6,7], target = 7,
            // A solution set is:
            // [
            //  [7],
            //  [2,2,3]
            // ]
            res = algorithm.CombinationSum2(new int[] { 2, 3, 6, 7 }, 7);
            Assert.Equal(2, res.Count);

            Assert.Contains(res, x => x.Count == 1);
            Assert.Contains(res, x => x.Count == 3);

            foreach (var r in res)
            {
                if (r.Count == 1)
                {
                    Assert.Equal(1, r.Count);
                    Assert.Contains(7, r);
                }

                if (r.Count == 3)
                {
                    Assert.Equal(3, r.Count);
                    Assert.Contains(2, r);
                    Assert.Contains(2, r);
                    Assert.Contains(3, r);
                }
            }
        }
    }
}
