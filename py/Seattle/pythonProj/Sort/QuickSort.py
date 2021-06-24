import random
from typing import List


class Solution:
    # Runtime: O(nlogn) expected, O(n^2) worst case. With a proper choice of pivot (using the median of medians
    # algorithm), the runtime can be reduced to strict O(nlogn). Space: O(n) expected, O(n^2) worst case
    def quicksort(self, nums):
        # if length 1 the return
        if len(nums) <= 1:
            return nums

        pivot = random.choice(nums)
        lt = [v for v in nums if v < pivot]
        eq = [v for v in nums if v == pivot]
        gt = [v for v in nums if v > pivot]

        return self.quicksort(lt) + eq + self.quicksort(gt)


if __name__ == '__main__':
    print('PyCharm')
    sln = Solution()
    inputList = [12, 11, 13, 5, 6, 7]

    print(sln.quicksort(inputList))

    print('Finished')