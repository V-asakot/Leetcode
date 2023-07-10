// each question have own branch

int EvalRPN(string[] tokens)
{
    var stack = new Stack<int>();

    int MathOperation(Func<int,int,int> predicate)
    {
        int s = stack.Pop(), f = stack.Pop();
        return predicate(f,s);
    }

    foreach (string s in tokens)
    {
        stack.Push(s switch
        {
            "+" => MathOperation((x, y) => x + y),
            "-" => MathOperation((x, y) => x - y),
            "*" => MathOperation((x, y) => x * y),
            "/" => MathOperation((x, y) => x / y),
            _ => int.Parse(s)
        });
    }

    return stack.Pop();
}