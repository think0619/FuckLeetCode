using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingLeetCode
{
    class NO002_Add_Two_Numbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode result = new ListNode(0);
            ListNode resultFlag = result;

            while (l1 != null || l2 != null)
            {  
                if (l1 != null)
                {
                    result.val += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    result.val += l2.val;
                    l2 = l2.next;
                }
                if (result.val < 10)
                { 
                    if (l1 != null || l2 != null)
                    {
                        ListNode nextNode = new ListNode(0);
                        result.next = nextNode;
                        result = result.next;
                    }
                }
                else
                {
                    result.val -= 10;
                    ListNode nextNode = new ListNode(1);
                    result.next = nextNode;
                    result = result.next; 
                }
            }

            return resultFlag;
        }
    }
}
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
  