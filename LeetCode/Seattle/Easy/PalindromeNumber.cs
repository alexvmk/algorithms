// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle.Easy
{
    /// <summary
    /// Palindrome Number.
    /// https://leetcode.com/problems/palindrome-number/
    /// </summary>
    public class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            if (x < 10 && x >= 0)
                return true;
            if (x < 0 || x % 10 == 0)
                return false;

            int revertedNumber = 0;
            while (x > revertedNumber)
            {
                revertedNumber = (revertedNumber * 10) + (x % 10);
                x /= 10;
            }

            return x == revertedNumber || x == revertedNumber / 10;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class PalindromeNumberTests
    {
        public PalindromeNumberTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void IsPalindrome()
        {
            var alg = new PalindromeNumber();
            Assert.True(alg.IsPalindrome(121));
            Assert.False(alg.IsPalindrome(-121));
            Assert.False(alg.IsPalindrome(10));
            Assert.True(alg.IsPalindrome(12321));
            Assert.True(alg.IsPalindrome(123321));
        }
    }
}
