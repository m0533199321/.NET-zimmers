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
        private readonly UserServicies _userSer;
        public UserController(UserServicies userServicies)
        {
            _userSer = userServicies;
        }
        // GET: api/<Users>
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return _userSer.Get();
        }

        // GET api/<Users>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            User u = _userSer.GetById(id);
            if (u == null) 
                return NotFound();
            return u;
        }

        // POST api/<Users>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] User user)
        {
            return _userSer.Add(user);
        }

        // PUT api/<Users>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] User user)
        {
            return _userSer.Update(id, user);
        }

        // DELETE api/<Users>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _userSer.Delete(id);
        }
    }
}
