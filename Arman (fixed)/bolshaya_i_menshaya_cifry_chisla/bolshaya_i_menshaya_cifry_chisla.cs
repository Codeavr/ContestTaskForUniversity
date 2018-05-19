using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int length = data[0].Length;
            int[] b = new int[length];
            int _i = 0;
            foreach (char c in data[0])
            {
                b[_i] = int.Parse(c.ToString());
                _i++;
            }
            string result;
            if (length != 1)
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
                if (min != max)
                {
                    result = "MIN=" + min.ToString() + " MAX=" + max.ToString();
                }
                else
                {
                    result = "MIN=MAX=" + max.ToString();
                }
                
            }
            else result = "MIN=MAX=" + data[0];
            Console.WriteLine(result);
            Console.Read();
        }
    }
}