// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle.Easy
{
    /// <summary
    /// https://leetcode.com/problems/factorial-trailing-zeroes/
    /// </summary>
    public class FactorialTrailingZeroes
    {
        public int TrailingZeroes(int n)
        {
            int zeroCount = 0;
            while (n > 0)
            {
                n /= 5;
                zeroCount += n;
            }

            return zeroCount;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class FactorialTrailingZeroesTests
    {
        public FactorialTrailingZeroesTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test()
        {
            var alg = new FactorialTrailingZeroes();

            Assert.Equal(0, alg.TrailingZeroes(3));
            Assert.Equal(1, alg.TrailingZeroes(5));
        }
    }
}
