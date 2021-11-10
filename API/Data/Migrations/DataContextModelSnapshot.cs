﻿// <auto-generated />
using System;
using API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("API.Entities.AppSongCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AppSongsId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("CategoryName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("AppSongsId");

                    b.ToTable("AppSongCategories");
                });

            modelBuilder.Entity("API.Entities.AppSongs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ArtistName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsFavourite")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("SongEdited")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SongEntered")
                        .HasColumnType("TEXT");

                    b.Property<string>("SongName")
                        .HasColumnType("TEXT");

                    b.Property<int>("SongRating")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SongUrl")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Songs");
                });

            modelBuilder.Entity("API.Entities.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("BLOB");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("BLOB");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("API.Entities.AppSongCategory", b =>
                {
                    b.HasOne("API.Entities.AppSongs", "AppSongs")
                        .WithMany("SongCategory")
                        .HasForeignKey("AppSongsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppSongs");
                });

            modelBuilder.Entity("API.Entities.AppSongs", b =>
                {
                    b.Navigation("SongCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
