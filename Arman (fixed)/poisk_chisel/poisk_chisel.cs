using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int length = data.Length;
            string result = "";
            bool solo = true;
            for (int i = 0; i < length; i++)
            {
                foreach (char c in data[i])
                {
                    if (Char.IsDigit(c)){
                        result += c;
                        solo = false;
                    }
                }
                if (solo == false && i!= (length-1))
                {
                    result += " ";
                    solo = true;
                }
            }
            Console.WriteLine(result);
        }
    }
}