using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallerThanCurrentNumber_1365
{
    /// <summary>
    /// https://leetcode.com/problems/how-many-numbers-are-smaller-than-the-current-number/
    /// </summary>
    public class Solution
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            Dictionary<int, int> numsMap = new();
            var sortedNums = nums.OrderByDescending(x => x).ToArray();

            for (int i = 0; i < sortedNums.Length; i++)
            {
                int tmp = sortedNums.Length - (i + 1);
                if (numsMap.ContainsKey(sortedNums[i]))
                {
                    numsMap[sortedNums[i]] = tmp;
                }
                else
                {
                    numsMap.Add(sortedNums[i], tmp);
                }
            }

            return nums.Select(x => numsMap[x]).ToArray();
        }
    }
}
