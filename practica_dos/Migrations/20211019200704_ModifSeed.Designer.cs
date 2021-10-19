﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using practica_dos.Models;

namespace practica_dos.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211019200704_ModifSeed")]
    partial class ModifSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("practica_dos.Models.Amigo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ciudad")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Amigos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ciudad = 7,
                            Email = "primero@mail.com",
                            Nombre = "Primero"
                        },
                        new
                        {
                            Id = 2,
                            Ciudad = 1,
                            Email = "segundo@mail.com",
                            Nombre = "Segundo"
                        },
                        new
                        {
                            Id = 3,
                            Ciudad = 4,
                            Email = "Tercero@mail.com",
                            Nombre = "Tercero"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
