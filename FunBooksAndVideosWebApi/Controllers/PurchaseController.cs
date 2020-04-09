using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using FunBooksAndVideosWebApi.Mapping;
using FunBooksAndVideosWebApi.RequestResponse;
using FunBooksAndVideosWebApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FunBooksAndVideosWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseController : ControllerBase
    {
        private IPurchaseOrderService _purchaseOrderService;
        private IMappingService _mapper;

        public PurchaseController(IPurchaseOrderService purchaseOrderService, IMappingService mapper)
        {
            _purchaseOrderService = purchaseOrderService;
            _mapper = mapper;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult Post([FromBody]PurchaseOrderDto purchaseOrderDto)
        {
            if (purchaseOrderDto == null)
            {
                return BadRequest("Purchse order object is null");
            }
            _purchaseOrderService.Process(_mapper.Map(purchaseOrderDto));
            //ideally shpuld be returning 201 with location header but for simplicity we can return 200
            return Ok();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
