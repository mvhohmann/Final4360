﻿// <auto-generated />
using System;
using Final4360;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Final4360.Migrations
{
    [DbContext(typeof(DBContext))]
    partial class DBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("Final4360.package", b =>
                {
                    b.Property<int>("PackageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("PickupDate")
                        .HasColumnType("TEXT");

                    b.Property<int>("PostingID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ResidentID")
                        .HasColumnType("INTEGER");

                    b.HasKey("PackageID");

                    b.ToTable("package");
                });

            modelBuilder.Entity("Final4360.posting", b =>
                {
                    b.Property<int>("PostingID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Service")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PostingID");

                    b.ToTable("posting");
                });

            modelBuilder.Entity("Final4360.resident", b =>
                {
                    b.Property<int>("ResidentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UnitNumber")
                        .HasColumnType("INTEGER");

                    b.HasKey("ResidentID");

                    b.ToTable("resident");
                });

            modelBuilder.Entity("Final4360.staff", b =>
                {
                    b.Property<int>("StaffID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("StaffPassword")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("StaffUsername")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("StaffID");

                    b.ToTable("staff");
                });

            modelBuilder.Entity("Final4360.unknown", b =>
                {
                    b.Property<int>("UnknownID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("PostingID")
                        .HasColumnType("INTEGER");

                    b.HasKey("UnknownID");

                    b.ToTable("unknown");
                });
#pragma warning restore 612, 618
        }
    }
}
