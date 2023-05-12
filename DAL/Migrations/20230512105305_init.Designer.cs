﻿// <auto-generated />
using System;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(CaloCalcDbContext))]
    [Migration("20230512105305_init")]
    partial class init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Kategori", b =>
                {
                    b.Property<int>("KategoriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KategoriID"), 1L, 1);

                    b.Property<string>("KategoriAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YiyecekID")
                        .HasColumnType("int");

                    b.HasKey("KategoriID");

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            KategoriID = 1,
                            KategoriAdi = "Ana Yemekler",
                            YiyecekID = 0
                        },
                        new
                        {
                            KategoriID = 2,
                            KategoriAdi = "Çorbalar",
                            YiyecekID = 0
                        },
                        new
                        {
                            KategoriID = 3,
                            KategoriAdi = "Salatalar",
                            YiyecekID = 0
                        },
                        new
                        {
                            KategoriID = 4,
                            KategoriAdi = "Tatlılar",
                            YiyecekID = 0
                        },
                        new
                        {
                            KategoriID = 5,
                            KategoriAdi = "İçecekler",
                            YiyecekID = 0
                        },
                        new
                        {
                            KategoriID = 6,
                            KategoriAdi = "Meyveler",
                            YiyecekID = 0
                        },
                        new
                        {
                            KategoriID = 7,
                            KategoriAdi = "Abur Cubur",
                            YiyecekID = 0
                        },
                        new
                        {
                            KategoriID = 8,
                            KategoriAdi = "Kahvaltılık",
                            YiyecekID = 0
                        },
                        new
                        {
                            KategoriID = 9,
                            KategoriAdi = "Sebzeler",
                            YiyecekID = 0
                        });
                });

            modelBuilder.Entity("Entities.Kullanici", b =>
                {
                    b.Property<int>("KullaniciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KullaniciID"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Boy")
                        .HasColumnType("int");

                    b.Property<int>("Kilo")
                        .HasColumnType("int");

                    b.Property<string>("KullaniciMail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OgunID")
                        .HasColumnType("int");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Yasi")
                        .HasColumnType("int");

                    b.HasKey("KullaniciID");

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("Entities.Ogun", b =>
                {
                    b.Property<int>("OgunID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgunID"), 1L, 1);

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<int>("OgunAdi")
                        .HasColumnType("int");

                    b.Property<double>("PorsiyonAdet")
                        .HasColumnType("float");

                    b.Property<double>("ToplamKalori")
                        .HasColumnType("float");

                    b.Property<DateTime>("YemekYemeZamani")
                        .HasColumnType("datetime2");

                    b.Property<int>("YiyecekID")
                        .HasColumnType("int");

                    b.HasKey("OgunID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("Ogunler");
                });

            modelBuilder.Entity("Entities.Yiyecek", b =>
                {
                    b.Property<int>("YiyecekID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YiyecekID"), 1L, 1);

                    b.Property<byte[]>("Fotograf")
                        .HasColumnType("image");

                    b.Property<string>("FotografYolu")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("Kalori")
                        .HasColumnType("float");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<int?>("OgunID")
                        .HasColumnType("int");

                    b.Property<int?>("Toplam")
                        .HasColumnType("int");

                    b.Property<string>("YiyecekAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("YiyecekID");

                    b.HasIndex("KategoriID");

                    b.HasIndex("OgunID");

                    b.ToTable("Yiyecekler");
                });

            modelBuilder.Entity("Entities.Ogun", b =>
                {
                    b.HasOne("Entities.Kullanici", "Kullanici")
                        .WithMany("Ogunler")
                        .HasForeignKey("KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("Entities.Yiyecek", b =>
                {
                    b.HasOne("Entities.Kategori", "Kategori")
                        .WithMany("Yiyecekler")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Ogun", "Ogun")
                        .WithMany("Yiyecekler")
                        .HasForeignKey("OgunID");

                    b.Navigation("Kategori");

                    b.Navigation("Ogun");
                });

            modelBuilder.Entity("Entities.Kategori", b =>
                {
                    b.Navigation("Yiyecekler");
                });

            modelBuilder.Entity("Entities.Kullanici", b =>
                {
                    b.Navigation("Ogunler");
                });

            modelBuilder.Entity("Entities.Ogun", b =>
                {
                    b.Navigation("Yiyecekler");
                });
#pragma warning restore 612, 618
        }
    }
}