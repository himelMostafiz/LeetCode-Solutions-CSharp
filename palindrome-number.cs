using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {

            string input = x.ToString();
            int lastIndexOfGivenInput = input.Length - 1;
            bool isPalindronNumber = true;
            for (int firstIndexOfGivenInput = 0; firstIndexOfGivenInput < lastIndexOfGivenInput; lastIndexOfGivenInput -= 1, firstIndexOfGivenInput += 1)
            {
                if (input[firstIndexOfGivenInput] != input[lastIndexOfGivenInput])
                {
                    isPalindronNumber = false;
                    break;
                }
            }

            return isPalindronNumber;
        }
    }
}
