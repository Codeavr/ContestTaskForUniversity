using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            int b = int.Parse(data[1]);
            int max = b + a;
            string result = "x:";
            if (max > 0)
            {
                for (int i = 0; i < max; i++)
                {
                    result += " " + i.ToString();
                }
                Console.WriteLine(result);
            }
            else Console.WriteLine("NULL");
            Console.Read();
        }
    }
}