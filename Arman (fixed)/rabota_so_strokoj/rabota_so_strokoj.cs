using System;

namespace Space
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] data = Console.ReadLine().Split(' ');
            int length = data.Length;
            int all_length=0;
            for (int i = 0; i < length; i++)
            {
                all_length += data[i].Length+1;
            }
            char[] b = new char[all_length];
            int ii = 0;
            for (int i = 0; i < length; i++)
            {
                foreach (char d in data[i])
                {
                    b[ii] = d;
                    ii++;
                }
                b[ii] = ' ';
                ii++;
            }
            ii--;
            Array.Resize(ref b, ii);
            string result = "";
            if (length < 99999)
            {
                for (int i = 0; i < ii; i++)
                {
                    int count = 0;
                    for (int j = 0; j < ii; j++)
                    {
                        if (b[i] == b[j] && (b[i]!=' ' && b[i]!='.'))
                        {
                            if (count > 0)
                            {
                                b[j] = '*';
                            }    
                            count++;
                        }
                    }
                }   
                for (int i = 0; i < ii; i++)
                {
                    if (b[i] != '*')
                    {
                        result += b[i].ToString();
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}