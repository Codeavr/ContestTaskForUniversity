using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int s = int.Parse(data[0]);
            int v = int.Parse(data[1]);
            int t = int.Parse(data[2]);
            if (s == 0)
            {
                if (v > 0 && t > 0 )
                {
                    Console.WriteLine("s=" + (v * t).ToString());
                }
            }
            if (v == 0)
            {
                if (s > 0 && t > 0)
                {
                    Console.WriteLine("v=" + (Convert.ToDouble(s) / t).ToString());
                }
            }
            if (t == 0)
            {
                if (v > 0 && s > 0)
                {
                    Console.WriteLine("t=" + (Convert.ToDouble(s) / v).ToString());
                }
            }
            Console.Read();
        }
    }
}