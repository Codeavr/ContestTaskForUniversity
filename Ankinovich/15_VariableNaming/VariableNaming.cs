using System;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        //Написать программу, которая форматирует имена переменных из snake_case в CamelCase и наоборот
        string inputVarName = Console.ReadLine();

        string outputVarName =
            IsSnakeCase(inputVarName) ?
            SnakeToCamel(inputVarName) :
            CamelToSnake(inputVarName);

        Console.WriteLine(outputVarName);
    }

    static string SnakeToCamel(string snake)
    {
        StringBuilder builder = new StringBuilder();

        string camel = string.Empty;

        int start = 0;
        do
        {
            int end = snake.IndexOf('_', start);
            if (end < 0)
            {
                end = snake.Length;
            }

            var part = snake.Substring(start, end - start);
            int indexToUpper = builder.Length;
            builder.Append(part);
            builder[indexToUpper] = char.ToUpper(builder[indexToUpper]);

            start = end + 1;
        } while (start < snake.Length);

        return builder.ToString();
    }

    static string CamelToSnake(string camel)
    {
        StringBuilder builder = new StringBuilder();
        int start = 0;
        for (int i = 1; i < camel.Length; i++)
        {
            bool isOnEnd = i == camel.Length - 1;

            if (char.IsUpper(camel[i]) || isOnEnd)
            {
                int end = isOnEnd ? i + 1 : i;
                var part = camel.Substring(start, end - start);

                if (builder.Length > 0)
                {
                    builder.Append('_');
                }
                builder.Append(part.ToLower());

                start = end;
            }
        }
        return builder.ToString();
    }

    static bool IsSnakeCase(string varName)
    {
        return varName.IndexOf('_') > -1 || char.IsLower(varName[0]);
    }
}