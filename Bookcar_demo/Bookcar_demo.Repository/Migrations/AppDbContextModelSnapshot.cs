﻿// <auto-generated />
using System;
using Bookcar_demo.Repository.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bookcar_demo.Repository.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bookcar_demo.Core.BorrowRecord", b =>
                {
                    b.Property<int>("BorrowRecordId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarRego");

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsActive");

                    b.Property<int>("UserId");

                    b.HasKey("BorrowRecordId");

                    b.HasIndex("CarRego");

                    b.HasIndex("UserId");

                    b.ToTable("BorrowRecord");
                });

            modelBuilder.Entity("Bookcar_demo.Core.Car", b =>
                {
                    b.Property<string>("Rego")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20);

                    b.Property<int?>("CarModelId");

                    b.Property<DateTime>("CreateDate");

                    b.Property<bool>("IsActive");

                    b.Property<int>("ModelId");

                    b.Property<byte>("Seats");

                    b.HasKey("Rego");

                    b.HasIndex("CarModelId");

                    b.ToTable("Car");
                });

            modelBuilder.Entity("Bookcar_demo.Core.CarModel", b =>
                {
                    b.Property<int>("CarModelId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CarMakeId");

                    b.Property<int?>("MakeId");

                    b.Property<string>("ModelName")
                        .HasMaxLength(255);

                    b.HasKey("CarModelId");

                    b.HasIndex("MakeId");

                    b.ToTable("CarModel");
                });

            modelBuilder.Entity("Bookcar_demo.Core.Make", b =>
                {
                    b.Property<int>("MakeId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MakeName")
                        .HasMaxLength(255);

                    b.HasKey("MakeId");

                    b.ToTable("Make");
                });

            modelBuilder.Entity("Bookcar_demo.Core.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWID()");

                    b.Property<string>("RoleName")
                        .HasMaxLength(255);

                    b.HasKey("RoleId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Bookcar_demo.Core.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactNumber")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateDate");

                    b.Property<string>("Firstname")
                        .HasMaxLength(255);

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName")
                        .HasMaxLength(255);

                    b.Property<string>("Password")
                        .HasColumnType("char(64)");

                    b.Property<Guid>("Salt");

                    b.HasKey("UserId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Bookcar_demo.Core.UserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<Guid>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("Bookcar_demo.Core.BorrowRecord", b =>
                {
                    b.HasOne("Bookcar_demo.Core.Car", "Car")
                        .WithMany("BorrowRecords")
                        .HasForeignKey("CarRego");

                    b.HasOne("Bookcar_demo.Core.User", "User")
                        .WithMany("BorrowRecords")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Bookcar_demo.Core.Car", b =>
                {
                    b.HasOne("Bookcar_demo.Core.CarModel")
                        .WithMany("Cars")
                        .HasForeignKey("CarModelId");
                });

            modelBuilder.Entity("Bookcar_demo.Core.CarModel", b =>
                {
                    b.HasOne("Bookcar_demo.Core.Make")
                        .WithMany("Models")
                        .HasForeignKey("MakeId");
                });

            modelBuilder.Entity("Bookcar_demo.Core.UserRole", b =>
                {
                    b.HasOne("Bookcar_demo.Core.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Bookcar_demo.Core.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
