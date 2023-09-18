// each question have own branch

 IList<IList<int>> LevelOrder(TreeNode root) 
 {
    var result = new List<IList<int>>();
    var queue = new Queue<TreeNode>();
    
    while(queue.Count > 0)
    {
        var curLength = queue.Count;
        List<int> level = new();
        for(int i = 0;i < curLength; i++)
        {
            var node = queue.Dequeue();
            if(node is not null)
            {
                level.Add(node.val);
                queue.Enqueue(node.left);
                queue.Enqueue(node.right);
            }
        }
        if(level.Count > 0) 
            result.Add(level);
        
    }

    return result;
 }

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

