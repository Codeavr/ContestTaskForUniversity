using System;

class Program
{
    static void Main(string[] args)
    {
        var input = Array.ConvertAll(Console.ReadLine().Split(' '), str => double.Parse(str));
        Console.WriteLine(Math.Abs(input[0] - input[1]));
    }
}