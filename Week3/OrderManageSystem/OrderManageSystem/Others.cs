using System;
using System.Collections.Generic;
using System.Text;

namespace OrderManageSystem
{
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
        public override string ToString()
        {
            if (name != null)
                return "\nCustormer's Name:" + name + '\n';
            else return "\n";
        }
    }

    public class Goods//商品
    {
        public string Name { get; }//商品名称
        private double Price;//商品价格
        private int Num;//商品数量

        public Goods(string name, double price, int num)
        {
            Name = name;
            Price = price;
            Num = num;
        }

        public double TotalPrice//该商品总价
        {
            get { return Price * Num; }
        }

        public override string ToString()
        {
            return "GoodsName:" + Name + "\nGoodPrice:" + Price + "\nGoodsNum:" + Num + "\nTotalSum:" +
                   TotalPrice + '\n';
        }

        public override bool Equals(object obj)
        {
            Goods goods=obj as Goods;
            return goods!=null && goods.Name == Name;//null
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
