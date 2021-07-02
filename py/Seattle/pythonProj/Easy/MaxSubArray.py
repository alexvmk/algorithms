from typing import List

class Solution:
    def maxSubArray(self, nums: List[int]):
        maxSubArraySum = currentSubArraySum = nums[0]

        for num in nums[1:]:
            currentSubArraySum = max(num, currentSubArraySum + num)
            maxSubArraySum = max(maxSubArraySum, currentSubArraySum)

        return maxSubArraySum

if __name__ == '__main__':
    print('Start')
    sln = Solution()

    print(sln.maxSubArray([-2,1,-3,4,-1,2,1,-5,4]))
    print('Finish')