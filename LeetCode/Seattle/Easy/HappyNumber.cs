using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/happy-number/
    /// </summary>
    public class HappyNumber
    {
        public bool IsHappy(int n)
        {
            var slow = n;
            var fast = n;
            do
            {
                slow = digitSquare(slow);
                fast = digitSquare(fast);
                fast = digitSquare(fast);

                if (fast == 1) return true;
            }
            while (slow != fast);

            return false;
        }

        private int digitSquare(int n)
        {
            var tmp = 0;
            var sum = 0;
            while (n != 0)
            {
                tmp = n % 10;
                sum += tmp * tmp;
                n = n / 10;
            }

            return sum;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class HappyNumberTests
    {
        public HappyNumberTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test()
        {
            var algorithm = new HappyNumber();

            var res = algorithm.IsHappy(19);

            // Input: 19
            // Output: true
            // Explanation:
            //            12 + 92 = 82
            // 82 + 22 = 68
            // 62 + 82 = 100
            // 12 + 02 + 02 = 1

            Assert.True(res);
        }
    }
}
