using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingLeetCode
{
    public class NO318_Maximum_Product_of_Word_Lengths
    {
        public string[] words { get; set; }

        public NO318_Maximum_Product_of_Word_Lengths()
        {
            words = new string[] { "abcw", "baz", "foo", "bar", "xtfn", "abcdef" };
        }

        public int MaxProduct_Violence(string[] words)
        { 
            int maxvalue = 0;
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {

                    bool sameflag = false;
                    foreach (char c in words[i])
                    {
                        if (words[j].Contains(c))
                        {
                            sameflag = true;
                            break;
                        }
                    }
                    if (!sameflag)
                    {
                        var multiplyvalue = words[j].Length * words[i].Length;
                        if (maxvalue < multiplyvalue)
                        {
                            maxvalue = multiplyvalue;
                        }
                    }
                }
            }
            return maxvalue;
        }


        public int MaxProduct(string[] words)
        {
            int maxvalue = 0;
            int[] charactersArray = new int[words.Length];
            for (int index = 0; index < words.Length; index++)
            {
                foreach (char c in words[index])
                {

                    //按位赋值
                    charactersArray[index] |= (1 << (c - 'a'));
                } 
            }
         
            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if ((charactersArray[i] & charactersArray[j]) ==0)
                    {
                        var multiplyvalue = words[j].Length * words[i].Length;
                        if (maxvalue < multiplyvalue)
                        {
                            maxvalue = multiplyvalue;
                        }
                    } 
                }
            }
            return maxvalue; 
        } 
    }
}
