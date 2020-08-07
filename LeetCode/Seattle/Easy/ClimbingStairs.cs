// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle.Easy.BestTimeToBuyAndSellStock
{
    /// <summary>
    /// https://leetcode.com/problems/climbing-stairs/
    /// </summary>
    public class ClimbingStairs
    {
        public int ClimbStairs(int n)
        {
            // calc Fibonacci Number:
            if (n == 1)
            {
                return 1;
            }

            int first = 1;
            int second = 2;
            for (int i = 3; i <= n; i++)
            {
                int third = first + second;
                first = second;
                second = third;
            }

            return second;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class ClimbingStairsTests
    {
        public ClimbingStairsTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void ClimbingStairsTest()
        {
            var algorithm = new ClimbingStairs();

            Assert.Equal(2, algorithm.ClimbStairs(2));
            Assert.Equal(3, algorithm.ClimbStairs(3));
        }
    }
}
