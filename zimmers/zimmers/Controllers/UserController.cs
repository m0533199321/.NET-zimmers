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
        UserServicies service=new UserServicies();
        // GET: api/<Users>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return service.Get();
        }

        // GET api/<Users>/5
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return service.GetById(id);
        }

        // POST api/<Users>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] User user)
        {
            return service.Post(user);
        }

        // PUT api/<Users>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id,[FromBody] User user)
        {
            return service.Put(id,user);
        }

        // DELETE api/<Users>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return service.Delete(id);
        }
    }
}
