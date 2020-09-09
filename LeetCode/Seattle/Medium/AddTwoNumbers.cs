// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Seattle.DataStructure;
using Xunit;

namespace Seattle.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers/.
    /// </summary>
    public class AddTwoNumbers
    {
        public ListNode AddTwoNumbersAlg(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;
            int carry = 0;
            while (p != null || q != null)
            {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class AddTwoNumbersTests
    {
        public AddTwoNumbersTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test1()
        {
            var algorithm = new AddTwoNumbers();

            // Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
            // Output: 7 -> 0 -> 8
            // Explanation: 342 + 465 = 807.

            var node13 = new ListNode(3);
            var node12 = new ListNode(4, node13);
            var node11 = new ListNode(2, node12);

            var node23 = new ListNode(4);
            var node22 = new ListNode(6, node23);
            var node21 = new ListNode(5, node22);


            var res = algorithm.AddTwoNumbersAlg(node11, node21);

            Assert.Equal(7, res.val);
            Assert.Equal(0, res.next.val);
            Assert.Equal(8, res.next.next.val);
        }
    }
}
