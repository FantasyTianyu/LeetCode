using System;
namespace LeetCode
{
    public class _1365_SmallerNumbersThanCurrentSolution
    {
        public _1365_SmallerNumbersThanCurrentSolution()
        {
        }

        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] result = new int[nums.Length];
            int minNum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                minNum = 0;
                for (int j = 0; j < nums.Length; j++)
                {

                    if (nums[j] < nums[i])
                    {
                        minNum++;
                    }
                    result[i] = minNum;
                }
            }
            return result;
        }
    }
}
