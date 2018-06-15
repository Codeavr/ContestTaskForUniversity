using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), s => int.Parse(s));

        int value = 0;

        for (int i = 0; i < array.Length; i++)
        {
            value += array[i] * (1 << array.Length - 1 - i);
        }

        Console.WriteLine(value);
    }
}