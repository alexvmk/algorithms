// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle.Easy.BestTimeToBuyAndSellStock
{
    /// <summary>
    /// Generate Parentheses.
    /// https://leetcode.com/problems/generate-parentheses/ .
    /// </summary>
    public class GenereateParentheses
    {
        public List<string> Generate(int pairsNumb)
        {
            if (pairsNumb <= 0)
            {
                return new List<string>();
            }

            if (pairsNumb == 1)
            {
                return new List<string>() { "()"};
            }

            var resList = new List<string>();
            BackTrack(resList, string.Empty, 0, 0, pairsNumb);
            return resList;
        }

        private void BackTrack(List<string> resList, string curStr, int open, int close, int pairsNumb)
        {
            if (curStr.Length == pairsNumb * 2)
            {
                resList.Add(curStr);
                return;
            }

            if (open < pairsNumb)
            {
                BackTrack(resList, curStr + "(", open + 1, close, pairsNumb);
            }

            if (close < open)
            {
                BackTrack(resList, curStr + ")", open, close + 1, pairsNumb);
            }
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class GenereateParenthesesTests
    {
        public GenereateParenthesesTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Theory]
        [InlineData(3)]
        public void Generate(int n)
        {
            var algorithm = new GenereateParentheses();

            var res = algorithm.Generate(0);
            Assert.Empty(res);

            res = algorithm.Generate(1);
            Assert.Single(res);
            Assert.Equal("()", res[0], StringComparer.CurrentCulture);

            res = algorithm.Generate(2);
            Assert.Equal(2, res.Count);
            Assert.Contains("()()", res, StringComparer.CurrentCulture);
            Assert.Contains("(())", res, StringComparer.CurrentCulture);

            res = algorithm.Generate(3);
            Assert.Equal(5, res.Count);
            Assert.Contains("((()))", res, StringComparer.CurrentCulture);
            Assert.Contains("(()())", res, StringComparer.CurrentCulture);
            Assert.Contains("(())()", res, StringComparer.CurrentCulture);
            Assert.Contains("()(())", res, StringComparer.CurrentCulture);
            Assert.Contains("()()()", res, StringComparer.CurrentCulture);
        }
    }
}
