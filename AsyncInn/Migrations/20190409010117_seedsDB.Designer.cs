﻿// <auto-generated />
using AsyncInn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AsyncInn.Migrations
{
    [DbContext(typeof(IHotelManager))]
    [Migration("20190409010117_seedsDB")]
    partial class seedsDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AsyncInn.Models.Amenities", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Amenities");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Heating"
                        },
                        new
                        {
                            ID = 2,
                            Name = "In-Unit Laundry"
                        },
                        new
                        {
                            ID = 3,
                            Name = "Pool"
                        },
                        new
                        {
                            ID = 4,
                            Name = "Balcony"
                        },
                        new
                        {
                            ID = 5,
                            Name = "WiFi"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.Hotel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City");

                    b.Property<string>("Name");

                    b.Property<int>("Phone");

                    b.Property<string>("State");

                    b.Property<string>("StreetAdress");

                    b.HasKey("ID");

                    b.ToTable("Hotel");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            City = "Seattle",
                            Name = "TestHotel",
                            Phone = 1234567,
                            State = "Washington",
                            StreetAdress = "0000 Fake Addy"
                        },
                        new
                        {
                            ID = 2,
                            City = "Seattle",
                            Name = "TestHote2",
                            Phone = 222222222,
                            State = "Washington",
                            StreetAdress = "0001 Fake Addy"
                        },
                        new
                        {
                            ID = 3,
                            City = "Seattle",
                            Name = "TestHotel3",
                            Phone = 1111234567,
                            State = "Washington",
                            StreetAdress = "0002 Fake Addy"
                        },
                        new
                        {
                            ID = 4,
                            City = "Seattle",
                            Name = "TestHotel4",
                            Phone = 221234567,
                            State = "Washington",
                            StreetAdress = "0003 Fake Addy"
                        },
                        new
                        {
                            ID = 5,
                            City = "Seattle",
                            Name = "TestHotel5",
                            Phone = 331234567,
                            State = "Washington",
                            StreetAdress = "0004 Fake Addy"
                        },
                        new
                        {
                            ID = 6,
                            City = "Seattle",
                            Name = "TestHotel6",
                            Phone = 441234567,
                            State = "Washington",
                            StreetAdress = "0005 Fake Addy"
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.Property<int>("HotelID");

                    b.Property<int>("RoomID");

                    b.Property<bool>("PetFriendly");

                    b.Property<int>("Rate");

                    b.Property<int>("RoomNumber");

                    b.HasKey("HotelID", "RoomID");

                    b.HasIndex("HotelID")
                        .IsUnique();

                    b.HasIndex("RoomID")
                        .IsUnique();

                    b.ToTable("HotelRoom");
                });

            modelBuilder.Entity("AsyncInn.Models.Room", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int>("RoomLayout");

                    b.HasKey("ID");

                    b.ToTable("Room");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Name = "Red",
                            RoomLayout = 0
                        },
                        new
                        {
                            ID = 2,
                            Name = "Blue",
                            RoomLayout = 0
                        },
                        new
                        {
                            ID = 3,
                            Name = "Green",
                            RoomLayout = 1
                        },
                        new
                        {
                            ID = 4,
                            Name = "Yellow",
                            RoomLayout = 1
                        },
                        new
                        {
                            ID = 5,
                            Name = "Orange",
                            RoomLayout = 2
                        },
                        new
                        {
                            ID = 6,
                            Name = "Purple",
                            RoomLayout = 2
                        });
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.Property<int>("AmenitiesID");

                    b.Property<int>("RoomID");

                    b.HasKey("AmenitiesID", "RoomID");

                    b.HasIndex("AmenitiesID")
                        .IsUnique();

                    b.HasIndex("RoomID")
                        .IsUnique();

                    b.ToTable("RoomAmenities");
                });

            modelBuilder.Entity("AsyncInn.Models.HotelRoom", b =>
                {
                    b.HasOne("AsyncInn.Models.Hotel", "Hotel")
                        .WithOne("HotelRoom")
                        .HasForeignKey("AsyncInn.Models.HotelRoom", "HotelID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsyncInn.Models.Room")
                        .WithOne("HotelRoom")
                        .HasForeignKey("AsyncInn.Models.HotelRoom", "RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AsyncInn.Models.RoomAmenities", b =>
                {
                    b.HasOne("AsyncInn.Models.Amenities", "Amenities")
                        .WithOne("RoomAmenities")
                        .HasForeignKey("AsyncInn.Models.RoomAmenities", "AmenitiesID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsyncInn.Models.Room", "Room")
                        .WithOne("RoomAmenities")
                        .HasForeignKey("AsyncInn.Models.RoomAmenities", "RoomID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
