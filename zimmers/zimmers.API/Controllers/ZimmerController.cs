using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using zimmers.API.PostModels;
using zimmers.core.DTOs;
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
        private readonly IMapper _mapper;
        public ZimmerController(IZimmerService iService, IMapper mapper)
        {
            _iService = iService;
            _mapper = mapper;
        }
        // GET: api/<ZimmerController>
        [HttpGet]
        public async Task<IEnumerable<ZimmerDto>> Get()
        {
            return await _iService.GetAsync();
        }

        // GET api/<ZimmerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ZimmerDto>> Get(int id)
        {
            ZimmerDto zimmerDto = await _iService.GetByIdAsync(id);
            if (zimmerDto == null)
                return NotFound();
            return zimmerDto;
        }

        // POST api/<ZimmerController>
        [HttpPost]
        public async Task<ActionResult<ZimmerDto>> Post([FromBody] ZimmerPostModel zimmerPostModel)
        {
            ZimmerDto zimmerDto = _mapper.Map<ZimmerDto>(zimmerPostModel);
            zimmerDto = await _iService.AddAsync(zimmerDto);
            if (zimmerDto == null)
                return NotFound();
            return zimmerDto;
        }

        // PUT api/<ZimmerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<ZimmerDto>> Put(int id, [FromBody] ZimmerPostModel zimmerPostModel)
        {
            ZimmerDto zimmerDto = _mapper.Map<ZimmerDto>(zimmerPostModel);
            zimmerDto = await _iService.UpdateAsync(id, zimmerDto);
            if (zimmerDto == null)
                return NotFound();
            return zimmerDto;
        }

        // DELETE api/<ZimmerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            return await _iService.DeleteAsync(id);
        }
    }
}
