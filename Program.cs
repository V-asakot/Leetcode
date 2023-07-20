// each question have own branch
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public void ReorderList(ListNode head)
    {
        //find middle
        ListNode slow = head, fast = head.next;
        while (fast is not null && fast.next is not null)
        {
            slow = slow.next;
            fast = fast.next.next;
        }

        //reverse second  half
        var second = slow.next;
        var prev = slow.next = null;
        while (second is not null)
        {
            var tmp = second.next;
            second.next = prev;
            prev = second;
            second = tmp;
        }
        //merge two halfs
        var first = head;
        second = prev;
        while (second is not null)
        {
            var tmp1 = first.next;
            var tmp2 = second.next;
            first.next = second;
            second.next = tmp1;
            first = tmp1;
            second = tmp2;
        }
    }
}