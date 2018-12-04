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
    [Migration("20181202122527_BookPersonalLibraryRelationship")]
    partial class BookPersonalLibraryRelationship
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
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Dob");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Nationality");

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("BookStoreApp.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

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

                    b.HasIndex("AuthorId");

                    b.HasIndex("Isbn")
                        .IsUnique()
                        .HasName("IsbnIndex");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookStoreApp.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64);

                    b.Property<string>("Phone")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("BookStoreApp.Models.Membership", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<int>("Genre");

                    b.Property<DateTime>("Initiated");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("Memberships");
                });

            modelBuilder.Entity("BookStoreApp.Models.PersonalLibrary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("CreatedAt");

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("PersonalLibraries");
                });

            modelBuilder.Entity("BookStoreApp.Models.PersonalLibraryBook", b =>
                {
                    b.Property<int>("BookId");

                    b.Property<int>("LibraryId");

                    b.HasKey("BookId", "LibraryId");

                    b.HasIndex("LibraryId");

                    b.ToTable("PersonalLibraryBooks");
                });

            modelBuilder.Entity("BookStoreApp.Models.Book", b =>
                {
                    b.HasOne("BookStoreApp.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookStoreApp.Models.Membership", b =>
                {
                    b.HasOne("BookStoreApp.Models.Client", "Client")
                        .WithOne("Membership")
                        .HasForeignKey("BookStoreApp.Models.Membership", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookStoreApp.Models.PersonalLibrary", b =>
                {
                    b.HasOne("BookStoreApp.Models.Client", "Client")
                        .WithOne("PersonalLibrary")
                        .HasForeignKey("BookStoreApp.Models.PersonalLibrary", "ClientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BookStoreApp.Models.PersonalLibraryBook", b =>
                {
                    b.HasOne("BookStoreApp.Models.Book", "Book")
                        .WithMany("PersonalLibraryBooks")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BookStoreApp.Models.PersonalLibrary", "PersonalLibrary")
                        .WithMany("PersonalLibraryBooks")
                        .HasForeignKey("LibraryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
