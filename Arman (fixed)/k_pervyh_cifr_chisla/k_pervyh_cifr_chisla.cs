using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int length = data[0].Length;
            int k = int.Parse(data[1]);
            int[] b = new int[length];
            int _i = 0;
            foreach (char c in data[0])
            {
                b[_i] = int.Parse(c.ToString());
                _i++;
            }
            string result = "";
            if (k <= length && length < 10)
            {
                int[] b_k = new int[k];
                Array.Copy(b, b_k, k);
                for (int i = 0; i < k; i++)
                {
                    result += b_k[i].ToString();
                }
                Console.WriteLine(result);
            }
            Console.Read();
        }
    }
}