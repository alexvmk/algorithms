// Copyright (c) Aleksandr Rakushev (2020-present). All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using Castle.Core.Internal;
using Seattle.DataStructure;
using Xunit;

namespace Seattle.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/add-two-numbers-ii.
    /// </summary>
    public class AddTwoNumbersII
    {
        public ListNode AddTwoNumbersAlg(ListNode l1, ListNode l2)
        {
            var s1 = new Stack<int>();
            var s2 = new Stack<int>();

            while (l1 != null)
            {
                s1.Push(l1.val);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                s2.Push(l2.val);
                l2 = l2.next;
            }

            ListNode list = new ListNode(0);
            int sum = 0;
            while (s1.Count > 0 || s2.Count > 0)
            {
                if (s1.Count != 0) sum += s1.Pop();
                if (s2.Count != 0) sum += s2.Pop();

                list.val = sum % 10;
                var head = new ListNode(0);
                head.next = list;
                list = head;

                sum /= 10;
            }

            return list.val == 0 ? list.next : list;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class AddTwoNumbersIITests
    {
        public AddTwoNumbersIITests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test1()
        {
            var algorithm = new AddTwoNumbersII();

            // Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
            // Output: 7 -> 0 -> 8
            // Explanation: 342 + 465 = 807.

            var node14 = new ListNode(3);
            var node13 = new ListNode(4, node14);
            var node12 = new ListNode(2, node13);
            var node11 = new ListNode(7, node12);

            var node23 = new ListNode(4);
            var node22 = new ListNode(6, node23);
            var node21 = new ListNode(5, node22);


            var res = algorithm.AddTwoNumbersAlg(node11, node21);

            Assert.Equal(7, res.val);
            Assert.Equal(8, res.next.val);
            Assert.Equal(0, res.next.next.val);
            Assert.Equal(7, res.next.next.next.val);
        }
    }
}
