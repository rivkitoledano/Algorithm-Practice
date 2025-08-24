using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlgorithmPractice.AddTwoNumbersSolution;

namespace AlgorithmPractice
{
    internal class HasCycleSolution
    {
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false; 
            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
                if (slow == fast) return true; 
            }

            return false; 
        }
    }
}
