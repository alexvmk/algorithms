// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Seattle
{
    /// <summary>
    /// Permutations.
    /// https://leetcode.com/problems/permutations/.
    /// Given a collection of distinct integers, return all possible permutations.
    /// </summary>
    public class Permutations
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var list = new List<IList<int>>();
            if (nums == null || nums.Length == 0)
                return list;

            BackTrack(list, new List<int>(), nums);
            return list;
        }

        private void BackTrack(IList<IList<int>> list, IList<int> subset, int[] chars)
        {
            if (subset.Count == chars.Length)
                list.Add(new List<int>(subset));
            else
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (subset.Contains(chars[i])) continue;
                    subset.Add(chars[i]);
                    BackTrack(list, subset, chars);
                    subset.RemoveAt(subset.Count - 1);
                }
            }
        }

        #region PermutationII with string
        public IList<string> PermuteStr(string chars)
        {
            var list = new List<IList<char>>();
            if (chars == null || chars.Length == 0)
                return new List<string>();

            BackTrack(list, new List<char>(), chars.ToCharArray());
            return list.Select(x => new string(x.ToArray())).ToList();
        }

        private void BackTrack(IList<IList<char>> list, IList<char> subset, char[] chars)
        {
            if (subset.Count == chars.Length)
                list.Add(new List<char>(subset));
            else
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (subset.Contains(chars[i])) continue;
                    subset.Add(chars[i]);
                    BackTrack(list, subset, chars);
                    subset.RemoveAt(subset.Count - 1);
                }
            }
        }
        #endregion
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class PermutationsTests
    {
        public PermutationsTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Permute()
        {
            var algorithm = new Permutations();

            var res = algorithm.Permute(null);
            Assert.Empty(res);

            res = algorithm.Permute(new int[] { });
            Assert.Empty(res);

            // Input: [1,2,3]
            // Output:
            // [
            //  [1,2,3],
            //  [1,3,2],
            //  [2,1,3],
            //  [2,3,1],
            //  [3,1,2],
            //  [3,2,1]
            // ]
            res = algorithm.Permute(new int[] { 1, 2, 3 });

            Assert.Equal(6, res.Count);
            Assert.True(res.All(x => x.Count == 3));
            Assert.Equal(res[0], new List<int> { 1, 2, 3 });
            Assert.Equal(res[1], new List<int> { 1, 3, 2 });
            Assert.Equal(res[2], new List<int> { 2, 1, 3 });
            Assert.Equal(res[3], new List<int> { 2, 3, 1 });
            Assert.Equal(res[4], new List<int> { 3, 1, 2 });
            Assert.Equal(res[5], new List<int> { 3, 2, 1 });
        }
    }
}
