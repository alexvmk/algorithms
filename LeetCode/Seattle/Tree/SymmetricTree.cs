using System;
using System.Collections.Generic;
using System.Text;
using Seattle.DataStructure;
using Xunit;

namespace Seattle.TreeAlgorithms
{
    /// <summary>
    /// https://leetcode.com/problems/symmetric-tree/.
    /// </summary>
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
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class SymmetricTreeTests
    {
        public SymmetricTreeTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test()
        {
            var algorithm = new SymmetricTree();

            //     1
            //    / \
            //   2   2
            //  / \ / \
            // 3  4 4  3
            var t2 = new Tree();
            int[] arr = {1, 2, 2, 3, 4, 4, 3};
            t2.root = t2.insertLevelOrder(arr, t2.root, 0);
            t2.inOrder(t2.root);

            var res = algorithm.IsSymmetric(t2.root);
            Assert.True(res);

            //      1
            //    /  \
            //   2    2
            //  / \  / \
            // 5  3  7  3
            arr = new int[] { 1, 2, 2, 6, 3, 7, 3 };
            t2.root = t2.insertLevelOrder(arr, t2.root, 0);
            t2.inOrder(t2.root);

            res = algorithm.IsSymmetric(t2.root);
            Assert.False(res);
        }
    }
}
