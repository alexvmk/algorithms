using System;
using System.Collections.Generic;
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
            return string.Empty;
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
