using Microsoft.AspNetCore.Mvc;
using zimmers.core.Entities;
using zimmers.core.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zimmers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        readonly IService<Owner> _iService;
        public OwnerController(IService<Owner> iService)
        {
            _iService = iService;
        }
        // GET: api/<OwnerController>
        [HttpGet]
        public ActionResult<IEnumerable<Owner>> Get()
        {
            return _iService.Get();
        }

        // GET api/<OwnerController>/5
        [HttpGet("{id}")]
        public ActionResult<Owner> Get(int id)
        {
            Owner o = _iService.GetById(id);
            if (o == null)
                return NotFound();
            return o;
        }

        // POST api/<OwnerController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Owner owner)
        {
            return _iService.Add(owner);
        }

        // PUT api/<OwnerController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Owner owner)
        {
            return _iService.Update(id, owner);
        }

        // DELETE api/<OwnerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iService.Delete(id);
        }
    }
}
