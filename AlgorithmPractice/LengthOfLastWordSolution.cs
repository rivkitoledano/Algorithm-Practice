using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class LengthOfLastWordSolution
    {
        public int LengthOfLastWord(string s)
        {
            string sRes = s.TrimEnd();
            return sRes.Substring(sRes.LastIndexOf(' ') + 1).Length;
        }
    }
}
