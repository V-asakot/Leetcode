// each question have own branch

int EvalRPN(string[] tokens)
{
    var stack = new Stack<int>();

    void MathOperation(Func<int,int,int> predicate)
    {
        int s = stack.Pop(), f = stack.Pop();
        stack.Push(predicate(f,s));
    }

    foreach (string s in tokens)
    {
        switch (s)
        {
            case "+":
                MathOperation((x, y) => x + y); break;
            case "-":
                MathOperation((x, y) => x - y); break;
            case "*":
                MathOperation((x, y) => x * y); break;
            case "/":
                MathOperation((x, y) => x / y); break;
            default: 
                stack.Push(int.Parse(s)); break;
        }
    }

    return stack.Pop();
}