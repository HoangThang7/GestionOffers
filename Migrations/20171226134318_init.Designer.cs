﻿// <auto-generated />
using GestionOffers.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GestionOffer.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20171226134318_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GestionOffers.Models.Address", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("city")
                        .IsRequired();

                    b.Property<string>("country")
                        .IsRequired();

                    b.Property<string>("region")
                        .IsRequired();

                    b.Property<string>("street")
                        .IsRequired();

                    b.Property<int>("zip");

                    b.HasKey("id");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("GestionOffers.Models.Offer", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("code");

                    b.Property<string>("description")
                        .IsRequired();

                    b.HasKey("id");

                    b.ToTable("Offer");
                });

            modelBuilder.Entity("GestionOffers.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Address")
                        .IsRequired();

                    b.Property<DateTime>("date");

                    b.Property<string>("firstName")
                        .IsRequired();

                    b.Property<string>("lastName")
                        .IsRequired();

                    b.Property<string>("mail")
                        .IsRequired();

                    b.Property<int>("numberTel");

                    b.Property<string>("password")
                        .IsRequired();

                    b.Property<int>("type");

                    b.HasKey("id");

                    b.HasIndex("Address");

                    b.ToTable("User");
                });

            modelBuilder.Entity("GestionOffers.Models.User", b =>
                {
                    b.HasOne("GestionOffers.Models.Address", "addressUser")
                        .WithMany()
                        .HasForeignKey("Address")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
