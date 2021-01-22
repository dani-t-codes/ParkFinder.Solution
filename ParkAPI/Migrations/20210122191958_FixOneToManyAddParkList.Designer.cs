﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkAPI.Models;

namespace ParkFinder.Solution.Migrations
{
    [DbContext(typeof(ParkAPIContext))]
    [Migration("20210122191958_FixOneToManyAddParkList")]
    partial class FixOneToManyAddParkList
    {
        protected void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ParkFinder.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<string>("Region");

                    b.Property<string>("State");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("ParkFinder.Models.Park", b =>
                {
                    b.Property<int>("ParkId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Alerts");

                    b.Property<string>("BasicInfo");

                    b.Property<string>("Directions");

                    b.Property<string>("Fees");

                    b.Property<bool>("HasHikingTrails");

                    b.Property<bool>("HasVisitorCenter");

                    b.Property<bool>("InternetAccess");

                    b.Property<bool>("IsCurrentlyOpen");

                    b.Property<int>("LocationId");

                    b.Property<string>("ParkAddress");

                    b.Property<int>("ParkName");

                    b.Property<string>("RequiredPasses");

                    b.Property<string>("TypeOfPark");

                    b.HasKey("ParkId");

                    b.HasIndex("LocationId");

                    b.ToTable("Parks");
                });

            modelBuilder.Entity("ParkFinder.Models.Park", b =>
                {
                    b.HasOne("ParkFinder.Models.Location", "Location")
                        .WithMany("Parks")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
