// each question have own branch
ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    var dummy = new ListNode();
    int carry = 0;
    var current = dummy;
    while (l1 != null || l2 != null)
    {
        int valueLeft = l1?.val ?? 0;
        int valueRight = l2?.val ?? 0;
        int value = valueLeft + valueRight + carry;
        carry = value / 10;
        value = value % 10;

        current.next = l1 ?? l2;
        current.next.val = value;
        current = current.next;

        l1 = l1?.next;
        l2 = l2?.next;
    }

    if (carry > 0)
    {
        current.next = new ListNode(1);
    }
    return dummy.next;
}

class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null) 
    { 
        this.val = val;
        this.next = next;
    } 
}