using System;

class Program
{
    static string GetSeason(int month)
    {
        if (month <= 2 || month == 12)
        {
            return "Зима";
        }
        if (month <= 5)
        {
            return "Весна";
        }
        if (month <= 8)
        {
            return "Лето";
        }
        if (month <= 11)
        {
            return "Осень";
        }
        throw new ArgumentOutOfRangeException(nameof(month));
    }

    static void Main(string[] args)
    {
        var monthNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(GetSeason(monthNumber));
    }
}