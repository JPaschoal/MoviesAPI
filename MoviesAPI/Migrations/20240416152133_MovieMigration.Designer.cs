﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MoviesAPI;
using MoviesAPI.Data;

#nullable disable

namespace MoviesAPI.Migrations;

[DbContext(typeof(MovieContext))]
[Migration("20240416152133_MovieMigration")]
partial class MovieMigration
{
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder
            .HasAnnotation("ProductVersion", "8.0.3")
            .HasAnnotation("Relational:MaxIdentifierLength", 64);

        MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

        modelBuilder.Entity("MoviesAPI.Models.Movie", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                b.Property<int>("Duration")
                    .HasColumnType("int");

                b.Property<string>("Genre")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)");

                b.Property<string>("Title")
                    .IsRequired()
                    .HasColumnType("longtext");

                b.HasKey("Id");

                b.ToTable("Movies");
            });
#pragma warning restore 612, 618
    }
}
