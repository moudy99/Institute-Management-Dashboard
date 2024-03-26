﻿// <auto-generated />
using System;
using LAP.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LAP.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240314205714_init_3")]
    partial class init_3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LAP.Models.Course", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CrsHours")
                        .HasColumnType("int");

                    b.Property<int?>("Degree")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<int>("MinDegree")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("LAP.Models.CrsResult", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("TraineeID")
                        .HasColumnType("int");

                    b.Property<int>("degree")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("CourseID");

                    b.HasIndex("TraineeID");

                    b.ToTable("CrsResults");
                });

            modelBuilder.Entity("LAP.Models.Department", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Manger")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("LAP.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("salary")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("LAP.Models.Trainee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("LAP.Models.Course", b =>
                {
                    b.HasOne("LAP.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("LAP.Models.CrsResult", b =>
                {
                    b.HasOne("LAP.Models.Course", "Course")
                        .WithMany("CrsResults")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LAP.Models.Trainee", "Trainee")
                        .WithMany("CrsResults")
                        .HasForeignKey("TraineeID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("LAP.Models.Instructor", b =>
                {
                    b.HasOne("LAP.Models.Course", "Course")
                        .WithMany("Instructors")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LAP.Models.Department", "Department")
                        .WithMany("instructors")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("LAP.Models.Trainee", b =>
                {
                    b.HasOne("LAP.Models.Department", "Department")
                        .WithMany("Trainees")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("LAP.Models.Course", b =>
                {
                    b.Navigation("CrsResults");

                    b.Navigation("Instructors");
                });

            modelBuilder.Entity("LAP.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Trainees");

                    b.Navigation("instructors");
                });

            modelBuilder.Entity("LAP.Models.Trainee", b =>
                {
                    b.Navigation("CrsResults");
                });
#pragma warning restore 612, 618
        }
    }
}
