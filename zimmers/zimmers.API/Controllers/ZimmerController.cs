using Microsoft.AspNetCore.Mvc;
using zimmers.core.Entities;
using zimmers.core.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zimmers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZimmerController : ControllerBase
    {
        readonly IService<Zimmer> _iService;
        public ZimmerController(IService<Zimmer> iService)
        {
            _iService = iService;
        }
        // GET: api/<ZimmerController>
        [HttpGet]
        public ActionResult<IEnumerable<Zimmer>> Get()
        {
            return _iService.Get();
        }

        // GET api/<ZimmerController>/5
        [HttpGet("{id}")]
        public ActionResult<Zimmer> Get(int id)
        {
            Zimmer z = _iService.GetById(id);
            if (z == null)
                return NotFound();
            return z;
        }

        // POST api/<ZimmerController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Zimmer zimmer)
        {
            return _iService.Add(zimmer);
        }

        // PUT api/<ZimmerController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Zimmer zimmer)
        {
            return _iService.Update(id, zimmer);
        }

        // DELETE api/<ZimmerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iService.Delete(id);
        }
    }
}
