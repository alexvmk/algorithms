from typing import List

class Solution:
    # https://leetcode.com/problems/climbing-stairs/
    def calc(self, n) -> int:
        result = 0
        if n == 0:
            return 0
        if n == 1:
            return 1
        #dp = [0] * (n + 1)
        #dp[1] = 1
        #dp[2] = 2

        #for i in range(3,n+1):
        #    dp[i] = dp[i-1] + dp[i-2]

        #return dp[n]

        first = 1
        second = 2
        for i in range(3, n + 1):
            third = first + second
            first = second
            second = third

        return second


if __name__ == '__main__':
    sln = Solution()
    print(sln.calc(10))