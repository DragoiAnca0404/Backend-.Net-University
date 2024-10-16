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
    [Migration("20210902101504_Add Schema Database")]
    partial class AddSchemaDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.ToTable("Student");
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

                    b.ToTable("Specializare");
                });

            modelBuilder.Entity("Commander.Model.Studenti", b =>
                {
                    b.HasOne("Commander.Models.Specializari", "Specializari")
                        .WithMany()
                        .HasForeignKey("Specializariid_Specializare");

                    b.Navigation("Specializari");
                });
#pragma warning restore 612, 618
        }
    }
}
