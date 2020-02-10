// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle.Medium
{
    /// <summary>
    /// Generate Parentheses.
    /// https://leetcode.com/problems/generate-parentheses/ .
    /// </summary>
    public class GenereateParentheses
    {
        public IList<string> GenerateParenthesis(int n)
        {
            // corner cases:
            if (n <= 0)
            {
                return new List<string>();
            }

            if (n == 1)
            {
                return new List<string>() { "()"};
            }

            // preparing the result list:
            var resList = new List<string>();
            // start the backtrack process:
            BackTrack(resList, string.Empty, 0, 0, n);
            return resList;
        }

        private void BackTrack(List<string> resList, string curStr, int open, int close, int pairsNumb)
        {
            // end of the execution stack and add result into output list:
            if (curStr.Length == pairsNumb * 2)
            {
                resList.Add(curStr);
                return;
            }

            // check the number of open parentheses that it no more then their max count:
            if (open < pairsNumb)
            {
                // backtrack it with "("
                BackTrack(resList, curStr + "(", open + 1, close, pairsNumb);
            }

            // check the number of close parentheses that it no more then open count:
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

            var res = algorithm.GenerateParenthesis(0);
            Assert.Empty(res);

            res = algorithm.GenerateParenthesis(1);
            Assert.Single(res);
            Assert.Equal("()", res[0], StringComparer.CurrentCulture);

            res = algorithm.GenerateParenthesis(2);
            Assert.Equal(2, res.Count);
            Assert.Contains("()()", res, StringComparer.CurrentCulture);
            Assert.Contains("(())", res, StringComparer.CurrentCulture);

            res = algorithm.GenerateParenthesis(3);
            Assert.Equal(5, res.Count);
            Assert.Contains("((()))", res, StringComparer.CurrentCulture);
            Assert.Contains("(()())", res, StringComparer.CurrentCulture);
            Assert.Contains("(())()", res, StringComparer.CurrentCulture);
            Assert.Contains("()(())", res, StringComparer.CurrentCulture);
            Assert.Contains("()()()", res, StringComparer.CurrentCulture);
        }
    }
}
