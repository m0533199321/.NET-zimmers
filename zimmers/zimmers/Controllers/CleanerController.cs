using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;
using zimmers.Servicies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zimmers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CleanerController : ControllerBase
    {
        CleanerServicies service=new CleanerServicies();
        // GET: api/<CleanerController>
        [HttpGet]
        public IEnumerable<Cleaner> Get()
        {
            return service.Get();
        }

        // GET api/<CleanerController>/5
        [HttpGet("{id}")]
        public Cleaner Get(int id)
        {
            return service.GetById(id);
        }

        // POST api/<CleanerController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Cleaner cleaner)
        {
            return service.Post(cleaner);
        }

        // PUT api/<CleanerController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Cleaner cleaner)
        {
            return service.Put(id, cleaner);
        }

        // DELETE api/<CleanerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return service.Delete(id);
        }
    }
}
