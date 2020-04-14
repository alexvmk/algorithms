using System;
using System.Collections.Generic;
using System.Text;
using Seattle.DataStructure;
using Xunit;

namespace Seattle.LinkedLists
{
    /// <summary>
    /// https://leetcode.com/problems/merge-two-sorted-lists/.
    /// </summary>
    public class MergeSortedLinkedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
            {
                return l2;
            }
            else if (l2 == null)
            {
                return l1;
            }
            else if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }

        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class MergeSortedLinkedListsTests
    {
        public MergeSortedLinkedListsTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test()
        {
            var algorithm = new MergeSortedLinkedLists();

            // 1 -> 5 -> 10 -> 20
            var node20 = new ListNode(20);
            var node10 = new ListNode(10);
            node10.next = node20;
            var node5 = new ListNode(5);
            node5.next = node10;
            var node1 = new ListNode(1);
            node1.next = node5;

            // 4 -> 12
            var node12 = new ListNode(12);
            var node4 = new ListNode(4);
            node4.next = node12;

            var res = algorithm.MergeTwoLists(node1, node4);

            // 1 -> 4 -> 5 -> 10 -> 12 -> 20
            Assert.Equal(res, node1);
            Assert.Equal(res.next, node4);
            Assert.Equal(res.next.next, node5);
            Assert.Equal(res.next.next.next, node10);
            Assert.Equal(res.next.next.next.next, node12);
            Assert.Equal(res.next.next.next.next.next, node20);
            Assert.Null(res.next.next.next.next.next.next);
        }
    }
}
