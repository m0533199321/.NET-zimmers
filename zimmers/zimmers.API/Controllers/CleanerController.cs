using Microsoft.AspNetCore.Mvc;
using zimmers.core.Entities;
using zimmers.core.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zimmers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CleanerController : ControllerBase
    {
        readonly IService<Cleaner> _iService;
        public CleanerController(IService<Cleaner> iService)
        {
            _iService = iService;
        }
        // GET: api/<CleanerController>
        [HttpGet]
        public ActionResult<IEnumerable<Cleaner>> Get()
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
        public ActionResult<bool> Post([FromBody] Cleaner cleaner)
        {
            return _iService.Add(cleaner);
        }

        // PUT api/<CleanerController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Cleaner cleaner)
        {
            return _iService.Update(id, cleaner);
        }

        // DELETE api/<CleanerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iService.Delete(id);
        }
    }
}
