using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            string a = data[0];
            string b = data[1];
            if (a != b)
            {
                Console.WriteLine(a + b);
            }
            else
            {
                Console.WriteLine("SAME");
            }
        }
    }
}