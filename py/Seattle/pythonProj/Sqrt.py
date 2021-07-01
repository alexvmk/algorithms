from math import e, log


class Solution:
    # https://leetcode.com/problems/sqrtx/
    def sqrt(self, n):
        if n < 2:
            return 1

        left = int(e**(0.5*log(n)))
        right = left + 1

        return left if right * right > n else right


if __name__ == '__main__':
    print('PyCharm')
    sln = Solution()
    print(sln.sqrt(4))
    print('Finished')