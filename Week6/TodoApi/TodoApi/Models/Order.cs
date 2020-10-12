using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class Order//简单order
    {
        public int Order_Id { get; set; }
        public string Name { get; set; }
        public int Item_Id { get; set; }
        public float Item_Sum { get; set; }
    }
}
