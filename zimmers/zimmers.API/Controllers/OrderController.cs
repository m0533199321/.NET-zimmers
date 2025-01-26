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
        public IEnumerable<OrderDto> Get()
        {
            return _iService.Get();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public ActionResult<OrderDto> Get(int id)
        {
            OrderDto oDto = _iService.GetById(id);
            if (oDto == null)
                return NotFound();
            return oDto;
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult<OrderDto> Post([FromBody] OrderPostModel orderPostModel)
        {
            OrderDto orderDto = _mapper.Map<OrderDto>(orderPostModel);
            orderDto = _iService.Add(orderDto);
            if (orderDto == null)
                return NotFound();
            return orderDto;
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public ActionResult<OrderDto> Put(int id, [FromBody] OrderPostModel orderPostModel)
        {
            OrderDto orderDto = _mapper.Map<OrderDto>(orderPostModel);
            orderDto = _iService.Update(id, orderDto);
            if (orderDto == null)
                return NotFound();
            return orderDto;
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public ActionResult<bool> Delete(int id)
        {
            return _iService.Delete(id);
        }
    }
}
