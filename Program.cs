// each question have own branch

int LastStoneWeight(int[] stones)
{
    var queue = new PriorityQueue<int, int>(Comparer<int>.Create((x,y) => y - x));
    foreach (var stone in stones) queue.Enqueue(stone, stone);
    while (queue.Count > 1)
    {
        int max = queue.Dequeue();
        int max_second = queue.Dequeue();
        int diff = max - max_second;
        if (diff > 0) queue.Enqueue(diff, diff);
    }
    if (queue.Count == 0) return 0;
    else return queue.Dequeue();
}