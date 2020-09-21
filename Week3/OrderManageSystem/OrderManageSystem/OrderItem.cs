using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    public class OrderItem:IComparable//订单明细
    {
        public Goods goods { get; set; }//商品的名称价格和数量

        public OrderItem(string goodsName, double goodsPrice, int goodsNum)
        {
            goods = new Goods(goodsName, goodsPrice, goodsNum);
        }
        public OrderItem() { }
        public void Modify(OrderItem orderItem)
        {
            goods = orderItem.goods;
        }

        public double Sum()
        {
            return goods.TotalPrice;
        }

        public int CompareTo(object obj)
        {
            OrderItem orderItem = obj as OrderItem;
            if (goods.TotalPrice > orderItem.goods.TotalPrice) return 1;
            else if (goods.TotalPrice < orderItem.goods.TotalPrice) return -1;
            else return 0;
        }

        public override bool Equals(object obj)
        {
            OrderItem orderItem = obj as OrderItem;
            return goods.Equals(orderItem.goods);
        }

        public override string ToString()
        {
            return goods.ToString();
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
