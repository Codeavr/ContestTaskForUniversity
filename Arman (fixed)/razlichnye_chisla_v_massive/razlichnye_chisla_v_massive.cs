using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int length = data.Length;
            int[] b = new int[length];
            for (int i = 0; i < length; i++)
            {
                b[i] = int.Parse(data[i]);
            }
            string result = "";
            if (length == 10)
            {
                int c = 0;
                while (c==0)
                {
                    bool checking = false;
                    for (int i = 0; i < length; i++)
                    {
                        int count = 0;
                        for (int j = 0; j < length; j++)
                        {
                            if (b[i] == b[j])
                            {
                                if (count > 0) b[j]++;
                                count++;
                            }
                        }
                        if (count > 1) checking = true;
                    }
                    if (checking == false) c++;
                }
                
                for (int i = 0; i < length; i++)
                {
                    result += b[i].ToString()+" ";
                }
                result = result.Substring(0, result.Length - 1);
                Console.WriteLine(result);
            }
            Console.Read();
        }
    }
}