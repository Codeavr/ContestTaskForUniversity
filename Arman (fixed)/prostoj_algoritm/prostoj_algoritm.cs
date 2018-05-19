using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            if (a>0 && data[0].Length > 0 && data[0].Length < 10)
            {
                if (((a + 100) / (a * 2)) > ((a * 3) / (a + 2)))
                {
                    Console.WriteLine("YES");
                }
                else Console.WriteLine("NO");
            }
            Console.Read();
        }
    }
}