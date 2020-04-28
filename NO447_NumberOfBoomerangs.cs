using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingLeetCode
{
    public class NO447_NumberOfBoomerangs
    {
        public int[][] testPoints = new int[3][];
        public int result { get; set; }
        public NO447_NumberOfBoomerangs() 
        {
            testPoints[0] = new int[] { 0, 0 };
            testPoints[1] = new int[] { 1, 0 };
            testPoints[2] = new int[] { 2, 0 };
        }

        public int NumberOfBoomerangs(int[][] points)
        {
            int count = 0;
            int pointscount = points.Count();
            for (int i = 0; i < pointscount; i++)
            {
                Dictionary<double, int> dist = new Dictionary<double, int>();
                for (int m = 0; m < pointscount; m++)
                {
                    if (m != i)
                    {
                        double disIJPow = (points[m][1] - points[i][1]) * (points[m][1] - points[i][1]) + (points[m][0] - points[i][0]) * (points[m][0] - points[i][0]);
                        if (!dist.ContainsKey(disIJPow))
                        {
                            dist.Add(disIJPow, 1);
                        }
                        else
                        {
                            dist[disIJPow]++;
                        }
                    }
                }
                foreach (var item in dist.Keys)
                {
                    count = count + (dist[item] * (dist[item] - 1));
                }
            }
            return count;
        } 
    }
}
