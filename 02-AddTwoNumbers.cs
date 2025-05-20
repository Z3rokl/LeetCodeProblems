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
        var resultList = new ListNode();
        ListNode previousNode = null;
        short aux = 0;

        do
        {
            var newNode = new ListNode();

            newNode.val = (l1?.val ?? 0) + (l2?.val ?? 0) + aux;

            if(newNode.val >= 10){
                aux = 1;
                newNode.val = newNode.val -10;
            }
            else
                aux = 0;
            
            if(previousNode == null)
            {
                resultList = newNode;
                previousNode = newNode;
            }
            else{
                previousNode.next = newNode;
                previousNode = newNode;
            }
            l1 = l1?.next ?? null;
            l2 = l2?.next ?? null;
        } while(l1 != null || l2 != null || aux != 0);
        return resultList;
    }
}