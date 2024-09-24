﻿// <auto-generated />
using System;
using AutodocConnector.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AutodocConnector.Persistence.Context.Migrations
{
    [DbContext(typeof(DbContext))]
    [Migration("20240924194852_InitializeDb")]
    partial class InitializeDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "uuid-ossp");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AutodocConnector.Persistence.Models.Country", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean")
                        .HasColumnName("active");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("code");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp")
                        .HasColumnName("created");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("countries", "autodoc-connector");
                });

            modelBuilder.Entity("AutodocConnector.Persistence.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<bool>("Active")
                        .HasColumnType("boolean")
                        .HasColumnName("active");

                    b.Property<string>("ArticleNumber")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("article-number");

                    b.Property<DateTime>("Created")
                        .HasColumnType("timestamp")
                        .HasColumnName("created");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Ean")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("ean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<int>("Stocks")
                        .HasColumnType("integer")
                        .HasColumnName("stocks");

                    b.HasKey("Id");

                    b.HasIndex("ArticleNumber")
                        .IsUnique();

                    b.HasIndex("Ean")
                        .IsUnique();

                    b.ToTable("products", "autodoc-connector");
                });

            modelBuilder.Entity("AutodocConnector.Persistence.Models.Role", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("text")
                        .HasColumnName("concurrency-stamp");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("text")
                        .HasColumnName("normalized-name");

                    b.HasKey("Id");

                    b.ToTable("roles", "autodoc-connector");
                });

            modelBuilder.Entity("AutodocConnector.Persistence.Models.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("claim-type");

                    b.Property<string>("ClaimValue")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("claim-value");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid")
                        .HasColumnName("role-id");

                    b.HasKey("Id");

                    b.ToTable("role-claims", "autodoc-connector");
                });

            modelBuilder.Entity("AutodocConnector.Persistence.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id")
                        .HasDefaultValueSql("uuid_generate_v4()");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer")
                        .HasColumnName("access-failed-count");

                    b.Property<Guid?>("ConcurrencyStamp")
                        .HasColumnType("uuid")
                        .HasColumnName("concurrency-stamp");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.Property<string>("Email")
                        .HasColumnType("text")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("email-confirmed");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("lockout-enabled");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("time with time zone")
                        .HasColumnName("lockout-end");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("text")
                        .HasColumnName("normalized-email");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("text")
                        .HasColumnName("normalized-user-name");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text")
                        .HasColumnName("password-hash");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text")
                        .HasColumnName("phone-number");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean")
                        .HasColumnName("phone-number-confirmed");

                    b.Property<Guid?>("SecurityStamp")
                        .HasColumnType("uuid")
                        .HasColumnName("security-stamp");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean")
                        .HasColumnName("two-factor-enabled");

                    b.Property<string>("UserName")
                        .HasColumnType("text")
                        .HasColumnName("user-name");

                    b.HasKey("Id");

                    b.ToTable("users", "autodoc-connector");

                    b.HasDiscriminator().HasValue("User");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("AutodocConnector.Persistence.Models.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text")
                        .HasColumnName("claim-type");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text")
                        .HasColumnName("claim-value");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user-id");

                    b.HasKey("Id");

                    b.ToTable("user-claims", "autodoc-connector");
                });

            modelBuilder.Entity("AutodocConnector.Persistence.Models.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("login-provider");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text")
                        .HasColumnName("provider-display-name");

                    b.Property<string>("ProviderKey")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("provider-key");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user-id");

                    b.ToTable("user-logins", "autodoc-connector");
                });

            modelBuilder.Entity("AutodocConnector.Persistence.Models.UserRole", b =>
                {
                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid")
                        .HasColumnName("role-id");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user-id");

                    b.ToTable("user-roles", "autodoc-connector");
                });

            modelBuilder.Entity("AutodocConnector.Persistence.Models.UserToken", b =>
                {
                    b.Property<string>("LoginProvider")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("login-provider");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("provider-key");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid")
                        .HasColumnName("user-id");

                    b.Property<string>("Value")
                        .HasColumnType("text")
                        .HasColumnName("provider-display-name");

                    b.ToTable("user-tokens", "autodoc-connector");
                });

            modelBuilder.Entity("AutodocConnector.Persistence.Models.AutodocUser", b =>
                {
                    b.HasBaseType("AutodocConnector.Persistence.Models.User");

                    b.Property<Guid?>("AssignedCountryId")
                        .IsRequired()
                        .HasColumnType("uuid")
                        .HasColumnName("assigned-country-id");

                    b.HasIndex("AssignedCountryId");

                    b.HasDiscriminator().HasValue("AutodocUser");
                });

            modelBuilder.Entity("AutodocConnector.Persistence.Models.AutodocUser", b =>
                {
                    b.HasOne("AutodocConnector.Persistence.Models.Country", "AssignedCountry")
                        .WithMany()
                        .HasForeignKey("AssignedCountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssignedCountry");
                });
#pragma warning restore 612, 618
        }
    }
}
