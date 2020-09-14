using System;

namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intList = new GenericList<int>();
            for (int i = 0; i < 10; i++) intList.Add(i);
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            int sum = 0;
            intList.ForEach(s => { max = max < s ? s : max; });
            intList.ForEach(s => { min = min > s ? s : min; });
            intList.ForEach(s => { sum += s; });
            Console.Write("Max:" + max + '\n');
            Console.Write("Min:" + min + '\n');
            Console.Write("Sum:" + sum + '\n');
        }
    }
}
