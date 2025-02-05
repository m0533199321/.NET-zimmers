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
    public class UserController : ControllerBase
    {
        private readonly IUserService _iService;
        private readonly IMapper _mapper;
        public UserController(IUserService iService, IMapper mapper)
        {
            _iService = iService;
            _mapper = mapper;
        }
        // GET: api/<Users>
        [HttpGet]
        public async Task<IEnumerable<UserDto>> Get()
        {
            return await _iService.GetAsync();
        }

        // GET api/<Users>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserDto>> Get(int id)
        {
            UserDto userDto = await _iService.GetByIdAsync(id);
            if (userDto == null)
                return NotFound();
            return userDto;
        }

        // POST api/<Users>
        [HttpPost]
        public async Task<ActionResult<UserDto>> Post([FromBody] UserPostModel userPostModel)
        {
            UserDto userDto = _mapper.Map<UserDto>(userPostModel);
            userDto = await _iService.AddAsync(userDto);
            if (userDto == null)
                return NotFound();
            return userDto;
        }

        // PUT api/<Users>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<UserDto>> Put(int id, [FromBody] UserPostModel userPostModel)
        {
            UserDto userDto = _mapper.Map<UserDto>(userPostModel);
            userDto = await _iService.UpdateAsync(id, userDto);
            if (userDto == null)
                return NotFound();
            return userDto;
        }

        // DELETE api/<Users>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            return await _iService.DeleteAsync(id);
        }
    }
}
