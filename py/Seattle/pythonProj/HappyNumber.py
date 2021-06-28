from typing import List

class Solution:
    # https://leetcode.com/problems/happy-number/
    def ishappy(self, n) -> bool:
        def getNext(n):
            sum = 0
            while n != 0:
                n, rem = divmod(n, 10)
                sum += rem**2
            return sum

        seen = set()
        while n != 1 and n not in seen:
            seen.add(n)
            n = getNext(n)

        return n == 1


if __name__ == '__main__':
    sln = Solution()
    print(sln.ishappy(19))