﻿// <auto-generated />
using System;
using CSharpIntermediate.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CSharpIntermediate.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("CSharpIntermediate.Models.Product", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int(10)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(30)")
                        .UseCollation("utf8mb4_general_ci");

                    MySqlPropertyBuilderExtensions.HasCharSet(b.Property<string>("Name"), "utf8mb4");

                    b.Property<int>("QuantityOnHand")
                        .HasColumnType("int(10)");

                    b.Property<int?>("ReorderTheshold")
                        .HasColumnType("int(10)");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(5,2)");

                    b.HasKey("ID");

                    b.ToTable("product");
                });
#pragma warning restore 612, 618
        }
    }
}
