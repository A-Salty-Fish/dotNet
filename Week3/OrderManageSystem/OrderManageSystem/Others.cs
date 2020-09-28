using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
    [Serializable]
    public class Custormer//用户
    {
        public string name;//用户姓名

        public string Name
        {
            get { return name; }
        }

        public Custormer(string name)
        {
            this.name = name;
        }
        public Custormer()
        {

        }
        public override string ToString()
        {
            if (name != null)
                return "\r\nCustormer's Name:" + name + "\r\n";
            else return "\r\n";
        }
    }

    [Serializable]
    public class Goods//商品
    {
        public string Name { get; set; }//商品名称
        public double Price { get; set; }//商品价格
        public int Num { get; set; }//商品数量

        public Goods(string name, double price, int num)
        {
            Name = name;
            Price = price;
            Num = num;
        }

        public Goods()
        {

        }

        public double TotalPrice//该商品总价
        {
            get { return Price * Num; }
        }

        public override string ToString()
        {
            return "GoodsName:" + Name + "\r\nGoodPrice:" + Price + "\r\nGoodsNum:" + Num + "\r\nTotalSum:" +
                   TotalPrice + "\r\n";
        }

        public override bool Equals(object obj)
        {
            Goods goods = obj as Goods;
            return goods != null && goods.Name == Name;//null
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
