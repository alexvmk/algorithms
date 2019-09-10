﻿using System;
using ListNode = Algorithms.InterSectionOfTwoLinkedLists.ListNode;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //----------------PalindromeNumber
            //var sln = new PalindromeNumber.PalindromeNumberSolution();
            //Console.WriteLine(sln.IsPalindrome(12312));

            ////----------------4SumII
            //int[] A = new int[] { 1, 2 };
            //int[] B = new int[] { -2, 1 };
            //int[] C = new int[] { -1, 2 };
            //int[] D = new int[] { 0, 2 };
            //var sum4Sln = new _4SumIISolution();
            //Console.WriteLine(sum4Sln.FourSumCount(A, B, C, D));


            //-----------------------HappyNumber-----
            //var hn = new HappyNumber();
            //Console.WriteLine(hn.IsHappy(2));

            //-----------------------TrailingZeroes-----
            //var tz = new TrailingZeroes();
            //Console.WriteLine(tz.CalcTrailingZeroes(10));

            //-----------------------InterSectionOfTwoLinkedLists-----
            // [4,1,8,4,5]
            //var head1 = new ListNode(4);
            //head1.next = new ListNode(1);
            //head1.next.next = new ListNode(8);
            //head1.next.next.next = new ListNode(4);
            //head1.next.next.next.next = new ListNode(5);

            //// [5,0,1,8,4,5]
            //var head2 = new ListNode(5);
            //head2.next = new ListNode(0);
            //head2.next.next = new ListNode(1);
            //head2.next.next.next = new ListNode(2);
            //head2.next.next.next.next = new ListNode(3);
            //head2.next.next.next.next.next = head1.next.next;
            //head2.next.next.next.next.next.next = new ListNode(4);
            //head2.next.next.next.next.next.next.next = new ListNode(5);

            //var sln = new InterSectionOfTwoLinkedLists();
            //Console.WriteLine("InterSectionOfTwoLinkedLists result:");
            //var res = sln.GetIntersectionNode(head1, head2);
            //Console.WriteLine(((res != null) ? res.val.ToString() : "null"));

            // SymmetricTree=========================
            var sln = new SymmetricTree();

            var root = new SymmetricTree.TreeNode(1);
            root.left = new SymmetricTree.TreeNode(2);
            root.right = new SymmetricTree.TreeNode(2);
            root.left.right = new SymmetricTree.TreeNode(3);
            root.left.left = new SymmetricTree.TreeNode(4);
            root.right.right = new SymmetricTree.TreeNode(4);
            root.right.left = new SymmetricTree.TreeNode(3);

            Console.WriteLine(sln.IsSymmetric(root));
        }
    }
}
