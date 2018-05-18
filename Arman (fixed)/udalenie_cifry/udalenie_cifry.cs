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

            int length = data[0].Length;
            int[] b = new int[length];
            int _i = 0;
            foreach (char c in data[0])
            {
                b[_i] = int.Parse(c.ToString());
                _i++;
            }
            string result = "";
            if (length<10 && m<10 && m>=0)
            {
                for (int i = 0; i < length; i++)
                {
                    if (b[i] != m)
                    {
                        result += b[i].ToString();
                    }
                    
                }
                Console.WriteLine(result);
            }     
            Console.Read();
        }
    }
}