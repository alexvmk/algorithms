using System;
using System.Collections.Generic;
using System.Text;

namespace Seattle.DataStructure
{
    /// <summary>
    /// C# program to construct binary tree from 
    /// given array in level order fashion.
    /// https://www.geeksforgeeks.org/construct-complete-binary-tree-given-array/.
    /// </summary>
    public class Tree
    {
        public TreeNode root { get; set; }

        // Function to insert nodes in level order 
        public TreeNode insertLevelOrder(int[] arr,
                                TreeNode root, int i)
        {
            // Base case for recursion 
            if (i < arr.Length)
            {
                TreeNode temp = new TreeNode(arr[i]);
                root = temp;

                // insert left child 
                root.left = insertLevelOrder(arr,
                                root.left, 2 * i + 1);

                // insert right child 
                root.right = insertLevelOrder(arr,
                                root.right, 2 * i + 2);
            }
            return root;
        }

        // Function to print tree 
        // nodes in InOrder fashion 
        public void inOrder(TreeNode root)
        {
            if (root != null)
            {
                inOrder(root.left);
                Console.Write(root.val + " ");
                inOrder(root.right);
            }
        }
    }
}
