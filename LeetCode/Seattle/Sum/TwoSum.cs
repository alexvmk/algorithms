// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle
{
    /// <summary
    /// Given an array of integers, return indices of the two numbers such that they add up to a specific target.
    /// You may assume that each input would have exactly one solution, and you may not use the same element twice.
    /// https://leetcode.com/problems/two-sum/
    /// Complexity Analysis:
    /// Time complexity : O(n)O(n). We traverse the list containing nn elements only once.Each look up in the table costs only O(1)O(1) time.
    /// Space complexity : O(n)O(n). The extra space required depends on the number of items stored in the hash table, which stores at most nn elements.
    /// </summary>
    public class TwoSum
    {
        public int[] CalcTwoSum(int[] nums, int target)
        {
            // this is a hash table where the key means how many numbers do not enough to target
            // value = index
            var notEnoughValuesDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (notEnoughValuesDict.ContainsKey(nums[i]))
                {
                    return new int[] { notEnoughValuesDict[nums[i]], i };
                }
                else
                {
                    if (!notEnoughValuesDict.ContainsKey(target - nums[i]))
                        notEnoughValuesDict.Add(target - nums[i], i);
                }

            }

            return null;
        }

        [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
        public class PalindromeNumberTests
        {
            public PalindromeNumberTests(SeattleTestsFixture seattleTestsFixture)
            {
            }

            [Fact]
            public void TwoSum()
            {
                // Given nums = [2, 7, 11, 15], target = 9,
                // Because nums[0] +nums[1] = 2 + 7 = 9,
                // return [0, 1].

                var alg = new TwoSum();

                var res = alg.CalcTwoSum(new int[] { 2,7,11,15}, 9);
                Assert.Equal(2, res.Length);
                Assert.Equal(0, res[0]);
                Assert.Equal(1, res[1]);
            }
        }
    }
}
