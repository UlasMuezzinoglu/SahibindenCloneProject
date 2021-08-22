using Business.Abstract;
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
            return new SuccessResult("İlan Resmi Başarı İle Eklendi");

        }

        public IResult Delete(AdvertisementImage advertisementImage)
        {
            try
            {
                var imageDelete = _advertisementDal.Get(c => c.Id == advertisementImage.Id);
                if (imageDelete == null)
                {
                    return new ErrorResult("Resim Bulunamadı");
                }
                _advertisementDal.Delete(advertisementImage);

                return new SuccessResult("Resim Başarı İle Silindi");
            }
            catch (Exception)
            {

                return new ErrorResult("Resim Silinemedi");
            }
        }

        public IDataResult<List<AdvertisementImage>> GetAll()
        {
            return new SuccessDataResult<List<AdvertisementImage>>(_advertisementDal.GetAll(), "Bütün Resimler Listelendi");
        }

        public IDataResult<List<AdvertisementImage>> GetByAdvertisementId(int advertisementId)
        {
            // unutma default resim features'i getir
            return new SuccessDataResult<List<AdvertisementImage>>(_advertisementDal.GetAll(c => c.AdvertisementId == advertisementId));
        }

        public IDataResult<AdvertisementImage> GetById(int id)
        {
            return new SuccessDataResult<AdvertisementImage>(_advertisementDal.Get(c => c.Id == id), "İlan Resimleri Listelendi");
        }

        public IResult Update(AdvertisementImage advertisementImage, IFormFile file)
        {
            var imageDelete = _advertisementDal.Get(c => c.Id == advertisementImage.Id);
            if (imageDelete == null)
            {
                return new ErrorResult("Bulunamadı");
            }
            var updatedFile = _fileHelper.Update(file, imageDelete.ImagePath);
            if (!updatedFile.Success)
            {
                return new ErrorResult(updatedFile.Message);
            }
            advertisementImage.ImagePath = updatedFile.Message;
            _advertisementDal.Update(advertisementImage);

            return new SuccessResult("Resim Başarılı İle Güncellendi");
        }
        public IResult IsOverflowCarImageCount(int advertisementId)
        {
            var result = _advertisementDal.GetAll(im => im.AdvertisementId == advertisementId);

            if (result.Count >= 20)
            {
                return new ErrorResult("Resim Sayısı 20 yi aştı...");
            }

            return new SuccessResult();

        }
    }
}
