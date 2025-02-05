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
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService _iService;
        private readonly IMapper _mapper;
        public OwnerController(IOwnerService iService, IMapper mapper)
        {
            _iService = iService;
            _mapper = mapper;
        }
        // GET: api/<OwnerController>
        [HttpGet]
        public async Task<IEnumerable<OwnerDto>> Get()
        {
            return await _iService.GetAsync();
        }

        // GET api/<OwnerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OwnerDto>> Get(int id)
        {
            OwnerDto ownerDto = await _iService.GetByIdAsync(id);
            if (ownerDto == null)
                return NotFound();
            return ownerDto;
        }

        // POST api/<OwnerController>
        [HttpPost]
        public async Task<ActionResult<OwnerDto>> Post([FromBody] OwnerPostModel ownerPostModel)
        {
            OwnerDto ownerDto = _mapper.Map<OwnerDto>(ownerPostModel);
            ownerDto = await _iService.AddAsync(ownerDto);
            if (ownerDto == null)
                return NotFound();
            return ownerDto;
        }

        // PUT api/<OwnerController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<OwnerDto>> Put(int id, [FromBody] OwnerPostModel ownerPostModel)
        {
            OwnerDto ownerDto = _mapper.Map<OwnerDto>(ownerPostModel);
            ownerDto = await _iService.UpdateAsync(id, ownerDto);
            if (ownerDto == null)
                return NotFound();
            return ownerDto;
        }

        // DELETE api/<OwnerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            return await _iService.DeleteAsync(id);
        }
    }
}
