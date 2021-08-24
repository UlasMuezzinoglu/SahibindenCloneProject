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


        public string UserFirstName { get; set; } // ilan sahibi kim ?
        public string UserLastName { get; set; } // ilan sahibi kim ?

        public string CityName { get; set; } // şehir id // tablo aç unutma
        public string HeatingTypeName { get; set; } // ısıtma tipi merkezi mi falan // tablo aç unutma
        public string DeedStatusName { get; set; } // tapu durumu id // tablo aç unutma
        public string FromWhoName { get; set; } // kimden id // tablo aç unutma
        public string HouseTypeName { get; set; } //satılık mı kiralık mı devren satılık mı falan // tablo aç unutma
        public string HomeTypeName { get; set; } //satılık mı kiralık mı devren satılık mı falan // tablo aç unutma
        

        public string ImagePath { get; set; }
        public int GrossSquareMeter { get; set; } // brüt metrekare
        public int NetSquareMeter { get; set; } // net metrekare
        public string NumberOfRooms { get; set; } // oda sayısı
        public string BuildingAge { get; set; } // bina yaşı
        public int NumberOfFloor { get; set; } // kat sayısı
        public int FloorLocation { get; set; } // kaçıncı kat
        public int NumberOfShower { get; set; } // banyo sayısı
        public bool Balcony { get; set; } // balkon var mı ?
        public bool IsFurnished { get; set; } // Eşyalı mı ?
        public bool IsInsideSite { get; set; } // site içinde mi ?
        public int Subscription { get; set; } // aidat
        public bool AvaiableForCredit { get; set; } //krediye uygun mu

        public bool IsSwapable { get; set; } // takasa açık mı ? 
                                             

        //
        // cephe
        public bool North { get; set; }
        public bool South { get; set; }
        public bool West { get; set; }
        public bool East { get; set; }

        // iç özellikler
        public bool Adsl { get; set; }
        public bool WoodJoinery { get; set; }
        public bool Smarthome { get; set; }
        public bool ThiefAlarm { get; set; }
        public bool FireAlarm { get; set; }
        public bool AluminumJoinery { get; set; }
        public bool AmericanDoor { get; set; }
        public bool AmericanKitchen { get; set; }
        public bool BuiltinOven { get; set; }
        public bool Barbeque { get; set; }
        public bool HouseholdAppliances { get; set; }
        public bool Painted { get; set; }
        public bool Wallpaper { get; set; }
        public bool ShowerCabin { get; set; }
        public bool ParentBath { get; set; }
        public bool FiberInternet { get; set; }
        public bool Oven { get; set; }
        public bool DressRoom { get; set; }
        public bool BuiltinWardrobe { get; set; }
        public bool BuiltinDiafon { get; set; }
        public bool Jacuzzi { get; set; }
        public bool AirConditioning { get; set; }
        public bool Bathtub { get; set; }
        public bool Furniture { get; set; }
        public bool BuildinKitchen { get; set; }
        public bool LaminateKitchen { get; set; }
        public bool Blinds { get; set; }
        public bool HardwoodFloor { get; set; }
        public bool LaminateFloor { get; set; }
        //dış özellikler
        public bool Elevator { get; set; }
        public bool Security { get; set; }
        public bool ThermalInsulation { get; set; }
        public bool Generator { get; set; }
        public bool CabloTv { get; set; }
        public bool CameraSystem { get; set; }
        public bool CloseGarage { get; set; }
        public bool DoorKeeper { get; set; }
        public bool PrivatePool { get; set; }
        public bool AutoPark { get; set; }
        public bool GamePark { get; set; }
        public bool SoundInsulation { get; set; }
        public bool SporSide { get; set; }
        public bool TennisCourt { get; set; }
        public bool FireStair { get; set; }
        public bool OpenPool { get; set; }
        public bool ClosePool { get; set; }
        // Muhit
        public bool Mall { get; set; }
        public bool Municipality { get; set; }
        public bool Mosque { get; set; }
        public bool SeeSide { get; set; }
        public bool Pharmacy { get; set; }
        public bool FunCenter { get; set; }
        public bool Fuar { get; set; }
        public bool Hospital { get; set; }
        public bool Church { get; set; }
        public bool HighSchool { get; set; }
        public bool PoliceStation { get; set; }
        public bool Collage { get; set; }
        public bool CityCenter { get; set; }
        public bool FiremanStation { get; set; }
        //
        
    }
}
