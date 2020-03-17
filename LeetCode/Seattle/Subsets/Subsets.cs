// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Seattle
{
    /// <summary>
    /// Subsets.
    /// https://leetcode.com/problems/subsets/
    /// Given a set of distinct integers, nums, return all possible subsets (the power set).
    /// Note: The solution set must not contain duplicate subsets.
    /// </summary>
    public class Subsets
    {
        public IList<IList<int>> CalcSubsets(int[] nums)
        {
            var list = new List<IList<int>>();
            if (nums == null || nums.Length == 0)
                return list;

            Backtrack(list, new List<int>(), nums, 0);
            return list;
        }

        private void Backtrack(List<IList<int>> list, List<int> tempList, int[] nums, int start)
        {
            list.Add(new List<int>(tempList));
            for (int i = start; i < nums.Length; i++)
            {
                tempList.Add(nums[i]);
                Backtrack(list, tempList, nums, i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class SubsetsTests
    {
        public SubsetsTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void CalcSubsets()
        {
            var algorithm = new Subsets();

            var res = algorithm.CalcSubsets(null);
            Assert.Empty(res);

            res = algorithm.CalcSubsets(new int[] { });
            Assert.Empty(res);

            // Input: nums = [1,2,3]
            // Output:
            // [
            //  [3],
            //  [1],
            //  [2],
            //  [1,2,3],
            //  [1,3],
            //  [2,3],
            //  [1,2],
            //  []
            res = algorithm.CalcSubsets(new int[] { 1, 2, 3 });

            Assert.Equal(8, res.Count);
            res.Contains(new List<int> { 3 });
            res.Contains(new List<int> { 1 });
            res.Contains(new List<int> { 2 });
            res.Contains(new List<int> { 1, 2, 3 });
            res.Contains(new List<int> { 1, 3 });
            res.Contains(new List<int> { 2, 3 });
            res.Contains(new List<int> { 1, 2 });
            res.Contains(new List<int> { });
        }
    }
}
