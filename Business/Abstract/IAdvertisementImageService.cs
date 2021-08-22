using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdvertisementImageService
    {
        IDataResult<List<AdvertisementImage>> GetAll();

        IDataResult<AdvertisementImage> GetById(int id);
        IDataResult<List<AdvertisementImage>> GetByAdvertisementId(int advertisementId);

        IResult Add(AdvertisementImage advertisementImage, IFormFile file);
        IResult Delete(AdvertisementImage advertisementImage);
        IResult Update(AdvertisementImage advertisementImage, IFormFile file);
    }
}
