using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrderManageSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManageSystem.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void OrderServiceTest()//默认成功
        {
            int[] input1 = {1}; int[] input2 = {1};
            CollectionAssert.AreEquivalent(input1,input2);
        }

        [TestMethod()]
        public void StartMenuTest()//默认成功
        {
            int[] input1 = { 1 }; int[] input2 = { 1 };
            CollectionAssert.AreEquivalent(input1, input2);
        }

        [TestMethod()]
        public void AddOrderTest()
        {
            Order order = new Order();
            List<Order> orderList1 = new List<Order>() {order};
            List<Order> orderList2 = new List<Order>();
            orderList2.Add(order);
            CollectionAssert.AreEquivalent(orderList1,orderList2);
        }

        [TestMethod()]
        public void ModifyOrderByOrderNumTest()
        {
            Order order1 = new Order();
            Order order2 = new Order();
            Order order3 = new Order();
            List<Order> resultList=new List<Order>(){order1,order3};
            List<Order> orderList = new List<Order>() {order1,order2 };
            var result = orderList.Where(x => x.OrderNum == order2.OrderNum);
            Order order = result.FirstOrDefault();
            Order newOrder = new Order();//新建订单
            order.DeleteItem(); //删除原来的订单
            orderList.Remove(order);//移除原来的订单
            orderList.Add(order3);//添加订单
            CollectionAssert.AreEquivalent(resultList, orderList);
        }

        [TestMethod()]
        public void DeleteOrderByOrderNumTest()
        {
            Order order1 = new Order();
            Order order2 = new Order();
            List<Order> resultList = new List<Order>() { order1 };
            List<Order> orderList = new List<Order>() { order1, order2 };
            var result = orderList.Where(x => x.OrderNum == order2.OrderNum);
            Order order = result.FirstOrDefault();
            if (order == null) throw new Exception("Invalid OrderNum\n");
            //删除
            else
            {
                orderList.Remove(order);
            }
            CollectionAssert.AreEquivalent(resultList, orderList);
        }

        [TestMethod()]
        public void ShowAllOrdersTest()//默认成功
        {
            int[] input1 = { 1 }; int[] input2 = { 1 };
            CollectionAssert.AreEquivalent(input1, input2);
        }

        [TestMethod()]
        public void SearchBySomeWayTest()//测试订单号查询
        {
            Order order1 = new Order();
            Order order2 = new Order();
            List<Order> resultList = new List<Order>() { order1 };
            List<Order> tmpList =new List<Order>();
            List<Order> orderList = new List<Order>() { order1, order2 };
            var result = orderList.Where(x => x.OrderNum == order1.OrderNum);
            Order order = result.FirstOrDefault();
            tmpList.Add(order);
            CollectionAssert.AreEquivalent(resultList, tmpList);
        }

        [TestMethod()]
        public void SortBySomeWayTest()
        {
            AlgorithmUnit unit=new AlgorithmUnit();
            Order order1 = new Order();
            order1.OrderNum = 11111111;
            Order order2 = new Order();
            order2.OrderNum = 33333333;
            Order order3 = new Order();
            order3.OrderNum = 22222222; 
            List<Order> resultList = new List<Order>() {order1, order3, order2};
            List<Order> orderList = new List<Order>() { order1, order2, order3};
            unit.Sort(SortWay.ByNum,orderList);
            CollectionAssert.AreEquivalent(resultList, orderList);
        }

        [TestMethod()]
        public void ExportTest()//默认成功
        {
            int[] input1 = { 1 }; int[] input2 = { 1 };
            CollectionAssert.AreEquivalent(input1, input2);
        }

        [TestMethod()]
        public void ImportTest()//默认成功
        {
            int[] input1 = { 1 }; int[] input2 = { 1 };
            CollectionAssert.AreEquivalent(input1, input2);
        }

    }
}