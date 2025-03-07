﻿// <auto-generated />
using Kolokwium_s22884.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kolokwium_s22884.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    [Migration("20240614065049_Add Character Table")]
    partial class AddCharacterTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Kolokwium_s22884.Models.Character", b =>
                {
                    b.Property<int>("PkCharacter")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkCharacter"));

                    b.Property<int>("CurrentWeig")
                        .HasColumnType("int")
                        .HasColumnName("current_weig");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("first_name");

                    b.Property<int>("MaxWeight")
                        .HasColumnType("int")
                        .HasColumnName("max_weight");

                    b.Property<int>("Money")
                        .HasColumnType("int")
                        .HasColumnName("money");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("last_name");

                    b.HasKey("PkCharacter");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("Kolokwium_s22884.Models.Item", b =>
                {
                    b.Property<int>("PkItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PK");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PkItem"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("name");

                    b.Property<int>("Weight")
                        .HasColumnType("int")
                        .HasColumnName("weig");

                    b.HasKey("PkItem");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
