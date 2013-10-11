using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedPrinciples
{
    class FasterSortSystem : SortingSystem
    {
        public override int[] Sort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int index = i;
                for (int j = index; j < nums.Length; j++)
                {
                    if (nums[j] > nums[index])
                        index = j;
                }
                int tmp = nums[i];
                nums[i] = nums[index];
                nums[index] = tmp;
            }

            return nums;
        }

    }
}
