using System;
using System.Collections;

namespace ISieve
{
    class Program
    {
        private const int Max = 100;
        private static int[] intArr = new int[Max];

        static void Main(string[] args)
        {
            ArrayList.Repeat(1, Max).CopyTo(intArr);
            intArr[0] = 0;

            for (int i = 2; i <= Max/2; i++)
            {
                int multiple = 2;
                while (i * multiple <= Max)
                {
                    intArr[i * multiple - 1] = 0;
                    multiple++;
                }
            }

            for (int i = 0; i < Max; i++)
            {
                if (intArr[i]!=0)
                    Console.WriteLine(i+1);
            }
        }
    }
}
