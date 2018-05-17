using System;

class Program
{
    public static int GetGcd(int a, int b)
    {
        return b != 0 ? GetGcd(b, a % b) : a;
    }

    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split();

        int gcd = GetGcd(int.Parse(input[0]), int.Parse(input[1]));

        Console.WriteLine(gcd);
    }
}