// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle.Easy.BestTimeToBuyAndSellStock
{
    /// <summary>
    /// https://leetcode.com/problems/best-time-to-buy-and-sell-stock-iii/
    /// All such tasks: https://medium.com/algorithms-and-leetcode/best-time-to-buy-sell-stocks-on-leetcode-the-ultimate-guide-ce420259b323
    /// </summary>
    public class BestTimeToBuyAndSellStockIII
    {
        public int MaxProfit(int[] prices)
        {
            int t1Cost = int.MaxValue;
            int t2Cost = int.MaxValue;
            int t1Profit = 0,
                t2Profit = 0;

            foreach (int price in prices)
            {
                // the maximum profit if only one transaction is allowed
                t1Cost = Math.Min(t1Cost, price);
                t1Profit = Math.Max(t1Profit, price - t1Cost);
                // reinvest the gained profit in the second transaction
                t2Cost = Math.Min(t2Cost, price - t1Profit);
                t2Profit = Math.Max(t2Profit, price - t2Cost);
            }

            return t2Profit;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class BestTimeToBuyAndSellStockIIITests
    {
        public BestTimeToBuyAndSellStockIIITests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void BestTimeToBuyAndSellStockIII()
        {
            var algorithm = new BestTimeToBuyAndSellStockIII();

            var prices = new int[] { 3, 3, 5, 0, 0, 3, 1, 4 };
            Assert.Equal(6, algorithm.MaxProfit(prices));

            prices = new int[] { 1, 2, 3, 4, 5 };
            Assert.Equal(4, algorithm.MaxProfit(prices));

            prices = new int[] { 7, 6, 4, 3, 1 };
            Assert.Equal(0, algorithm.MaxProfit(prices));
        }
    }
}
