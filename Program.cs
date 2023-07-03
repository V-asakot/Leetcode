// each question have own branch
int DiameterOfBinaryTree(TreeNode root)
{
    int max = 0;
    int BFS(TreeNode root)
    {
        if (root is null) return -1;
        int l = BFS(root.left);
        int r = BFS(root.right);
        max = Math.Max(max, 2 + l + r);
        return (l > r ? l : r) + 1;
    }

    BFS(root);
    return max;
}

public class TreeNode
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