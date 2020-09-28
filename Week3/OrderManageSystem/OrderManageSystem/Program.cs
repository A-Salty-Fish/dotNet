using System;

namespace OrderManageSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            OrderService orderService=new OrderService();
            orderService.StartMenu();
        }
    }
}
