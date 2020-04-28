using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingLeetCode
{
    public class NO067_AddBinary
    {
        public string stringA;
        public string stringB;
        public string result ;

        public NO067_AddBinary()
        {
            stringA = "11";
            stringB = "1";
            result = String.Empty;
        }

        public string AddBinary(string a, string b)
        {
            int minLenth = b.Length;
            //a长，比短
            if ((a.Length - b.Length) < 0)
            {
                minLenth = a.Length;
                string c = a;
                a = b;
                b = c;
            }

            StringBuilder sb = new StringBuilder(100);
            bool needCarry = false;
            for (int i = 1; i <= minLenth; i++)
            {
                char achar = a[a.Length - i];
                char bchar = b[b.Length - i];

                int oneCount = 0;
                if (achar == '1') { oneCount++; }
                if (bchar == '1') { oneCount++; }
                if (needCarry) { oneCount++; }

                switch (oneCount)
                {
                    case 0: { sb.Insert(0, 0); break; }
                    case 1: { needCarry = false; sb.Insert(0, 1); break; }
                    case 2: { needCarry = true; sb.Insert(0, 0); break; }
                    case 3: { needCarry = true; sb.Insert(0, 1); break; }
                }
            }
            string ahead = a.Substring(0, a.Length - minLenth);

            for (int k = 1; k <= ahead.Length; k++)
            {
                int oneCountHead = 0;
                if (needCarry) { oneCountHead++; }
                if (ahead[ahead.Length - k] == '1') { oneCountHead++; }

                if (oneCountHead == 2)
                {
                    needCarry = true;
                    sb.Insert(0, 0);
                }
                else if (oneCountHead == 1)
                {
                    needCarry = false;
                    sb.Insert(0, 1);
                    sb.Insert(0, ahead.Substring(0, ahead.Length - k));
                    break;
                }
                else
                {
                    sb.Insert(0, ahead.Substring(0, ahead.Length - k + 1));
                    break;
                }
            }
            if (needCarry)
            {
                sb.Insert(0, 1);
            }
            return sb.ToString();
        }
    }
}
