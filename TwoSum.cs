using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    public class TwoSum
    {
        // 73ms -> 5ms -> 4ms "melhor abordagem"
        public int[] MyTurn(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var result = target - nums[i];
                if (map.ContainsKey(result) && map[result] != i)
                {
                    return new int[] { map[result], i };
                }
                map[nums[i]] = i;
            }

            return new int[] { };
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
        public int[] TwoSumBruteForce(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { i, j };
                    }
                }
            }
        
            return new int[] { };
        }
        public int[] TwoSumTwoPointers(int[] nums, int target)
        {
            var arr = nums
                .Select((value, index) => new { value, index })
                .OrderBy(x => x.value)
                .ToArray();
        
            int left = 0;
            int right = arr.Length - 1;
        
            while (left < right)
            {
                int sum = arr[left].value + arr[right].value;
        
                if (sum == target)
                {
                    return new int[]
                    {
                        arr[left].index,
                        arr[right].index
                    };
                }
        
                if (sum < target)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        
            return new int[] { };
        }
    }
}
