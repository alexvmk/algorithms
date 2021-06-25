from typing import List

class Solution:
    def merge(self, nums1: List[int], m: int, nums2: List[int], n: int):

        p1 = m - 1
        p2 = n - 1
        for p in range(n + m - 1, -1, -1):
            if p1 >= 0 and nums1[p1] > nums2[p2]:
                nums1[p] = nums1[p1]
                p1 -= 1
            elif p2 >= 0:
                nums1[p] = nums2[p2]
                p2 -= 1

if __name__ == '__main__':
    inputlist1 = [1,2,3,0,0,0]
    inputlist2 = [2, 5, 6]

    sln = Solution()
    sln.merge(inputlist1, 3, inputlist2, 3)
    print(inputlist1)