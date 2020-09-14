using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Homework1
{
    class Rectangle:Shape
    {
        public double GetDist(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
        }
        public Point[] PointsList = new Point[4];

        public Rectangle()
        {
        }
        public Rectangle(Point a, Point b, Point c, Point d)
        {
            PointsList[0] = a;
            PointsList[1] = b;
            PointsList[2] = c;
            PointsList[3] = d;
        }

        public bool IsLegal()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = i + 1; j < 4; j++)
                {
                    if (PointsList[i] == PointsList[j])
                        return false;
                }
            }

            //判断四个点到中心的距离是否相等
            double centerX = PointsList[0].X + PointsList[1].X + PointsList[2].X + PointsList[3].X / 4.0;
            double centerY = PointsList[0].Y + PointsList[1].Y + PointsList[2].Y + PointsList[3].Y / 4.0;

            double length = GetDist(PointsList[0].X, PointsList[0].Y, centerX, centerY);

            foreach (var x in PointsList)
            {
                if (GetDist(x.X, x.Y, centerX, centerY) != length)
                    return false;
            }

            return true;
        }

        public double GetArea()
        {
            return GetDist(PointsList[0].X, PointsList[0].Y, PointsList[1].X, PointsList[1].Y)
                   * GetDist(PointsList[1].X, PointsList[1].Y, PointsList[2].X, PointsList[2].Y);
        }

        public void ShowPoints()
        {
            foreach (var x in PointsList)
            {
                Console.WriteLine("(" + ((Point)x).X + "," + ((Point)x).Y + ")");
            }
        }
    }
}
