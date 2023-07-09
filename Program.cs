// each question have own branch

class Node
{
    public readonly HashSet<Node> children;
    public bool endOfWord;

    public Node()
    {
        children = new HashSet<Node>();
    }
}
class Trie
{
    private readonly Node head;
    public Trie()
    {
        head = new Node();
    }

    public void Insert(string word)
    {
        var cur = head;
        foreach (var ch in word)
        {
            int index = GetCharIndex(ch);
            if (cur.children[index] is null)
                cur.children[index] = new Node();
            cur = cur.children[index];
        }

        cur.endOfWord = true;
    }

    public bool Search(string word)
    {
        var cur = head;
        foreach (var ch in word)
        {
            int index = GetCharIndex(ch);
            if (cur.children[index] is null)
                return false;
            cur = cur.children[index];
        }

        return cur.endOfWord;
    }

    public bool StartsWith(string prefix)
    {
        var cur = head;
        foreach (var ch in prefix)
        {
            int index = GetCharIndex(ch);
            if (cur.children[index] is null)
                return false;
            cur = cur.children[index];
        }

        return true;
    }

    private int GetCharIndex(char ch) => ((int)ch) - 97;
}