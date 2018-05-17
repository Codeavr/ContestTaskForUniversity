using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int n = int.Parse(data[0]);
            int m = int.Parse(data[1]);
            string result = "";
            if (n<m && n>=1 && m>=1 && n<=100 && m<=100)
            {
                for (int i = n; i <= m; i++)
                {
                    result += i.ToString() + " ";
                }
                result = result.Substring(0, result.Length - 1);
                Console.WriteLine(result);
            }     
        }
    }
}