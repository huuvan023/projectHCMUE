﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAPI.Data.EF;

namespace WebAPI.Data.Migrations
{
    [DbContext(typeof(WebApiDbContext))]
    [Migration("20210101212220_up")]
    partial class up
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.admin", b =>
                {
                    b.Property<string>("idAdmin")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.HasKey("idAdmin");

                    b.ToTable("admin ");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.odersDetails", b =>
                {
                    b.Property<string>("idOder")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("idOrderList")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idProduct")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("photoReview")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<int>("quality")
                        .HasColumnType("int");

                    b.HasKey("idOder");

                    b.HasIndex("idOrderList");

                    b.HasIndex("idProduct");

                    b.ToTable("odersDetails");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.odersList", b =>
                {
                    b.Property<string>("idOrderList")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("idUser")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("idVoucher")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<int>("status")
                        .HasColumnType("int");

                    b.Property<int>("totalPrice")
                        .HasColumnType("int");

                    b.HasKey("idOrderList");

                    b.HasIndex("idUser");

                    b.ToTable("odersList");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.productBrand", b =>
                {
                    b.Property<string>("idBrand")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("brandDetail")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("brandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idBrand");

                    b.ToTable("productBrand");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.productCategories", b =>
                {
                    b.Property<string>("idCategory")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("categoryName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("idCategory");

                    b.ToTable("productCategory");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.productColor", b =>
                {
                    b.Property<string>("idColor")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("colorName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("idColor");

                    b.ToTable("productColor");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.productPhotos", b =>
                {
                    b.Property<string>("IdPhoto")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idProduct")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("link")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<DateTime>("uploadedTime")
                        .HasColumnType("datetime2");

                    b.HasKey("IdPhoto");

                    b.HasIndex("idProduct");

                    b.ToTable("productPhotos");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.productSize", b =>
                {
                    b.Property<string>("idSize")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("sizeName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("idSize");

                    b.ToTable("productSize");

                    b.HasData(
                        new
                        {
                            idSize = "L",
                            sizeName = "L-(Chest 101-106cm)"
                        },
                        new
                        {
                            idSize = "M",
                            sizeName = "M-(Chest 96-101cm)"
                        },
                        new
                        {
                            idSize = "S",
                            sizeName = "S-(Chest 91-96cm)"
                        },
                        new
                        {
                            idSize = "XL",
                            sizeName = "XL-(Chest 106-111cm)"
                        });
                });

            modelBuilder.Entity("WebAPI.Data.Entities.productTypes", b =>
                {
                    b.Property<string>("idType")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("typeName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("idType");

                    b.ToTable("productTypes");

                    b.HasData(
                        new
                        {
                            idType = "BagsNPurses",
                            typeName = "Bags & Purses"
                        },
                        new
                        {
                            idType = "MEN",
                            typeName = "Men Products"
                        },
                        new
                        {
                            idType = "WOMEN",
                            typeName = "Women Products"
                        });
                });

            modelBuilder.Entity("WebAPI.Data.Entities.products", b =>
                {
                    b.Property<string>("idProduct")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<DateTime>("dateAdded")
                        .HasColumnType("datetime2");

                    b.Property<string>("detail")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<DateTime>("expiredSalingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("idBrand")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("idCategory")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("idColor")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("idSize")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("idType")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<byte>("isSaling")
                        .HasColumnType("tinyint");

                    b.Property<string>("photoReview")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("price")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("productName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("salePrice")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.HasKey("idProduct");

                    b.HasIndex("idBrand");

                    b.HasIndex("idCategory");

                    b.HasIndex("idColor");

                    b.HasIndex("idSize");

                    b.HasIndex("idType");

                    b.ToTable("products");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.rating", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("comment")
                        .IsRequired()
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("idProduct")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<string>("idUser")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<int>("rate")
                        .HasColumnType("int");

                    b.Property<DateTime>("rateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("idProduct");

                    b.HasIndex("idUser");

                    b.ToTable("rating");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("role");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.users", b =>
                {
                    b.Property<string>("idUser")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("address")
                        .HasMaxLength(400)
                        .HasColumnType("nvarchar(400)");

                    b.Property<string>("avatar")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<DateTime>("birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("interestedIn")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime>("lastLogin")
                        .HasColumnType("datetime2");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("note")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("province")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("idUser");

                    b.ToTable("users");

                    b.HasData(
                        new
                        {
                            idUser = "2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "bcbbf782-f085-42b7-8d96-060e12c2602b",
                            Email = "nhattruongtp2000@gmail.com",
                            EmailConfirmed = true,
                            Id = "69BD714F-9576-45BA-B5B7-F00649BE00DE",
                            LockoutEnabled = false,
                            NormalizedEmail = "nhattruongtp2000@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAEISQI8LNO44l1DyOnP1bnecyY52UPWSvdbNmaugI8IROr/luUP5QK2erjg8USQ9Orw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin",
                            address = "asd",
                            avatar = "asd",
                            birthday = new DateTime(2020, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            firstName = "Nguyen",
                            interestedIn = "asd",
                            lastLogin = new DateTime(2020, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            lastName = "Truong",
                            note = "asd",
                            province = "asd"
                        });
                });

            modelBuilder.Entity("WebAPI.Data.Entities.vouchers", b =>
                {
                    b.Property<string>("idVoucher")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR(200)");

                    b.Property<DateTime>("expiredDate")
                        .HasColumnType("datetime2");

                    b.Property<byte>("isUse")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("tinyint")
                        .HasDefaultValue((byte)0);

                    b.Property<int>("price")
                        .HasColumnType("int");

                    b.HasKey("idVoucher");

                    b.ToTable("vouchers");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.odersDetails", b =>
                {
                    b.HasOne("WebAPI.Data.Entities.odersList", "odersLists")
                        .WithMany("odersDetails")
                        .HasForeignKey("idOrderList");

                    b.HasOne("WebAPI.Data.Entities.products", "Products")
                        .WithMany("odersDetails")
                        .HasForeignKey("idProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("odersLists");

                    b.Navigation("Products");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.odersList", b =>
                {
                    b.HasOne("WebAPI.Data.Entities.users", "users")
                        .WithMany("odersLists")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("users");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.productPhotos", b =>
                {
                    b.HasOne("WebAPI.Data.Entities.products", "products")
                        .WithMany("productPhotos")
                        .HasForeignKey("idProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("products");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.products", b =>
                {
                    b.HasOne("WebAPI.Data.Entities.productBrand", "productBrand")
                        .WithMany("products")
                        .HasForeignKey("idBrand")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Data.Entities.productCategories", "productCategories")
                        .WithMany("products")
                        .HasForeignKey("idCategory")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Data.Entities.productColor", "productColor")
                        .WithMany("products")
                        .HasForeignKey("idColor")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Data.Entities.productSize", "productSize")
                        .WithMany("products")
                        .HasForeignKey("idSize")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Data.Entities.productTypes", "productTypes")
                        .WithMany("products")
                        .HasForeignKey("idType")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("productBrand");

                    b.Navigation("productCategories");

                    b.Navigation("productColor");

                    b.Navigation("productSize");

                    b.Navigation("productTypes");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.rating", b =>
                {
                    b.HasOne("WebAPI.Data.Entities.products", "products")
                        .WithMany("ratings")
                        .HasForeignKey("idProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebAPI.Data.Entities.users", "users")
                        .WithMany("ratings")
                        .HasForeignKey("idUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("products");

                    b.Navigation("users");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.odersList", b =>
                {
                    b.Navigation("odersDetails");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.productBrand", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.productCategories", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.productColor", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.productSize", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.productTypes", b =>
                {
                    b.Navigation("products");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.products", b =>
                {
                    b.Navigation("odersDetails");

                    b.Navigation("productPhotos");

                    b.Navigation("ratings");
                });

            modelBuilder.Entity("WebAPI.Data.Entities.users", b =>
                {
                    b.Navigation("odersLists");

                    b.Navigation("ratings");
                });
#pragma warning restore 612, 618
        }
    }
}
