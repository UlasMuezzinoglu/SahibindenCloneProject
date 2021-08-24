using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.Concrete.Estate;
using Entities.Concrete.Estate.Home;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class SahibindenCloneContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDb;Database=SahibindenClone;Trusted_Connection=true");
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<AdvertisementImage> AdvertisementImages { get; set; }
        public DbSet<DeedType> DeedTypes { get; set; }
        public DbSet<FromWho> FromWhos { get; set; }
        public DbSet<NumberOfRoom> NumberOfRooms { get; set; }


        
        public DbSet<BuildingAge> BuildingAges { get; set; }

        public DbSet<HeatingType> HeatingTypes { get; set; }
        public DbSet<HouseType> HouseTypes { get; set; }
        public DbSet<HomeType> HomeTypes { get; set; }
        public DbSet<HouseAdvertisement> Houses { get; set; }

        
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }

    }
}
