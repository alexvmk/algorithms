// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Seattle.Easy
{
    /// <summary
    /// Valid Palindrome.
    /// https://leetcode.com/problems/valid-palindrome/
    /// </summary>
    public class ValidPalindrome
    {
        public bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s) || s.Length == 1)
            {
                return true;
            }

            int leftPointer = 0;
            int rigthPointer = s.Length - 1;

            while (leftPointer <= rigthPointer)
            {
                if (!char.IsLetterOrDigit(s[leftPointer]))
                {
                    leftPointer++;
                }
                else if (!char.IsLetterOrDigit(s[rigthPointer]))
                {
                    rigthPointer--;
                }
                else
                {
                    if (char.ToLower(s[leftPointer]) != char.ToLower(s[rigthPointer]))
                    {
                        return false;
                    }

                    leftPointer++;
                    rigthPointer--;
                }
            }

            return true;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class ValidPalindromeTests
    {
        public ValidPalindromeTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void ValidPalindrome()
        {
            var alg = new ValidPalindrome();
            Assert.True(alg.IsPalindrome("A man, a plan, a canal: Panama"));
            Assert.False(alg.IsPalindrome("race a car"));

            Assert.True(alg.IsPalindrome(" r"));

            Assert.True(alg.IsPalindrome("race ecar"));
            Assert.True(alg.IsPalindrome("234  33 3 3  333432"));
        }
    }
}
