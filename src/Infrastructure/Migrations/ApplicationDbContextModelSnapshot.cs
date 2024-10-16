﻿// <auto-generated />
using System;
using System.Collections.Generic;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Domain.Entities.Alert", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("AlertMessage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("DisasterType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RegionId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("RiskLevel")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Alerts");
                });

            modelBuilder.Entity("Domain.Entities.AlertSetting", b =>
                {
                    b.Property<int>("RegionId")
                        .HasColumnType("integer");

                    b.Property<string>("DisasterType")
                        .HasColumnType("text");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<double>("ThresholdScore")
                        .HasColumnType("double precision");

                    b.HasKey("RegionId", "DisasterType");

                    b.ToTable("AlertSettings");
                });

            modelBuilder.Entity("Domain.Entities.Region", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<List<string>>("DisasterTypes")
                        .IsRequired()
                        .HasColumnType("text[]");

                    b.Property<double>("Latitude")
                        .HasColumnType("double precision");

                    b.Property<double>("Longitude")
                        .HasColumnType("double precision");

                    b.HasKey("Id");

                    b.ToTable("Regions");
                });
#pragma warning restore 612, 618
        }
    }
}
