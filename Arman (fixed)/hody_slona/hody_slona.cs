using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int x1 = int.Parse(data[0]);
            int y1 = int.Parse(data[1]);
            int x2 = int.Parse(data[2]);
            int y2 = int.Parse(data[3]);
            string result = "";
            if ( x1>=1 && x1<=8 && y1>=1 && y1<=8 && x2>=1 && x2<=8 && y2>=1 && y2<=8)
            {
                int maxx = Math.Max(x1, x2);
                int maxy = Math.Max(y1, y2);
                int minx = Math.Min(x1, x2);
                int miny = Math.Min(y1, y2);
                if (maxx - minx == maxy - miny)
                {
                    result = "YES";
                }
                else
                {
                    result = "NO";
                }
                Console.WriteLine(result);
            }     
        }
    }
}