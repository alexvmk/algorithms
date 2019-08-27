using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class TrailingZeroes
    {
        public int CalcTrailingZeroes(int n)
        {
            int cnt = 0;
            while (n > 0)
            {
                cnt += n / 5;
                n /= 5;
            }
            return cnt;
        }
    }
}
