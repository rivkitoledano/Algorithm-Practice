using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class SearchInMatrix
    {
        public bool SearchMatrix(int[][] matrix, int target)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            int row = 0;
            int col = cols - 1;

            while (row < rows && col >= 0)
            {
                int val = matrix[row][col];

                if (val == target)
                {
                    return true;
                }
                else if (val > target)
                {
                    col--;
                }
                else
                {
                    row++;
                }
            }

            return false;
        }

    }
    }
