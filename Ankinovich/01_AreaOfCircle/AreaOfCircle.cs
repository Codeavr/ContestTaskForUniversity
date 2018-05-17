using System;

class Program
{
    static void Main(string[] args)
    {
        double r = double.Parse(Console.ReadLine()) / 2.0;
        Console.WriteLine(Math.Round(r * r * Math.PI, 2));
    }
}