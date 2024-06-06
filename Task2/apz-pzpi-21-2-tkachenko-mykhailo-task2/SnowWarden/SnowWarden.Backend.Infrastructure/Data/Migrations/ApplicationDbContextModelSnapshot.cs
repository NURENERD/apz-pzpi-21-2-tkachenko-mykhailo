﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using SnowWarden.Backend.Infrastructure.Data;

#nullable disable

namespace SnowWarden.Backend.Infrastructure.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Booking.Booking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CancelledAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("GuestId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsCancelled")
                        .HasColumnType("boolean");

                    b.Property<int>("TrainingId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GuestId");

                    b.HasIndex("TrainingId");

                    b.ToTable("Bookings");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Communications.IoT.IoTMonitoringDeviceLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("IotMessage")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("LoggedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("SectionId")
                        .HasColumnType("integer");

                    b.Property<int?>("SectionId1")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SectionId");

                    b.HasIndex("SectionId1");

                    b.ToTable("IoTMonitoringDeviceLog");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Identity.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LanguageCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Inventory.Inventory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Inventories");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Inventory.InventoryItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("InventoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("InventoryId");

                    b.ToTable("InventoryItems");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Track.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AggregateDangerIndex")
                        .HasColumnType("integer");

                    b.Property<string>("DeterminingFactors")
                        .IsRequired()
                        .HasColumnType("json");

                    b.Property<int>("TrackId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TrackId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Track.Track", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tracks");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Training.TrainingSession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("InstructorId")
                        .HasColumnType("integer");

                    b.Property<int>("TrackId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.HasIndex("TrackId");

                    b.ToTable("Trainings");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Utils.Localization.Language", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("text");

                    b.Property<string>("Representation")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Code");

                    b.ToTable("Language");

                    b.HasData(
                        new
                        {
                            Code = "en",
                            Representation = "American english"
                        },
                        new
                        {
                            Code = "ua",
                            Representation = "Українська мова"
                        });
                });

            modelBuilder.Entity("TrainingSessionInventoryItem", b =>
                {
                    b.Property<int>("InventoryItemId")
                        .HasColumnType("integer");

                    b.Property<int>("SessionId")
                        .HasColumnType("integer");

                    b.HasKey("InventoryItemId", "SessionId");

                    b.HasIndex("SessionId");

                    b.ToTable("TrainingSessionInventoryItem");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Members.Admin", b =>
                {
                    b.HasBaseType("SnowWarden.Backend.Core.Features.Identity.ApplicationUser");

                    b.ToTable("Managers");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Members.Guest", b =>
                {
                    b.HasBaseType("SnowWarden.Backend.Core.Features.Identity.ApplicationUser");

                    b.Property<int>("Membership")
                        .HasColumnType("integer");

                    b.ToTable("Guests");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Members.Instructor", b =>
                {
                    b.HasBaseType("SnowWarden.Backend.Core.Features.Identity.ApplicationUser");

                    b.Property<int>("ExperienceMonths")
                        .HasColumnType("integer");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("SnowWarden.Backend.Core.Features.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("SnowWarden.Backend.Core.Features.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SnowWarden.Backend.Core.Features.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("SnowWarden.Backend.Core.Features.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Booking.Booking", b =>
                {
                    b.HasOne("SnowWarden.Backend.Core.Features.Members.Guest", "Guest")
                        .WithMany("Bookings")
                        .HasForeignKey("GuestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SnowWarden.Backend.Core.Features.Training.TrainingSession", "TrainingSession")
                        .WithMany("Bookings")
                        .HasForeignKey("TrainingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Guest");

                    b.Navigation("TrainingSession");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Communications.IoT.IoTMonitoringDeviceLog", b =>
                {
                    b.HasOne("SnowWarden.Backend.Core.Features.Track.Section", null)
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SnowWarden.Backend.Core.Features.Track.Section", null)
                        .WithMany("IotLogs")
                        .HasForeignKey("SectionId1");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Inventory.InventoryItem", b =>
                {
                    b.HasOne("SnowWarden.Backend.Core.Features.Inventory.Inventory", "Inventory")
                        .WithMany("InventoryItems")
                        .HasForeignKey("InventoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsMany("SnowWarden.Backend.Core.Features.Inventory.InventoryAttribute", "Attributes", b1 =>
                        {
                            b1.Property<int>("InventoryItemId")
                                .HasColumnType("integer");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            b1.Property<string>("Title")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("Value")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("InventoryItemId", "Id");

                            b1.ToTable("InventoryItems");

                            b1.ToJson("Attributes");

                            b1.WithOwner()
                                .HasForeignKey("InventoryItemId");
                        });

                    b.Navigation("Attributes");

                    b.Navigation("Inventory");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Track.Section", b =>
                {
                    b.HasOne("SnowWarden.Backend.Core.Features.Track.Track", "Track")
                        .WithMany("Sections")
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("SnowWarden.Backend.Core.Features.Track.SectionInfo", "Information", b1 =>
                        {
                            b1.Property<int>("SectionId")
                                .HasColumnType("integer");

                            b1.Property<int>("CurvatureDegrees")
                                .HasColumnType("integer");

                            b1.Property<int>("Danger")
                                .HasColumnType("integer");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("SectionId");

                            b1.ToTable("Sections");

                            b1.WithOwner()
                                .HasForeignKey("SectionId");
                        });

                    b.Navigation("Information")
                        .IsRequired();

                    b.Navigation("Track");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Training.TrainingSession", b =>
                {
                    b.HasOne("SnowWarden.Backend.Core.Features.Members.Instructor", "Instructor")
                        .WithMany("Trainings")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SnowWarden.Backend.Core.Features.Track.Track", "Track")
                        .WithMany()
                        .HasForeignKey("TrackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("SnowWarden.Backend.Core.Features.Training.TrainingInformation", "GeneralInformation", b1 =>
                        {
                            b1.Property<int>("TrainingSessionId")
                                .HasColumnType("integer");

                            b1.Property<string>("Descriptions")
                                .HasColumnType("text");

                            b1.Property<int>("DurationMinutes")
                                .HasColumnType("integer");

                            b1.Property<string>("Name")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<DateTime>("Start")
                                .HasColumnType("timestamp with time zone");

                            b1.HasKey("TrainingSessionId");

                            b1.ToTable("Trainings");

                            b1.ToJson("GeneralInformation");

                            b1.WithOwner()
                                .HasForeignKey("TrainingSessionId");
                        });

                    b.OwnsMany("SnowWarden.Backend.Core.Features.Training.TrainingLevel", "Levels", b1 =>
                        {
                            b1.Property<int>("TrainingSessionId")
                                .HasColumnType("integer");

                            b1.Property<int>("Id")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("integer");

                            b1.Property<int>("Level")
                                .HasColumnType("integer");

                            b1.HasKey("TrainingSessionId", "Id");

                            b1.ToTable("Trainings");

                            b1.ToJson("Levels");

                            b1.WithOwner()
                                .HasForeignKey("TrainingSessionId");
                        });

                    b.Navigation("GeneralInformation")
                        .IsRequired();

                    b.Navigation("Instructor");

                    b.Navigation("Levels");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("TrainingSessionInventoryItem", b =>
                {
                    b.HasOne("SnowWarden.Backend.Core.Features.Inventory.InventoryItem", null)
                        .WithMany()
                        .HasForeignKey("InventoryItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SnowWarden.Backend.Core.Features.Training.TrainingSession", null)
                        .WithMany()
                        .HasForeignKey("SessionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Members.Admin", b =>
                {
                    b.HasOne("SnowWarden.Backend.Core.Features.Identity.ApplicationUser", null)
                        .WithOne()
                        .HasForeignKey("SnowWarden.Backend.Core.Features.Members.Admin", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Members.Guest", b =>
                {
                    b.HasOne("SnowWarden.Backend.Core.Features.Identity.ApplicationUser", null)
                        .WithOne()
                        .HasForeignKey("SnowWarden.Backend.Core.Features.Members.Guest", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Members.Instructor", b =>
                {
                    b.HasOne("SnowWarden.Backend.Core.Features.Identity.ApplicationUser", null)
                        .WithOne()
                        .HasForeignKey("SnowWarden.Backend.Core.Features.Members.Instructor", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Inventory.Inventory", b =>
                {
                    b.Navigation("InventoryItems");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Track.Section", b =>
                {
                    b.Navigation("IotLogs");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Track.Track", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Training.TrainingSession", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Members.Guest", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("SnowWarden.Backend.Core.Features.Members.Instructor", b =>
                {
                    b.Navigation("Trainings");
                });
#pragma warning restore 612, 618
        }
    }
}