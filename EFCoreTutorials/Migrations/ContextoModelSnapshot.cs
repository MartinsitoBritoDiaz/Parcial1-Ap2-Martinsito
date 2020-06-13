﻿// <auto-generated />
using System;
using EFCoreTutorials.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EFCoreTutorials.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EFCoreTutorials.Models.Curso", b =>
                {
                    b.Property<int>("cursoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cursoId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("EFCoreTutorials.Models.DireccionEstudiante", b =>
                {
                    b.Property<int>("direccionEstudianteId")
                        .HasColumnType("int");

                    b.Property<string>("ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("estudianteId")
                        .HasColumnType("int");

                    b.Property<string>("pais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("provincia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("direccionEstudianteId");

                    b.ToTable("DireccionEstudiante");
                });

            modelBuilder.Entity("EFCoreTutorials.Models.Estudiante", b =>
                {
                    b.Property<int>("estudianteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GradoId")
                        .HasColumnType("int");

                    b.Property<decimal>("altura")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("peso")
                        .HasColumnType("real");

                    b.Property<byte[]>("photo")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("estudianteId");

                    b.HasIndex("GradoId");

                    b.ToTable("Estudiantes");
                });

            modelBuilder.Entity("EFCoreTutorials.Models.Grado", b =>
                {
                    b.Property<int>("gradoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Seccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("gradoId");

                    b.ToTable("Grado");
                });

            modelBuilder.Entity("EFCoreTutorials.Models.DireccionEstudiante", b =>
                {
                    b.HasOne("EFCoreTutorials.Models.Estudiante", "Estudiante")
                        .WithOne("Direccion")
                        .HasForeignKey("EFCoreTutorials.Models.DireccionEstudiante", "direccionEstudianteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCoreTutorials.Models.Estudiante", b =>
                {
                    b.HasOne("EFCoreTutorials.Models.Grado", "Grado")
                        .WithMany("estudiantes")
                        .HasForeignKey("GradoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
