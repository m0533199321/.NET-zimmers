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
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _iService;
        private readonly IMapper _mapper;
        public OrderController(IOrderService iService, IMapper mapper)
        {
            _iService = iService;
            _mapper = mapper;
        }
        // GET: api/<OrderController>
        [HttpGet]
        public async Task<IEnumerable<OrderDto>> Get()
        {
            return await _iService.GetAsync();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderDto>> Get(int id)
        {
            OrderDto oDto = await _iService.GetByIdAsync(id);
            if (oDto == null)
                return NotFound();
            return oDto;
        }

        // POST api/<OrderController>
        [HttpPost]
        public async Task<ActionResult<OrderDto>> Post([FromBody] OrderPostModel orderPostModel)
        {
            OrderDto orderDto = _mapper.Map<OrderDto>(orderPostModel);
            orderDto = await _iService.AddAsync(orderDto);
            if (orderDto == null)
                return NotFound();
            return orderDto;
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult<OrderDto>> Put(int id, [FromBody] OrderPostModel orderPostModel)
        {
            OrderDto orderDto = _mapper.Map<OrderDto>(orderPostModel);
            orderDto = await _iService.UpdateAsync(id, orderDto);
            if (orderDto == null)
                return NotFound();
            return orderDto;
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            return await _iService.DeleteAsync(id);
        }
    }
}
