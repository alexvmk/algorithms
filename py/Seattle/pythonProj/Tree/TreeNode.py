from typing import List
import TreeNode

# Definition for a binary tree node.
class TreeNode(object):
    def __init__(self, val=0, left=None, right=None):
        self.root = None
        self.val = val
        self.left = left
        self.right = right

    # Function to insert nodes in level order (BFT)
    def insert_level_order(self, arr: List[int], root: TreeNode, i: int):

        # Base case for recursion
        if i < len(arr):
            temp = TreeNode(arr[i])
            root = temp

            # insert left child
            root.left = self.insert_level_order(arr, root.left, 2 * i + 1)

            # insert right child
            root.right = self.insert_level_order(arr, root.right, 2 * i + 2)

        return root

    # Function to print tree nodes in InOrder fashion (DFT)
    def in_order(self, root: TreeNode):
        if root != None:
            self.in_order(root.left)
            print(f"{root.val} ")
            self.in_order(root.right)
