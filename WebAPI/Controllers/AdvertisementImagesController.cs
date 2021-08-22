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
    public class AdvertisementImagesController : ControllerBase
    {
        IAdvertisementImageService _advertisementImageService;

        public AdvertisementImagesController(IAdvertisementImageService advertisementImageService)
        {
            _advertisementImageService = advertisementImageService;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _advertisementImageService.GetAll();

            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpPost("add")]
        public IActionResult Add(IFormFile file, [FromForm] AdvertisementImage advertisementImage)
        {
            var result = _advertisementImageService.Add(advertisementImage, file);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpDelete("delete")]
        public IActionResult Delete([FromForm(Name = ("id"))] int id)
        {
            var deleteCarImage = _advertisementImageService.GetById(id).Data;
            var result = _advertisementImageService.Delete(deleteCarImage);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
        [HttpPut("update")]
        public IActionResult Update([FromForm] AdvertisementImage advertisementImage,  IFormFile file)
        {
            var result = _advertisementImageService.Update(advertisementImage, file);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }

        [HttpGet("getbyadvertisementid")]
        public IActionResult GetByAdvertisementId(int advertisementId)
        {
            var result = _advertisementImageService.GetByAdvertisementId(advertisementId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result.Message);
        }
    }
}
