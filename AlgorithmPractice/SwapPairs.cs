using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlgorithmPractice.AddTwoNumbersSolution;

namespace AlgorithmPractice
{
    internal class SwapPairs
    {
        public ListNode SwapPairsSol(ListNode head)
        {
            ListNode tmp = new ListNode(0, head);
            ListNode prev = tmp;
            while (prev.next != null && prev.next.next != null)
            {
                ListNode first = prev.next;
                ListNode second = prev.next.next;
                first.next = second.next;
                second.next = first;
                prev.next = second;
                prev = first;
            }
            return tmp.next;
        }
    }
}
