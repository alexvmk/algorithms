from ListNode import ListNode


class Solution:
    # https://leetcode.com/problems/intersection-of-two-linked-lists/
    # Time complexity : O(N + M)
    # Space complexity : O(1)
    def intersection(self, l1: ListNode, l2: ListNode) -> ListNode:
        l1head = l1
        l2head = l2

        while l1head != l2head:
            l1head = l2 if l1head is None else l1head.next
            l2head = l1 if l2head is None else l2head.next

        return l1head


if __name__ == '__main__':
    sln = Solution()

    # 1 -> 2 -> 3 -> 4
    node4 = ListNode(4)
    node3 = ListNode(3)
    node3.next = node4
    node2 = ListNode(2)
    node2.next = node3
    node1 = ListNode(1)
    node1.next = node2

    print(sln.intersection(node1, node2))
