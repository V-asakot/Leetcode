// each question have own branch

int[][] KClosest(int[][] points, int k)
{
    var res = new int[k][];
    var queue = new PriorityQueue<int[], int>(Comparer<int>.Create((x, y) => y - x));
    foreach (var point in points)
    {
        var weighted = point[0] * point[0] + point[1] * point[1];
        queue.Enqueue(point, weighted);
    }

    for(int i = 0; i < k; i++)
    {
        res[i] = queue.Dequeue();
    }

    return res;
}