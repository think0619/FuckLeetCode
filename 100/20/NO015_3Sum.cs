using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingLeetCode
{
    public class NO015_3Sum
    {
        public int[] TestValue = new int[] { -1, 0, 1, 2, -1, -4 };
        public IList<IList<int>> result = new List<IList<int>>();
        public IList<IList<int>> ThreeSum(int[] nums)
        { 
            {
                IList<IList<int>> resultList = new List<IList<int>>();
                //Order
                //Array.Sort(nums);
                nums = nums.OrderBy(x => x).ToArray();
                int length = nums.Length;

                if (length == 3)
                {
                    if ((nums[0] + nums[1] + nums[2]) == 0) resultList.Add(new int[] { nums[0], nums[1], nums[2] });
                }

                else if (length > 3)
                {
                    if (nums[0] <= 0)
                    {
                        for (int i = 0; i < length; i++)
                        {
                            if (i > 0 && nums[i] == nums[i - 1])
                            {
                                continue;
                            }
                            int FirstIndex = i + 1;
                            int LastIndex = length - 1;
                            while (FirstIndex < LastIndex)
                            {
                                int sum = nums[i] + nums[FirstIndex] + nums[LastIndex];
                                if (sum > 0)
                                {
                                    LastIndex--;
                                }
                                else if (sum < 0)
                                {
                                    FirstIndex++;
                                }
                                else
                                {
                                    resultList.Add(new int[] { nums[i], nums[FirstIndex], nums[LastIndex] });
                                    while (FirstIndex < LastIndex && (nums[FirstIndex] == nums[FirstIndex + 1]))
                                    {
                                        FirstIndex++;
                                    }

                                    while (FirstIndex < LastIndex && (nums[LastIndex] == nums[LastIndex - 1]))
                                    {
                                        LastIndex--;
                                    }
                                    if (FirstIndex < LastIndex)
                                    {
                                        FirstIndex++;
                                        LastIndex--;
                                    }
                                }
                            }
                        }
                    }
                }
                return resultList;
            }
        }
    }
}
