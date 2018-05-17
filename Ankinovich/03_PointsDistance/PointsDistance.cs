using System;

class Program
{
    struct Point
    {
        public double X;
        public double Y;
        public double Z;
    }

    static double DistanceBetweenPoints(Point a, Point b)
    {
        var dx = a.X - b.X;
        var dy = a.Y - b.Y;
        var dz = a.Z - b.Z;

        return Math.Sqrt(dx * dx + dy * dy + dz * dz);
    }

    static void Main(string[] args)
    {
        double[] points = Array.ConvertAll(Console.ReadLine().Split(), raw => double.Parse(raw));
        var firstPoint = new Point() { X = points[0], Y = points[1], Z = points[2] };
        var secondPoint = new Point() { X = points[3], Y = points[4], Z = points[5] };

        Console.WriteLine(DistanceBetweenPoints(firstPoint, secondPoint));
    }

}