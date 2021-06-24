import random
from typing import List


class Solution:
    #O(logN).
    def search(self, nums: List[int], target: int) -> int:
        left, right = 0, len(nums) - 1

        while left <= right:
            pivot = left + (right - left) // 2

            if target == nums[pivot]:
                return pivot
            if target < nums[pivot]:
                right = pivot - 1
            else:
                left = pivot + 1
        return -1


if __name__ == '__main__':
    print('PyCharm')
    sln = Solution()
    inputList = [-1,0,3,5,9,12]

    print(sln.search(inputList, 9))

    print('Finished')