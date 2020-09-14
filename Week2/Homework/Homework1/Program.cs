using System;
using System.Drawing;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(3,4);
            Point b = new Point(5, 6);
            Point c = new Point(6, 6);

            TriAngle triAngle = new TriAngle(a, b, c);
            triAngle.ShowPoints();
            Console.WriteLine(triAngle.GetArea());
        }
    }
}
