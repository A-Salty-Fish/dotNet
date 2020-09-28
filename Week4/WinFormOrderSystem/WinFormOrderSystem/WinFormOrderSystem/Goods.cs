using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OrderManageSystem
{
    class GoodsArrays
    {
        public static string[] Names = new string[5] { "水性笔","墨水","A4纸","铅笔","橡皮" };
    }
    class Good
    {
        public string name { get; set; }
        public double price { get; set; }
    }

    class Goods
    {
        public List<Good> GoodsList = new List<Good>();

        public Goods()
        {
            InitializeGoods();
        }

        public void InitializeGoods()
        {
            Random r = new Random();
            for (int i = 0; i < 5; i++)
                GoodsList.Add(new Good() { name = GoodsArrays.Names[i], price = r.Next() % 10 + 1});
        }

        public bool GoodExists(string goodname)
        {
            var result = GoodsList.Where(g => g.name == goodname);
            return result.FirstOrDefault() != null;
        }

        public double GetPrice(string goodname)
        {
            var result = GoodsList.Where(g => g.name == goodname);
            return result.FirstOrDefault() == null ? 0 : result.FirstOrDefault().price;
        }
    }

    public class GoodNotExistsException : ApplicationException
    {
        public GoodNotExistsException(string message) : base(message)
        {
        }
    }
}
