using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesCodeFirst.Context
{
    internal class CitiesContext : DbContext
    {
        public CitiesContext()
        {

        }
        public CitiesContext(DbContextOptions<CitiesContext> option) : base(option)
        {

        }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<PopularProduct> PopularProducts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-55D3033\\MSSQLSERVER01;Database=CitiesDB;Trusted_Connection=True;TrustServerCertificate=True;");

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(v =>
            {
                v.Property(v => v.CityName).HasMaxLength(50);
            });
            modelBuilder.Entity<PopularProduct>(v =>
            {
                v.Property(v => v.ProductName).HasMaxLength(50);
            });
            AddDummyData(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
        private void AddDummyData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>().HasData(
                new City() { CityID = 1, CityName = "Adana" },
                new City() { CityID = 6, CityName = "Ankara" },
                new City() { CityID = 61, CityName = "Trabzon" }
                );

            modelBuilder.Entity<PopularProduct>().HasData(
            new PopularProduct { PopularProductID = 1, ProductName = "Keçi", CityID = 6 },
            new PopularProduct { PopularProductID = 2, ProductName = "Şırdan", CityID = 1 },
            new PopularProduct { PopularProductID = 3, ProductName = "Aykut Bey", CityID = 1 },
            new PopularProduct { PopularProductID = 4, ProductName = "Tereyağ", CityID = 61 },
            new PopularProduct { PopularProductID = 5, ProductName = "Ekmek", CityID = 61 }
            );
        }


    }

}
