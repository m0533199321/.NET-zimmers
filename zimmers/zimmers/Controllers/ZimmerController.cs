﻿using Microsoft.AspNetCore.Mvc;
using zimmers.Entities;
using zimmers.Servicies;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zimmers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ZimmerController : ControllerBase
    {
        ZimmerServicies service = new ZimmerServicies();
        // GET: api/<ZimmerController>
        [HttpGet]
        public ActionResult<IEnumerable<Zimmer>> Get()
        {
            return service.Get();
        }

        // GET api/<ZimmerController>/5
        [HttpGet("{id}")]
        public ActionResult<Zimmer> Get(int id)
        {
            Zimmer z = service.GetById(id);
            if (z==null)
                return NotFound();
            return z;
        }

        // POST api/<ZimmerController>
        [HttpPost]
        public ActionResult<bool> Post([FromBody] Zimmer zimmer)
        {
            return service.Add(zimmer);
        }

        // PUT api/<ZimmerController>/5
        [HttpPut("{id}")]
        public ActionResult<bool> Put(int id, [FromBody] Zimmer zimmer)
        {
            return service.Update(id, zimmer);
        }

        // DELETE api/<ZimmerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return service.Delete(id);
        }
    }
}
