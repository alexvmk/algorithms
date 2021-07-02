class Solution:
    # https://leetcode.com/problems/reverse-bits/
    def reverse_bits(self, n):
        ret, power = 0, 31
        while n:
            ret += (n & 1) << power
            n = n >> 1
            power -= 1
        return ret


if __name__ == '__main__':
    print('start')
    # 4294967293 = 11111111111111111111111111111101
    print(Solution().reverse_bits(4294967293))
    # 3221225471 = 10111111111111111111111111111111
    print('finish')