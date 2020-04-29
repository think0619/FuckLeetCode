using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingLeetCode
{
    class NO003_Longest_Substring_Without_Repeating_Characters
    {
        

        public int LengthOfLongestSubstring(string s)
        {
            int maxLength = 0;
            if (s.Length == 0 || s.Length == 1)
            {
                maxLength = s.Length;
            }
            else
            { 
                Dictionary<char, int> charLastIndex = new Dictionary<char, int>();
                int firstRepeatIndex = -1;
                int lastRepeatIndex = -1;
               // char[] sarray = new char[s.Length];
                int index = 0;
                foreach (char item in s)
                {
                   // sarray[index] = item;
                    if (charLastIndex.ContainsKey(item))
                    {
                        if (firstRepeatIndex == -1)
                        {
                            firstRepeatIndex = index;
                        }
                        lastRepeatIndex = charLastIndex[item];
                        //找中间
                        int lengthTmp = index - charLastIndex[item];
                        if (maxLength < lengthTmp)
                        {
                            maxLength = lengthTmp;
                        }

                        //  charLastIndex[item] = index;
                        charLastIndex.Clear();

                    }
                    charLastIndex.Add(item, index);
                    //else
                    //{
                    //    charLastIndex.Add(item, index);
                    //}
                    index++;
                }
                if (firstRepeatIndex != -1)
                {
                    if (firstRepeatIndex  > maxLength)
                    {
                        maxLength = firstRepeatIndex ;
                    }
                }

                if (lastRepeatIndex != -1)
                {
                    if ((s.Length-lastRepeatIndex-1) > maxLength)
                    {
                        maxLength = s.Length - lastRepeatIndex - 1;
                    }
                }

                if (firstRepeatIndex == -1 && lastRepeatIndex == -1)
                {
                    maxLength = s.Length;
                }
            }
            return maxLength;
        }
    }
}
