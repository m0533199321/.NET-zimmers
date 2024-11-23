using Microsoft.AspNetCore.Mvc;
using zimmers.core.Entities;
using zimmers.core.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zimmers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly IService<User> _iService;
        public UserController(IService<User> iService)
        {
            _iService = iService;
        }
        // GET: api/<Users>
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
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
        public ActionResult<bool> Post([FromBody] User user)
        {
            return _iService.Add(user);
        }

        // PUT api/<Users>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] User user)
        {
            return _iService.Update(id, user);
        }

        // DELETE api/<Users>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iService.Delete(id);
        }
    }
}
