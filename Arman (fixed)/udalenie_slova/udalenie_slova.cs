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
            string[] checking = new string[length-1];
            string tocheck = data[length - 1];
            if (tocheck[0] == '!')
            {
                if (tocheck[1] != '!')
                {
                    for (int i = 0; i < length - 1; i++)
                    {
                        bool finded = false;
                        int k = 0;
                        for (int j = 0; j < data[i].Length; j++)
                        {
                            if (j < tocheck.Length-1)
                            {
                                if (data[i][j] == tocheck[j+1])
                                {
                                    k++;
                                }
                            }
                            if (k == tocheck.Length-1)
                            {
                                finded = true;
                            }
                        }
                        int m = 0;
                        foreach (char c in data[i])
                        {
                            if (char.IsLetter(c))
                            {
                                if (m != k && finded == true)
                                {
                                    checking[i] += "";
                                    m++;
                                }
                                else
                                {
                                    if(finded == false)
                                    {
                                        checking[i] += c;
                                    }      
                                }
                            }
                        }
                        if (checking[i].Length != 0)
                        {
                            result += checking[i] + " ";
                        }  
                    }
                }
                else
                {
                    tocheck = tocheck.Remove(0, 2);
                    for (int i = 0; i < length - 1; i++)
                    {
                        int k = 0;
                        if (data[i] == tocheck)
                        {
                            k = data[i].Length;
                        }
                        int m = 0;
                        foreach (char c in data[i])
                        {
                            if (char.IsLetter(c))
                            {
                                if (m != k)
                                {
                                    checking[i] += "";
                                    m++;
                                }
                                else
                                {
                                    checking[i] += c;
                                }
                            }
                        }
                        if (checking[i].Length != 0)
                        {
                            result += checking[i] + " ";
                        }
                    }
                }
            }
            result = result.Substring(0, result.Length - 1);
            Console.WriteLine(result);
            Console.Read();
        }
    }
}