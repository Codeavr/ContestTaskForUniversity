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
            string result = a.ToString();
            int m = b - a;
            if ( m>1 && a>0 && b>0 && a<100 && b<100)
            {
                for (int i = a; i+m < 100;)
                {
                    i = i + m;
                    result += " " + i.ToString();
                }
                Console.WriteLine(result);
            }     
        }
    }
}