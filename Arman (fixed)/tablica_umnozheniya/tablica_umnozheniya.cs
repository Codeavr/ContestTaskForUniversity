using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int a = int.Parse(data[0]);
            string result="";
            for (int i = 2; i < 10; i++)
            {
                result += a.ToString() + "*" + i.ToString() + "=" + (a * i).ToString()+"\n";
            }
            result = result.Substring(0, result.Length - 1);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}