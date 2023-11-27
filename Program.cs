bool IsHappy(int n) 
{
    var hash = new HashSet<int>();
    while(!hash.Contains(n))
    {
        if(n == 1)
        {
            return true;
        }
        hash.Add(n);
        
        var sum = 0;
        while(n > 0)
        {
            var temp = n % 10;
            sum += temp * temp;
            n /= 10;
        }
        n = sum;
    }

    return false;
}

