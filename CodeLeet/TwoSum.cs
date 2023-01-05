using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class TwoSum
    {
        public int[] Run(int[] nums, int target)
        {
            for(int index = 0; index < nums.Length; index++) 
            {
                for(int secIndex = index+1; secIndex < nums.Length; secIndex++) 
                {
                    if (nums[index] + nums[secIndex] == target) 
                    {
                        return new int[]{ nums[index], nums[secIndex]};
                       
                    }
                }
            }
            return null;
        }
    }
}
