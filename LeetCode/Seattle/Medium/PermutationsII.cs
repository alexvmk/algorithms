// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Seattle.Medium
{
    /// <summary>
    /// Permutations II.
    /// https://leetcode.com/problems/permutations-ii/.
    /// Given a collection of numbers that might contain duplicates, return all possible unique permutations.
    /// </summary>
    public class PermutationsII
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            var list = new List<IList<int>>();
            if (nums == null || nums.Length == 0)
                return list;

            Array.Sort(nums);
            BackTrack(list, new List<int>(), nums, new bool[nums.Length]);
            return list;
        }

        private void BackTrack(IList<IList<int>> list, IList<int> subset, int[] nums, bool[] used)
        {
            if (subset.Count == nums.Length)
            {
                list.Add(new List<int>(subset));
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (used[i] || (i > 0 && nums[i] == nums[i - 1] && !used[i - 1])) continue;
                    used[i] = true;
                    subset.Add(nums[i]);
                    BackTrack(list, subset, nums, used);
                    used[i] = false;
                    subset.RemoveAt(subset.Count - 1);
                }
            }
        }

        #region PermutationII with int array
        public IList<string> PermuteUniqueStr(string str)
        {
            var list = new List<IList<char>>();
            if (str == null || str.Length == 0)
                return new List<string>();

            var charsArr = string.Concat(str.OrderBy(x => x)).ToCharArray();

            BackTrackStr(list, new List<char>(), charsArr, new bool[charsArr.Length]);
            return list.Select(x => new string(x.ToArray())).ToList();
        }

        private void BackTrackStr(IList<IList<char>> list, IList<char> subset, char[] chars, bool[] used)
        {
            if (subset.Count == chars.Length)
            {
                list.Add(new List<char>(subset));
            }
            else
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (used[i] || (i > 0 && chars[i] == chars[i - 1] && !used[i - 1])) continue;
                    used[i] = true;
                    subset.Add(chars[i]);
                    BackTrackStr(list, subset, chars, used);
                    used[i] = false;
                    subset.RemoveAt(subset.Count - 1);
                }
            }
        }
        #endregion region
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class PermutationsIITests
    {
        public PermutationsIITests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void PermuteUnique()
        {
            var algorithm = new PermutationsII();

            var res = algorithm.PermuteUnique(null);
            Assert.Empty(res);

            res = algorithm.PermuteUnique(new int[] { });
            Assert.Empty(res);

            // Input: [1,1,2]
            // Output:
            // [
            //  [1,1,2],
            //  [1,2,1],
            //  [2,1,1]
            // ]
            res = algorithm.PermuteUnique(new int[] { 1, 1, 2 });

            Assert.Equal(3, res.Count);
            Assert.True(res.All(x => x.Count == 3));
            Assert.Equal(res[0], new List<int> { 1, 1, 2 });
            Assert.Equal(res[1], new List<int> { 1, 2, 1 });
            Assert.Equal(res[2], new List<int> { 2, 1, 1 });
        }
    }
}
