﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NotasUApi.Data;

namespace NotasUApi.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NotasUApi.Model.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<decimal>("Note")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("Percent")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int?>("QualificationId")
                        .HasColumnType("int");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("QualificationId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("NotasUApi.Model.Qualification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Cort")
                        .HasColumnType("int");

                    b.Property<string>("SubjectCode")
                        .HasColumnType("varchar(10)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("TotalActivityPercent")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("TotalPartial")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<decimal>("TotalPercent")
                        .HasColumnType("decimal(18, 2)");

                    b.HasKey("Id");

                    b.HasIndex("SubjectCode");

                    b.ToTable("Qualifications");
                });

            modelBuilder.Entity("NotasUApi.Model.Subject", b =>
                {
                    b.Property<string>("Code")
                        .HasColumnType("varchar(10)")
                        .HasMaxLength(10);

                    b.Property<decimal>("Definitiva")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Code");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("NotasUApi.Model.Activity", b =>
                {
                    b.HasOne("NotasUApi.Model.Qualification", null)
                        .WithMany("Activities")
                        .HasForeignKey("QualificationId");
                });

            modelBuilder.Entity("NotasUApi.Model.Qualification", b =>
                {
                    b.HasOne("NotasUApi.Model.Subject", null)
                        .WithMany("Qualifications")
                        .HasForeignKey("SubjectCode");
                });
#pragma warning restore 612, 618
        }
    }
}
