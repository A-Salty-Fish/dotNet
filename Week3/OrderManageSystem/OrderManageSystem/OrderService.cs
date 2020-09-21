using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户等字段进行查询）功能。
//提示：主要的类有Order（订单）、OrderItem（订单明细项），OrderService（订单服务），订单数据可以保存在OrderService中一个List中。
//在Program里面可以调用OrderService的方法完成各种订单操作。
//要求：
//（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。订单号√
//（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。√
//（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。 √
//（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。√
//（5）OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。√
namespace OrderManageSystem
{
    interface IServiceIO//客户端IO接口 In为输入接口 Out为输出接口 IO为输入和输出接口
    {
        public abstract void InputOrderItemIO(int i, OrderItem orderItem);//添加item的交互
        public abstract void InputOrderIO(Order order);//添加order的交互
        public abstract long DeleteOrderIn();//删除order的输入
        public long ModifyOrderByNumIn();//修改order的输入
        public abstract void ShowAllOrdersOut(List<Order> orderlList);//展示所有order
        public abstract void ShowOrderOut(Order order, ShowWay showWay, int n = 0);//展示某个order
        public abstract SortWay SortBySomeWayIO();//输入搜索方式
        public abstract SearchWay SearchBySomeWayIO();//搜索order
        public abstract long SearchByOrderNumIO();//通过订单号搜索
        public abstract string SearchByCustomerNameIO();//通过用户名搜索
        public abstract void StartMenu();//开始菜单
    }
    enum ShowWay//显示方式
    {
        Normal,
        Add,
        Delete,
        Modify,
        Modified,
        Show,
        Search,
        Undefined
    };

    enum SearchWay//搜索方式
    {
        ByNum,
        ByName,
        Undefined
    }

    enum SortWay//排序方式
    {
        ByNum,
        BySum,
        ByDate,
        Undefined
    }
    class OrderService //订单服务
    {
        private List<Order> orderList;
        private IServiceIO serviceIo;//

        public OrderService()
        {
            orderList = new List<Order>();
            serviceIo=new CMDServiceIO();//客户端命令行交互接口
        }

        public void StartMenu()
        {
            serviceIo.StartMenu();
        }

        public void AddOrder()
        {
            bool isRepeat = false;
            Order order;
            while (true)
            {
                order = new Order();
                foreach (Order x in orderList)
                {
                    if (x.Equals(order)) isRepeat = true;
                }
                if (!isRepeat) break;
            }
            //输入订单
            serviceIo.InputOrderIO(order);
            orderList.Add(order);
            //打印订单
            Console.ForegroundColor = ConsoleColor.Red;
            serviceIo.ShowOrderOut(order,ShowWay.Add);
        }

        public void ModifyOrderByOrderNum()//通过订单号修改订单 不改变订单号与客户
        {
            long OrderNum = serviceIo.ModifyOrderByNumIn();
            var result = orderList.Where(x => x.OrderNum == OrderNum);
            Order order = result.FirstOrDefault();
            if (order == null) throw new Exception("OrderNum not exist\n");
            else
            {
                Order newOrder=new Order();//新建订单
                serviceIo.ShowOrderOut(order,ShowWay.Modify);
                order.DeleteItem(); //删除原来的订单
                serviceIo.InputOrderIO(newOrder); //输入订单
                orderList.Remove(order);//移除原来的订单
                orderList.Add(newOrder);//添加订单
                serviceIo.ShowOrderOut(newOrder,ShowWay.Modified);//输出修改后的订单
            }
        }

        public void DeleteOrderByOrderNum()//通过订单号删除订单
        {
            long OrderNum = serviceIo.DeleteOrderIn();//输入
            //寻找
            var result = orderList.Where(x => x.OrderNum == OrderNum);
            Order order = result.FirstOrDefault();
            if (order == null) throw new Exception("Invalid OrderNum\n");
            //删除
            else
            {
                orderList.Remove(order);
                serviceIo.ShowOrderOut(order, ShowWay.Delete);
            }
        }

        public void ShowAllOrders()//显示所有的Order
        {
            serviceIo.ShowAllOrdersOut(orderList);
        }

        public void SearchBySomeWay()//搜索
        {
            SearchWay input = serviceIo.SearchBySomeWayIO();
            switch (input)
            {
                case SearchWay.ByNum: //通过订单号搜索
                    long OrderNum = serviceIo.SearchByOrderNumIO();
                    var result1 = orderList.Where(x => x.OrderNum == OrderNum);
                    Order order = result1.FirstOrDefault();
                    if (order != null)
                    {
                        serviceIo.ShowOrderOut(order,ShowWay.Normal);
                    }
                    else throw new Exception("Invalid OrderNum:" + OrderNum + '\n');
                    break;
                case SearchWay.ByName://通过客户名搜索
                    string CustormerName = serviceIo.SearchByCustomerNameIO();
                    var result2 = from x in orderList
                        where x.custormer.Name == CustormerName
                        orderby x.OrderNum
                        select x;
                    if (result2.FirstOrDefault() != null)//搜索到了则输出
                    {
                        int i = 1;
                        foreach (var x in result2)
                        {
                            serviceIo.ShowOrderOut(x,ShowWay.Normal,i);
                            i++;
                        }
                    }
                    else throw new Exception("No such name.\n");
                    break;
            }
        }


        public void SortBySomeWay() //排序方式
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            if (orderList.Count == 0) throw new Exception("Empty Order.\n");
            else
            {
                SortWay input = serviceIo.SortBySomeWayIO();
                switch (input)
                {
                    case SortWay.ByNum:
                        orderList.Sort((order1, order2) => (int) (order1.OrderNum - order2.OrderNum));
                        break;
                    case SortWay.ByDate:
                        orderList.Sort((order1, order2) => DateTime.Compare(order1.orderTime, order2.orderTime));
                        break;
                    case SortWay.BySum:
                        orderList.Sort((order1, order2) => order1.TotalSum.CompareTo(order2.TotalSum));
                        break;
                    default: throw new Exception("Invalid Sort Input");
                }
                //排序后显示？
                serviceIo.ShowAllOrdersOut(orderList);
            }
        }

    }
}
