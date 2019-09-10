using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class SymmetricTree
    {
        public bool IsSymmetric(TreeNode root)
        {
            return IsMirror(root, root);
        }

        private bool IsMirror(TreeNode r, TreeNode l)
        {
            if (r == null && l == null) return true;
            if (r == null || l == null) return false;
            return (r.val == l.val)
                   && IsMirror(r.right, l.left)
                   && IsMirror(r.left, l.right);
        }

        // Definition for a binary tree node.
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}
