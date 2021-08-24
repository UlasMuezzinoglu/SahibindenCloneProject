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
    public class FromWhosController : ControllerBase
    {
        IFromWhoService _fromWhoService;

        public FromWhosController(IFromWhoService fromWhoService)
        {
            _fromWhoService = fromWhoService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _fromWhoService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }


            //return NotFound(result);
            return BadRequest(result);
            //return Unauthorized(result);
        }
        [HttpPost("add")]
        public IActionResult Add(FromWho fromWho)
        {
            var result = _fromWhoService.Add(fromWho);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("updatefromwho")]
        public IActionResult Update(FromWho fromWho)
        {
            var result = _fromWhoService.Update(fromWho);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deletefromwho")]
        public IActionResult Delete(FromWho fromWho)
        {
            var result = _fromWhoService.Delete(fromWho);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
