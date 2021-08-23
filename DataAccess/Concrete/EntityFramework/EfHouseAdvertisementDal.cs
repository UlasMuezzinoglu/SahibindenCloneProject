using Core.DataAccess.EntityFramework;
using DataAccess.Abstact;
using Entities.Concrete.Estate.Home;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHouseAdvertisementDal : EfEntityRepositoryBase<HouseAdvertisement, SahibindenCloneContext>, IHouseAdvertisementDal
    {
        public List<HouseAdvertisementDetailDto> GetHouseAdvertisementDetails()
        {
            using (SahibindenCloneContext context = new SahibindenCloneContext())
            {
                var result = from house in context.Houses
                             join us in context.Users
                             on house.UserId equals us.Id
                             join xy in context.HomeTypes
                             on house.HomeTypeId equals xy.Id
                             join hstp in context.HouseTypes
                             on house.HouseTypeId equals hstp.Id
                             join hetp in context.HeatingTypes
                             on house.HeatingTypeId equals hetp.Id
                             join frwh in context.FromWhos
                             on house.FromWhoId equals frwh.Id
                             join dests in context.DeedTypes
                             on house.DeedStatusId equals dests.Id
                             join cty in context.Cities
                             on house.CityId equals cty.Id
                             
                             select new HouseAdvertisementDetailDto
                             {
                                 Id = house.Id,
                                 CreatedTime = house.CreatedTime,
                                 Title = house.Title,
                                 Description = house.Description,
                                 Price = house.Price,
                                 ImagePath = (from x in context.AdvertisementImages where x.AdvertisementId == house.Id select x.ImagePath).FirstOrDefault(),
                                 UserFirstName = us.FirstName,
                                 UserLastName = us.LastName,
                                 CityName = cty.CityName,
                                 HeatingTypeName = hetp.HeatingTypeName,
                                 DeedStatusName = dests.DeedTypeName,
                                 FromWhoName = frwh.FromWhoName,
                                 HouseTypeName = hstp.HouseTypeName,
                                 HomeTypeName = xy.Name,
                                 GrossSquareMeter = house.GrossSquareMeter,
                                 NetSquareMeter = house.NetSquareMeter,
                                 NumberOfRooms = house.NumberOfRooms,
                                 BuildingAge = house.BuildingAge,
                                 NumberOfFloor = house.NumberOfFloor,
                                 FloorLocation = house.FloorLocation,
                                 NumberOfShower = house.NumberOfShower,
                                 Balcony = house.Balcony,
                                 IsFurnished = house.IsFurnished,
                                 IsInsideSite = house.IsInsideSite,
                                 Subscription = house.Subscription,
                                 AvaiableForCredit = house.AvaiableForCredit,
                                 IsSwapable = house.IsSwapable,
                                 Adsl = house.Adsl,
                                 AirConditioning = house.AirConditioning,
                                 AluminumJoinery = house.AluminumJoinery,
                                 AmericanDoor = house.AmericanDoor,
                                 AmericanKitchen = house.AmericanKitchen,
                                 AutoPark = house.AutoPark,
                                 Barbeque = house.Barbeque,
                                 Bathtub = house.Bathtub,
                                 Blinds = house.Blinds,
                                 BuildinKitchen = house.BuildinKitchen,
                                 BuiltinDiafon = house.BuiltinDiafon,
                                 BuiltinOven = house.BuiltinOven,
                                 BuiltinWardrobe = house.BuiltinWardrobe,
                                 CabloTv = house.CabloTv,
                                 CameraSystem = house.CameraSystem,
                                 Church = house.Church,
                                 CityCenter = house.CityCenter,
                                 CloseGarage = house.CloseGarage,
                                 ClosePool = house.ClosePool,
                                 Collage = house.Collage,
                                 DoorKeeper = house.DoorKeeper,
                                 DressRoom = house.DressRoom,
                                 East = house.East,
                                 Elevator = house.Elevator,
                                 FiberInternet = house.FiberInternet,
                                 FireAlarm = house.FireAlarm,
                                 FiremanStation = house.FiremanStation,
                                 FireStair = house.FireStair,
                                 Fuar = house.Fuar,
                                 FunCenter = house.FunCenter,
                                 Furniture = house.Furniture,
                                 GamePark = house.GamePark,
                                 Generator = house.Generator,
                                 HardwoodFloor = house.HardwoodFloor,
                                 HighSchool = house.HighSchool,
                                 WoodJoinery = house.WoodJoinery,
                                 Hospital = house.Hospital,
                                 HouseholdAppliances = house.HouseholdAppliances,
                                 Jacuzzi = house.Jacuzzi,
                                 LaminateFloor = house.LaminateFloor,
                                 LaminateKitchen = house.LaminateKitchen,
                                 Mall = house.Mall,
                                 Mosque = house.Mosque,
                                 Municipality = house.Municipality,
                                 North = house.North,
                                 OpenPool = house.OpenPool,
                                 Oven = house.Oven,
                                 Painted = house.Painted,
                                 ParentBath = house.ParentBath,
                                 Pharmacy = house.Pharmacy,
                                 PoliceStation = house.PoliceStation,
                                 PrivatePool = house.PrivatePool,
                                 Security = house.Security,
                                 SeeSide = house.SeeSide,
                                 ShowerCabin = house.ShowerCabin,
                                 Smarthome = house.Smarthome,
                                 SoundInsulation = house.SoundInsulation,
                                 South = house.South,
                                 SporSide = house.SporSide,
                                 TennisCourt = house.TennisCourt,
                                 ThermalInsulation = house.ThermalInsulation,
                                 ThiefAlarm = house.ThiefAlarm,
                                 Wallpaper = house.Wallpaper,
                                 West = house.West
                               
                             };



                //return result.ToList();
                var results = result.ToList();
                foreach (var item in results)
                {
                    if (item.ImagePath == null)
                    {
                        item.ImagePath = "/images/default.png";
                    }
                }
                return results;
            }
        }
    }
}
