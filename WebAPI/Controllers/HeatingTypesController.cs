using Business.Abstract;
using DataAccess.Abstact;
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
    public class HeatingTypesController : ControllerBase
    {
        IHeatingTypeService _heatingTypeService;

        public HeatingTypesController(IHeatingTypeService heatingTypeService)
        {
            _heatingTypeService = heatingTypeService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _heatingTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }


            //return NotFound(result);
            return BadRequest(result);
            //return Unauthorized(result);
        }
        [HttpPost("add")]
        public IActionResult Add(HeatingType heatingType)
        {
            var result = _heatingTypeService.Add(heatingType);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("updateheatingtype")]
        public IActionResult Update(HeatingType heatingType)
        {
            var result = _heatingTypeService.Update(heatingType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deleteheatingtype")]
        public IActionResult Delete(HeatingType heatingType)
        {
            var result = _heatingTypeService.Delete(heatingType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
