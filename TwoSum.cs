using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class TwoSum
    {
        // 73ms
        public int[] TwoSums(int[] nums, int target)
        {
            int? x = null;
            int xPos = 0;
            int? y = null;
            int yPos = 0;
            for (var i = 0; i < nums.Length || y != null; i++)
            {
                x = nums[i];
                for (var j = i + 1; j < nums.Length || y != null; j++)
                {
                    yPos = j;
                    y = target == x + nums[j] ? nums[j] : null;
                    if (y != null)
                        break;
                }
                xPos = i;
                if (y != null)
                    break;
            }


            return new int[] { xPos, yPos };
        }
        // 2ms
        public int[] TwoSumPlus(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                map[nums[i]] = i;
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement) && map[complement] != i)
                {
                    return new int[] { i, map[complement] };
                }
            }


            return new int[] { };
        }
        // 1ms
        public int[] TwoSumPlusPlus(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }
                map[nums[i]] = i;
            }
            // Return an empty array if no solution is found
            return new int[] { };
        }
    }
}
