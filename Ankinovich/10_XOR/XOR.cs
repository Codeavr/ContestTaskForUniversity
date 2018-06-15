using System;

class Program
{
    public static int[] Encode(String pText, String pKey)
    {
        int[] encoded = new int[pText.Length];

        for (int i = 0; i < pText.Length; i++)
        {
            encoded[i] = pText[i] ^ pKey[i % pKey.Length];
        }

        return encoded;
    }

    static void Main(string[] args)
    {
        var key = Console.ReadLine();
        var sentence = Console.ReadLine();

        var encoded = Encode(sentence, key);
        Console.WriteLine(string.Join(" ", encoded));
    }
}