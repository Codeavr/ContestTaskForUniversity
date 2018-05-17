using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        var substring = Console.ReadLine();
        var text = Console.ReadLine();

        Console.WriteLine(Regex.Matches(text, substring).Count);
    }
}