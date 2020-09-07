using System;
using System.Globalization;

namespace ToplitzMatrix
{
    class Program
    {
        public static bool isToplitzMatrix(int[,] matrix)
        {
            //int minLength = (int) (matrix.GetLength(0) < matrix.GetLongLength(1)
            //    ? matrix.GetLength(0)
            //    : matrix.GetLongLength(1));
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i + 1, j + 1] != matrix[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            int[,] matrix = new int[3,4]
            {
                {4, 3, 7, 7},
                {2, 4, 3, 7},
                {2, 2, 1, 3 }
            };
            Console.WriteLine(isToplitzMatrix(matrix));
        }
    }
}
