from typing import List

class Solution:
    def permutate(self, nums: List[int]) -> List[List[int]]:
        def backtrack(self, first):
            # if all integers are used up
            if first == n:
                output.append(nums[:])
            else:
                for i in range(first,n):
                    # place i-th integer first
                    # in the current permutation
                    nums[first], nums[i] = nums[i], nums[first]
                    # use next integers to complete the permutations
                    backtrack(self, first + 1)
                    # backtrack
                    nums[first], nums[i] = nums[i], nums[first]

        n = len(nums)
        output = []
        backtrack(self, 0)
        return output


if __name__ == '__main__':
    inputlist1 = [1,2,3]
    sln = Solution()
    print(sln.permutate(inputlist1))