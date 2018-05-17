using System;

class Program
{
    const int LettersCount = 'z' - 'a' + 1;
    const int StartChar = 'a';
    const int EndChar = 'z';

    static void Main(string[] args)
    {
        var shift  = int.Parse(Console.ReadLine());
        var sentence = Console.ReadLine().ToCharArray();

        for (int i = 0; i < sentence.Length; i++)
        {
            if (char.IsLetter(sentence[i]))
            {
                int shiftedValue = sentence[i] + shift;
                int code = (((shiftedValue - StartChar) % LettersCount));
                sentence[i] = code >= 0 ? (char)(code + StartChar) : (char)(EndChar + 1 + code);
            }
        }

        Console.WriteLine(new string(sentence));
    }
}