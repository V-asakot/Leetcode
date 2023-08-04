// each question have own branch

ListNode RemoveNthFromEnd(ListNode head, int n)
{
    var dummy = new ListNode(next: head);
    var slow = dummy;
    var fast = head;
    while (n > 0 && fast != null)
    {
        fast = fast.next;
        n--; 
    }

    while (fast != null)
    {
        fast = fast.next;
        slow = slow.next;
    }

    slow.next = slow.next.next;
    return dummy.next;
}

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