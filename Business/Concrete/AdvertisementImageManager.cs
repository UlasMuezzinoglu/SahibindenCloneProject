using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constraints;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Performance;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstact;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AdvertisementImageManager : IAdvertisementImageService
    {
        IAdvertisementImageDal _advertisementDal;
        IFileHelper _fileHelper;

        public AdvertisementImageManager(IAdvertisementImageDal advertisementDal, IFileHelper fileHelper)
        {
            _advertisementDal = advertisementDal;
            _fileHelper = fileHelper;
        }

        //[SecuredOperation("admin")]
        [CacheRemoveAspect("IAdvertisementImageService.Get")]
        public IResult Add(AdvertisementImage advertisementImage, IFormFile file)
        {
            IResult result = BusinessRules.Run(IsOverflowCarImageCount(advertisementImage.AdvertisementId));
            
            if (result != null)
            {
                return new ErrorResult(result.Message);
            }

            var imageResult = _fileHelper.Upload(file);
            if (!imageResult.Success)
            {
                return new ErrorResult(imageResult.Message);
            }
            advertisementImage.ImagePath = imageResult.Message;
            advertisementImage.Date = DateTime.Now;
            _advertisementDal.Add(advertisementImage);
            return new SuccessResult(Messages.AdvertisementImageAdded);

        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("IAdvertisementImageService.Get")]
        public IResult Delete(AdvertisementImage advertisementImage)
        {
            try
            {
                var imageDelete = _advertisementDal.Get(c => c.Id == advertisementImage.Id);
                if (imageDelete == null)
                {
                    return new ErrorResult(Messages.AdvertisementImageNotExist);
                }
                _advertisementDal.Delete(advertisementImage);

                return new SuccessResult(Messages.AdvertisementImageDeleted);
            }
            catch (Exception)
            {

                return new ErrorResult(Messages.AdvertisementImageCantDeleded);
            }
        }

        [CacheAspect]
        public IDataResult<List<AdvertisementImage>> GetAll()
        {
            return new SuccessDataResult<List<AdvertisementImage>>(_advertisementDal.GetAll(), Messages.AdvertisementImagesListed);
        }

        [CacheAspect]
        [PerformanceAspect(7)] // bu metotun çalışması 7 saniyeyi geçerce beni uyar
        public IDataResult<List<AdvertisementImage>> GetByAdvertisementId(int advertisementId)
        {
            var result = BusinessRules.Run(ShowDefaultImage(advertisementId));
            if (result == null)
            {
                return new SuccessDataResult<List<AdvertisementImage>>(_advertisementDal.GetAll(c => c.AdvertisementId == advertisementId));
            }
            return new ErrorDataResult<List<AdvertisementImage>>(Messages.AdvertisementImageError);

        }

        [CacheAspect]
        public IDataResult<AdvertisementImage> GetById(int id)
        {
            return new SuccessDataResult<AdvertisementImage>(_advertisementDal.Get(c => c.Id == id), Messages.AdvertisementImagesListed);
        }

        [SecuredOperation("admin")]
        [CacheRemoveAspect("IAdvertisementImageService.Get")]
        public IResult Update(AdvertisementImage advertisementImage, IFormFile file)
        {
            var imageDelete = _advertisementDal.Get(c => c.Id == advertisementImage.Id);
            if (imageDelete == null)
            {
                return new ErrorResult(Messages.AdvertisementImageError);
            }
            var updatedFile = _fileHelper.Update(file, imageDelete.ImagePath);
            if (!updatedFile.Success)
            {
                return new ErrorResult(updatedFile.Message);
            }
            advertisementImage.ImagePath = updatedFile.Message;
            _advertisementDal.Update(advertisementImage);

            return new SuccessResult(Messages.AdvertisementImageUpdated);
        }
        public IResult IsOverflowCarImageCount(int advertisementId)
        {
            var result = _advertisementDal.GetAll(im => im.AdvertisementId == advertisementId);

            if (result.Count >= 20)
            {
                return new ErrorResult(Messages.AdvertisementImageCountOverflowError);
            }

            return new SuccessResult();

        }
        private IResult ShowDefaultImage(int advertisementId)
        {


            try
            {
                string path = @"\images\default.png";
                var result = _advertisementDal.GetAll(c => c.AdvertisementId == advertisementId).Any();
                if (result)
                {
                    List<AdvertisementImage> advertisementImage = new List<AdvertisementImage>();
                    advertisementImage.Add(new AdvertisementImage { AdvertisementId = advertisementId, Date = DateTime.Now, ImagePath = path });
                    return new SuccessDataResult<List<AdvertisementImage>>(advertisementImage);
                }
            }
            catch (Exception)
            {

                return new ErrorDataResult<List<AdvertisementImage>>(Messages.AdvertisementImageError);
            }
            return new SuccessDataResult<List<AdvertisementImage>>(_advertisementDal.GetAll(c => c.AdvertisementId == advertisementId).ToList());

        }
    }
}
