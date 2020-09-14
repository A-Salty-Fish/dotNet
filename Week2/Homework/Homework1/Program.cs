using System;
using System.Drawing;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Factories.Factories factories = new Factories.Factories();
            Console.WriteLine(factories.RandomTenArea());
        }
    }
}
