using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;
using zimmers.Servicies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zimmers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        OwnerServicies service = new OwnerServicies();
        // GET: api/<OwnerController>
        [HttpGet]
        public IEnumerable<Owner> Get()
        {
            return service.Get();
        }

        // GET api/<OwnerController>/5
        [HttpGet("{id}")]
        public Owner Get(int id)
        {
            return service.GetById(id);
        }

        // POST api/<OwnerController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Owner owner)
        {
            return service.Post(owner);
        }

        // PUT api/<OwnerController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Owner owner)
        {
            return service.Put(id, owner);
        }

        // DELETE api/<OwnerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return service.Delete(id);
        }
    }
}
