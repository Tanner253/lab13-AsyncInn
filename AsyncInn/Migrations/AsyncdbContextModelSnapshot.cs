﻿// <auto-generated />
using AsyncInn.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AsyncInn.Migrations
{
    [DbContext(typeof(AsyncdbContext))]
    partial class AsyncdbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
