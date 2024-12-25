using Microsoft.AspNetCore.Mvc;
using zimmers.core.Entities;
using zimmers.core.Interfaces.IService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zimmers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CleanerController : ControllerBase
    {
        readonly ICleanerService _iService;
        public CleanerController(ICleanerService iService)
        {
            _iService = iService;
        }
        // GET: api/<CleanerController>
        [HttpGet]
        public IEnumerable<Cleaner> Get()
        {
            return _iService.Get();
        }

        // GET api/<CleanerController>/5
        [HttpGet("{id}")]
        public ActionResult<Cleaner> Get(int id)
        {
            Cleaner c = _iService.GetById(id);
            if (c == null)
                return NotFound();
            return c;
        }

        // POST api/<CleanerController>
        [HttpPost]
        public ActionResult<Cleaner> Post([FromBody] Cleaner cleaner)
        {
            Cleaner c = _iService.Add(cleaner);
            if (c == null)
                return NotFound();
            return c;
        }

        // PUT api/<CleanerController>/5
        [HttpPut("{id}")]
        public ActionResult<Cleaner> Put(int id, [FromBody] Cleaner cleaner)
        {
            Cleaner c = _iService.Update(id, cleaner);
            if (c == null)
                return BadRequest();
            return c;
        }

        // DELETE api/<CleanerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iService.Delete(id);
        }
    }
}
