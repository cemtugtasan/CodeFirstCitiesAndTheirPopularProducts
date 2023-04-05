﻿// <auto-generated />
using CitiesCodeFirst.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CitiesCodeFirst.Migrations
{
    [DbContext(typeof(CitiesContext))]
    partial class CitiesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CitiesCodeFirst.Context.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityID"));

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CityID");

                    b.ToTable("Cities");

                    b.HasData(
                        new
                        {
                            CityID = 1,
                            CityName = "Adana"
                        },
                        new
                        {
                            CityID = 6,
                            CityName = "Ankara"
                        },
                        new
                        {
                            CityID = 61,
                            CityName = "Trabzon"
                        });
                });

            modelBuilder.Entity("CitiesCodeFirst.Context.PopularProduct", b =>
                {
                    b.Property<int>("PopularProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ProductID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PopularProductID"));

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("PopularProductID");

                    b.HasIndex("CityID");

                    b.ToTable("PopularProducts");

                    b.HasData(
                        new
                        {
                            PopularProductID = 1,
                            CityID = 6,
                            ProductName = "Keçi"
                        },
                        new
                        {
                            PopularProductID = 2,
                            CityID = 1,
                            ProductName = "Şırdan"
                        },
                        new
                        {
                            PopularProductID = 3,
                            CityID = 1,
                            ProductName = "Aykut Bey"
                        },
                        new
                        {
                            PopularProductID = 4,
                            CityID = 61,
                            ProductName = "Tereyağ"
                        },
                        new
                        {
                            PopularProductID = 5,
                            CityID = 61,
                            ProductName = "Ekmek"
                        });
                });

            modelBuilder.Entity("CitiesCodeFirst.Context.PopularProduct", b =>
                {
                    b.HasOne("CitiesCodeFirst.Context.City", "Cities")
                        .WithMany("PopularProducts")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cities");
                });

            modelBuilder.Entity("CitiesCodeFirst.Context.City", b =>
                {
                    b.Navigation("PopularProducts");
                });
#pragma warning restore 612, 618
        }
    }
}
