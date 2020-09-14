using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows;

namespace Homework1
{
    class TriAngle: Shape
    {
        public Point[] PointsList = new Point[3];
        public TriAngle(Point a, Point b, Point c)
        {
            PointsList[0] = a;
            PointsList[1] = b;
            PointsList[2] = c;
        }
        public bool IsLegal()
        {
            //判断点是否重合
            if (PointsList[0] == PointsList[1] ||
                PointsList[0] == PointsList[2] ||
                PointsList[1] == PointsList[2])
                return false;
            //判断是否在一条直线上
            if ((PointsList[2].Y - PointsList[1].Y) * (PointsList[1].X - PointsList[0].X)
                == (PointsList[1].Y - PointsList[0].Y) * (PointsList[2].X - PointsList[1].X))
                return false;
            return true;
        }

        public double GetArea()
        {
            double Length1 = Math.Sqrt(
                (PointsList[2].Y - PointsList[1].Y) * (PointsList[2].Y - PointsList[1].Y) +
                (PointsList[2].X - PointsList[1].X) * (PointsList[2].X - PointsList[1].X)
            );
            double Length2 = Math.Sqrt(
                (PointsList[2].Y - PointsList[0].Y) * (PointsList[2].Y - PointsList[0].Y) +
                (PointsList[2].X - PointsList[0].X) * (PointsList[2].X - PointsList[0].X)
            );
            double Length3 = Math.Sqrt(
                (PointsList[1].Y - PointsList[0].Y) * (PointsList[1].Y - PointsList[0].Y) +
                (PointsList[1].X - PointsList[0].X) * (PointsList[1].X - PointsList[0].X)
            );
            double HalfLength = (Length1 + Length2 + Length3) / 2;
            //海伦公式
            double area = Math.Sqrt(HalfLength *
                                    (HalfLength - Length1) *
                                    (HalfLength - Length2) *
                                    (HalfLength - Length3));
            return area;
        }

        public void ShowPoints()
        {
            foreach (var x in PointsList)
            {
                Console.WriteLine("(" + ((Point) x).X + "," + ((Point) x).Y + ")");
            }
        }
    }
}
