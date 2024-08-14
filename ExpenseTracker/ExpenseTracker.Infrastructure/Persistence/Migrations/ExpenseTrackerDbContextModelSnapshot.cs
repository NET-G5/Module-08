﻿// <auto-generated />
using System;
using ExpenseTracker.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExpenseTracker.Infrastructure.Persistence.Migrations
{
    [DbContext(typeof(ExpenseTrackerDbContext))]
    partial class ExpenseTrackerDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ExpenseTracker.Domain.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Category", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2024, 8, 11, 10, 8, 55, 658, DateTimeKind.Utc).AddTicks(1470),
                            Description = "Monthly grocery expenses.",
                            Name = "Grocery"
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2024, 8, 11, 10, 8, 55, 658, DateTimeKind.Utc).AddTicks(1490),
                            Description = "Monthly grocery expenses.",
                            Name = "Community services"
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2024, 8, 11, 10, 8, 55, 658, DateTimeKind.Utc).AddTicks(1499),
                            Description = "Regular Job income.",
                            Name = "Salary"
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2024, 8, 11, 10, 8, 55, 658, DateTimeKind.Utc).AddTicks(1505),
                            Description = "Side husstle.",
                            Name = "Other incomes"
                        });
                });

            modelBuilder.Entity("ExpenseTracker.Domain.Entities.Transfer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasPrecision(13, 2)
                        .HasColumnType("decimal(13,2)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Transfer", (string)null);
                });

            modelBuilder.Entity("ExpenseTracker.Domain.Entities.Transfer", b =>
                {
                    b.HasOne("ExpenseTracker.Domain.Entities.Category", "Category")
                        .WithMany("Transfers")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ExpenseTracker.Domain.Entities.Category", b =>
                {
                    b.Navigation("Transfers");
                });
#pragma warning restore 612, 618
        }
    }
}
