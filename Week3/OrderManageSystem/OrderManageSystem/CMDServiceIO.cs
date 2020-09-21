using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace OrderManageSystem
{
    class CMDServiceIO: IServiceIO //客户端命令行交互接口
    {
        public void InputOrderItemIO(int i,OrderItem orderItem)
        {
            string goodsName;
            double goodsPrice;
            int goodsNum;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("----------\nPlease enter the goods" + (i + 1) + "'s name:");
            goodsName = Console.ReadLine();
            if (goodsName=="") throw new Exception("Invalid goods' name Input.\n");
            Console.Write("Please enter the goods" + (i + 1) + "'s price:");
            if (!double.TryParse(Console.ReadLine(), out goodsPrice)) throw new Exception("Invalid goods' price Input.\n");
            Console.Write("Please enter the goods" + (i + 1) + "'s number:");
            if (!int.TryParse(Console.ReadLine(),out goodsNum)) throw new Exception("Invalid goods' num input.\n");
            orderItem.goods = new Goods(goodsName, goodsPrice, goodsNum);
        }

        public void InputOrderIO(Order order)
        {
            //输入用户名
            string customerName;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("----------\nPlease enter the Custormer's name:");
            customerName = Console.ReadLine();
            if (customerName == "") throw new Exception("name can't be empty.\n");
            Custormer custormer = new Custormer(customerName);
            order.custormer = custormer;
            //创建订单项目
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("----------\nPlease enter the order item's num:");
            int orderItemNum = 0;
            if(!int.TryParse(Console.ReadLine(),out orderItemNum)) throw new Exception("Invalid Order num input.\n");
            if (orderItemNum < 0) throw new Exception("Num must be positive.\n");
            else
            {
                for (int i = 0; i < orderItemNum; i++)//循环添加item
                {
                    //读取商品信息
                    OrderItem orderItem = new OrderItem();
                    //新建订单项目
                    InputOrderItemIO(i,orderItem);
                    order.AddItem(orderItem);
                    //添加订单项
                    Console.Write('\n');
                }
            }
        }

        public long DeleteOrderIn()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("----------\nPlease enter the Order Num you want to delete:");
            long OrderNum = -1;
            if (!long.TryParse(Console.ReadLine(), out OrderNum)) throw new Exception("Invalid Delete Num input.\n");
            else return OrderNum;
        }

        public long ModifyOrderByNumIn()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            long OrderNum = -1;
            Console.Write("----------\nPlease enter the Order Num you want to modify:");
            if (!long.TryParse(Console.ReadLine(), out OrderNum)) throw new Exception("Invalid Modify num input.\n");
            else return OrderNum;
        }

        public void ShowOrderOut(Order order,ShowWay showWay,int n=0)
        {
            switch (showWay)
            {
                case ShowWay.Add:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("----------\nYou add the Order:\n");
                    Console.Write(order);
                    break;
                case ShowWay.Delete:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\nYou delete the order:");
                    Console.Write(order);
                    break;
                case ShowWay.Modify:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("----------\nThe Original order:");
                    Console.Write(order);
                    break;
                case ShowWay.Modified:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write("----------\nThe Modified order:");
                    Console.Write(order);
                    break;
                case ShowWay.Search:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("----------\nThe Search result:");
                    Console.Write(order);
                    break;
                case ShowWay.Normal:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    if (n!=0) Console.Write("\nOrder "+n+":\n");//循环输出
                    Console.Write(order);
                    break;
                default:throw new Exception("Invalid Show Input.\n");
            }
        }

        public void ShowAllOrdersOut(List<Order>orderlList)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            if (orderlList.Count == 0)//空表
                Console.Write("----------\nNone order.\n");
            else//非空则遍历
            {
                Console.Write("----------\nHere are the all orders:\n");
                int i = 1;
                foreach (var x in orderlList)
                {
                    Console.Write("----------\nOrder " + i + ":\n");
                    Console.Write(x);
                    i++;
                }
            }
        }

        public SearchWay SearchBySomeWayIO()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("----------\n1 to search by ordernum; 2 to search by name:");
            int input = -1;
            if(!int.TryParse(Console.ReadLine(),out input)) throw new Exception("Invalid SearchWay Input.\n");
            else
            {
                if (input == 1) return SearchWay.ByNum;
                else if (input == 2) return SearchWay.ByName;
                else return SearchWay.Undefined;
            }
            
        }

        public long SearchByOrderNumIO()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            long OrderNum = -1;
            Console.Write("----------\nPlease enter the Order Num you want to search:");
            if (!long.TryParse(Console.ReadLine(), out OrderNum)) throw new Exception("Invalid Num input.\n");
            else return OrderNum;
        }

        public string SearchByCustomerNameIO()//通过用户名搜索 价格升序
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            string CustormerName;
            Console.Write("----------\nPlease enter the Customer Name you want to search:");
            CustormerName = Console.ReadLine();
            return CustormerName;
        }

        public SortWay SortBySomeWayIO()//输入函数
        {
            Console.Write("Please enter the way to sort. 1 by orderNum, 2 by data, 3 by sum : ");
            int input = 0;
            if (!int.TryParse(Console.ReadLine(), out input)) throw new Exception("Invalid Sort Input");
            else
            {
                if (input == 1) return SortWay.ByNum;
                else if (input == 2) return SortWay.ByDate;
                else if (input == 3) return SortWay.BySum;
                else return SortWay.Undefined;
            }
        }

        public void StartMenu()
        {
            OrderService orderService = new OrderService();
            int num = -1;
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(
                        "----------\nPlease enter a number.\n 1 to add;   2 to delete;\n 3 to modify;4 to show all;\n 5 to search; 6 to Sort;\nothers to quit:");
                    num = int.Parse(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            orderService.AddOrder();
                            break;
                        case 2:
                            orderService.DeleteOrderByOrderNum();
                            break;
                        case 3:
                            orderService.ModifyOrderByOrderNum();
                            break;
                        case 4:
                            orderService.ShowAllOrders();
                            break;
                        case 5:
                            orderService.SearchBySomeWay();
                            break;
                        case 6:
                            orderService.SortBySomeWay();
                            break;
                        default: return;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed; 
                    Console.Write("Error:"+e.Message+'\n'); 
                    continue;
                }
            }
        }
    }
}
