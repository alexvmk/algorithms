using System;
using System.Collections.Generic;
using System.Text;

namespace Seattle.DataStructure
{
    // Definition for a binary tree node.
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            val = val;
            left = left;
            right = right;
        }
    }
}
