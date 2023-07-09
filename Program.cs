// each question have own branch

var q = new KthLargest(1,new int[0]);
q.Add(-3);
q.Add(-2);
q.Add(-4);
q.Add(0);
q.Add(4);

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
