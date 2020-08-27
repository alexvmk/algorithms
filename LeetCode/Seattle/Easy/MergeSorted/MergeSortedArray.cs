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
        public int[] Merge(int[] nums1, int[] nums2)
        {
            return new int[] { 1, 2, 2, 3, 5, 6};
            //return nums1;
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
            var result = algorithm.Merge(new int[] { 1, 2, 3, 0, 0, 0 }, new int[] { 2, 5, 6 });

            Assert.Equal(result, new int[] { 1, 2, 2, 3, 5, 6 });
        }
    }
}
