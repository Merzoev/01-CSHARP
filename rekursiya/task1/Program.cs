﻿int Fact(int n)
{
    if (n == 1  || n == 0) 
    {
        Console.WriteLine($"Stop: {n}");
        return 1;
    }
 Console.WriteLine(n);

// Console.WriteLine($"Возврат: n= {n}, fact={Fact (n-1)}");
    
    return n * Fact(n - 1);

}

Console.WriteLine(Fact(5));