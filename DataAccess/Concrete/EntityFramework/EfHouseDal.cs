using Core.DataAccess.EntityFramework;
using DataAccess.Abstact;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfHouseDal : EfEntityRepositoryBase<House, SahibindenCloneContext>, IHouseDal
    {
        public List<HouseAdvertisementDetailDto> GetHouseAdvertisementDetails()
        {
            using (SahibindenCloneContext context = new SahibindenCloneContext())
            {
                var result = from house in context.Houses
                             join us in context.Users
                             on house.UserId equals us.Id
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
                                 AvaiableForCredit = house.AvaiableForCredit,
                                 Balcony = house.Balcony,
                                 BuildingAge = house.BuildingAge,
                                 CityName = cty.CityName,
                                 DeedStatusName = dests.DeedTypeName,
                                 FloorLocation = house.FloorLocation,
                                 FromWhoName = frwh.FromWhoName,
                                 GrossSquareMeter = house.GrossSquareMeter,
                                 HeatingTypeName = hetp.HeatingTypeName,
                                 HouseTypeName = hstp.HouseTypeName,
                                 IsFurnished = house.IsFurnished,
                                 IsInsideSite = house.IsInsideSite,
                                 IsSwapable = house.IsSwapable,
                                 NetSquareMeter = house.NetSquareMeter,
                                 NumberOfFloor = house.NumberOfFloor,
                                 NumberOfRooms = house.NumberOfRooms,
                                 NumberOfShower = house.NumberOfShower,
                                 Subscription = house.Subscription,
                                 UserFirstName = us.FirstName,
                                 UserLastName = us.LastName


                             };


                return result.ToList();
            }
           
        }
    }
}
