class Solution:
    # https://leetcode.com/problems/number-of-1-bits/
    def calc_number_of_one_bits(self, n: int):
        bits = 0
        '''
        mask = 1
        for i in range(0, 32):
            if (n & mask) != 0:
                bits += 1
            mask = mask << 1

        '''
        while n:
            # this will take out the right-most 1 of n
            n = n & (n - 1)
            # update counter
            bits += 1

        return bits


if __name__ == '__main__':
    print('start')
    # 4294967293 = 11111111111111111111111111111101
    print(Solution().calc_number_of_one_bits(4294967293))
    print('finish')