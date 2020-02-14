// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle.Medium
{
    /// <summary>
    /// Coin Change.
    /// https://leetcode.com/problems/coin-change/
    /// You are given coins of different denominations and a total amount of money amount.
    /// Write a function to compute the fewest number of coins that you need to make up that amount.
    /// If that amount of money cannot be made up by any combination of the coins, return -1.
    /// </summary>
    public class CoinChangeProblem
    {
        public int CoinChange(int[] coins, int amount)
        {
            int max = amount + 1;
            var dp = new int[max];
            for (int i = 0; i < dp.Length; i++)
            {
                dp[i] = max;
            }

            dp[0] = 0;
            for (int i = 1; i <= amount; i++)
            {
                for (int j = 0; j < coins.Length; j++)
                {
                    if (i >= coins[j])
                    {
                        dp[i] = Math.Min(dp[i], dp[i - coins[j]] + 1);
                    }
                }
            }

            return dp[amount] > amount ? -1 : dp[amount];
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class CoinChangeTests
    {
        public CoinChangeTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void CoinChangeProblem()
        {
            var algorithm = new CoinChangeProblem();
            var res = algorithm.CoinChange(new[] { 2 }, 3);
            Assert.Equal(res, -1);

            res = algorithm.CoinChange(new[] { 1, 2, 3 }, 5);
            // 2 + 3
            Assert.Equal(2, res);

            res = algorithm.CoinChange(new[] { 1, 2, 5 }, 11);
            // 5 + 5 + 1
            Assert.Equal(3, res);

            res = algorithm.CoinChange(new[] { 1, 2, 5 }, 11);
            // 5 + 5 + 1
            Assert.Equal(3, res);
        }
    }
}
