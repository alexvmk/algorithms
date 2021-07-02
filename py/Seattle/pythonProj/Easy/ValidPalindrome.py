from typing import List

class Solution:
    # https://leetcode.com/problems/valid-palindrome
    def valid(self, s) -> bool:
        alphanumericOnlyChars = filter(lambda c: c.isalnum(), s)
        lowercaseCharsList = list(map(lambda c: c.lower(), alphanumericOnlyChars))
        reversedChars = lowercaseCharsList[::-1]
        return reversedChars == lowercaseCharsList


if __name__ == '__main__':
    s = "A man, a plan, a canal: Panama"
    sln = Solution()
    print(sln.valid(s))