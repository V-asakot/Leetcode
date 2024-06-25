
public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
 
public class Solution
{
    private int GoodNode(TreeNode root, int max) 
    {
        if (root is null) return 0;
        var result = root.val >= max ? 1 : 0;
        max = max > root.val ? max : root.val;
        result += GoodNode(root.right, max);
        result += GoodNode(root.left, max);
        return result;
    }

    public int GoodNodes(TreeNode root)
    {
         return 1 + GoodNode(root.left, root.val) + GoodNode(root.right, root.val);
    }
}