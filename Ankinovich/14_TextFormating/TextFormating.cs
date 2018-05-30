using System;
using System.Text.RegularExpressions;

class Program
{
    static readonly char[] Punctuations = { ',', '.', '?', '!' };
    static readonly char[] EndSentensePunctuation = { '.', '!', '?' };

    static void Main(string[] args)
    {
        string str = Console.ReadLine();

        str = RemoveExtraSpaces(str);
        str = RemoveSpacesBeforePuncutation(str);
        str = AddSpacesAfterPuncutation(str);
        str = FirstSentenseWorkToUpper(str);

        Console.WriteLine(str);
    }

    static string FirstSentenseWorkToUpper(string str)
    {
        int index = -1;
        int targetIndex = 0;
        do
        {
            if (index < 0 && char.IsLetter(str[0]))
            {
                index = 0;
                targetIndex = 0;
            }
            else
            {
                index = str.IndexOfAny(EndSentensePunctuation, index + 1);
                if (index < 0)
                {
                    break;
                }
                targetIndex = index + 2;
            }

            if (index < str.Length - 2)
            {
                string uppperChar = char.ToUpper(str[targetIndex]).ToString();
                str = str.Remove(targetIndex, 1);
                str = str.Insert(targetIndex, uppperChar);
            }
        } while (index < str.Length - 1);

        return str;
    }

    static string AddSpacesAfterPuncutation(string str)
    {
        int index = -1;
        do
        {
            index = str.IndexOfAny(Punctuations, index + 1);
            if (index == -1)
            {
                break;
            }

            if (index < str.Length - 1)
            {
                if (!char.IsWhiteSpace(str[index + 1]))
                {
                    str = str.Insert(index+1, " ");
                    index++;
                }
            }
        } while (index < str.Length - 1);

        return str;
    }

    static string RemoveExtraSpaces(string str)
    {
        Regex regex = new Regex("[ ]{2,}", RegexOptions.None);
        return regex.Replace(str, " ");
    }

    static string RemoveSpacesBeforePuncutation(string str)
    {
        int index = -1;
        do
        {
            index = str.IndexOfAny(Punctuations, index + 1);
            if (index == -1)
            {
                break;
            }

            if (index > 0)
            {
                if (char.IsWhiteSpace(str[index - 1]))
                {
                    str = str.Remove(index - 1, 1);
                    index--;
                }
            }
        } while (index < str.Length - 1);

        return str;
    }
}