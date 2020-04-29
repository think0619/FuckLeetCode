using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingLeetCode 
{
    public class NO001_AddTwoNumbers
    {
        public int[] TestValue = new int[] { 2, 7, 11, 15 };
        public int target = 9;
        public int[] result = new int[] { };
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = null;
            Dictionary<int, int> flagDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (flagDict.ContainsKey(nums[i]))
                {
                    result = new int[] { i, flagDict[nums[i]] };
                    break;
                }
                else
                {
                    int anothervalue = target - nums[i];
                    if (!flagDict.ContainsKey(anothervalue))
                    {
                        flagDict.Add(anothervalue, i);
                    }
                }
            }
            return result;
        }
    }
}
