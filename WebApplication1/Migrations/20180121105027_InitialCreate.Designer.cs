﻿// <auto-generated />
using HotelReservation.API;
using HotelReservation.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace HotelReservation.API.Migrations
{
    [DbContext(typeof(HotelContext))]
    [Migration("20180121105027_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HotelReservation.Models.Entities.DtoGuest", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<string>("Email");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("HotelReservation.Models.Entities.DtoReservation", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("ArrivalDate");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<DateTime>("DepartureDate");

                    b.Property<Guid?>("GuestId");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<Guid?>("RoomId");

                    b.HasKey("Id");

                    b.HasIndex("GuestId");

                    b.HasIndex("RoomId");

                    b.ToTable("Reservations");
                });

            modelBuilder.Entity("HotelReservation.Models.Entities.DtoReservationStatus", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<Guid?>("DtoReservationId");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<int>("ReservationStatus");

                    b.HasKey("Id");

                    b.HasIndex("DtoReservationId");

                    b.ToTable("DtoReservationStatus");
                });

            modelBuilder.Entity("HotelReservation.Models.Entities.DtoRoom", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<double>("Floor");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<string>("Number");

                    b.Property<Guid?>("RoomTypeId");

                    b.HasKey("Id");

                    b.HasIndex("RoomTypeId");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("HotelReservation.Models.Entities.DtoRoomType", b =>
                {
                    b.Property<Guid?>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CancellationFeeNightsCount");

                    b.Property<DateTime?>("CreatedOn");

                    b.Property<decimal>("DepositFeePercentage");

                    b.Property<string>("Description");

                    b.Property<DateTime?>("ModifiedOn");

                    b.Property<double>("Rate");

                    b.HasKey("Id");

                    b.ToTable("RoomTypes");
                });

            modelBuilder.Entity("HotelReservation.Models.Entities.DtoReservation", b =>
                {
                    b.HasOne("HotelReservation.Models.Entities.DtoGuest", "Guest")
                        .WithMany()
                        .HasForeignKey("GuestId");

                    b.HasOne("HotelReservation.Models.Entities.DtoRoom", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("HotelReservation.Models.Entities.DtoReservationStatus", b =>
                {
                    b.HasOne("HotelReservation.Models.Entities.DtoReservation")
                        .WithMany("ReservationStatus")
                        .HasForeignKey("DtoReservationId");
                });

            modelBuilder.Entity("HotelReservation.Models.Entities.DtoRoom", b =>
                {
                    b.HasOne("HotelReservation.Models.Entities.DtoRoomType", "RoomType")
                        .WithMany()
                        .HasForeignKey("RoomTypeId");
                });
#pragma warning restore 612, 618
        }
    }
}
