﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using appTutorial.EntityFramework;

namespace appTutorial.EntityFramework.Migrations
{
    [DbContext(typeof(TestsDbContext))]
    partial class TestsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("appTutorial.EntityFramework.DTOs.TestDto", b =>
                {
                    b.Property<Guid>("TestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("AutorID")
                        .HasColumnType("TEXT");

                    b.Property<string>("TestDiscription")
                        .HasColumnType("TEXT");

                    b.Property<int>("TestTime")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Testname")
                        .HasColumnType("TEXT");

                    b.HasKey("TestID");

                    b.HasIndex("AutorID");

                    b.ToTable("Tests");
                });

            modelBuilder.Entity("appTutorial.EntityFramework.DTOs.UserDto", b =>
                {
                    b.Property<Guid>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserLogin")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserPassword")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserStanding")
                        .HasColumnType("TEXT");

                    b.Property<bool>("UserStatus")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserSurname")
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .HasColumnType("TEXT");

                    b.HasKey("UserID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("appTutorial.EntityFramework.DTOs.TestDto", b =>
                {
                    b.HasOne("appTutorial.EntityFramework.DTOs.UserDto", "User")
                        .WithMany()
                        .HasForeignKey("AutorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
