using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class ValidSudoku
    {
        public bool IsValidSupBox(char[][] board, int row, int col)
        {
            int[] counter = new int[10];
            for (int i = row; i < row + 3; i++)
            {
                for (int j = col; j < col + 3; j++)
                {
                    if (board[i][j] != '.')
                    {
                        int num = board[i][j] - '0';
                        counter[num]++;
                        if (counter[num] > 1)
                            return false;
                    }
                }
            }
            return true;
        }

        public bool IsValidSudoku(char[][] board)
        {
            for (int i = 0; i < 9; i++)
            {
                int[] counterI = new int[10];
                int[] counterJ = new int[10];
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] != '.')
                    {
                        int num = board[i][j] - '0';
                        counterI[num]++;
                        if (counterI[num] > 1)
                            return false;
                    }
                    if (board[j][i] != '.')
                    {
                        int num = board[j][i] - '0';
                        counterJ[num]++;
                        if (counterJ[num] > 1)
                            return false;
                    }

                    if (i % 3 == 0 && j % 3 == 0)
                    {
                        if (!IsValidSupBox(board, i, j))
                            return false;
                    }
                }
            }
            return true;
        }
    }
}
