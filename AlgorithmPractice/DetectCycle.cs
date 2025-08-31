using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlgorithmPractice.AddTwoNumbersSolution;

namespace AlgorithmPractice
{
    internal class DetectCycle
    {
        public ListNode DetectCycleSolution(ListNode head)
        {
            ListNode slow = head;
            ListNode fast = head;
            bool isExists = false;
            while (fast != null && fast.next != null)
            {

                slow = slow.next;
                fast = fast.next.next;
                if (fast == slow)
                {
                    isExists = true;
                    break;
                }
            }

            if (isExists)
            {
                fast = head;
                while (fast != slow)
                {
                    slow = slow.next;
                    fast = fast.next;
                }
                return fast;
            }
            return null;

        }
    }
}
