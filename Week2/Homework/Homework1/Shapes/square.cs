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

        public bool IsLegal()
        {
            double length = GetDist(PointsList[0].X, PointsList[0].Y, PointsList[1].X, PointsList[1].Y);
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (GetDist(PointsList[i].X, PointsList[i].Y,
                            PointsList[j].X, PointsList[j].Y) != length)
                        return false;
                }
            }
            return true;
        }
    }
}
