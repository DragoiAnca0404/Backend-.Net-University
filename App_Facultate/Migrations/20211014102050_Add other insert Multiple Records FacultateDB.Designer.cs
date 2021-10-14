﻿// <auto-generated />
using System;
using Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace App_Facultate.Migrations
{
    [DbContext(typeof(FacultateContext))]
    [Migration("20211014102050_Add other insert Multiple Records FacultateDB")]
    partial class AddotherinsertMultipleRecordsFacultateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.Administratori", b =>
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

                    b.HasData(
                        new
                        {
                            id_administrator = 1,
                            id_utilizator = 1
                        },
                        new
                        {
                            id_administrator = 2,
                            id_utilizator = 2
                        },
                        new
                        {
                            id_administrator = 3,
                            id_utilizator = 3
                        },
                        new
                        {
                            id_administrator = 4,
                            id_utilizator = 4
                        },
                        new
                        {
                            id_administrator = 5,
                            id_utilizator = 5
                        });
                });

            modelBuilder.Entity("Model.Studenti", b =>
                {
                    b.Property<int>("id_student")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Specializariid_Specializare")
                        .HasColumnType("int");

                    b.Property<int?>("Utilizatoriid_utilizator")
                        .HasColumnType("int");

                    b.Property<int>("id_specializare")
                        .HasColumnType("int");

                    b.Property<int>("id_utilizatori")
                        .HasColumnType("int");

                    b.Property<bool>("scutit_plata")
                        .HasColumnType("bit");

                    b.HasKey("id_student");

                    b.HasIndex("Specializariid_Specializare");

                    b.HasIndex("Utilizatoriid_utilizator");

                    b.ToTable("Studenti");

                    b.HasData(
                        new
                        {
                            id_student = 1,
                            id_specializare = 1,
                            id_utilizatori = 1,
                            scutit_plata = true
                        },
                        new
                        {
                            id_student = 2,
                            id_specializare = 2,
                            id_utilizatori = 2,
                            scutit_plata = false
                        },
                        new
                        {
                            id_student = 3,
                            id_specializare = 3,
                            id_utilizatori = 3,
                            scutit_plata = false
                        },
                        new
                        {
                            id_student = 4,
                            id_specializare = 4,
                            id_utilizatori = 4,
                            scutit_plata = true
                        },
                        new
                        {
                            id_student = 5,
                            id_specializare = 5,
                            id_utilizatori = 5,
                            scutit_plata = false
                        });
                });

            modelBuilder.Entity("Model.Utilizatori", b =>
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

                    b.HasData(
                        new
                        {
                            id_utilizator = 1,
                            email = "matei_matt@yahoo.ro",
                            nume = "Solomon",
                            parola = "matte777*",
                            prenume = "Matei",
                            username = "MateiSolomon"
                        },
                        new
                        {
                            id_utilizator = 2,
                            email = "ana_maria@yahoo.com",
                            nume = "Ion",
                            parola = "ana827272",
                            prenume = "Ana-Maria",
                            username = "AnaMaria"
                        },
                        new
                        {
                            id_utilizator = 3,
                            email = "george_07@gmail.com",
                            nume = "Ciobanu",
                            parola = "dogiuaaj922",
                            prenume = "George",
                            username = "George0647"
                        },
                        new
                        {
                            id_utilizator = 4,
                            email = "flo_andrei@yahoo.com",
                            nume = "Florescu",
                            parola = "moviehsjjs",
                            prenume = "Andrei",
                            username = "FlorescuAndrei"
                        },
                        new
                        {
                            id_utilizator = 5,
                            email = "anastasia_sia@yahoo.ro",
                            nume = "Soare",
                            parola = "sia73737*",
                            prenume = "Anastasia",
                            username = "AnastasiaS"
                        });
                });

            modelBuilder.Entity("Models.Calificative", b =>
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

                    b.Property<double>("nota")
                        .HasColumnType("float");

                    b.HasKey("id_Specializare");

                    b.HasIndex("Materiiid_materie");

                    b.HasIndex("Studentiid_student");

                    b.ToTable("Calificative");

                    b.HasData(
                        new
                        {
                            id_Specializare = 1,
                            id_materie = 1,
                            id_student = 1,
                            nota = 10.0
                        },
                        new
                        {
                            id_Specializare = 2,
                            id_materie = 2,
                            id_student = 2,
                            nota = 9.0500000000000007
                        },
                        new
                        {
                            id_Specializare = 3,
                            id_materie = 3,
                            id_student = 3,
                            nota = 7.5
                        },
                        new
                        {
                            id_Specializare = 4,
                            id_materie = 4,
                            id_student = 4,
                            nota = 5.6500000000000004
                        },
                        new
                        {
                            id_Specializare = 5,
                            id_materie = 5,
                            id_student = 5,
                            nota = 4.7999999999999998
                        });
                });

            modelBuilder.Entity("Models.Materii", b =>
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

                    b.HasData(
                        new
                        {
                            id_materie = 1,
                            denumire_materie = "Statistica economica"
                        },
                        new
                        {
                            id_materie = 2,
                            denumire_materie = "Psihologie politica"
                        },
                        new
                        {
                            id_materie = 3,
                            denumire_materie = "Bazele administratiei publice"
                        },
                        new
                        {
                            id_materie = 4,
                            denumire_materie = "Tehnici promotionale"
                        },
                        new
                        {
                            id_materie = 5,
                            denumire_materie = "Psihologie sociala"
                        });
                });

            modelBuilder.Entity("Models.Profesori", b =>
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

                    b.HasData(
                        new
                        {
                            id_profesor = 1,
                            grad = 0,
                            id_materie = 1,
                            id_utilizator = 1,
                            salariu = 5000m
                        },
                        new
                        {
                            id_profesor = 2,
                            grad = 1,
                            id_materie = 2,
                            id_utilizator = 2,
                            salariu = 5800m
                        },
                        new
                        {
                            id_profesor = 3,
                            grad = 2,
                            id_materie = 3,
                            id_utilizator = 3,
                            salariu = 7830m
                        },
                        new
                        {
                            id_profesor = 4,
                            grad = 3,
                            id_materie = 4,
                            id_utilizator = 4,
                            salariu = 4000m
                        },
                        new
                        {
                            id_profesor = 5,
                            grad = 0,
                            id_materie = 5,
                            id_utilizator = 5,
                            salariu = 6700m
                        });
                });

            modelBuilder.Entity("Models.Specializari", b =>
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

                    b.HasData(
                        new
                        {
                            id_Specializare = 1,
                            denumire_specializare = "Finante"
                        },
                        new
                        {
                            id_Specializare = 2,
                            denumire_specializare = "Stiinte politice"
                        },
                        new
                        {
                            id_Specializare = 3,
                            denumire_specializare = "Drept administrativ"
                        },
                        new
                        {
                            id_Specializare = 4,
                            denumire_specializare = "Marketing"
                        },
                        new
                        {
                            id_Specializare = 5,
                            denumire_specializare = "Asistenta sociala"
                        });
                });

            modelBuilder.Entity("Model.Administratori", b =>
                {
                    b.HasOne("Model.Utilizatori", "Utilizatori")
                        .WithMany()
                        .HasForeignKey("Utilizatoriid_utilizator");

                    b.Navigation("Utilizatori");
                });

            modelBuilder.Entity("Model.Studenti", b =>
                {
                    b.HasOne("Models.Specializari", "Specializari")
                        .WithMany()
                        .HasForeignKey("Specializariid_Specializare");

                    b.HasOne("Model.Utilizatori", "Utilizatori")
                        .WithMany()
                        .HasForeignKey("Utilizatoriid_utilizator");

                    b.Navigation("Specializari");

                    b.Navigation("Utilizatori");
                });

            modelBuilder.Entity("Models.Calificative", b =>
                {
                    b.HasOne("Models.Materii", "Materii")
                        .WithMany()
                        .HasForeignKey("Materiiid_materie");

                    b.HasOne("Model.Studenti", "Studenti")
                        .WithMany()
                        .HasForeignKey("Studentiid_student");

                    b.Navigation("Materii");

                    b.Navigation("Studenti");
                });

            modelBuilder.Entity("Models.Profesori", b =>
                {
                    b.HasOne("Models.Materii", "Materii")
                        .WithMany()
                        .HasForeignKey("Materiiid_materie");

                    b.HasOne("Model.Utilizatori", "Utilizatori")
                        .WithMany()
                        .HasForeignKey("Utilizatoriid_utilizator");

                    b.Navigation("Materii");

                    b.Navigation("Utilizatori");
                });
#pragma warning restore 612, 618
        }
    }
}
