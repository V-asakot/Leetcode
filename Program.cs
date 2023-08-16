// each question have own branch
Node CloneGraph(Node node)
{
    if (node is null) return null;
    var dict = new Dictionary<Node, Node>();

    Node DFS(Node node)
    {
        if (dict.ContainsKey(node))
        {
            return dict[node];
        }

        var clone = new Node(node.val);
        dict.Add(node, clone);
        foreach (var neighbor in node.neighbors)
        {
            clone.neighbors.Add(DFS(neighbor));
        }

        return clone;
    }
    return DFS(node);
}

class Node
{
    public int val;
    public IList<Node> neighbors;

    public Node()
    {
        val = 0;
        neighbors = new List<Node>();
    }

    public Node(int _val)
    {
        val = _val;
        neighbors = new List<Node>();
    }

    public Node(int _val, List<Node> _neighbors)
    {
        val = _val;
        neighbors = _neighbors;
    }
}
