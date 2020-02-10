// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle.Medium
{
    /// <summary>
    /// Combinations.
    /// https://leetcode.com/problems/combinations/ .
    /// </summary>
    public class Combinations
    {
        public IList<IList<int>> Combine(int n, int k)
        {
            var result = new List<IList<int>>();
            return result;
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
    public class CombinationsTests
        {
        public CombinationsTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Theory]
        [InlineData(4, 2)]
        public void Combine(int n, int k)
        {
            var algorithm = new Combinations();
        }
    }
}
