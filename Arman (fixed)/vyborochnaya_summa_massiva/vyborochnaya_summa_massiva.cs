using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int[] a = new int[data.Length];
            string result ="SUM=";
            int sum=0;
            for (int i = 0; i < data.Length; i++)
            {
                a[i] = int.Parse(data[i]);
                if (IsEven(a[i]))
                {
                    sum += a[i];
                }   
            }
            if (sum > 0)
            {
                result += sum.ToString();
            }
            else result ="NULL";
            Console.WriteLine(result);
            Console.Read();
        }

        static bool IsEven(int a)
        {
            return (a % 2) == 0;
        }
    }
}