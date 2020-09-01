using System;
using System.Collections.Generic;
using System.Text;
using Seattle.DataStructure;
using Xunit;

namespace Seattle.Easy
{
    /// <summary>
    /// https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree/ .
    /// </summary>
    public class ConvertSortedArrayToBinarySearchTree
    {
        private int[] nums;

        private TreeNode PreOrder(int leftInd, int rightInd)
        {
            if (rightInd < leftInd) return null;

            // always choose right middle node as a root
            var middleInd = (leftInd + rightInd) / 2;
            if ((leftInd + rightInd) % 2 == 1) ++middleInd;

            // preorder traversal: node -> left -> right
            var node = new TreeNode(nums[middleInd]);
            node.left = PreOrder(leftInd, middleInd - 1);
            node.right = PreOrder(middleInd + 1, rightInd);

            return node;
        }

        /// <summary>
        /// It's known that inorder traversal of BST is an array sorted in the ascending order.
        /// Does this problem have a unique solution, i.e. could inorder traversal be used as a unique identifier to encore/decode BST? The answer is no. 
        /// We are going to implement: "Preorder Traversal: Always Choose Right Middle Node as a Root" 
        /// </summary>
        public TreeNode SortedArrayToBST(int[] nums)
        {
            this.nums = nums;
            return PreOrder(0, nums.Length - 1);
        }
    }

    [Collection(SeattleCollectionFixture.SeattleCollectionFixtureName)]
    public class ConvertSortedArrayToBinarySearchTreeTests
    {
        public ConvertSortedArrayToBinarySearchTreeTests(SeattleTestsFixture seattleTestsFixture)
        {
        }

        [Fact]
        public void Test()
        {
            var algorithm = new ConvertSortedArrayToBinarySearchTree();
            var node = algorithm.SortedArrayToBST(new int[] { -10, -3, 0, 5, 9 });

            // result: [0,-3,9,-10,null,5]
        }
    }
}
