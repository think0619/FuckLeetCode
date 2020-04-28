using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuckingLeetCode
{
    class NO019_Remove_Nth_Node_From_End_of_List
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)  {  return null; }
            if (head.next == null && n == 1)  { return null; }

            ListNode headTemp = head;
            int count = 0;
            while (headTemp != null)
            {
                count++;
                headTemp = headTemp.next;
            } 

            ListNode firstNode = head;
            ListNode secondNode = null;
            int nIndex = count - n;
            int k = 0;
            while (firstNode != null)
            {
                if (k != nIndex)
                {
                    secondNode = firstNode;
                    firstNode = firstNode.next;
                    k++;
                }
                else
                {
                    if (k == 0)
                    { 
                        head = head.next;
                    }
                    else
                    { 
                        secondNode.next = firstNode.next;
                    }
                    break;
                } 
            }
            return head;
        } 
    }


    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int x) { val = x; }
    }
}
