﻿// <auto-generated />
using System;
using BurgerShop.AppClases;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurgerShop.Migrations
{
    [DbContext(typeof(BurgerShopContext))]
    [Migration("20240114123239_UpdateNames")]
    partial class UpdateNames
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BurgerShop.Models.Burger", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Bacon")
                        .HasColumnType("int");

                    b.Property<Guid?>("BurgerNameId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Cutlet")
                        .HasColumnType("int");

                    b.Property<Guid?>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Picles")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Tomatos")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BurgerNameId");

                    b.HasIndex("OrderId");

                    b.ToTable("Burgers");
                });

            modelBuilder.Entity("BurgerShop.Models.BurgerName", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImageSrc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("BurgerNames");
                });

            modelBuilder.Entity("BurgerShop.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BurgerShop.Models.Burger", b =>
                {
                    b.HasOne("BurgerShop.Models.BurgerName", "BurgerName")
                        .WithMany()
                        .HasForeignKey("BurgerNameId");

                    b.HasOne("BurgerShop.Models.Order", "Order")
                        .WithMany("Burgers")
                        .HasForeignKey("OrderId");

                    b.Navigation("BurgerName");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BurgerShop.Models.Order", b =>
                {
                    b.Navigation("Burgers");
                });
#pragma warning restore 612, 618
        }
    }
}
