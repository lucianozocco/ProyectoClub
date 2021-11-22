﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Proyecto.Context;

namespace Proyecto.Migrations
{
    [DbContext(typeof(SitioWebClubContext))]
    [Migration("20211122222657_primero")]
    partial class primero
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Proyecto.Models.Actividad", b =>
                {
                    b.Property<int>("ActividadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClubId")
                        .HasColumnType("int");

                    b.Property<int>("HorarioFinal")
                        .HasColumnType("int");

                    b.Property<int>("HorarioInicio")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("ActividadId");

                    b.HasIndex("ClubId");

                    b.ToTable("Actividades");
                });

            modelBuilder.Entity("Proyecto.Models.Club", b =>
                {
                    b.Property<int>("ClubId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClubId");

                    b.ToTable("Clubs");
                });

            modelBuilder.Entity("Proyecto.Models.Plan", b =>
                {
                    b.Property<int>("PlanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClubId")
                        .HasColumnType("int");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("PlanId");

                    b.HasIndex("ClubId");

                    b.ToTable("Planes");
                });

            modelBuilder.Entity("Proyecto.Models.Socio", b =>
                {
                    b.Property<int>("SocioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ClubId")
                        .HasColumnType("int");

                    b.Property<int?>("ClubId1")
                        .HasColumnType("int");

                    b.Property<string>("Domicilio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Edad")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SocioId");

                    b.HasIndex("ClubId");

                    b.HasIndex("ClubId1");

                    b.ToTable("Socios");
                });

            modelBuilder.Entity("Proyecto.Models.Actividad", b =>
                {
                    b.HasOne("Proyecto.Models.Club", null)
                        .WithMany("ListaActividades")
                        .HasForeignKey("ClubId");
                });

            modelBuilder.Entity("Proyecto.Models.Plan", b =>
                {
                    b.HasOne("Proyecto.Models.Club", null)
                        .WithMany("ListaPlanes")
                        .HasForeignKey("ClubId");
                });

            modelBuilder.Entity("Proyecto.Models.Socio", b =>
                {
                    b.HasOne("Proyecto.Models.Club", null)
                        .WithMany("ListaDeudores")
                        .HasForeignKey("ClubId");

                    b.HasOne("Proyecto.Models.Club", null)
                        .WithMany("ListaSocios")
                        .HasForeignKey("ClubId1");
                });
#pragma warning restore 612, 618
        }
    }
}
