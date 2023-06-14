﻿// <auto-generated />
using Infrastructure.SqLite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.SqLite.Migrations
{
    [DbContext(typeof(WebApiContext))]
    [Migration("20230614170916_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.18");

            modelBuilder.Entity("Infrastructure.SqLite.Entities.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Infrastructure.SqLite.Entities.Museum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("TownId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TownId");

                    b.ToTable("Museum");
                });

            modelBuilder.Entity("Infrastructure.SqLite.Entities.Town", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CountryId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Town");
                });

            modelBuilder.Entity("Infrastructure.SqLite.Entities.Museum", b =>
                {
                    b.HasOne("Infrastructure.SqLite.Entities.Town", "Town")
                        .WithMany("Museums")
                        .HasForeignKey("TownId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Town");
                });

            modelBuilder.Entity("Infrastructure.SqLite.Entities.Town", b =>
                {
                    b.HasOne("Infrastructure.SqLite.Entities.Country", "Country")
                        .WithMany("Towns")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Infrastructure.SqLite.Entities.Country", b =>
                {
                    b.Navigation("Towns");
                });

            modelBuilder.Entity("Infrastructure.SqLite.Entities.Town", b =>
                {
                    b.Navigation("Museums");
                });
#pragma warning restore 612, 618
        }
    }
}
