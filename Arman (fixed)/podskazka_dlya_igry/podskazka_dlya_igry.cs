using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int x = int.Parse(data[0]);
            string result = "";
            if (x>=1 && x <= 9)
            {
                if (x >= 5)
                {
                    result += "x>=5 ";
                    if (x >= 7)
                    {
                        result += "x>=7";
                    }
                    else
                    {
                        result += "x<=7";
                    }
                }
                else
                {
                    result += "x<=5 ";
                    if (x >= 3)
                    {
                        result += "x>=3";
                    }
                    else
                    {
                        result += "x<=3";
                    }
                }
                Console.WriteLine(result);
            }     
        }
    }
}