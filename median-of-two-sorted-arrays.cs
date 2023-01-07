using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution
    {
		public double FindMedianSortedArrays(int[] nums1, int[] nums2)
		{

			double output = 0.00000;
			var length = nums1.Length + nums2.Length;
			int[] array = new int[length];
			Array.Copy(nums1, array, nums1.Length);
			Array.Copy(nums2, 0, array, nums1.Length, nums2.Length);

			Array.Sort(array);

			int index = 0;

			if (length % 2 == 1)
			{
				index = length / 2;
				output = array[index];
			}
			else
			{
				index = (length / 2);
				output = ((Double)(array[index - 1] + array[index]) / 2);
			}

			return output;

		}
	}
}
