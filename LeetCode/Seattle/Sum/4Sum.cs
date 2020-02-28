﻿// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle
{
    /// <summary
    /// Given an array nums of n integers and an integer target, are there elements a, b, c, and d in nums such that a + b + c + d = target?
    /// Find all unique quadruplets in the array which gives the sum of target.
    /// Note:
    /// The solution set must not contain duplicate quadruplets.
    /// https://leetcode.com/problems/4sum/
    /// </summary>
    public class _4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {

        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class PalindromeNumberTests
    {
        public PalindromeNumberTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void IsPalindrome()
        {
            // Given array nums = [1, 0, -1, 0, -2, 2], and target = 0.

            // A solution set is:
            // [
            //  [-1,  0, 0, 1],
            //  [-2, -1, 1, 2],
            //  [-2,  0, 0, 2]
            // ]

        }
    }
}
