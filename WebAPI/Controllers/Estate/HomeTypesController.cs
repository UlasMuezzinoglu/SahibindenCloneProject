using Business.Abstract;
using Entities.Concrete.Estate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeTypesController : ControllerBase
    {
        IHomeTypeService _homeTypeService;

        public HomeTypesController(IHomeTypeService homeTypeService)
        {
            _homeTypeService = homeTypeService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _homeTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }


            //return NotFound(result);
            return BadRequest(result);
            //return Unauthorized(result);
        }
        [HttpPost("add")]
        public IActionResult Add(HomeType homeType)
        {
            var result = _homeTypeService.Add(homeType);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
