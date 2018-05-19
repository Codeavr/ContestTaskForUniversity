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
            if (data[0].Length > 0 && data[0].Length < 9)
            {
                switch (k)
                {
                    case 1:
                        Console.WriteLine((a * a).ToString());
                        break;
                    case 2:
                        Console.WriteLine((a * a * a).ToString());
                        break;
                    case 3:
                        Console.WriteLine((a * 2).ToString());
                        break;
                    case 4:
                        Console.WriteLine((a * 3).ToString());
                        break;
                }
            }
            Console.Read();
        }
    }
}