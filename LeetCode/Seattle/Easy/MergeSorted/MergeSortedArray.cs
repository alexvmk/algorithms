// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle.Easy.BestTimeToBuyAndSellStock
{
    /// <summary>
    /// https://leetcode.com/problems/merge-sorted-array/ .
    /// </summary>
    public class MergeSortedArray
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            var p1 = m - 1;
            var p2 = n - 1;
            var p = n + m - 1;

            while (p1 >= 0 && p2 >= 0)
            {
                nums1[p--] = nums1[p1] > nums2[p2] ? nums1[p1--] : nums2[p2--];
            }

            Array.Copy(nums2, 0, nums1, 0, p2 + 1);
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class MergeSortedArrayTests
    {
        public MergeSortedArrayTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Merge()
        {
            var algorithm = new MergeSortedArray();
            var nums1 = new int[] { 1, 2, 3, 0, 0, 0 };
            algorithm.Merge(nums1, 3, new int[] { 2, 5, 6 }, 3);

            Assert.Equal(nums1, new int[] { 1, 2, 2, 3, 5, 6 });
        }
    }
}
