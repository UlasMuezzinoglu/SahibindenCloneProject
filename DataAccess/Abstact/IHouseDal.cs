﻿using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstact
{
    public interface IHouseDal : IEntityRepository<House>
    {
        List<HouseAdvertisementDetailDto> GetHouseAdvertisementDetails();
    }
}
