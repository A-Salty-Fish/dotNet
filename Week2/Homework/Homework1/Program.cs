using System;
using System.Drawing;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(3,4);
            Point d = new Point(4,5);
            Point b = new Point(5, 6);
            Point c = new Point(6, 6);


            Rectangle rectangle = new Rectangle(a,d,b,c);
        }
    }
}
