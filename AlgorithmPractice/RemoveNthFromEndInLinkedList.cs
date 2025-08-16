using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlgorithmPractice.AddTwoNumbersSolution;

namespace AlgorithmPractice
{
    internal class RemoveNthFromEndInLinkedList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode dummy = new ListNode(0, head);
            ListNode tail = head;

            int length = 0;
            while (tail != null)
            {
                tail = tail.next;
                length++;
            }

            int steps = length - n;
            tail = dummy;  

            for (int i = 0; i < steps; i++)
            {
                tail = tail.next;
            }

            tail.next = tail.next.next;

            return dummy.next;

        }

    }
}
