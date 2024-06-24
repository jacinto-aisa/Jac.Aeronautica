﻿// <auto-generated />
using Jac.Aeronaves.DAL.Contexto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jac.Aeronaves.Migrations
{
    [DbContext(typeof(AeronavesContexto))]
    [Migration("20221124181748_InitialCreateAzure")]
    partial class InitialCreateAzure
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Jac.Aeronaves.Models.Aeronave", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("IncrementoSueldo")
                        .HasColumnType("real");

                    b.Property<string>("Matricula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MesesDesdeMantenimento")
                        .HasColumnType("int");

                    b.Property<int>("NumeroMotores")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Aeronaves");
                });
#pragma warning restore 612, 618
        }
    }
}
