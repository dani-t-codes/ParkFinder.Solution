﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ParkFinder.Models;

namespace ParkFinder.Solution.Migrations
{
    [DbContext(typeof(ParkFinderContext))]
    partial class ParkFinderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("ParkId");

                    b.Property<string>("Region");

                    b.Property<string>("State");

                    b.HasKey("LocationId");

                    b.HasIndex("ParkId");

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

                    b.Property<string>("ParkAddress");

                    b.Property<int>("ParkName");

                    b.Property<string>("RequiredPasses");

                    b.Property<string>("TypeOfPark");

                    b.HasKey("ParkId");

                    b.ToTable("Parks");
                });

            modelBuilder.Entity("ParkFinder.Models.Location", b =>
                {
                    b.HasOne("ParkFinder.Models.Park", "Park")
                        .WithMany()
                        .HasForeignKey("ParkId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}