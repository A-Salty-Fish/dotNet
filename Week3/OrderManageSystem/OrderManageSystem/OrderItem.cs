using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    [Serializable]
    public class OrderItem : IComparable//订单明细
    {
        //public Goods goods { get; set; }//商品的名称价格和数量
        public string name;
        public double price;
        public int number;

        public OrderItem(string goodsName, double goodsPrice, int goodsNum)
        {
            price = goodsPrice;
            number = goodsNum;
            name = goodsName;
            //goods = new Goods(goodsName, goodsPrice, goodsNum);
        }
        public OrderItem() { }
        public void Modify(OrderItem orderItem)
        {
            //goods = orderItem.goods;
            name = orderItem.name;
            price = orderItem.price;
            number = orderItem.number;
        }

        public double Sum
        {
            //return goods.TotalPrice;
            get { return price * number; }
        }

        public int CompareTo(object obj)
        {
            OrderItem orderItem = obj as OrderItem;
            //if (goods.TotalPrice > orderItem.goods.TotalPrice) return 1;
            //else if (goods.TotalPrice < orderItem.goods.TotalPrice) return -1;
            //else return 0;
            if (Sum > orderItem.Sum) return 1;
            else if (Sum < orderItem.Sum) return -1;
            else return 0;
        }

        public override bool Equals(object obj)
        {
            OrderItem orderItem = obj as OrderItem;
            //return goods.Equals(orderItem.goods);
            return name == orderItem.name;
        }

        public override string ToString()
        {
            return "GoodsName:" + name + "\r\nGoodPrice:" + price + "\r\nGoodsNum:" + number + "\r\nTotalSum:" +
                   Sum + "\r\n";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
