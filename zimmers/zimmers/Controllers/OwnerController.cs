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
        public ActionResult<IEnumerable<Owner>> Get()
        {
            return service.Get();
        }

        // GET api/<OwnerController>/5
        [HttpGet("{id}")]
        public ActionResult<Owner> Get(int id)
        {
            Owner o = service.GetById(id);
            if (o == null) 
                return NotFound();
            return o;
        }

        // POST api/<OwnerController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Owner owner)
        {
            return service.Add(owner);
        }

        // PUT api/<OwnerController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Owner owner)
        {
            return service.Update(id, owner);
        }

        // DELETE api/<OwnerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return service.Delete(id);
        }
    }
}
