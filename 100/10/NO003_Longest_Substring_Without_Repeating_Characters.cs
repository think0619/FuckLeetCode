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
            if (s.Length == 1 || s.Length == 0)
            {
                maxLength = s.Length;
            }
            else
            {
                //滑动窗口
                int index = 0;
                int LeftIndex = 0;
                Dictionary<char, int> LastCharacterIndex = new Dictionary<char, int>();
                foreach (char item in s)
                {
                    if (LastCharacterIndex.ContainsKey(item))
                    {
                        var lenghtA = index - LeftIndex;
                        if (lenghtA > maxLength)
                        {
                            maxLength = lenghtA;
                        }

                        int nextIndex = LastCharacterIndex[item] + 1;
                        if (nextIndex >= LeftIndex)
                        {
                            while ((nextIndex <= index) && (LastCharacterIndex.ContainsKey(s[nextIndex]) && LastCharacterIndex[s[nextIndex]] != nextIndex))
                            {
                                nextIndex++;
                            }
                            if (nextIndex > index) { nextIndex = index; }
                            LeftIndex = nextIndex;
                        }
                        LastCharacterIndex[item] = index;
                    }
                    else
                    {
                        var lengthTmp = index - LeftIndex + 1;
                        if (lengthTmp > maxLength)
                        {
                            maxLength = lengthTmp;
                        }
                        LastCharacterIndex.Add(item, index);
                    }
                    index++;
                }

                if ((s.Length - LeftIndex) > maxLength)
                {
                    maxLength = s.Length - LeftIndex;
                }
            }
            return maxLength;
        }
    }
}
