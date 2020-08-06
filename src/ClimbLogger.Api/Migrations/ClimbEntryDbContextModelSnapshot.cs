﻿// <auto-generated />
using System;
using ClimbLogger.Api.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ClimbLogger.Api.Migrations
{
    [DbContext(typeof(ClimbEntryDbContext))]
    partial class ClimbEntryDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6");

            modelBuilder.Entity("ClimbLogger.Data.ClimbEntry", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ClimbDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Grade")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ClimbEntries");
                });
#pragma warning restore 612, 618
        }
    }
}
