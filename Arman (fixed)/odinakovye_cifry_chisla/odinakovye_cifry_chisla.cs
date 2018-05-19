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
            string result="";
            int[] b_copy = new int[length];
            Array.Copy(b, b_copy, length);
            for (int i = 0; i < length; i++)
            {
                int checking = 0;
                for (int j = 0; j < length; j++)
                {
                    if (b[i] == b_copy[j])
                    {
                        checking++;
                        b_copy[j] = -1;
                    }
                }
                if (checking > 1)
                {
                    result += b[i].ToString() + " " + checking.ToString() + ", ";
                }
            }
            if (result != "")
            {
                result = result.Substring(0, result.Length - 2);
            }
            else result = "NULL";
            Console.WriteLine(result);
            Console.Read();
        }
    }
}