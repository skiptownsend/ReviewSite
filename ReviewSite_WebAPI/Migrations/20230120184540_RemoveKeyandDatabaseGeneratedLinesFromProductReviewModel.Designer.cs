﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ReviewSite_WebAPI.Data;

#nullable disable

namespace ReviewSite_WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230120184540_RemoveKeyandDatabaseGeneratedLinesFromProductReviewModel")]
    partial class RemoveKeyandDatabaseGeneratedLinesFromProductReviewModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ReviewSite_WebAPI.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 1, 20, 11, 45, 39, 862, DateTimeKind.Local).AddTicks(7582),
                            Description = "Lorem ipsum dolor sit amet.",
                            ImageUrl = "./Images/white_t-shirt.jpg",
                            Name = "White T-Shirt",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 1, 20, 11, 45, 39, 862, DateTimeKind.Local).AddTicks(7617),
                            Description = "Lorem ipsum dolor sit amet.",
                            ImageUrl = "./Images/black_t-shirt.jpg",
                            Name = "Black T-Shirt",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 1, 20, 11, 45, 39, 862, DateTimeKind.Local).AddTicks(7619),
                            Description = "Lorem ipsum dolor sit amet.",
                            ImageUrl = "./Images/red_t-shirt.jpg",
                            Name = "Red T-Shirt",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 1, 20, 11, 45, 39, 862, DateTimeKind.Local).AddTicks(7621),
                            Description = "Lorem ipsum dolor sit amet.",
                            ImageUrl = "./Images/blue_t-shirt.jpg",
                            Name = "Blue T-Shirt",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 1, 20, 11, 45, 39, 862, DateTimeKind.Local).AddTicks(7623),
                            Description = "Lorem ipsum dolor sit amet.",
                            ImageUrl = "./Images/maroon_t-shirt.jpg",
                            Name = "Maroon T-Shirt",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 1, 20, 11, 45, 39, 862, DateTimeKind.Local).AddTicks(7624),
                            Description = "Lorem ipsum dolor sit amet.",
                            ImageUrl = "./Images/yellow_t-shirt.jpg",
                            Name = "Yellow T-Shirt",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ReviewSite_WebAPI.Models.ProductReview", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Review")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReviewerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductReviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 1, 20, 11, 45, 39, 862, DateTimeKind.Local).AddTicks(7704),
                            ProductId = 1,
                            Review = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Sociis natoque penatibus et magnis dis parturient montes nascetur. Nulla aliquet porttitor lacus luctus accumsan tortor posuere ac.",
                            ReviewerName = "John Smith",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("ReviewSite_WebAPI.Models.ProductReview", b =>
                {
                    b.HasOne("ReviewSite_WebAPI.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}