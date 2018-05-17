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
            string[] checking = new string[length];
            bool solo = true;
            for (int i = 0; i < length; i++)
            {
                int j = 0;
                int count = 0;
                foreach (char c in data[i])
                {
                    if (char.IsLetter(c))
                    {
                        checking[i] += char.ToLower(c);
                    }
                }
                for (int m =0; m < length; m++)
                {
                    if (checking[i] == checking[m])
                    {
                        count++;
                        if (count > 1)
                        {
                            solo = false;
                        }
                    }
                }
                if (solo == true)
                {
                    result += checking[i] + " ";
                }
                solo = true;
                count = 0;
            }
            result = result.Substring(0, result.Length - 1);
            Console.WriteLine(result);
        }
    }
}