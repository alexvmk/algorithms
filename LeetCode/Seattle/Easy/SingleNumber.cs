using System;
using System.Collections.Generic;
using System.Text;
using Seattle.DataStructure;
using Xunit;

namespace Seattle.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/single-number/.
    /// </summary>
    public class SingleNumber
    {
        /// <summary>
        /// Concept:
        ///   - If we take XOR of zero and some bit, it will return that bit
        ///      a⊕0=a
        ///   - If we take XOR of two same bits, it will return 0
        ///      a⊕a=0
        ///   - a⊕b⊕a=(a⊕a)⊕b=0⊕b=b
        /// So we can XOR all bits together to find the unique number.
        /// </summary>
        public int SingleNumberA(int[] nums)
        {
            int r = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                r ^= nums[i];
            }

            return r;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class SingleNumberTests
    {
        public SingleNumberTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test()
        {
            var algorithm = new SingleNumber();
            var r1 = algorithm.SingleNumberA(new int[] { 2, 2, 1 });
            Assert.Equal(1, r1);

            var r2 = algorithm.SingleNumberA(new int[] { 4, 1, 2, 1, 2 });
            Assert.Equal(4, r2);
        }
    }
}
