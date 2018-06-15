using System;

class Program
{
    static void Main(string[] args)
    {
        string str = Console.ReadLine();
        int[] limits = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));

        Console.WriteLine(str.Substring(limits[0], limits[1] - limits[0] + 1));
    }
}