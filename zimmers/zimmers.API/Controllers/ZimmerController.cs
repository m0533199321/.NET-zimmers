using Microsoft.AspNetCore.Mvc;
using zimmers.core.Entities;
using zimmers.core.Interfaces;
using zimmers.core.Interfaces.IService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zimmers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZimmerController : ControllerBase
    {
        private readonly IZimmerService _iService;
        public ZimmerController(IZimmerService iService)
        {
            _iService = iService;
        }
        // GET: api/<ZimmerController>
        [HttpGet]
        public IEnumerable<Zimmer> Get()
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
        public ActionResult<Zimmer> Post([FromBody] Zimmer zimmer)
        {
            Zimmer z = _iService.Add(zimmer);
            if (z == null)
                return NotFound();
            return z;
        }

        // PUT api/<ZimmerController>/5
        [HttpPut("{id}")]
        public ActionResult<Zimmer> Put(int id, [FromBody] Zimmer zimmer)
        {
            Zimmer z = _iService.Update(id, zimmer);
            if (z == null)
                return NotFound();
            return z;
        }

        // DELETE api/<ZimmerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iService.Delete(id);
        }
    }
}
