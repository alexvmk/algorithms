using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Algorithms.DataStructure;

namespace Algorithms
{
    public class MergeSortedLinkedLists
    {
        /* Takes two lists sorted in  
            increasing order, and merge  
            their nodes together to make 
            one big sorted list. Below  
            function takes O(Log n) extra  
            space for recursive calls,  
            but it can be easily modified  
            to work with same time and  
            O(1) extra space */
        private static ListNode SortedMerge(ListNode a, ListNode b)
        {
            ListNode result = null;

            /* Base cases */
            if (a == null)
                return b;
            else if (b == null)
                return a;

            /* Pick either a or b, and recur */
            if (a.val <= b.val)
            {
                result = a;
                result.next = SortedMerge(a.next, b);
            }
            else
            {
                result = b;
                result.next = SortedMerge(a, b.next);
            }

            return result;
        }

        // The main function that takes  
        // an array of lists arr[0..last]  
        // and generates the sorted output  
        public static ListNode MergeKLists(ListNode[] arr, int last)
        {
            // repeat until only one list is left  
            while (last != 0)
            {
                int i = 0, j = last;

                // (i, j) forms a pair  
                while (i < j)
                {
                    // merge List i with List j and store  
                    // merged list in List i  
                    arr[i] = SortedMerge(arr[i], arr[j]);

                    // consider next pair  
                    i++; j--;

                    // If all pairs are merged, update last  
                    if (i >= j)
                        last = j;
                }
            }

            return arr[0];
        }

        /* Function to print nodes in a given linked list */
        public static void PrintList(ListNode node)
        {
            while (node != null)
            {
                Console.Write(node.val + " ");
                node = node.next;
            }
        }
    }
}
