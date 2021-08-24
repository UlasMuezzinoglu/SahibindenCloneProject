using Business.Abstract.Estate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers.Estate
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildingAgesController : ControllerBase
    {
        IBuildingAgeService _buildingAgeService;

        public BuildingAgesController(IBuildingAgeService buildingAgeService)
        {
            _buildingAgeService = buildingAgeService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _buildingAgeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }


            //return NotFound(result);
            return BadRequest(result);
            //return Unauthorized(result);
        }
    }
}
