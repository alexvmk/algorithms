using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    /// <summary>
    /// https://leetcode.com/problems/permutations-ii/
    /// </summary>
    public class PermutationUniqueWithInt
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            var list = new List<IList<int>>();
            Array.Sort(nums);
            BackTrack(list, new List<int>(), nums, new bool[nums.Length]);
            return list;
        }

        private void BackTrack(IList<IList<int>> list, IList<int> subset, int[] nums, bool[] used)
        {
            if (subset.Count == nums.Length)
            {
                list.Add(new List<int>(subset));
            }
            else
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    if (used[i] || i > 0 && nums[i] == nums[i - 1] && !used[i - 1]) continue;
                    used[i] = true;
                    subset.Add(nums[i]);
                    BackTrack(list, subset, nums, used);
                    used[i] = false;
                    subset.RemoveAt(subset.Count - 1);
                }
            }
        }
    }
}
