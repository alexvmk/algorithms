using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
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
}
