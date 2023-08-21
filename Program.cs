// each question have own branch
int[] DailyTemperatures(int[] temperatures)
{
    var stack = new Stack<(int,int)>();
    stack.Push((0,temperatures[0]));
    temperatures[0] = 0;
    for (int i=1;i < temperatures.Length;i++)
    {
        int val = temperatures[i];
        while (stack.Any() && val > stack.Peek().Item2)
        {
            var current = stack.Pop();
            temperatures[current.Item1] = i - current.Item1;
        }
        temperatures[i] = 0;
        stack.Push((i,val));
    }
    return temperatures;
}