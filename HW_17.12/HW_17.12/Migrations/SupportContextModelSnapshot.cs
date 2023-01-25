﻿// <auto-generated />
using System;
using HW_17._12;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HW_17._12.Migrations
{
    [DbContext(typeof(SupportContext))]
    partial class SupportContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.31")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("HW_17._12.Models.Department", b =>
                {
                    b.Property<Guid>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("HW_17._12.Models.SupportRequest", b =>
                {
                    b.Property<Guid>("SupportRequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<Guid>("SupportSpecialistId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Topic")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("SupportRequestId");

                    b.HasIndex("SupportSpecialistId");

                    b.ToTable("SupportRequests");
                });

            modelBuilder.Entity("HW_17._12.Models.SupportSpecialist", b =>
                {
                    b.Property<Guid>("SupportSpecialistId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.HasKey("SupportSpecialistId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("SupportSpecialists");
                });

            modelBuilder.Entity("HW_17._12.Models.SupportRequest", b =>
                {
                    b.HasOne("HW_17._12.Models.SupportSpecialist", "SupportSpecialist")
                        .WithMany("SupportRequests")
                        .HasForeignKey("SupportSpecialistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HW_17._12.Models.SupportSpecialist", b =>
                {
                    b.HasOne("HW_17._12.Models.Department", "Department")
                        .WithMany("SupportSpecialists")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
