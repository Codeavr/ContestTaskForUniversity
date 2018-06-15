using System;

class Program
{
    struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }


    static void Main(string[] args)
    {
        int pointsCount = int.Parse(Console.ReadLine());
        Point[] points = new Point[pointsCount];

        for (int i = 0; i < pointsCount; i++)
        {
            double[] input = Array.ConvertAll(Console.ReadLine().Split(), s => double.Parse(s));
            points[i] = new Point(input[0], input[1]);
        }

        Point sum = new Point();

        for (int i = 0; i < pointsCount; i++)
        {
            sum.X += points[i].X;
            sum.Y += points[i].Y;
        }

        sum.X /= pointsCount;
        sum.Y /= pointsCount;

        Console.WriteLine("{0} {1}", Math.Round(sum.X), Math.Round(sum.Y));
    }
}