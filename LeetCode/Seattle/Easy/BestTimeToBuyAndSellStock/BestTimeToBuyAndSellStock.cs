// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle.Easy.BestTimeToBuyAndSellStock
{
    /// <summary>
    /// Best Time to Buy and Sell Stock.
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock/.
    /// All such tasks: https://medium.com/algorithms-and-leetcode/best-time-to-buy-sell-stocks-on-leetcode-the-ultimate-guide-ce420259b323
    /// </summary>
    public class BestTimeToBuyAndSellStock
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length < 2)
            {
                return 0;
            }

            var maxProfit = 0;
            var minProfit = prices[0];

            foreach (int p in prices)
            {
                maxProfit = Math.Max(maxProfit, p - minProfit);
                minProfit = Math.Min(minProfit, p);
            }

            return maxProfit;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class BestTimeToBuyAndSellStockTests
    {
        public BestTimeToBuyAndSellStockTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void BestTimeToBuyAndSellStock()
        {
            var algorithm = new BestTimeToBuyAndSellStock();

            var prices = new int[] { 7, 1, 5, 3, 6, 4 };
            Assert.Equal(5, algorithm.MaxProfit(prices));

            prices = new int[] { 7, 6, 4, 3, 1 };
            Assert.Equal(0, algorithm.MaxProfit(prices));
        }
    }
}
