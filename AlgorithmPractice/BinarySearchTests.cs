using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace AlgorithmPractice
{
    internal class BinarySearchTests
    {
        public static void RunTests()
        {
            (int[] nums, int target, int expectedIndex)[] testCases = new (int[], int, int)[]
            {
                (new int[] {1, 2, 3, 4, 5}, 3, 2),           // נמצא באמצע
                (new int[] {1, 2, 3, 4, 5}, 1, 0),           // נמצא בתחילת המערך
                (new int[] {1, 2, 3, 4, 5}, 5, 4),           // נמצא בסוף המערך
                (new int[] {1, 2, 3, 4, 5}, 6, -1),          // לא קיים
                (new int[] {}, 1, -1),                       // מערך ריק
                (new int[] {1}, 1, 0),                       // איבר בודד שקיים
                (new int[] {1}, 2, -1),                      // איבר בודד שלא קיים
                (new int[] {2, 4, 6, 8, 10, 12}, 10, 4),     // מספר זוגי איברים
                (new int[] {2, 4, 6, 8, 10, 12}, 7, -1),     // לא קיים, בין שניים
                (new int[] {-5, -2, 0, 3, 6, 10}, -2, 1),     // ערכים שליליים
            };

            Console.WriteLine("Running BinarySearch tests:\n");

            for (int i = 0; i < testCases.Length; i++)
            {
                var (nums, target, expectedIndex) = testCases[i];
                int actual = BinarySearch.BinSearch(nums, target);

                Console.WriteLine($"Test {i + 1}: nums = [{string.Join(", ", nums)}], target = {target}");
                Console.WriteLine($"  Expected: {expectedIndex}, Actual: {actual}");
                Console.WriteLine(actual == expectedIndex ? "  ✅ Passed\n" : "  ❌ Failed\n");
            }
        }
    }
}
