using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    /// <summary>
    /// https://leetcode.com/problems/permutations-ii/
    /// </summary>
    public class PermutationUnique
    {
        public IList<string> Permute(string str)
        {
            var list = new List<IList<char>>();
            var charsArr = String.Concat(str.OrderBy(x => x)).ToCharArray();

            BackTrack(list, new List<char>(), charsArr, new bool[charsArr.Length]);
            return list.Select(x => new string(x.ToArray())).ToList();
        }

        private void BackTrack(IList<IList<char>> list, IList<char> subset, char[] chars, bool[] used)
        {
            if (subset.Count == chars.Length)
            {
                list.Add(new List<char>(subset));
            }
            else
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (used[i] || i > 0 && chars[i] == chars[i-1] && !used[i-1]) continue;
                    used[i] = true;
                    subset.Add(chars[i]);
                    BackTrack(list, subset, chars, used);
                    used[i] = false;
                    subset.RemoveAt(subset.Count - 1);
                }
            }
        }
    }
}
