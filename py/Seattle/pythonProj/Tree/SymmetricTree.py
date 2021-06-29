from typing import List
from TreeNode import TreeNode

class Solution:
    # https://leetcode.com/problems/symmetric-tree/
    def isSymmetric(self, r: TreeNode) -> bool:
        return self.isMirror(r, r)

    def isMirror(self, l: TreeNode, r: TreeNode) -> bool:
        if l is None and r is None: return True
        if l is None or r is None: return False
        if l.val == r.val and self.isMirror(l.left, r.right) and self.isMirror(l.right, r.left):
            return True
        else:
            return False


if __name__ == '__main__':
    sln = Solution()

    t2 = TreeNode()
    arr = [1, 2, 2, 3, 4, 4, 3]
    t2.root = t2.insert_level_order(arr, t2.root, 0)
    t2.in_order(t2.root);
    print(sln.isSymmetric(t2.root))

    arr = [1, 2, 2, 6, 3, 7, 3]
    t2.root = t2.insert_level_order(arr, t2.root, 0)
    t2.in_order(t2.root)
    print(sln.isSymmetric(t2.root))