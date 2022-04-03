﻿// <auto-generated />
using System;
using Jeremy_Castillo_Ap1_PF.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Jeremy_Castillo_Ap1_PF.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.3");

            modelBuilder.Entity("Jeremy_Castillo_Ap1_PF.Entidades.Estudiantes", b =>
                {
                    b.Property<int>("EstudianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("CantidadAsistencias")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("TEXT");

                    b.Property<int>("NacionalidadId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<char>("Sexo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("EstudianteId");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("Jeremy_Castillo_Ap1_PF.Entidades.Expedientes", b =>
                {
                    b.Property<int>("ExpedienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CantidadDocumentos")
                        .HasColumnType("INTEGER");

                    b.Property<int>("EstudianteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ExpedienteId");

                    b.ToTable("Expedientes");
                });

            modelBuilder.Entity("Jeremy_Castillo_Ap1_PF.Entidades.ExpedientesDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ExpedienteId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("TiposDocumentosId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ExpedienteId");

                    b.ToTable("ExpedientesDetalle");
                });

            modelBuilder.Entity("Jeremy_Castillo_Ap1_PF.Entidades.Nacionalidades", b =>
                {
                    b.Property<int>("NacionalidadId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<int?>("EstudiantesEstudianteId")
                        .HasColumnType("INTEGER");

                    b.HasKey("NacionalidadId");

                    b.HasIndex("EstudiantesEstudianteId");

                    b.ToTable("Nacionalidades");

                    b.HasData(
                        new
                        {
                            NacionalidadId = 1,
                            Descripcion = "Argentina"
                        },
                        new
                        {
                            NacionalidadId = 2,
                            Descripcion = "Bolivia"
                        },
                        new
                        {
                            NacionalidadId = 3,
                            Descripcion = "Colombia"
                        },
                        new
                        {
                            NacionalidadId = 4,
                            Descripcion = "Dominica"
                        },
                        new
                        {
                            NacionalidadId = 5,
                            Descripcion = "Ecuador"
                        },
                        new
                        {
                            NacionalidadId = 6,
                            Descripcion = "España"
                        },
                        new
                        {
                            NacionalidadId = 7,
                            Descripcion = "Haiti"
                        },
                        new
                        {
                            NacionalidadId = 8,
                            Descripcion = "Republica Dominicana"
                        },
                        new
                        {
                            NacionalidadId = 9,
                            Descripcion = "Rusia"
                        },
                        new
                        {
                            NacionalidadId = 10,
                            Descripcion = "Venezuela"
                        });
                });

            modelBuilder.Entity("Jeremy_Castillo_Ap1_PF.Entidades.TiposDocumentos", b =>
                {
                    b.Property<int>("TipoDocumentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("ExpedientesDetalleId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<bool>("RequeridoaAdulto")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("VecesAsignado")
                        .HasColumnType("INTEGER");

                    b.HasKey("TipoDocumentoId");

                    b.HasIndex("ExpedientesDetalleId");

                    b.ToTable("TiposDocumentos");
                });

            modelBuilder.Entity("Jeremy_Castillo_Ap1_PF.Entidades.ExpedientesDetalle", b =>
                {
                    b.HasOne("Jeremy_Castillo_Ap1_PF.Entidades.Expedientes", null)
                        .WithMany("ExpedienteDetalle")
                        .HasForeignKey("ExpedienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Jeremy_Castillo_Ap1_PF.Entidades.Nacionalidades", b =>
                {
                    b.HasOne("Jeremy_Castillo_Ap1_PF.Entidades.Estudiantes", null)
                        .WithMany("Nacionalidades")
                        .HasForeignKey("EstudiantesEstudianteId");
                });

            modelBuilder.Entity("Jeremy_Castillo_Ap1_PF.Entidades.TiposDocumentos", b =>
                {
                    b.HasOne("Jeremy_Castillo_Ap1_PF.Entidades.ExpedientesDetalle", null)
                        .WithMany("TiposDocumentos")
                        .HasForeignKey("ExpedientesDetalleId");
                });

            modelBuilder.Entity("Jeremy_Castillo_Ap1_PF.Entidades.Estudiantes", b =>
                {
                    b.Navigation("Nacionalidades");
                });

            modelBuilder.Entity("Jeremy_Castillo_Ap1_PF.Entidades.Expedientes", b =>
                {
                    b.Navigation("ExpedienteDetalle");
                });

            modelBuilder.Entity("Jeremy_Castillo_Ap1_PF.Entidades.ExpedientesDetalle", b =>
                {
                    b.Navigation("TiposDocumentos");
                });
#pragma warning restore 612, 618
        }
    }
}
