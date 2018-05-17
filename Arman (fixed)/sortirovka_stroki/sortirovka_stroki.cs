using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int length = data.Length;
            int temp;
            string stemp;
            for (int i = 0; i < length; i++)
            {
                for (int j = i; j < length; j++)
                {
                    if (data[j].Length < data[i].Length)
                    {
                        temp = data[i].Length;
                        stemp = data[i];
                        data[i] = data[j];
                        data[j] = stemp;
                    }
                }
            }
            string result = "";
            for (int i = 0; i < length; i++)
            {
                result += data[i].ToString() + " ";
            }
            result = result.Substring(0, result.Length - 1);
            Console.WriteLine(result);
        }
    }
}