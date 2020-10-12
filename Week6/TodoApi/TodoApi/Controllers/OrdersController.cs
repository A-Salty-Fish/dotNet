using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrderContext _context;

        public OrdersController(OrderContext context)
        {
            _context = context;
        }

        // GET: api/DBOrders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetTodoItems()
        {
            return await _context.DBOrders.ToListAsync();
        }

        // GET: api/DBOrders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetTodoItem(long id)
        {
            var todoItem = await _context.DBOrders.FindAsync(id);

            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        [HttpPost("Add")]//增
        public Task<ActionResult<Order>> CreateOrder()
        {
            Order order = new Order();

            _context.DBOrders.Add(order);
            _context.SaveChanges();

            return null;

        }

        [HttpDelete("{id}")]//删
        public async Task<ActionResult<Order>> Delete(int id)
        {
            var todoItem = await _context.DBOrders.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.DBOrders.Remove(todoItem);
            await _context.SaveChangesAsync();

            return todoItem;
        }
        [HttpDelete("Search {id}")]//删
        public async Task<ActionResult<Order>> Search(int id)
        {
            var todoItem = await _context.DBOrders.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            return todoItem;
        }

        // PUT: api/DBOrders/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTodoItem(long id, Order todoItem)
        {
            if (id != todoItem.Order_Id)
            {
                return BadRequest();
            }

            _context.Entry(todoItem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TodoItemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DBOrders
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Order>> PostTodoItem(Order todoItem)
        {
            _context.DBOrders.Add(todoItem);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTodoItem", new { id = todoItem.Id }, todoItem);
            return CreatedAtAction(nameof(GetTodoItem), new { id = todoItem.Order_Id }, todoItem);
        }

        // DELETE: api/DBOrders/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Order>> DeleteTodoItem(long id)
        {
            var todoItem = await _context.DBOrders.FindAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _context.DBOrders.Remove(todoItem);
            await _context.SaveChangesAsync();

            return todoItem;
        }

        private bool TodoItemExists(long id)
        {
            return _context.DBOrders.Any(e => e.Order_Id == id);
        }


    }
}
