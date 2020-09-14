using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Text;

namespace Homework1.Factories
{
    class TriAngleFactory:ShapesFactory
    {
        Random rd = new Random();
        public Shape CreateShape()
        {
            Point a = new Point(rd.Next(1, 100), rd.Next(1, 100));
            Point b = new Point(rd.Next(1, 100), rd.Next(1, 100));
            Point c = new Point(rd.Next(1, 100), rd.Next(1, 100));
            return new TriAngle(a,b,c);
        }
    }

    class RectangleFactory : ShapesFactory
    {
        Random rd = new Random();
        public Shape CreateShape()
        {
            Point a = new Point(rd.Next(1, 100), rd.Next(1, 100));
            Point b = new Point(rd.Next(1, 100), a.Y);
            Point c = new Point(b.X, rd.Next(1, 100));
            Point d = new Point(a.X,c.Y);
            return new Rectangle(a, b, c,d);
        }
    }

    class SquareFactory: ShapesFactory
    {
        Random rd = new Random();

        public Shape CreateShape()
        {
            Point a = new Point(rd.Next(1, 100), rd.Next(1, 100));
            Point b = new Point(rd.Next(1, 100), a.Y);
            int length = Math.Abs(a.X - b.X);
            Point c = new Point(a.X,a.Y+length);
            Point d = new Point(b.X,b.Y+length);
            return new Square(a,b,c,d);
        }
    }

    class Factories
    {
        public double RandomTenArea()
        {
            //初始化
            Random rd = new Random();
            double sum = 0.0;
            ShapesFactory shapesFactory = new RectangleFactory();
            Shape shape = shapesFactory.CreateShape();
            //随机十个
            for (int i = 0; i < 10; i++)
            {
                int kind = rd.Next(1, 4);
                switch (kind)
                {
                    case 1:
                        shapesFactory = new TriAngleFactory();
                        break;
                    case 2:
                        shapesFactory = new RectangleFactory();
                        break;
                    case 3:
                        shapesFactory = new SquareFactory();
                        break;
                }
                shape = shapesFactory.CreateShape();
                sum += shape.GetArea();
            }

            return sum;
        }
    }
}
