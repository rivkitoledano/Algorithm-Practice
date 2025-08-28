using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    internal class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            string shortWord = strs.Aggregate((w1, w2) => w1.Length < w2.Length ? w1 : w2);
            for (int i = 0; i < strs.Length; i++)
            {
                string currentWord = strs[i];
                int loopLength = Math.Min(currentWord.Length, shortWord.Length);
                for (int j = 0; j < loopLength; j++)
                {
                    if (shortWord[j] != currentWord[j])
                    {
                        shortWord = shortWord.Substring(0, j);
                        break;
                    }
                }
            }
            return shortWord;
        }
    }
}
