using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Subsets
    {
        public List<List<int>> CalcSubsets(int[] nums)
        {
            var list = new List<List<int>>();
            //list.Sort();
            Backtrack(list, new List<int>(), nums, 0);
            return list;
        }

        private void Backtrack(List<List<int>> list, List<int> tempList, int[] nums, int start)
        {
            list.Add(new List<int>(tempList));
            for (int i = start; i < nums.Length; i++)
            {
                tempList.Add(nums[i]);
                Backtrack(list, tempList, nums, i + 1);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}

//public List<List<int>> CalcSubsets(int[] nums)
//{
//var list = new List<List<int>>();
////list.Sort();
//Backtrack(nums, new int[nums.Length], list, 0);
//return list;
//}

//private void Backtrack(int[] nums, int[] subset, List<List<int>> list, int start)
//{
//if (start == nums.Length)
//{
//    list.Add(new List<int>(subset));
//}
//else
//{
//    subset[start] = -1;
//    Backtrack(nums, subset, list, start + 1);
//    subset[start] = nums[start];
//    Backtrack(nums, subset, list, start + 1);
//}
//}
