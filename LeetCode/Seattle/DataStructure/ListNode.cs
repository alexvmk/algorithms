using System;
using System.Collections.Generic;
using System.Text;

namespace Seattle.DataStructure
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
        public ListNode(int x, ListNode pnext) { val = x; next = pnext; }
    }
}
