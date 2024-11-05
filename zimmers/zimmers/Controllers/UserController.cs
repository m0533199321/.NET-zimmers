using Microsoft.AspNetCore.Mvc;
using zimmers.Servicies;
using zimmers.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zimmers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserServicies service = new UserServicies();
        // GET: api/<Users>
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return service.Get();
        }

        // GET api/<Users>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            User u = service.GetById(id);
            if (u == null) 
                return NotFound();
            return u;
        }

        // POST api/<Users>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] User user)
        {
            return service.Add(user);
        }

        // PUT api/<Users>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] User user)
        {
            return service.Update(id, user);
        }

        // DELETE api/<Users>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return service.Delete(id);
        }
    }
}
