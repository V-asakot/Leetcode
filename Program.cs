class MinStack
{
    private readonly LinkedList<int> _stack;
    private readonly LinkedList<int> _minStack;
    public MinStack()
    {
        _stack = new LinkedList<int>();
        _minStack = new LinkedList<int>();
    }

    public void Push(int val)
    {
        if (_minStack.Count == 0)
        {
            _minStack.AddFirst(val);
        }
        else
        {
            var min = _minStack.First.Value;
            if(min >= val) _minStack.AddFirst(val);
        }
        _stack.AddFirst(val);
    }

    public void Pop()
    {
        var val = _stack.First.Value;
        if(_minStack.First.Value == val) _minStack.RemoveFirst();
        _stack.RemoveFirst();
    }

    public int Top()
    {
        return _stack.First.Value;
    }

    public int GetMin()
    {
        return _minStack.First.Value;
    }
}