using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Seattle.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/plus-one/solution/
    /// </summary>
    public class OnePlus
    {
        public int[] PlusOne(int[] digits)
        {
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                else
                {
                    digits[i] = 0;
                }
            }

            var res = new int[digits.Length + 1];
            res[0] = 1;
            return res;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class OnePlusTests
    {
        public OnePlusTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test()
        {
            // Arrange
            var algorithm = new OnePlus();
            var inputArr = new int[] { 1, 2, 3 };

            // Act
            // Input: [1,2,3]
            // Output: [1, 2, 4]
            var res = algorithm.PlusOne(inputArr);

            // Assert
            Assert.Equal(res, new int[] { 1, 2, 4 });
        }
    }
}
