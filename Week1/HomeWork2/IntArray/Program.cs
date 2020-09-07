using System;
using System.Linq;

namespace IntArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strArr = Console.ReadLine().Split(' ');
            int[] intArr = new int[strArr.Length];
            intArr = Array.ConvertAll<string, int>(strArr, x => int.Parse(x));
            
            Console.WriteLine("Min: " + intArr.Min());
            Console.WriteLine("Max: " + intArr.Max());
            Console.WriteLine("Average: " + intArr.Average());
        }
    }
}
