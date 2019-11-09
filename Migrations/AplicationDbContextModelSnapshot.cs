﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnyxPlataform.Models;

namespace OnyxPlataform.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("OnyxPlataform.Models.Buy", b =>
                {
                    b.Property<string>("BuyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BuyDate");

                    b.Property<string>("BuyDateDeliver");

                    b.Property<string>("BuyDetailsId");

                    b.Property<string>("CatalogueId");

                    b.Property<string>("StoreId");

                    b.HasKey("BuyId");

                    b.HasIndex("BuyDetailsId");

                    b.HasIndex("CatalogueId");

                    b.HasIndex("StoreId");

                    b.ToTable("BuyList");
                });

            modelBuilder.Entity("OnyxPlataform.Models.BuyDetails", b =>
                {
                    b.Property<string>("BuyDetailsId")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("BuyDetailsDiscount");

                    b.Property<int>("BuyDetailsQuantity");

                    b.Property<double>("BuyDetailsTotalPrice");

                    b.Property<string>("ProductId");

                    b.HasKey("BuyDetailsId");

                    b.HasIndex("ProductId");

                    b.ToTable("BuyDetailsList");
                });

            modelBuilder.Entity("OnyxPlataform.Models.BuyUser", b =>
                {
                    b.Property<string>("BuyUserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserDataId");

                    b.HasKey("BuyUserId");

                    b.HasIndex("UserDataId");

                    b.ToTable("BuyUserList");
                });

            modelBuilder.Entity("OnyxPlataform.Models.Catalogue", b =>
                {
                    b.Property<string>("CatalogueID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CatalogueProductBrand");

                    b.Property<string>("CatalogueProductBuilder");

                    b.Property<string>("CatalogueProductDescription");

                    b.Property<string>("CatalogueProductModel");

                    b.Property<string>("CatalogueProductName");

                    b.Property<string>("CatalogueProductType");

                    b.Property<string>("StoreId");

                    b.HasKey("CatalogueID");

                    b.HasIndex("StoreId");

                    b.ToTable("CatalogueList");
                });

            modelBuilder.Entity("OnyxPlataform.Models.ClassRoom", b =>
                {
                    b.Property<string>("ClassRoomId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassRoomDescriptions");

                    b.Property<string>("ClassRoomDirections");

                    b.Property<string>("ClassRoomName");

                    b.Property<string>("UserDataId");

                    b.HasKey("ClassRoomId");

                    b.HasIndex("UserDataId");

                    b.ToTable("ClassRoomList");
                });

            modelBuilder.Entity("OnyxPlataform.Models.Course", b =>
                {
                    b.Property<string>("CourseId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClassRoomId");

                    b.Property<int>("CourseCapacity");

                    b.Property<string>("CourseDescription");

                    b.Property<string>("CourseFinalDate");

                    b.Property<string>("CourseInitialDate");

                    b.Property<string>("CourseName");

                    b.HasKey("CourseId");

                    b.HasIndex("ClassRoomId");

                    b.ToTable("CourseList");
                });

            modelBuilder.Entity("OnyxPlataform.Models.Product", b =>
                {
                    b.Property<string>("ProductID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CatalogueId");

                    b.Property<string>("ProductColor");

                    b.Property<double>("ProductPrice");

                    b.Property<string>("ProductSerialNumber");

                    b.Property<string>("ProductWeight");

                    b.HasKey("ProductID");

                    b.HasIndex("CatalogueId");

                    b.ToTable("ProductList");
                });

            modelBuilder.Entity("OnyxPlataform.Models.Store", b =>
                {
                    b.Property<string>("StoreId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("StoreDescription");

                    b.Property<string>("StoreDirection");

                    b.Property<string>("StoreMotto");

                    b.Property<string>("StoreName");

                    b.Property<string>("UserDataId");

                    b.HasKey("StoreId");

                    b.HasIndex("UserDataId");

                    b.ToTable("StoreList");
                });

            modelBuilder.Entity("OnyxPlataform.Models.UserData", b =>
                {
                    b.Property<string>("UserDataID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("UserDataCreditCard");

                    b.Property<string>("UserDataCreditCardPin");

                    b.Property<string>("UserDataDirection");

                    b.Property<string>("UserDataFirstName");

                    b.Property<string>("UserDataLastName");

                    b.Property<string>("UserDataPostalCode");

                    b.HasKey("UserDataID");

                    b.ToTable("UserDataList");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OnyxPlataform.Models.Buy", b =>
                {
                    b.HasOne("OnyxPlataform.Models.BuyDetails", "buydetails")
                        .WithMany()
                        .HasForeignKey("BuyDetailsId");

                    b.HasOne("OnyxPlataform.Models.Catalogue", "catalogue")
                        .WithMany()
                        .HasForeignKey("CatalogueId");

                    b.HasOne("OnyxPlataform.Models.Store", "store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("OnyxPlataform.Models.BuyDetails", b =>
                {
                    b.HasOne("OnyxPlataform.Models.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("OnyxPlataform.Models.BuyUser", b =>
                {
                    b.HasOne("OnyxPlataform.Models.UserData", "user")
                        .WithMany()
                        .HasForeignKey("UserDataId");
                });

            modelBuilder.Entity("OnyxPlataform.Models.Catalogue", b =>
                {
                    b.HasOne("OnyxPlataform.Models.Store", "store")
                        .WithMany()
                        .HasForeignKey("StoreId");
                });

            modelBuilder.Entity("OnyxPlataform.Models.ClassRoom", b =>
                {
                    b.HasOne("OnyxPlataform.Models.UserData", "user")
                        .WithMany()
                        .HasForeignKey("UserDataId");
                });

            modelBuilder.Entity("OnyxPlataform.Models.Course", b =>
                {
                    b.HasOne("OnyxPlataform.Models.ClassRoom", "clasroom")
                        .WithMany()
                        .HasForeignKey("ClassRoomId");
                });

            modelBuilder.Entity("OnyxPlataform.Models.Product", b =>
                {
                    b.HasOne("OnyxPlataform.Models.Catalogue", "catalogue")
                        .WithMany()
                        .HasForeignKey("CatalogueId");
                });

            modelBuilder.Entity("OnyxPlataform.Models.Store", b =>
                {
                    b.HasOne("OnyxPlataform.Models.UserData", "user")
                        .WithMany()
                        .HasForeignKey("UserDataId");
                });
#pragma warning restore 612, 618
        }
    }
}
