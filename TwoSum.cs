using System;
using System.Collections.Generic;
using System.Text;

namespace TwoSum_LeetCode
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            int isfound = 0;
            for (int i = 0; i < nums.Length - 1; i += 1)
            {
                for (int j = i + 1; j < nums.Length; j += 1)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        isfound = 1;
                        break;
                    }
                }
                if (isfound == 1)
                    break;

            }

            return result;
        }
    }
}
