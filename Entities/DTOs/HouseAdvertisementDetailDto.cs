using Core.Entities;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class HouseAdvertisementDetailDto :Advertisement,IDto
    {
        public string UserFirstName { get; set; } 
        public string UserLastName { get; set; }
        public string HouseTypeName { get; set; } //satılık mı kiralık mı devren satılık mı falan // tablo aç unutma
        public int GrossSquareMeter { get; set; } // brüt metrekare
        public int NetSquareMeter { get; set; } // net metrekare
        public string NumberOfRooms { get; set; } // oda sayısı
        public string BuildingAge { get; set; } // bina yaşı
        public int NumberOfFloor { get; set; } // kat sayısı
        public int FloorLocation { get; set; } // kaçıncı kat
        public string HeatingTypeName { get; set; } // ısıtma tipi merkezi mi falan // tablo aç unutma
        public int NumberOfShower { get; set; } // banyo sayısı
        public bool Balcony { get; set; } // balkon var mı ?
        public bool IsFurnished { get; set; } // Eşyalı mı ?
        public bool IsInsideSite { get; set; } // site içinde mi ?
        public int Subscription { get; set; } // aidat
        public bool AvaiableForCredit { get; set; } //krediye uygun mu
        public string DeedStatusName { get; set; } // tapu durumu id // tablo aç unutma
        public string FromWhoName { get; set; } // kimden id // tablo aç unutma
        public bool IsSwapable { get; set; } // takasa açık mı ? 
        //
        public string CityName { get; set; } // şehir id // tablo aç unutma
    }
}
