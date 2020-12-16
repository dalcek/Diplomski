﻿// <auto-generated />
using System;
using DatabaseLayer.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatabaseLayer.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Common.Models.Airline", b =>
                {
                    b.Property<int>("AirlineId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100);

                    b.Property<int?>("AdministratorUserId");

                    b.Property<string>("Description")
                        .HasMaxLength(100);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("AirlineId");

                    b.HasIndex("AdministratorUserId");

                    b.ToTable("Airline");
                });

            modelBuilder.Entity("Common.Models.AirlineDestination", b =>
                {
                    b.Property<int>("AirlineId");

                    b.Property<int>("DestinationId");

                    b.HasKey("AirlineId", "DestinationId");

                    b.HasIndex("DestinationId");

                    b.ToTable("AirlineDestination");
                });

            modelBuilder.Entity("Common.Models.AirlineFlightLuggage", b =>
                {
                    b.Property<int>("AirlineId");

                    b.Property<int>("FlightLuggageId");

                    b.HasKey("AirlineId", "FlightLuggageId");

                    b.HasIndex("FlightLuggageId");

                    b.ToTable("AirlineFlightLuggage");
                });

            modelBuilder.Entity("Common.Models.Destination", b =>
                {
                    b.Property<int>("DestinationId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Latitude");

                    b.Property<decimal>("Longitude");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("DestinationId");

                    b.ToTable("Destination");
                });

            modelBuilder.Entity("Common.Models.Flight", b =>
                {
                    b.Property<int>("FlightId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AirlineId");

                    b.Property<DateTime>("ArrivalDate");

                    b.Property<DateTime>("DepartureDate");

                    b.Property<int?>("FromDestinationDestinationId");

                    b.Property<int>("NumOfChangeovers");

                    b.Property<int>("ToDestinationDestinationId");

                    b.Property<decimal>("TripLength")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("FlightId");

                    b.HasIndex("AirlineId");

                    b.HasIndex("FromDestinationDestinationId");

                    b.HasIndex("ToDestinationDestinationId");

                    b.ToTable("Flight");
                });

            modelBuilder.Entity("Common.Models.FlightLuggage", b =>
                {
                    b.Property<int>("FlightLuggageId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FlightLuggageType");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.HasKey("FlightLuggageId");

                    b.ToTable("FlightLuggage");
                });

            modelBuilder.Entity("Common.Models.FlightOrder", b =>
                {
                    b.Property<int>("FlightOrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Confirmed");

                    b.Property<int?>("FlightId");

                    b.Property<int?>("FlightLuggageId");

                    b.Property<int?>("FlightTicketId");

                    b.Property<int?>("SeatId");

                    b.Property<int?>("UserId");

                    b.HasKey("FlightOrderId");

                    b.HasIndex("FlightId");

                    b.HasIndex("FlightLuggageId");

                    b.HasIndex("FlightTicketId");

                    b.HasIndex("SeatId");

                    b.HasIndex("UserId");

                    b.ToTable("FlightOrder");
                });

            modelBuilder.Entity("Common.Models.FlightTicket", b =>
                {
                    b.Property<int>("FlightTicketId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FlightId");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(8,4)");

                    b.Property<int>("Type");

                    b.HasKey("FlightTicketId");

                    b.HasIndex("FlightId");

                    b.ToTable("FlightTicket");
                });

            modelBuilder.Entity("Common.Models.Friend", b =>
                {
                    b.Property<int>("FriendshipId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Confirmed");

                    b.Property<int>("FriendOfId");

                    b.Property<int>("FriendWithId");

                    b.HasKey("FriendshipId");

                    b.HasIndex("FriendOfId");

                    b.HasIndex("FriendWithId");

                    b.ToTable("Friend");
                });

            modelBuilder.Entity("Common.Models.Seat", b =>
                {
                    b.Property<int>("SeatId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("FlightId");

                    b.Property<int>("SeatNumber");

                    b.Property<int>("SeatState");

                    b.HasKey("SeatId");

                    b.HasIndex("FlightId");

                    b.ToTable("Seat");
                });

            modelBuilder.Entity("Common.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasMaxLength(100);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Key")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<long>("PassportId");

                    b.Property<long>("Phone");

                    b.Property<int>("Role");

                    b.Property<string>("Salt")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("TokenId");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Common.Models.Airline", b =>
                {
                    b.HasOne("Common.Models.User", "Administrator")
                        .WithMany()
                        .HasForeignKey("AdministratorUserId");
                });

            modelBuilder.Entity("Common.Models.AirlineDestination", b =>
                {
                    b.HasOne("Common.Models.Airline", "Airline")
                        .WithMany("AirlineDestinations")
                        .HasForeignKey("AirlineId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Common.Models.Destination", "Destination")
                        .WithMany()
                        .HasForeignKey("DestinationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Common.Models.AirlineFlightLuggage", b =>
                {
                    b.HasOne("Common.Models.Airline", "Airline")
                        .WithMany("AvailableFlightLuggage")
                        .HasForeignKey("AirlineId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Common.Models.FlightLuggage", "FlightLuggage")
                        .WithMany()
                        .HasForeignKey("FlightLuggageId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Common.Models.Flight", b =>
                {
                    b.HasOne("Common.Models.Airline", "Airline")
                        .WithMany("Flights")
                        .HasForeignKey("AirlineId");

                    b.HasOne("Common.Models.Destination", "FromDestination")
                        .WithMany()
                        .HasForeignKey("FromDestinationDestinationId");

                    b.HasOne("Common.Models.Destination", "ToDestination")
                        .WithMany()
                        .HasForeignKey("ToDestinationDestinationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Common.Models.FlightOrder", b =>
                {
                    b.HasOne("Common.Models.Flight", "Flight")
                        .WithMany("FlightOrders")
                        .HasForeignKey("FlightId");

                    b.HasOne("Common.Models.FlightLuggage", "FlightLuggage")
                        .WithMany()
                        .HasForeignKey("FlightLuggageId");

                    b.HasOne("Common.Models.FlightTicket", "FlightTicket")
                        .WithMany()
                        .HasForeignKey("FlightTicketId");

                    b.HasOne("Common.Models.Seat", "Seat")
                        .WithMany()
                        .HasForeignKey("SeatId");

                    b.HasOne("Common.Models.User", "User")
                        .WithMany("FlightOrders")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Common.Models.FlightTicket", b =>
                {
                    b.HasOne("Common.Models.Flight")
                        .WithMany("Tickets")
                        .HasForeignKey("FlightId");
                });

            modelBuilder.Entity("Common.Models.Friend", b =>
                {
                    b.HasOne("Common.Models.User", "FriendOf")
                        .WithMany("FriendsOf")
                        .HasForeignKey("FriendOfId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Common.Models.User", "FriendWith")
                        .WithMany("FriendsWith")
                        .HasForeignKey("FriendWithId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Common.Models.Seat", b =>
                {
                    b.HasOne("Common.Models.Flight", "Flight")
                        .WithMany("Seats")
                        .HasForeignKey("FlightId");
                });
#pragma warning restore 612, 618
        }
    }
}