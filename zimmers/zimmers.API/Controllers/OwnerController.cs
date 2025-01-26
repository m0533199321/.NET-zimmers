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
        public IEnumerable<OwnerDto> Get()
        {
            return _iService.Get();
        }

        // GET api/<OwnerController>/5
        [HttpGet("{id}")]
        public ActionResult<OwnerDto> Get(int id)
        {
            OwnerDto ownerDto = _iService.GetById(id);
            if (ownerDto == null)
                return NotFound();
            return ownerDto;
        }

        // POST api/<OwnerController>
        [HttpPost]
        public ActionResult<OwnerDto> Post([FromBody] OwnerPostModel ownerPostModel)
        {
            OwnerDto ownerDto = _mapper.Map<OwnerDto>(ownerPostModel);
            ownerDto = _iService.Add(ownerDto);
            if (ownerDto == null)
                return NotFound();
            return ownerDto;
        }

        // PUT api/<OwnerController>/5
        [HttpPut("{id}")]
        public ActionResult<OwnerDto> Put(int id, [FromBody] OwnerPostModel ownerPostModel)
        {
            OwnerDto ownerDto = _mapper.Map<OwnerDto>(ownerPostModel);
            ownerDto = _iService.Update(id, ownerDto);
            if (ownerDto == null)
                return NotFound();
            return ownerDto;
        }

        // DELETE api/<OwnerController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iService.Delete(id);
        }
    }
}
