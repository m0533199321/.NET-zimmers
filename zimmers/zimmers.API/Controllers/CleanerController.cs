using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using zimmers.API.PostModels;
using zimmers.core.DTOs;
using zimmers.core.Entities;
using zimmers.core.Interfaces.IService;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zimmers.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CleanerController : ControllerBase
    {
        private readonly ICleanerService _iService;
        private readonly IMapper _mapper;
        public CleanerController(ICleanerService iService, IMapper mapper)
        {
            _iService = iService;
            _mapper = mapper;
        }
        // GET: api/<CleanerController>
        [HttpGet]
        public async Task<IEnumerable<CleanerDto>> Get()
        {
            return await _iService.GetAsync();
        }

        // GET api/<CleanerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CleanerDto>> Get(int id)
        {
            CleanerDto cleanerDto = await _iService.GetByIdAsync(id);
            if (cleanerDto == null)
                return NotFound();
            return cleanerDto;
        }

        // POST api/<CleanerController>
        [HttpPost]
        public async Task<ActionResult<CleanerDto>> Post([FromBody] CleanerPostModel cleanerPostModel)
        {
            CleanerDto cleanerDto = _mapper.Map<CleanerDto>(cleanerPostModel);
            cleanerDto = await _iService.AddAsync(cleanerDto);
            if (cleanerDto == null)
                return NotFound();
            return cleanerDto;
        }

        // PUT api/<CleanerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<CleanerDto>> Put(int id, [FromBody] CleanerPostModel cleanerPostModel)
        {
            CleanerDto cleanerDto = _mapper.Map<CleanerDto>(cleanerPostModel);
            cleanerDto = await _iService.UpdateAsync(id, cleanerDto);
            if (cleanerDto == null)
                return BadRequest();
            return cleanerDto;
        }

        // DELETE api/<CleanerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            return await _iService.DeleteAsync(id);
        }
    }
}
