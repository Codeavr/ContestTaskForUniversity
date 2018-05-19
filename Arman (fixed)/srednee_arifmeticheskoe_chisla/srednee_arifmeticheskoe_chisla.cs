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
            string result = "";
            if (length < 10)
            {
                int sum = 0;
                for (int i = 0; i < length; i++)
                {
                    sum += b[i];
                }
                result = (Convert.ToDouble(sum) / length).ToString();
            }
            Console.WriteLine(result);
            Console.Read();
        }
    }
}