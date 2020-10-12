using System;
using System.Linq;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Newtonsoft.Json;
using OrderNameSpace;
using DatabaseNameSpace;

namespace ServiceNameSpace
{
    public class OrderService
    {
        //查
        public static string searchOrder(long id)
        {
            using (var db = new Database())
            {
                var obj = db.Orders.Where(x => x.id == id).FirstOrDefault();
                if (obj == null) return "no such order";
                return JsonConvert.SerializeObject(obj, Formatting.Indented);
            }
        }
        //增
        public static string addOrder(string name, long itemId, double totalSum)
        {
            using (var db = new Database())
            {
                Order order = new Order() { customer_name = name, item_id = itemId, item_sum = totalSum };
                db.Add(order);
                db.SaveChanges();
                return JsonConvert.SerializeObject(order, Formatting.Indented);
            }
        }
        //删
        public static string deleteOrder(long itemid)
        {
            using (var db = new Database())
            {
                var obj = db.Orders.Where(x => x.id == itemid).FirstOrDefault();
                if (obj == null) return "No such Order";
                db.Remove(obj);
                db.SaveChanges();
                return JsonConvert.SerializeObject(obj, Formatting.Indented);
            }
        }
        //改
        public static string updateOrder(long itemid, string name, long itemId, double totalSum)
        {
            using (var db = new Database())
            {
                var obj = db.Orders.Where(x => x.id == itemid).FirstOrDefault();
                if (obj == null) return "No such Order";
                db.Remove(obj);
                db.SaveChanges();
                obj.customer_name = name;
                obj.item_id = itemId;
                obj.item_sum = totalSum;
                db.Add(obj);
                db.SaveChanges();
                return JsonConvert.SerializeObject(obj, Formatting.Indented);
            }
        }
    }
}
