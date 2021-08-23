using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constraints
{
    public static class Messages
    {
        // Auth Manager Messages
        public static string AuthSuccess = "Kayıt oldu";
        public static string UserNotExist = "Kullanıcı Bulunamadı";
        public static string UserExist = "Kullanıcı Mevcut";
        public static string WrongPassword = "Parola Hatası";
        public static string SuccessfulLogin = "Başarılı Giriş";
        public static string TokenCreated = "Token Oluşturuldu";

        // City Manager Messages
        public static string CityAdded = "Şehir Eklendi";
        public static string CitiesListed = "Şehirler Listelendi";
        // DeedType Manager Messages
        public static string DeedTypeAdded = "Tapu Tipi Başarı ile Eklendi";
        public static string DeedTypeDeleted = "Tapu Tipi Başarı ile Silindi";
        public static string DeedTypeCantDeledet = "Tapu Tipi Silinemedi... Böyle Birşey Artık Olmayabilir.";
        public static string DeedTypesListed = "Tapu Tipleri Başarı ile Listelendi";
        public static string DeedTypeUpdated = "Tapu Tipi Başarı ile Güncellendi";
        public static string DeedTypeCantUpdated = "Tapu Tipi Güncellenemedi... Böyle Birşey Artık Olmayabilir";
        // FromWho Manager Messages
        public static string FromWhoAdded = "Kimden Tipi Başarı ile Eklendi";
        public static string FromWhoDeleted = "Kimden Tipi Başarı ile Silindi";
        public static string FromWhoCantDeledet = "Kimden Tipi Silinemedi... Böyle Birşey Artık Olmayabilir.";
        public static string FromWhosListed = "Kimden Tipleri Başarı ile Listelendi";
        public static string FromWhoUpdated = "Kimden Tipi Başarı ile Güncellendi";
        public static string FromWhoCantUpdated = "Kimden Tipi Güncellenemedi... Böyle Birşey Artık Olmayabilir";
        // HeatingType Manager Messages
        public static string HeatingTypeAdded = "Isıtma Tipi Başarı ile Eklendi";
        public static string HeatingTypeDeleted = "Isıtma Tipi Başarı ile Silindi";
        public static string HeatingTypeCantDeledet = "Isıtma Tipi Silinemedi... Böyle Birşey Artık Olmayabilir.";
        public static string HeatingTypesListed = "Isıtma Tipleri Başarı ile Listelendi";
        public static string HeatingTypeUpdated = "Isıtma Tipi Başarı ile Güncellendi";
        public static string HeatingTypeCantUpdated = "Isıtma Tipi Güncellenemedi... Böyle Birşey Artık Olmayabilir";
        // HouseType Manager Messages
        public static string HouseTypeAdded = "Emlak Tipi Başarı ile Eklendi";
        public static string HouseTypeDeleted = "Emlak Tipi Başarı ile Silindi";
        public static string HouseTypeCantDeledet = "Emlak Tipi Silinemedi... Böyle Birşey Artık Olmayabilir.";
        public static string HouseTypesListed = "Emlak Tipleri Başarı ile Listelendi";
        public static string HouseTypeUpdated = "Emlak Tipi Başarı ile Güncellendi";
        public static string HouseTypeCantUpdated = "Emlak Tipi Güncellenemedi... Böyle Birşey Artık Olmayabilir";
        // House Manager Messages
        public static string HouseAdded = "Emlak İlanı Başarı ile Eklendi";
        public static string HouseDeleted = "Emlak İlanı Başarı ile Silindi";
        public static string HouseCantDeledet = "Emlak İlanı Silinemedi... Böyle Birşey Artık Olmayabilir.";
        public static string HousesListed = "Emlak İlanı Başarı ile Listelendi";
        public static string HouseAdvertisementListedDetailDto = "Emlak İlanı Başarı ile Getirildi";
        public static string HousesListedById = "Emlak İlanı Id ye Göre Başarı ile Listelendi";
        public static string HousesListedByUserId = "Emlak İlanı Kullanıcıya Göre Başarı ile Listelendi";
        public static string HouseUpdated = "Emlak İlanı Başarı ile Güncellendi";
        public static string HouseCantUpdated = "Emlak İlanı Güncellenemedi... Böyle Birşey Artık Olmayabilir";
        // AdvertisementImage Manager Messages
        public static string AdvertisementImageAdded = "İlan Resimi Tipi Başarı ile Eklendi";
        public static string AdvertisementImageNotExist = "İlan Resimi Mevcut Değil";
        public static string AdvertisementImageError = "Hata !";
        public static string AdvertisementImageCountOverflowError = "Resim Sayısı 20 yi aştı...";
        public static string AdvertisementImageDeleted = "İlan Resimi Başarı ile Silindi";
        public static string AdvertisementImageCantDeleded = "İlan Resimi Silinemedi... Böyle Birşey Artık Olmayabilir.";
        public static string AdvertisementImagesListed = "İlan Resimleri Başarı ile Listelendi";
        public static string AdvertisementImageUpdated = "İlan Resimi Başarı ile Güncellendi";
        public static string AdvertisementImageCantUpdated = "İlan Resimi Güncellenemedi... Böyle Birşey Artık Olmayabilir";

    }
}
