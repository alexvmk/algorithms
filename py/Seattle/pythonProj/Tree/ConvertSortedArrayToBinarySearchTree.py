from TreeNode import TreeNode


class Solution:
    # https://leetcode.com/problems/convert-sorted-array-to-binary-search-tree
    # Preorder Traversal: Always Choose Left Middle Node as a Root
    def convert(self, arr):
        def helper(self, left, right):
            if left > right:
                return None

            # always choose left middle node as a root
            p = (right + left) // 2

            # preorder traversal: node -> left -> righ
            node = TreeNode(arr[p])
            node.left = helper(self, left, p - 1)
            node.right = helper(self, p + 1, right)

            return node

        return helper(self, 0, len(arr) - 1)


if __name__ == '__main__':
    print('PyCharm')
    sln = Solution()
    print(sln.convert([-10,-3,0,5,9]))
    print('Finished')