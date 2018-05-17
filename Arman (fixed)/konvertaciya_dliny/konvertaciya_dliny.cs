using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            int k = int.Parse(data[1]);
            switch (k)
            {
                case 1:
                    Console.WriteLine((a * 1000).ToString());
                    break;
                case 2:
                    Console.WriteLine((a * 10000).ToString());
                    break;
                case 3:
                    Console.WriteLine((a * 100000).ToString());
                    break;
            }
        }
    }
}