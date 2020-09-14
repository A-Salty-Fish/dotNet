using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Homework1
{
    class Square:Rectangle
    {
        public Square(Point a, Point b, Point c, Point d)
        {
            PointsList[0] = a;
            PointsList[1] = b;
            PointsList[2] = c;
            PointsList[3] = d;
        }
    }
}
