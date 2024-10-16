﻿// <auto-generated />
using System;
using Commander.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App_Facultate.Migrations
{
    [DbContext(typeof(FacultateContext))]
    [Migration("20210906111316_Generate")]
    partial class Generate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Commander.Model.Administratori", b =>
                {
                    b.Property<int>("id_administrator")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Utilizatoriid_utilizator")
                        .HasColumnType("int");

                    b.Property<int>("id_utilizator")
                        .HasColumnType("int");

                    b.HasKey("id_administrator");

                    b.HasIndex("Utilizatoriid_utilizator");

                    b.ToTable("Administratori");
                });

            modelBuilder.Entity("Commander.Model.Studenti", b =>
                {
                    b.Property<int>("id_student")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Specializariid_Specializare")
                        .HasColumnType("int");

                    b.Property<int>("id_specializare")
                        .HasColumnType("int");

                    b.Property<bool>("scutit_plata")
                        .HasColumnType("bit");

                    b.HasKey("id_student");

                    b.HasIndex("Specializariid_Specializare");

                    b.ToTable("Studenti");
                });

            modelBuilder.Entity("Commander.Model.Utilizatori", b =>
                {
                    b.Property<int>("id_utilizator")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nume")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("parola")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("prenume")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("id_utilizator");

                    b.ToTable("Utilizatori");
                });

            modelBuilder.Entity("Commander.Models.Calificative", b =>
                {
                    b.Property<int>("id_Specializare")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Materiiid_materie")
                        .HasColumnType("int");

                    b.Property<int?>("Studentiid_student")
                        .HasColumnType("int");

                    b.Property<int>("id_materie")
                        .HasColumnType("int");

                    b.Property<int>("id_student")
                        .HasColumnType("int");

                    b.Property<int>("nota")
                        .HasColumnType("int");

                    b.HasKey("id_Specializare");

                    b.HasIndex("Materiiid_materie");

                    b.HasIndex("Studentiid_student");

                    b.ToTable("Calificative");
                });

            modelBuilder.Entity("Commander.Models.Materii", b =>
                {
                    b.Property<int>("id_materie")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("denumire_materie")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("id_materie");

                    b.ToTable("Materii");
                });

            modelBuilder.Entity("Commander.Models.Profesori", b =>
                {
                    b.Property<int>("id_profesor")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Materiiid_materie")
                        .HasColumnType("int");

                    b.Property<int?>("Utilizatoriid_utilizator")
                        .HasColumnType("int");

                    b.Property<int?>("grad")
                        .HasColumnType("int");

                    b.Property<int>("id_materie")
                        .HasColumnType("int");

                    b.Property<int>("id_utilizator")
                        .HasColumnType("int");

                    b.Property<decimal>("salariu")
                        .HasColumnType("money");

                    b.HasKey("id_profesor");

                    b.HasIndex("Materiiid_materie");

                    b.HasIndex("Utilizatoriid_utilizator");

                    b.ToTable("Profesori");
                });

            modelBuilder.Entity("Commander.Models.Specializari", b =>
                {
                    b.Property<int>("id_Specializare")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("denumire_specializare")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("id_Specializare");

                    b.ToTable("Specializari");
                });

            modelBuilder.Entity("Commander.Model.Administratori", b =>
                {
                    b.HasOne("Commander.Model.Utilizatori", "Utilizatori")
                        .WithMany()
                        .HasForeignKey("Utilizatoriid_utilizator");

                    b.Navigation("Utilizatori");
                });

            modelBuilder.Entity("Commander.Model.Studenti", b =>
                {
                    b.HasOne("Commander.Models.Specializari", "Specializari")
                        .WithMany()
                        .HasForeignKey("Specializariid_Specializare");

                    b.Navigation("Specializari");
                });

            modelBuilder.Entity("Commander.Models.Calificative", b =>
                {
                    b.HasOne("Commander.Models.Materii", "Materii")
                        .WithMany()
                        .HasForeignKey("Materiiid_materie");

                    b.HasOne("Commander.Model.Studenti", "Studenti")
                        .WithMany()
                        .HasForeignKey("Studentiid_student");

                    b.Navigation("Materii");

                    b.Navigation("Studenti");
                });

            modelBuilder.Entity("Commander.Models.Profesori", b =>
                {
                    b.HasOne("Commander.Models.Materii", "Materii")
                        .WithMany()
                        .HasForeignKey("Materiiid_materie");

                    b.HasOne("Commander.Model.Utilizatori", "Utilizatori")
                        .WithMany()
                        .HasForeignKey("Utilizatoriid_utilizator");

                    b.Navigation("Materii");

                    b.Navigation("Utilizatori");
                });
#pragma warning restore 612, 618
        }
    }
}
