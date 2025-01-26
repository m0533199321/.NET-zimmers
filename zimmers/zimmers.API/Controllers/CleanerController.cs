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
        public IEnumerable<CleanerDto> Get()
        {
            return _iService.Get();
        }

        // GET api/<CleanerController>/5
        [HttpGet("{id}")]
        public ActionResult<CleanerDto> Get(int id)
        {
            CleanerDto cleanerDto = _iService.GetById(id);
            if (cleanerDto == null)
                return NotFound();
            return cleanerDto;
        }

        // POST api/<CleanerController>
        [HttpPost]
        public ActionResult<CleanerDto> Post([FromBody] CleanerPostModel cleanerPostModel)
        {
            CleanerDto cleanerDto = _mapper.Map<CleanerDto>(cleanerPostModel);
            cleanerDto = _iService.Add(cleanerDto);
            if (cleanerDto == null)
                return NotFound();
            return cleanerDto;
        }

        // PUT api/<CleanerController>/5
        [HttpPut("{id}")]
        public ActionResult<CleanerDto> Put(int id, [FromBody] CleanerPostModel cleanerPostModel)
        {
            CleanerDto cleanerDto = _mapper.Map<CleanerDto>(cleanerPostModel);
            cleanerDto = _iService.Update(id, cleanerDto);
            if (cleanerDto == null)
                return BadRequest();
            return cleanerDto;
        }

        // DELETE api/<CleanerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iService.Delete(id);
        }
    }
}
