﻿using System;
using System.Linq;
using System.Numerics;
using System.Text;
using Xunit;

namespace Seattle.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/add-binary/.
    /// </summary>
    public class AddBinary
    {
        /// <summary>
        /// Approach 1: Bit-by-Bit Computation.
        /// </summary>
        public string AddBinary1(string a, string b)
        {
            int n = a.Length, m = b.Length;
            if (n < m) return AddBinary1(b, a);
            int L = Math.Max(n, m);

            var sb = new StringBuilder();
            int carry = 0, j = m - 1;
            for (int i = L - 1; i > -1; --i)
            {
                if (a[i] == '1') ++carry;
                if (j > -1 && b[j--] == '1') ++carry;

                if (carry % 2 == 1) sb.Append('1');
                else sb.Append('0');

                carry /= 2;
            }
            if (carry == 1) sb.Append('1');

            return new string(sb.ToString().Reverse<char>().ToArray());
        }

        /// <summary>
        /// Approach 2: Bit Manipulation.
        /// </summary>
        public string Run(string a, string b)
        {
            BigInteger x = BinToBigInteger(a);
            BigInteger y = BinToBigInteger(b);

            BigInteger zero = 0;
            BigInteger answer, carry;

            while (y.CompareTo(zero) != 0)
            {
                answer = x ^ y;
                carry = (x & y) << 1;
                x = answer;
                y = carry;
            }

            return ToBinaryString(x);
        }

        /// <summary>
        /// https://stackoverflow.com/questions/8774083/c-sharp-convert-large-binary-string-to-decimal-system.
        /// </summary>
        private BigInteger BinToBigInteger(string value)
        {
            // BigInteger can be found in the System.Numerics dll
            BigInteger res = 0;

            // I'm totally skipping error handling here
            foreach (char c in value)
            {
                res <<= 1;
                res += c == '1' ? 1 : 0;
            }

            return res;
        }

        /// <summary>
        /// TODO need to work on it.
        /// </summary>
        private string ToBinaryString(BigInteger bigint)
        {
            var bytes = bigint.ToByteArray();
            var idx = bytes.Length - 1;

            // Create a StringBuilder having appropriate capacity.
            var base2 = new StringBuilder(bytes.Length * 8);

            // Convert first byte to binary.
            var binary = Convert.ToString(bytes[idx], 2);

            // Ensure leading zero exists if value is positive.
            // TODO ???
            //if (binary[0] != '0' && bigint.Sign == 1)
            //{
            //    base2.Append('0');
            //}

            // Append binary string to StringBuilder.
            base2.Append(binary);

            // Convert remaining bytes adding leading zeros.
            for (idx--; idx >= 0; idx--)
            {
                base2.Append(Convert.ToString(bytes[idx], 2).PadLeft(8, '0'));
            }

            return base2.ToString();
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

            // Approach 1: Bit-by-Bit Computation
            var r1 = algorithm.AddBinary1("11", "1");
            Assert.Equal("100", r1);

            r1 = algorithm.AddBinary1("1010", "1011");
            Assert.Equal("10101", r1);

            // Approach 2: Bit Manipulation
            r1 = algorithm.Run("11", "1");
            Assert.Equal("100", r1);

            r1 = algorithm.Run("1010", "1011");
            Assert.Equal("10101", r1);


            // TODO this does not work because of incorrect method ToBinaryString
            //r1 = algorithm.Run("11", "11010010");
            //Assert.Equal("11010101", r1);
        }
    }
}
