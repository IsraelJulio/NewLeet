using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace Questions
{
    public class Arrays
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>();// HashSet é uma coleção que armazena elementos únicos, ou seja, não permite duplicatas. Ele é implementado como uma tabela hash, o que significa que as operações de inserção, remoção e busca são geralmente muito rápidas, com complexidade média de O(1).

            for (int i = 0; i < nums.Length; i++)
            {
                if (!seen.Add(nums[i]))
                    return true;
            }

            return false;
        }

        public int MissingNumber(int[] nums)
        {
            Dictionary<int, bool> numeros =
    Enumerable.Range(0, nums.Length)
              .ToDictionary(i => i, i => false);


            HashSet<int> vistos = nums.ToHashSet();

            for (int i = 0; i <= nums.Length; i++)
            {
                if (!vistos.Contains(i))
                    return i;
            }

            return -1; // Should never reach here if input is valid

        }
    }
}
