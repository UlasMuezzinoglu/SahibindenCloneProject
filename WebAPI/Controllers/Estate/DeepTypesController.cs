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
    public class DeepTypesController : ControllerBase
    {
        IDeedTypeService _deedTypeService;

        public DeepTypesController(IDeedTypeService deedTypeService)
        {
            _deedTypeService = deedTypeService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _deedTypeService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }


            //return NotFound(result);
            return BadRequest(result);
            //return Unauthorized(result);
        }
        [HttpPost("add")]
        public IActionResult Add(DeedType deedType)
        {
            var result = _deedTypeService.Add(deedType);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        

        [HttpPost("updatedeedtype")]
        public IActionResult Update(DeedType deedType)
        {
            var result = _deedTypeService.Update(deedType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deletedeedtype")]
        public IActionResult Delete(DeedType deedType)
        {
            var result = _deedTypeService.Delete(deedType);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
