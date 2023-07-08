// each question have own branch

using System.Reflection.Emit;

bool IsBalanced(TreeNode root)
{

    (bool, int) dfs(TreeNode root)
    {
        if (root == null) return (true, 0);
        var l = dfs(root.left);
        var r = dfs(root.right);
        int rvalue = r.Item2, lvalue = l.Item2;
        var pair = lvalue > rvalue ? (lvalue, rvalue) : (rvalue, lvalue);//item1 - max,item2 - min
        bool isBalanced = l.Item1 && r.Item1 && pair.Item1 - pair.Item2 <= 1;

        return (isBalanced, pair.Item1 + 1);
    }

    return dfs(root).Item1;
}

class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
