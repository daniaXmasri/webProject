﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using wep.Models;

#nullable disable

namespace wep.Migrations
{
    [DbContext(typeof(ServisContext))]
    [Migration("20241203203411_KuaforSalonu")]
    partial class KuaforSalonu
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.36")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("wep.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"), 1L, 1);

                    b.Property<int>("EmployeeExperience")
                        .HasMaxLength(30)
                        .HasColumnType("int");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<string>("EmployeeSurname")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.Property<int>("workingHours")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("wep.Models.Servis", b =>
                {
                    b.Property<int>("ServisID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ServisID"), 1L, 1);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<string>("ServisName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ServisID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("servis");
                });

            modelBuilder.Entity("wep.Models.Servis", b =>
                {
                    b.HasOne("wep.Models.Employee", "employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("employee");
                });
#pragma warning restore 612, 618
        }
    }
}
