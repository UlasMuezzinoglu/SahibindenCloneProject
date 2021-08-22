using Business.Abstract;
using Entities.Concrete;
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
    public class HouseTypesController : ControllerBase
    {
        IHouseTypeService _houseTypeService;

        public HouseTypesController(IHouseTypeService houseTypeService)
        {
            _houseTypeService = houseTypeService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _houseTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }


            //return NotFound(result);
            return BadRequest(result);
            //return Unauthorized(result);
        }
        [HttpPost("add")]
        public IActionResult Add(HouseType houseType)
        {
            var result = _houseTypeService.Add(houseType);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("updatehouseType")]
        public IActionResult Update(HouseType houseType)
        {
            var result = _houseTypeService.Update(houseType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deletehouseType")]
        public IActionResult Delete(HouseType houseType)
        {
            var result = _houseTypeService.Delete(houseType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
