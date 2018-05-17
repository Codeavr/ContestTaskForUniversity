using System;

class Program
{
    static void Main(string[] args)
    {
        var target = int.Parse(Console.ReadLine());
        var array = Array.ConvertAll(Console.ReadLine().Split(), raw => int.Parse(raw));
        Console.WriteLine(Array.IndexOf(array, target));
    }
}