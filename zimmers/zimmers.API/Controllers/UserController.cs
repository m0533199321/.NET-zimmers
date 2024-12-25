using Microsoft.AspNetCore.Mvc;
using zimmers.core.Entities;
using zimmers.core.Interfaces;
using zimmers.core.Interfaces.IService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zimmers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _iService;
        public UserController(IUserService iService)
        {
            _iService = iService;
        }
        // GET: api/<Users>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _iService.Get();
        }

        // GET api/<Users>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(int id)
        {
            User u = _iService.GetById(id);
            if (u == null)
                return NotFound();
            return u;
        }

        // POST api/<Users>
        [HttpPost]
        public ActionResult<User> Post([FromBody] User user)
        {
            User u = _iService.Add(user);
            if (u == null)
                return NotFound();
            return u;
        }

        // PUT api/<Users>/5
        [HttpPut("{id}")]
        public ActionResult<User> Put(int id, [FromBody] User user)
        {
            User u = _iService.Update(id, user);
            if (u == null)
                return NotFound();
            return u;
        }

        // DELETE api/<Users>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iService.Delete(id);
        }
    }
}
