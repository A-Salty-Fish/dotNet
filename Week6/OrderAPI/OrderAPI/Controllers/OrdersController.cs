using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

using OrderNameSpace;
using DatabaseNameSpace;

namespace OrderLibraryWeb.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : Controller
    {
        private Database db = new Database();

        [HttpGet]
        public ActionResult<Order> GetById(long id)
        {
            return db.Orders.Find(id);
        }

        [HttpDelete]
        public ActionResult<Order> Delete(long id)
        {
            var ret = db.Orders.Find(id);
            if (ret == null) return null;
            db.Orders.Remove(ret);
            db.SaveChanges();
            return ret;
        }

        [HttpPost]
        public ActionResult<Order> Add(long itemid, string custom, double sum)
        {
            var ret = db.Add(new Order() { customer_name = custom, item_id = itemid, item_sum = sum });
            db.SaveChanges();
            return ret.Entity;
        }
    }
}