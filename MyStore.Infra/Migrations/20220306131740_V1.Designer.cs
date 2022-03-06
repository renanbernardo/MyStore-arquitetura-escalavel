﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyStore.Infra.Persistence.Contexts;

#nullable disable

namespace MyStore.Infra.Migrations
{
    [DbContext(typeof(MyStoreDataContext))]
    [Migration("20220306131740_V1")]
    partial class V1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("MyStore.Domain.Account.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ActivationCode")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nchar(4)")
                        .IsFixedLength();

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("AuthorizationCode")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("nchar(4)")
                        .IsFixedLength();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(160)
                        .HasColumnType("nvarchar(160)");

                    b.Property<DateTime>("LastAuthorizationCodeRequest")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LastLoginDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(36)
                        .HasColumnType("nchar(36)")
                        .IsFixedLength();

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("VerificationCode")
                        .IsRequired()
                        .HasMaxLength(6)
                        .HasColumnType("nchar(6)")
                        .IsFixedLength();

                    b.Property<bool>("Verified")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
