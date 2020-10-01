using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Text;
using Seattle.DataStructure;
using Xunit;

namespace Seattle.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/add-binary/.
    /// </summary>
    public class AddBinary
    {
        public string Run(string a, string b)
        {
            long x = Convert.ToInt64(a, 2);
            long y = Convert.ToInt64(b, 2);

            long zero = 0;
            long answer, carry;

            while (y.CompareTo(zero) != 0)
            {
                answer = x ^ y;
                carry = (x & y) << 1;
                x = answer;
                y = carry;
            }

            return Convert.ToString(x, 2);
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class AddBinaryTests
    {
        public AddBinaryTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test()
        {
            var algorithm = new AddBinary();
            var r1 = algorithm.Run("11", "1");
            Assert.Equal("100", r1);

            var r2 = algorithm.Run("1010", "1011");
            Assert.Equal("10101", r2);
        }
    }
}
