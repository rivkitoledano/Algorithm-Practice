using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace AlgorithmPractice
{
    internal class MajorityElementTests
    {
        public static void RunTests()
        {
            int[][] testCases = new int[][]
            {
                new int[] {3, 3, 4, 2, 4, 4, 2, 4, 4},    // 4 מופיע 5 פעמים
                new int[] {2, 2, 1, 1, 1, 2, 2},          // 2 מופיע 4 פעמים
                new int[] {1, 1, 1, 1, 2, 3, 4},          // 1 מופיע 4 פעמים
                new int[] {5, 5, 5, 5, 5},                // כל המספרים זהים
                new int[] {10},                           // רק איבר אחד
                new int[] {6, 7, 6, 7, 6, 7, 6},          // 6 מופיע 4 פעמים
                new int[] {9, 9, 9, 8, 8},                // 9 מופיע 3 פעמים מתוך 5
                new int[] {1, 2, 3, 1, 1, 1},             // 1 מופיע 4 פעמים
                new int[] {2, 2, 2, 2, 3, 3, 3},          // 2 מופיע 4 פעמים
                new int[] {4, 5, 4, 4, 6, 4, 4},          // 4 מופיע 5 פעמים
            };

            Console.WriteLine("Running MajorityElement tests:\n");

            for (int i = 0; i < testCases.Length; i++)
            {
                var arr = testCases[i];
                int result = MajorityElement.MajorityElementSolution(arr);

                Console.WriteLine($"Test case {i + 1}: [{string.Join(", ", arr)}]");
                Console.WriteLine($"  Majority element: {result}");
                Console.WriteLine();
            }
        }
    }
}
