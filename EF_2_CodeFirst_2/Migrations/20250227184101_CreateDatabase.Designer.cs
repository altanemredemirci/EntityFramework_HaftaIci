﻿// <auto-generated />
using EF_2_CodeFirst_2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF_2_CodeFirst_2.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20250227184101_CreateDatabase")]
    partial class CreateDatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EF_2_CodeFirst_2.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Numara")
                        .HasColumnType("int");

                    b.Property<int>("SinifId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SinifId");

                    b.ToTable("Ogrenciler");
                });

            modelBuilder.Entity("EF_2_CodeFirst_2.Sinif", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Siniflar");
                });

            modelBuilder.Entity("EF_2_CodeFirst_2.Ogrenci", b =>
                {
                    b.HasOne("EF_2_CodeFirst_2.Sinif", "Sinif")
                        .WithMany("Ogrencis")
                        .HasForeignKey("SinifId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sinif");
                });

            modelBuilder.Entity("EF_2_CodeFirst_2.Sinif", b =>
                {
                    b.Navigation("Ogrencis");
                });
#pragma warning restore 612, 618
        }
    }
}
