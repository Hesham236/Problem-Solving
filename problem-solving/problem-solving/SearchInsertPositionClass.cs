using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_solving
{
    internal class SearchInsertPositionClass
    {
        public int InsertSearchPosition(int[] nums , int target)
        {
            int mid = nums[(nums.Length / 2)];
            if (target > nums[nums.Length-1]) return nums.Length + 1 ;
            if (target < nums[0]) return 0;
            if (mid == target) return nums.Length / 2;
            else if (mid > target)
            {
                for (int i = 0; i < (nums.Length / 2); i++)
                {
                    if (nums[i] == target) return i;
                    if (nums[i] > target) return i;
                }
                return -1;
            }
            else if (mid < target)
            {
                for (int i = (nums.Length / 2); i < nums.Length; i++)
                {
                    if (nums[i] == target) return i;
                    if (nums[i] > target) return i;
                }
                return -1;
            }
            else return -1;
        }
    }
}
