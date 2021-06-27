from typing import List
from collections import Counter

class Solution:
    # https://leetcode.com/problems/permutations-ii/solution/
    def permutate(self, nums: List[int]) -> List[List[int]]:
        output = []
        def backtrack(self, comb, counter):
            if len(nums) == len(comb):
                output.append(list(comb))
            else:
                for num in counter:
                    if counter[num] > 0:
                        comb.append(num)
                        counter[num] -= 1
                        backtrack(self, comb, counter)
                        comb.pop()
                        counter[num] += 1

        n = len(nums)
        backtrack(self, [], Counter(nums))
        return output


if __name__ == '__main__':
    inputlist1 = [1,1,2]
    sln = Solution()
    print(sln.permutate(inputlist1))