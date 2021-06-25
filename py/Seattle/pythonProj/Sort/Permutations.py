from typing import List

class Solution:
    def permutate(self, nums: List[int]) -> List[List[int]]:
        n = len(nums)
        def backtrack(self, first):
            if first == n:
                output.append(nums[:])
            else:
                for i in range(first,n):
                    nums[first], nums[i] = nums[i], nums[first]
                    backtrack(self, first + 1)
                    nums[first], nums[i] = nums[i], nums[first]

        output = []
        backtrack(self, 0)
        return output


if __name__ == '__main__':
    inputlist1 = [1,2,3]
    sln = Solution()
    print(sln.permutate(inputlist1))