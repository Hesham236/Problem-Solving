using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving
{
    internal class BinarySearch
    {
        public int Search(int[] nums, int target)
        {
            int mid = nums[(nums.Length / 2)];
            if (mid == target) return nums.Length / 2;
            else if (mid > target)
            {
                for (int i = 0; i < (nums.Length / 2); i++)
                {
                    if (nums[i] == target)
                        return i;
                }
                return -1;
            }
            else if (mid < target)
            {
                for (int i = (nums.Length / 2); i < nums.Length; i++)
                {
                    if (nums[i] == target) return i;
                }
                return -1; 
            }
            else return -1;
        }
    }
}
