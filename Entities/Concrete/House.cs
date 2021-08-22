using Core.Entities;
using Entities.concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class House : Advertisement,IEntity
    {
        public int UserId { get; set; } // ilan sahibi kim ?
        public int HouseTypeId { get; set; } //satılık mı kiralık mı devren satılık mı falan // tablo aç unutma
        public int GrossSquareMeter { get; set; } // brüt metrekare
        public int NetSquareMeter { get; set; } // net metrekare
        public string NumberOfRooms { get; set; } // oda sayısı
        public string BuildingAge { get; set; } // bina yaşı
        public int NumberOfFloor { get; set; } // kat sayısı
        public int FloorLocation { get; set; } // kaçıncı kat
        public int HeatingTypeId { get; set; } // ısıtma tipi merkezi mi falan // tablo aç unutma
        public int NumberOfShower { get; set; } // banyo sayısı
        public bool Balcony { get; set; } // balkon var mı ?
        public bool IsFurnished { get; set; } // Eşyalı mı ?
        public bool IsInsideSite { get; set; } // site içinde mi ?
        public int Subscription { get; set; } // aidat
        public bool AvaiableForCredit { get; set; } //krediye uygun mu
        public int DeedStatusId { get; set; } // tapu durumu id // tablo aç unutma
        public int FromWhoId { get; set; } // kimden id // tablo aç unutma
        public bool IsSwapable { get; set; } // takasa açık mı ? 
        //
        public int CityId { get; set; } // şehir id // tablo aç unutma
        


    }
}
