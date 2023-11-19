﻿// <auto-generated />
using AREA_ReST_API;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AREA_ReST_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231030094939_add_is_connected_needed")]
    partial class add_is_connected_needed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AREA_ReST_API.Models.ActionsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DefaultConfiguration")
                        .HasColumnType("longtext");

                    b.Property<string>("Endpoint")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Actions");
                });

            modelBuilder.Entity("AREA_ReST_API.Models.AreasModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Favorite")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Areas");
                });

            modelBuilder.Entity("AREA_ReST_API.Models.ReactionsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("DefaultConfiguration")
                        .HasColumnType("longtext");

                    b.Property<string>("Endpoint")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Reactions");
                });

            modelBuilder.Entity("AREA_ReST_API.Models.ServicesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ConnectionLink")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Endpoint")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("IsConnectionNeeded")
                        .HasColumnType("tinyint(1)");

                    b.Property<byte[]>("Logo")
                        .IsRequired()
                        .HasColumnType("longblob");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Services");
                });

            modelBuilder.Entity("AREA_ReST_API.Models.UserActionsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ActionId")
                        .HasColumnType("int");

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<string>("Configuration")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Countdown")
                        .HasColumnType("int");

                    b.Property<int>("Timer")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserActions");
                });

            modelBuilder.Entity("AREA_ReST_API.Models.UserReactionsModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AreaId")
                        .HasColumnType("int");

                    b.Property<string>("Configuration")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ReactionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserReactions");
                });

            modelBuilder.Entity("AREA_ReST_API.Models.UserServicesModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AccessToken")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ExpiresIn")
                        .HasColumnType("int");

                    b.Property<string>("RefreshToken")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserServices");
                });

            modelBuilder.Entity("AREA_ReST_API.Models.UsersModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Admin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext");

                    b.Property<bool>("IsGoogleConnected")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsMailVerified")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .HasColumnType("longtext");

                    b.Property<string>("Surname")
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });
#pragma warning restore 612, 618
        }
    }
}
