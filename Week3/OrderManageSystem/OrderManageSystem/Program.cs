using System;

namespace OrderManageSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService orderService=new OrderService();
            orderService.StartMenu();
        }
    }
}
