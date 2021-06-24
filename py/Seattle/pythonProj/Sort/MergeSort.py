from typing import List


def sort(nums: List[int]) -> List[int]:
    # if length 1 the return
    if len(nums) == 1:
        return nums

    # split array into two subareas
    mid = len(nums) // 2
    left = nums[:mid]
    right = nums[mid:]

    # Recursively break the arrays - O(log n)
    a = sort(left)
    b = sort(right)

    # sort O(n)
    return merge(left, right)

def merge(a: List[int], b: List[int]) -> List[int]:
    out = []
    while a and b:
        if a[0] > b[0]:
            out.append(b.pop(0))
        else:
            out.append(a.pop(0))
    if a:
        out += a
    else:
        out += b
    return out


if __name__ == '__main__':
    print('PyCharm')
    inputList = [12, 11, 13, 5, 6, 7]

    print(sort(inputList))

    print('Finished')