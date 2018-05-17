using System;

class Program
{
    static void Main(string[] args)
    {
        var shift  = int.Parse(Console.ReadLine());
        var array = Console.ReadLine().Split();
        if (shift < 0)
        {
            var temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;
        }
        else if (shift > 0)
        {
            var temp = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = temp;
        }
        Console.WriteLine(string.Join(" ", array));
    }
}