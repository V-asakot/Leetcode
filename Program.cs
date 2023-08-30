// each question have own branch

int FindKthLargest(int[] nums, int k)
{
    var queue = new PriorityQueue<int, int>(Comparer<int>.Create((x, y) => y - x));
    foreach (var num in nums)
    {
        queue.Enqueue(num, num);
    }

    var res = queue.Dequeue();
    for (int i=1;i<k;i++)
    {
        res = queue.Dequeue();
    }
    return res;
}