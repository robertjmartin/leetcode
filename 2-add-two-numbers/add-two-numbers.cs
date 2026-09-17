/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        bool done = false;
        ListNode result = null;
        ListNode cur = null;
        int carry = 0;

        while (!done)
        {
            if (l1 == null && l2 == null && carry == 0)
            {
                done = true;
                break;
            }

            int value1 = l1 != null ? l1.val : 0;
            int value2 = l2 != null ? l2.val : 0;
            int resultDigit = carry + value1 + value2;
            carry = 0;

            if (resultDigit > 9)
            {
                resultDigit -= 10;
                carry = 1;
            }

            if (resultDigit > 9)
            {
                throw new Exception("Invalid Input 0 <= Node.val <= 9 not true");
            }

            if (result == null)
            {
                result = new ListNode(resultDigit);
                cur = result;
            }
            else
            {
                cur.next = new ListNode(resultDigit);
                cur = cur.next;
            }
    
            l1 = l1?.next;
            l2 = l2?.next;            
        }

        return result;
    }
}