using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            int n = int.Parse(data[1]);
            if (data[0].Length > 0 && data[0].Length < 10 && n >= 0 && n <= 10)
            {
                for (int i = 0; i < n; i++)
                {
                    a = a * 2;
                }
                Console.WriteLine(a.ToString());
            } 
            Console.Read();
        }
    }
}
