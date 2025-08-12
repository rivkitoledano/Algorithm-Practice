using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class LargestNumverSolution
    {
        public string LargestNumber(int[] nums)
        {
            string[] arr = nums.Select(n => n.ToString()).ToArray();

            Array.Sort(arr, (a, b) => (b + a).CompareTo(a + b));

            if (arr[0] == "0") return "0";

            return string.Join("", arr);
        }
    }
}
