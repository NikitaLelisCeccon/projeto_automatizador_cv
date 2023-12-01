﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projeto_automatizador_cv.Models;

#nullable disable

namespace projeto_automatizador_cv.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231201004438_M06-AdjustTableExperiencia")]
    partial class M06AdjustTableExperiencia
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("projeto_automatizador_cv.Models.Curriculo", b =>
                {
                    b.Property<string>("Candidato")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Certificacoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Competencias")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cursos")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Formacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Idiomas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Posicao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Resumo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Candidato");

                    b.ToTable("Curriculos");
                });

            modelBuilder.Entity("projeto_automatizador_cv.Models.Experiencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Atividades")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CurriculoCandidato")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Empresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inicio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Termino")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CurriculoCandidato");

                    b.ToTable("Experiencias");
                });

            modelBuilder.Entity("projeto_automatizador_cv.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("projeto_automatizador_cv.Models.Experiencia", b =>
                {
                    b.HasOne("projeto_automatizador_cv.Models.Curriculo", "Curriculo")
                        .WithMany("Experiencias")
                        .HasForeignKey("CurriculoCandidato")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Curriculo");
                });

            modelBuilder.Entity("projeto_automatizador_cv.Models.Curriculo", b =>
                {
                    b.Navigation("Experiencias");
                });
#pragma warning restore 612, 618
        }
    }
}
