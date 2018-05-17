using System;

class Program
{
    static void Main(string[] args)
    {
        var size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        for (int i = 0; i < size; i++)
        {
            var line = Console.ReadLine().Split();
            for (int j = 0; j < line.Length; j++)
            {
                matrix[i, j] = int.Parse(line[j]);
            }
        }

        int primarySum = 0;
        for (int i = 0; i < size; i++)
        {
            primarySum += matrix[i, i];
        }

        int secondarySum = 0;
        for (int i = 0; i < size; i++)
        {
            secondarySum += matrix[size - i - 1, i];
        }

        Console.WriteLine(primarySum + " " + secondarySum);
    }
}