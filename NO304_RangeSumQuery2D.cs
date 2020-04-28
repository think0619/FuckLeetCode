using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingLeetCode
{
    class NO304_RangeSumQuery2D
    {

    }

    public class NumMatrix
    {
        public int[][] matrixA { get; set; }

        public NumMatrix(int[][] matrix)
        {
            matrixA = new int[matrix.Length][];
            for (int i = 0; i < matrixA.Length; i++)
            {
                matrixA[i] = new int[matrix[0].Length + 1];
            }

            if (matrix != null)
            {
                for (int r = 0; r < matrix.Length; r++)
                {
                    for (int c = 0; c < matrix[0].Length; c++)
                    {
                        matrixA[r][c + 1] = matrix[r][c] + matrixA[r][c];
                    }
                }
            }
        }

        public int SumRegion(int row1, int col1, int row2, int col2)
        {
            int result = 0;
            if (matrixA != null && (row1 < matrixA.Length && row2 < matrixA.Length && col1 < matrixA[0].Length && col2 < matrixA[0].Length))
            {
                for (int rowIndex = row1; rowIndex <= row2; rowIndex++)
                {
                    result += matrixA[rowIndex][col2 + 1] - matrixA[rowIndex][col1];
                }
            }
            return result;
        }
    }
}
