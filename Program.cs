// each question have own branch

class KthLargest
{
    private readonly PriorityQueue<int,int> _queue;
    private readonly int _k;
   public KthLargest(int k, int[] nums)
    {
        _queue = new PriorityQueue<int, int>();
        _k = k;
        foreach (var num in nums)
        {
            _queue.Enqueue(num,num);
        }

        while (_queue.Count > k)
        {
            _queue.Dequeue();
        }
    }

    public int Add(int val)
    {
        _queue.Enqueue(val, val);
        while (_queue.Count > _k)
        {
            _queue.Dequeue();
        }
        return _queue.Peek();
    }

}
