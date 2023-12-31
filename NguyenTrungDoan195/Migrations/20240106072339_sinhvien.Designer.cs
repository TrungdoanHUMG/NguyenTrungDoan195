﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace NguyenTrungDoan195.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240106072339_sinhvien")]
    partial class sinhvien
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.0");

            modelBuilder.Entity("NguyenTrungDoan195.Models.SinhVien", b =>
                {
                    b.Property<string>("MaSinhVien")
                        .HasColumnType("TEXT");

                    b.Property<double>("Diem")
                        .HasColumnType("REAL");

                    b.Property<string>("SoBaoDanh")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("MaSinhVien");

                    b.ToTable("SinhVien");
                });
#pragma warning restore 612, 618
        }
    }
}
