// each question have own branch

int FindKthLargest(int[] nums, int k)
{
    var queue = new PriorityQueue<int, int>(nums.Length);
    foreach (var num in nums)
    {
        queue.Enqueue(num, num);
        if(queue.Count > k) queue.Dequeue();
    }

    var res = queue.Dequeue();
    return res;
}