using Business.Abstract;
using Entities.Concrete.Estate.Home;
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
    public class HouseAdvertisementsController : ControllerBase
    {
        IHouseAdvertisementService _houseAdvertisementService;

        public HouseAdvertisementsController(IHouseAdvertisementService houseAdvertisementService)
        {
            _houseAdvertisementService = houseAdvertisementService;
        }
        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _houseAdvertisementService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }


            //return NotFound(result);
            return BadRequest(result);
            //return Unauthorized(result);
        }
        [HttpGet("getalldetailswithdto")]
        public IActionResult GetWithDto()
        {
            var result = _houseAdvertisementService.GetHouseAdvertisementDetailDto();
            if (result.Success)
            {
                return Ok(result);
            }


            //return NotFound(result);
            return BadRequest(result);
            //return Unauthorized(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _houseAdvertisementService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }


            //return NotFound(result);
            return BadRequest(result);
            //return Unauthorized(result);
        }
        [HttpGet("getbyuserid")]
        public IActionResult GetByUserId(int userId)
        {
            var result = _houseAdvertisementService.GetByUserId(userId);
            if (result.Success)
            {
                return Ok(result);
            }


            //return NotFound(result);
            return BadRequest(result);
            //return Unauthorized(result);
        }
        [HttpPost("add")]
        public IActionResult Add(HouseAdvertisement houseAdvertisement)
        {
            var result = _houseAdvertisementService.Add(houseAdvertisement);

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }


        [HttpPost("updatehouse")]
        public IActionResult Update(HouseAdvertisement houseAdvertisement)
        {
            var result = _houseAdvertisementService.Update(houseAdvertisement);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpPost("deletehouse")]
        public IActionResult Delete(HouseAdvertisement houseAdvertisement)
        {
            var result = _houseAdvertisementService.Delete(houseAdvertisement);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
