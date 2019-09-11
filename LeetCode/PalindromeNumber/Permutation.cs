using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    /// <summary>
    /// https://leetcode.com/problems/permutations/
    /// </summary>
    public class Permutation
    {
        public IList<string> Permute(string chars)
        {
            var list = new List<IList<char>>();
            BackTrack(list, new List<char>(), chars.ToCharArray());
            return list.Select(x => new string(x.ToArray())).ToList();
        }

        private void BackTrack(IList<IList<char>> list, IList<char> subset, char[] chars)
        {
            if (subset.Count == chars.Length)
            {
                list.Add(new List<char>(subset));
            }
            else
            {
                for (int i = 0; i < chars.Length; i++)
                {
                    if (subset.Contains(chars[i])) continue;
                    subset.Add(chars[i]);
                    BackTrack(list, subset, chars);
                    subset.RemoveAt(subset.Count - 1);
                }
            }
        }
    }
}
