using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Seattle;
using Seattle.Easy;
using Xunit;

namespace Seattle.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/sqrtx/.
    /// </summary>
    public class Sqrt
    {
        public int MySqrt(int x)
        {
            if (x < 2) return x;

            double x0 = x;
            double x1 = (x0 + x / x0) / 2.0;
            while (Math.Abs(x0 - x1) >= 1)
            {
                x0 = x1;
                x1 = (x0 + x / x0) / 2.0;
            }

            return (int)x1;
        }
    }    

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class SqrtTests
    {
        public SqrtTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test()
        {
            var algorithm = new Sqrt();
            Assert.Equal(2, algorithm.MySqrt(4));

            // Explanation: The square root of 8 is 2.82842..., and since
            // the decimal part is truncated, 2 is returned.
            Assert.Equal(2, algorithm.MySqrt(8));
        }
    }
}
