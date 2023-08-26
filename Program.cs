// each question have own branch
TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
{
    var current = root;
    while (current is not null)
    {
        if (p.val > current.val && q.val > current.val)
        {
            current = current.right;
        }
        else if (p.val < current.val && q.val < current.val)
        {
            current = current.left;
        }
        else
        {
            return current;
        }
    }
    return current;
}

public class TreeNode
{
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x) { val = x; }
}