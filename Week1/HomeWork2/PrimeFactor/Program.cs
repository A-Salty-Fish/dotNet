using System;

namespace PrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= n; i++)//i=2为最小商，控制循环次数到输入值的本身
            {
                if (n % i == 0)//判断n余i是否余0
                {
                    n /= i;//如果n能整除i，说明i是n的其中一个质因数，n需要除以这个质因数，进行下一轮质因数判断
                    Console.WriteLine(i);//输出结果i进行下一轮循环
                    i--;//如果n能整除i，说明i是n的其中一个质因数，i–就是为了使质因数还从这个数字继续循环判断
                }
            }
        }
    }
}
