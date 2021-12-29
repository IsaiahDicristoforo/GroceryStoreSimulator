using GroceryStoreSimulatorWebAPI.Models;
using GroceryStoreSimulatorWebAPI.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GroceryStoreSimulatorWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly OrderService orderService;

        public OrdersController(OrderService orderService)
        {
            this.orderService = orderService;
        }
        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return orderService.Get();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return orderService.Get(id);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] Order value)
        {
             orderService.Post(value);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put([FromBody] Order value)
        {
            orderService.Put(value);
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(Order order)
        {
            orderService.Delete(order);
        }
    }
}
