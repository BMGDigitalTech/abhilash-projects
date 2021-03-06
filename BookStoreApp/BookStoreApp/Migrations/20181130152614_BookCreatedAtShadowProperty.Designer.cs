﻿// <auto-generated />
using System;
using BookStoreApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BookStoreApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20181130152614_BookCreatedAtShadowProperty")]
    partial class BookCreatedAtShadowProperty
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BookStoreApp.Models.Author", b =>
                {
                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<DateTime>("Dob");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Nationality");

                    b.HasKey("FirstName", "LastName");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BookStoreApp.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("getdate()");

                    b.Property<string>("Isbn")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("Isbn")
                        .IsUnique()
                        .HasName("IsbnIndex");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
