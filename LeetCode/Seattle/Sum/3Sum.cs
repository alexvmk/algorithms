// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Seattle
{
    /// <summary
    /// Given an array nums of n integers, are there elements a, b, c in nums such that a + b + c = 0?
    /// Find all unique triplets in the array which gives the sum of zero.
    /// Note:
    /// The solution set must not contain duplicate triplets.
    /// https://leetcode.com/problems/3sum/
    /// </summary>
    public class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var res = new List<IList<int>>();
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                if (nums[i] > 0) break;
                if (i > 0 && nums[i - 1] == nums[i]) continue;

                var l = i + 1;
                var r = nums.Length - 1;

                while (l < r)
                {
                    var total = nums[i] + nums[l] + nums[r];
                    if (total < 0)
                    {
                        l++;
                    }
                    else if (total > 0)
                    {
                        r--;
                    }
                    else
                    {
                        res.Add(new List<int>() { nums[i], nums[l], nums[r] });

                        while (l < r && nums[l] == nums[l+1])
                            l++;
                        while (l < r && nums[r] == nums[r-1])
                            r--;
                        l++;
                        r--;
                    }
                }
            }

            return res;
        }

        [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
        public class _3SumTests
        {
            public _3SumTests(SeattleTestsFixture seattleTestsFixture)
            {
            }

            [Fact]
            public void ThreeSum()
            {
                // Given array nums = [-1, 0, 1, 2, -1, -4],
                // A solution set is:
                // [
                //  [-1, 0, 1],
                //  [-1, -1, 2]
                // ]

                var alg = new _3Sum();

                var res = alg.ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 });
                Assert.Equal(2, res.Count);

                res.Contains(new List<int> { -1, 0, 1 });
                res.Contains(new List<int> { -1, -1, 2 });
            }
        }
    }
}
