﻿// <auto-generated />
using System;
using CustomerData.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CustomerData.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.10");

            modelBuilder.Entity("CustomerData.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("User", "Identity");

                    b.HasData(
                        new
                        {
                            Id = "4ec135f7-2d61-4429-bd9b-b1078ce19d95",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "c8c9db50-2719-488b-af4d-68db37a0c3cc",
                            Email = "superadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Amit",
                            LastName = "Naik",
                            LockoutEnabled = false,
                            NormalizedEmail = "SUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "SUPERADMIN",
                            PasswordHash = "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "1d37674d-d587-4535-96d8-1bf4c4a7e9d9",
                            TwoFactorEnabled = false,
                            UserName = "superadmin"
                        },
                        new
                        {
                            Id = "9a66796d-c355-4b94-988a-9989fe3b673c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b71e6ae5-7ba7-4f54-bc75-c933ca1a9f39",
                            Email = "basicuser@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Basic",
                            LastName = "User",
                            LockoutEnabled = false,
                            NormalizedEmail = "BASICUSER@GMAIL.COM",
                            NormalizedUserName = "BASICUSER",
                            PasswordHash = "AQAAAAEAACcQAAAAEBLjouNqaeiVWbN0TbXUS3+ChW3d7aQIk/BQEkWBxlrdRRngp14b0BIH0Rp65qD6mA==",
                            PhoneNumberConfirmed = true,
                            SecurityStamp = "0b691690-4a32-4984-abb8-71a312d1d35f",
                            TwoFactorEnabled = false,
                            UserName = "basicuser"
                        });
                });

            modelBuilder.Entity("CustomerData.Domain.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bb25560d-6976-4da4-8f85-eb64e526b48b"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Concert",
                            Name = "Concert"
                        },
                        new
                        {
                            Id = new Guid("bfc8e57e-f25d-437d-8627-70fe79bdf3ee"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Musical",
                            Name = "Musical"
                        },
                        new
                        {
                            Id = new Guid("6747446d-4c4f-4973-8a77-6858c57eeb1b"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Conference",
                            Name = "Conference"
                        });
                });

            modelBuilder.Entity("CustomerData.Domain.Entities.Event", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("LastModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("LastModifiedDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f5215504-f0ac-4ea1-841f-dc8f80c93f01"),
                            CategoryId = new Guid("bfc8e57e-f25d-437d-8627-70fe79bdf3ee"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2023, 4, 21, 13, 59, 37, 784, DateTimeKind.Local).AddTicks(4551),
                            Description = "Guitar music concert 2020",
                            Name = "Guitar hits 2020"
                        },
                        new
                        {
                            Id = new Guid("9dd3dd8c-b076-4169-8bda-ed9e794c1b54"),
                            CategoryId = new Guid("bfc8e57e-f25d-437d-8627-70fe79bdf3ee"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2023, 4, 21, 13, 59, 37, 784, DateTimeKind.Local).AddTicks(4595),
                            Description = "Guitar music concert 2021",
                            Name = "Guitar hits 2021"
                        },
                        new
                        {
                            Id = new Guid("fb688f57-ebf2-480a-bcac-7ccf56a17805"),
                            CategoryId = new Guid("6747446d-4c4f-4973-8a77-6858c57eeb1b"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2023, 10, 21, 13, 59, 37, 784, DateTimeKind.Local).AddTicks(4600),
                            Description = "The tech conference in c#",
                            Name = "Event 2020"
                        },
                        new
                        {
                            Id = new Guid("960dedb4-83d2-44f3-b900-d57fa06a9376"),
                            CategoryId = new Guid("6747446d-4c4f-4973-8a77-6858c57eeb1b"),
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Date = new DateTime(2023, 8, 21, 13, 59, 37, 784, DateTimeKind.Local).AddTicks(4603),
                            Description = "The tech conference in .net core",
                            Name = "Event 2021"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("Role", "Identity");

                    b.HasData(
                        new
                        {
                            Id = "90f042e7-24d9-4087-a4ec-04139b0af30d",
                            ConcurrencyStamp = "d72dfbf3-4bfd-41de-9f31-ee2c8f08f6a1",
                            Name = "SuperAdmin",
                            NormalizedName = "SuperAdmin"
                        },
                        new
                        {
                            Id = "da3a93df-9caa-4c01-915a-30e4f7e7fcd9",
                            ConcurrencyStamp = "369e0926-9800-4636-967e-ae9454c6fbab",
                            Name = "Admin",
                            NormalizedName = "Admin"
                        },
                        new
                        {
                            Id = "ae67aea4-462f-42b0-9cf3-288aa5d53999",
                            ConcurrencyStamp = "d34763c5-1845-4f12-9d3d-8568ceced9fc",
                            Name = "Moderator",
                            NormalizedName = "Moderator"
                        },
                        new
                        {
                            Id = "c6ecdd35-aa15-4195-9643-cf461a6315d9",
                            ConcurrencyStamp = "92aabb17-aa1e-42fb-b8f7-9b678fc062ac",
                            Name = "Basic",
                            NormalizedName = "Basic"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider");

                    b.ToTable("UserLogins", "Identity");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles", "Identity");

                    b.HasData(
                        new
                        {
                            UserId = "9a66796d-c355-4b94-988a-9989fe3b673c",
                            RoleId = "c6ecdd35-aa15-4195-9643-cf461a6315d9"
                        },
                        new
                        {
                            UserId = "4ec135f7-2d61-4429-bd9b-b1078ce19d95",
                            RoleId = "90f042e7-24d9-4087-a4ec-04139b0af30d"
                        },
                        new
                        {
                            UserId = "4ec135f7-2d61-4429-bd9b-b1078ce19d95",
                            RoleId = "da3a93df-9caa-4c01-915a-30e4f7e7fcd9"
                        },
                        new
                        {
                            UserId = "4ec135f7-2d61-4429-bd9b-b1078ce19d95",
                            RoleId = "ae67aea4-462f-42b0-9cf3-288aa5d53999"
                        },
                        new
                        {
                            UserId = "4ec135f7-2d61-4429-bd9b-b1078ce19d95",
                            RoleId = "c6ecdd35-aa15-4195-9643-cf461a6315d9"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens", "Identity");
                });

            modelBuilder.Entity("CustomerData.Domain.Entities.Event", b =>
                {
                    b.HasOne("CustomerData.Domain.Entities.Category", "Category")
                        .WithMany("Events")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("CustomerData.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("CustomerData.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CustomerData.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("CustomerData.Domain.Entities.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("CustomerData.Domain.Entities.Category", b =>
                {
                    b.Navigation("Events");
                });
#pragma warning restore 612, 618
        }
    }
}
