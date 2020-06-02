using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingLeetCode 
{
    public class NO006_Zigzag
    {
        public static string Convert(string s, int numRows)
        {
            string result = string.Empty;
            if (numRows == 1)
            {
                result = s;
            }
            else
            {

                List<char[]> rows = new List<char[]>();

                int index = 0;

                char[] onerow = new char[numRows];
                foreach (char chr in s)
                {
                    int indexRowMod = index % (2 * numRows - 2);

                    if (indexRowMod < numRows)
                    {
                        if (index != 0 && indexRowMod == 0)
                        {
                            rows.Add(onerow);
                            onerow = new char[numRows];
                        }
                        onerow[indexRowMod] = chr;
                    }
                    else
                    {
                        rows.Add(onerow);
                        onerow = new char[numRows];

                        onerow[2 * numRows - indexRowMod - 2] = chr;
                    }
                    index++;
                }
                rows.Add(onerow);

                StringBuilder sb = new StringBuilder();

                for (int rowindex = 0; rowindex < numRows; rowindex++)
                {
                    for (int k = 0; k < rows.Count(); k++)
                    {
                        if ((rows[k].Length - rowindex) >= 1)
                        {
                            var xvalue = rows[k][rowindex];
                            if (xvalue != '\0')
                            {
                                sb.Append(xvalue);
                            }
                        }
                    }
                }
                result = sb.ToString();
            }

            return result;
        }
    }
}
