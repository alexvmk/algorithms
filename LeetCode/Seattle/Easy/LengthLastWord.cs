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
    /// https://leetcode.com/problems/length-of-last-word/.
    /// </summary>
    public class LengthLastWord
    {
        public int LengthOfLastWord(string s)
        {
            int p = s.Length, length = 0;
            while (p > 0)
            {
                p--;

                // we're in the middle of the last word
                if (s[p] != ' ')
                {
                    length++;
                }

                // here is the end of last word
                else if (length > 0)
                {
                    return length;
                }
            }

            return length;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class LengthLastWordTests
    {
        public LengthLastWordTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test()
        {
            var algorithm = new LengthLastWord();
            Assert.Equal(5, algorithm.LengthOfLastWord("Hello World"));
        }
    }
}
