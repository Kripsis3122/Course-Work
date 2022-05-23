﻿// <auto-generated />
using FactsApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FactsApp.Migrations
{
    [DbContext(typeof(FactsContext))]
    partial class FactsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("FactsApp.Models.Fact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .HasColumnType("text");

                    b.Property<string>("FactBody")
                        .HasColumnType("text");

                    b.Property<string>("FactTitle")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Facts");
                });
#pragma warning restore 612, 618
        }
    }
}
