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
            if (k !=0 && k<= length && length < 11)
            {
                result += b[k-1].ToString();
                Console.WriteLine(result);
            }         
            Console.Read();
        }
    }
}