using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

        Array.Sort(array);

        var middle = array.Length / 2;

        var median = array.Length % 2 != 0 ?
                        array[middle] :
                        (array[middle - 1] + array[middle]) / 2.0;

        Console.WriteLine(median);
    }
}
