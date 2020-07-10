// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle.Easy.BestTimeToBuyAndSellStock
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-ii/.
    /// All such tasks: https://medium.com/algorithms-and-leetcode/best-time-to-buy-sell-stocks-on-leetcode-the-ultimate-guide-ce420259b323
    /// </summary>
    public class BestTimeToBuyAndSellStockII
    {
        public int MaxProfit(int[] prices)
        {
            var maxprofit = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    maxprofit += prices[i] - prices[i - 1];
            }

            return maxprofit;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class BestTimeToBuyAndSellStockIITests
    {
        public BestTimeToBuyAndSellStockIITests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void BestTimeToBuyAndSellStockII()
        {
            var algorithm = new BestTimeToBuyAndSellStockII();

            var prices = new int[] { 7, 1, 5, 3, 6, 4 };
            Assert.Equal(7, algorithm.MaxProfit(prices));

            prices = new int[] { 1, 2, 3, 4, 5 };
            Assert.Equal(4, algorithm.MaxProfit(prices));

            prices = new int[] { 7, 6, 4, 3, 1 };
            Assert.Equal(0, algorithm.MaxProfit(prices));
        }
    }
}
