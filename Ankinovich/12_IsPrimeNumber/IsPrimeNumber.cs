using System;

class Program
{
    static bool IsPrime(int n)
    {
        if (n < 2) 
        {
            return false;
        }

        for (int i = 2, limit = (int)Math.Ceiling(Math.Sqrt(n)); i <= limit; i++)
        {
            if (n % i == 0 && n != i)
            {
                return false;
            }
        }

        return true;
    }
    
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(IsPrime(n) ? "+" : "-");
    }
}
