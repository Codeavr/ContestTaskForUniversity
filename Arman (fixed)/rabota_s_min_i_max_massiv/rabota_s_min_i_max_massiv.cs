using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int length = data.Length - 1;
            int[] b = new int[length];
            for (int i = 0; i < length; i++)
            {
                b[i] = int.Parse(data[i]);
            }
            int a = int.Parse(data[length]);
            string result = "";
            if (length == 10 && a>=-100 && a<=100)
            {
                int min = b[0], minIndex = 0;
                for (int i = 0; i < length; i++)
                {
                    if (min > b[i])
                    {
                        min = b[i];
                        minIndex = i;
                    }
                }

                int max = b[0], maxIndex = 0;
                for (int i = 0; i < length; i++)
                {
                    if (max < b[i])
                    {
                        max = b[i];
                        maxIndex = i;
                    }
                }

                if (a < min)
                {
                    for (int i = 0; i < length; i++)
                    {
                        b[i] = min;
                        result += b[i].ToString() + " ";
                    }
                }
                else
                {
                    for (int i = 0; i < length; i++)
                    {
                        b[i] = max;
                        result += b[i].ToString() + " ";
                    }
                }
                result = result.Substring(0, result.Length - 1);
            }
            Console.WriteLine(result);
            Console.Read();
        }
    }
}