using System;

namespace OrderLibrary_EF.Models
{
    public class Order
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public long id { get; set; }

        /// <summary>
        /// 商品编号
        /// </summary>
        public long item_id { get; set; }

        /// <summary>
        /// 客户名称
        /// </summary>
        public string customer_name { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        public double item_sum { get; set; }

    }
}