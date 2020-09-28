using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Text;
namespace OrderManageSystem
{
    [Serializable]
    public class Order:IComparable//订单
    {
        public string custormer { get; set; }//用户
        public long OrderNum { get; set; }//订单号
        public DateTime orderTime;//订单时间
        public string Time;
        public List<OrderItem> orderItemsList;//订单列表

        public Order()
        {
            orderTime=DateTime.Now;
            Time = orderTime.ToString("yyyy-MM-dd HH:mm:ss");
            orderItemsList = new List<OrderItem>();
            //随机生成8位订单号
            long num = 0;
            Random random=new Random();
            for (int i = 0; i < 8; i++)
                num += random.Next(10) * (long)Math.Pow(10, i);
            OrderNum = num;
        }

        public void AddItem(OrderItem orderItem)//添加订单明细
        {
            bool IsRepeat = false;//是否重复
            foreach (OrderItem x in orderItemsList)
            {
                if (x.Equals(orderItem)) IsRepeat = true;
            }

            if (!IsRepeat)
            { 
                orderItemsList.Add(orderItem);
                orderTime = DateTime.Now;
                Time = orderTime.ToString("yyyy-MM-dd HH:mm:ss");
            }
            else throw new Exception("Repeat OrderItem\n");
        }

        public void ModifyItem(OrderItem oldItem,OrderItem newItem)//修改订单
        {
            var item = orderItemsList.Where(x => x.Equals(oldItem)).FirstOrDefault();
            if (item != null)
                item.Modify(newItem);
            else throw new Exception("Invalid Modify");
        }

        public void DeleteItem()
        {
            orderItemsList.Clear();
        }

        public double TotalSum
        {
            get
            {
                double sum = 0;
                foreach (OrderItem x in orderItemsList)
                {
                    sum += x.Sum;
                }

                return sum;
            }
        }

        public int CompareTo(object obj)
        {
            Order order = obj as Order;
            if (TotalSum > order.TotalSum) return 1;
            else if (TotalSum < order.TotalSum) return -1;
            else return 0;
        }

        public override bool Equals(object obj)
        {
            Order order=obj as Order;
            return order!=null && order.OrderNum == OrderNum;//订单号是否一致
        }

        public override string ToString()
        {
            string str = "\nOrderNum:" + OrderNum + custormer.ToString();
            int i = 1;
            foreach (OrderItem x in orderItemsList)
            {
                str += "Item " + i + ":\n";
                str += x.ToString();
                i++;
            }

            return "\nOrder Time:" + Time + str + "\nOrderSum:" + TotalSum + '\n';
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }


}
