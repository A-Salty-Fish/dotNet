using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace OrderManageSystem
{
    public class OrderService
    {
        public List<Order> OrderList = new List<Order>();

        public void AddOrder(Order order)
        {
            if (OrderList.Exists(o => o.Equals(order)))
            {
                throw new OrderExistsException("当前添加的订单已存在。");
            }
            OrderList.Add(order);
        }

        public void DelOrder(String id)
        {
            var result = OrderList.Where(i => i.ID == id);
            if (result.FirstOrDefault()==null)
                throw new OrderInvalidException("欲删除的订单不存在。");
            OrderList.Remove(result.FirstOrDefault());
        }

        public void SortOrder(string op)
        {
            switch (op)
            {
                case "ID":
                    OrderList.Sort((o1, o2) => o1.ID.CompareTo(o2.ID));
                    break;
                case "Price":
                    OrderList.Sort((o1, o2) => o1.TotalPrice.CompareTo(o2.TotalPrice));
                    break;
                case "Customer":
                    OrderList.Sort((o1, o2) => o1.Customer.CompareTo(o2.Customer));
                    break;
                default:
                    throw new InvalidSortException("错误的排序依据。");
            }

        }

        public void ModifyOrder(String id, String pname, int pnum)
        {
            var result = OrderList.Where(o => o.ID == id);
            if (result.FirstOrDefault()==null)
                throw new OrderInvalidException("欲修改的订单不存在。");
            result.FirstOrDefault().ModifyItem(pname, pnum);
        }

        public List<Order> Query(String op, String src)
        {
            List<Order> re = new List<Order>();
            switch (op)
            {
                case "ID":
                    var IDResult = OrderList.Where(o => o.ID == src);
                    foreach (var o in IDResult)
                        re.Add(o);
                    return re;
                case "Product":
                    var ProResult = OrderList.Where(o => o.HasGood(src));
                    foreach (var o in ProResult)
                        re.Add(o);
                    return re;
                case "Customer":
                    var CusResult = OrderList.Where(o => o.Customer == src);
                    foreach (var o in CusResult)
                        re.Add(o);
                    return re;
                default:
                    throw new InvalidQueryException("错误的查询依据。");
            }
        }

        public void Export()
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("OrderList.xml", FileMode.Create))
            {
                xmlserializer.Serialize(fs, OrderList);
            }
        }

        public void Import()
        {
            XmlSerializer xmlserializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fs = new FileStream("OrderList.xml", FileMode.Open))
            {
                OrderList = (List<Order>)xmlserializer.Deserialize(fs);
            }
        }

    }


    public class OrderExistsException : ApplicationException
    {
        public OrderExistsException(string message) : base(message)
        {
        }
    }

    public class OrderInvalidException : ApplicationException
    {
        public OrderInvalidException(string message) : base(message)
        {
        }
    }
    public class InvalidSortException : ApplicationException
    {
        public InvalidSortException(string message) : base(message)
        {
        }
    }

    public class InvalidQueryException : ApplicationException
    {
        public InvalidQueryException(string message) : base(message)
        {
        }
    }
}
