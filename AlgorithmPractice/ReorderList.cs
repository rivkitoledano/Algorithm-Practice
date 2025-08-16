﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AlgorithmPractice.AddTwoNumbersSolution;

namespace AlgorithmPractice
{
    internal class ReorderList
    {
        public void ReorderListSol(ListNode head)
        {
            if (head == null || head.next == null) return;
            ListNode slow = head, fast = head;
            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            ListNode prev = null, curr = slow.next;
            slow.next = null;
            while (curr != null)
            {
                ListNode nextTemp = curr.next;
                curr.next = prev;
                prev = curr;
                curr = nextTemp;
            }
            ListNode first = head, second = prev;
            while (second != null)
            {
                ListNode tmp1 = first.next;
                ListNode tmp2 = second.next;

                first.next = second;
                second.next = tmp1;

                first = tmp1;
                second = tmp2;
            }
        }
    }
}
