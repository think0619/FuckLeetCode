using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingLeetCode
{
    public class NO018_4Sum
    {
        public int[] TestValue = new int[] { -1, 0, 1, 2, -1, -4};
        public int TestTarget = -1;
        public IList<IList<int>> result = new List<IList<int>>();

        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            IList<IList<int>> result = new List<IList<int>>();
           // nums = nums.OrderBy(n => n).ToArray() ;
            Array.Sort(nums);

            if (nums.Count() == 4)
            {
                if ((nums[0] + nums[1] + nums[2] + nums[3]) == target)
                {
                    result.Add(new int[] { nums[0], nums[1], nums[2], nums[3] });
                }
            }
            else if (nums.Count()> 4)
            {
                for (int i = 0; i < nums.Count() - 3; i++)
                {
                    if (i != 0 && (nums[i] == nums[i - 1]))
                    { 
                        continue;
                    }
                    for (int n = i + 1; n < nums.Count() - 2; n++)
                    {
                        if (nums[n] == nums[n - 1] && ((n - i) != 1))
                        { 
                            continue;
                        }
                        int L = n + 1;
                        int R = nums.Count() - 1;
                        while (L < R)
                        {
                            if ((nums[i] + nums[n] + nums[L] + nums[R]) > target)
                            {
                                R--;
                            }
                            else if ((nums[i] + nums[n] + nums[L] + nums[R]) < target)
                            {
                                L++;
                            }
                            else
                            {
                                result.Add(new int[] { nums[i], nums[n], nums[L], nums[R] });
                                while (L < R && (nums[L] == nums[L + 1])) { L++; }

                                while (L < R && (nums[R] == nums[R - 1])) { R--; }

                                if (L < R)
                                {
                                    L++;
                                    R--;
                                }
                            } 
                        }
                    }
                }
            }  

            return result;
        }
    }
}
