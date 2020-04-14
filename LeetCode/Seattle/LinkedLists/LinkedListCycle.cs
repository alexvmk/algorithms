using System;
using System.Collections.Generic;
using System.Text;
using Seattle.DataStructure;
using Xunit;

namespace Seattle.LinkedLists
{
    /// <summary>
    /// https://leetcode.com/problems/linked-list-cycle/solution/.
    /// </summary>
    public class LinkedListCycle
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }
            ListNode slow = head;
            ListNode fast = head.next;
            while (slow != fast)
            {
                if (fast == null || fast.next == null)
                {
                    return false;
                }
                slow = slow.next;
                fast = fast.next.next;
            }
            return true;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class LinkedListCycleTests
    {
        public LinkedListCycleTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test()
        {
            var algorithm = new LinkedListCycle();

            // 3 -> 2 -> 1
            var node = new ListNode(0);
            var node1 = new ListNode(1);
            node1.next = node;
            var node2 = new ListNode(2);
            node2.next = node1;
            var node3 = new ListNode(3);
            node3.next = node2;
            var res = algorithm.HasCycle(node3);

            Assert.False(res);

            // 3 -> 2 -> 1 -> #3
            node.next = node3;
            res = algorithm.HasCycle(node3);
            Assert.True(res);
        }
    }
}
