class Solution:
    # https://leetcode.com/problems/count-primes/
    def count_primes(self, n):
        if n < 2:
            return 0

        not_prime = [False] * n
        count = 0

        for i in range(2, n):
            if not not_prime[i]:
                count += 1
                j = 2
                while i*j < n:
                    not_prime[i*j] = True
                    j += 1

        return count


if __name__ == '__main__':
    print('PyCharm')
    sln = Solution()
    print(sln.count_primes(10))
    print('Finished')