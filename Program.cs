// each question have own branch

Node CopyRandomList(Node head)
{
    var dict = new Dictionary<Node, Node?>();
    var cur = head;
    while (cur != null)
    {
        var copy = new Node(cur.val);
        dict.Add(cur, copy);
        cur = cur.next;
    }
    cur = head;
    while (cur != null)
    {
        var copy = dict[cur];
        copy.next = cur.next is not null ? dict[cur.next] : null;
        copy.random = cur.random is not null ? dict[cur.random] : null;
        cur = cur.next;
    }
    return head is not null ? dict[head] : null;
}

public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}