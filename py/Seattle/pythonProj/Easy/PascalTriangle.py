class Solution:
    # https://leetcode.com/problems/pascals-triangle
    def calc_triangle(self, n: int) -> [[int]]:
        result = [[1]]
        if n <= 1:
            return result
        result.append([1, 1])

        for i in range(2, n):
            result.append([])
            for j in range(0, i + 1):
                if j == 0:
                    result[i].append(1)
                elif j == i:
                    result[i].append(1)
                else:
                    result[i].append(result[i - 1][j - 1] + result[i - 1][j])

        return result


if __name__ == '__main__':
    print('start')
    print(Solution().calc_triangle(5))
    print('finish')