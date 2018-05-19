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
            int c = int.Parse(data[2]);
            int max = 0;
            int min = 0;
            int d = 0;
            if (a > b && a > c)
            {
                max = a;
                if (b < c)
                {
                    min = b;
                    d = c;
                }
                else
                {
                    min = c;
                    d = b;
                }
            }
            else if (b > c)
            {
                max = b;
                if (a < c)
                {
                    min = a;
                    d = c;
                }
                else
                {
                    min = c;
                    d = a;
                }
            }
            else
            {
                max = c;
                if (a < b)
                {
                    min = a;
                    d = b;
                }
                else
                {
                    min = b;
                    d = a;
                }
            }
            if (a>=0 && b>=0 && c >= 0)
            {
                Console.WriteLine((Convert.ToDouble(min + max) / d).ToString());
            }
            Console.Read();
        }
    }
}