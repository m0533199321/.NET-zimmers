using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;
using zimmers.Servicies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zimmers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        OrderServicies service=new OrderServicies();
        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return service.Get();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return service.GetById(id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Order order)
        {
            return service.Post(order);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Order order)
        {
            return service.Put(id, order);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return service.Delete(id);
        }
    }
}
