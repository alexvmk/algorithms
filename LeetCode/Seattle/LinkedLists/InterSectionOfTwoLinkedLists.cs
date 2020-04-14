using System;
using System.Collections.Generic;
using System.Text;
using Seattle.DataStructure;
using Xunit;

namespace Seattle.LinkedLists
{
    /// <summary>
    /// https://leetcode.com/problems/intersection-of-two-linked-lists/.
    /// </summary>
    public class InterSectionOfTwoLinkedLists
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null) return null;

            ListNode a = headA;
            ListNode b = headB;

            //if a & b have different len, then we will stop the loop after second iteration
            while (a != b)
            {
                //for the end of first iteration, we just reset the pointer to the head of another linkedlist
                a = a == null ? headB : a.next;
                b = b == null ? headA : b.next;
            }

            return a;
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class InterSectionOfTwoLinkedListsTests
    {
        public InterSectionOfTwoLinkedListsTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test()
        {
            var algorithm = new InterSectionOfTwoLinkedLists();

            // 1 -> 2 -> 3 -> 4
            var node4 = new ListNode(4);
            var node3 = new ListNode(3);
            node3.next = node4;
            var node2 = new ListNode(2);
            node2.next = node3;
            var node1 = new ListNode(1);
            node1.next = node2;


            var res = algorithm.GetIntersectionNode(node1, node2);

            Assert.Equal(node2, res);

            // 5 -> 6
            var node6 = new ListNode(6);
            var node5 = new ListNode(5);
            node5.next = node6;
            res = algorithm.GetIntersectionNode(node1, node5);
            Assert.Null(res);
        }
    }
}
