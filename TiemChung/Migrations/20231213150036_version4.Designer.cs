﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TiemChung;

#nullable disable

namespace TiemChung.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231213150036_version4")]
    partial class version4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TiemChung.Entity.CTGoiTiemChungEntity", b =>
                {
                    b.Property<string>("MaGoiTiemChung")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(0);

                    b.Property<string>("MaVaccine")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(1);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTimes")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaGoiTiemChung", "MaVaccine");

                    b.HasIndex("MaVaccine");

                    b.ToTable("CTGoiTiemChung");
                });

            modelBuilder.Entity("TiemChung.Entity.CTNhapVaccineEntity", b =>
                {
                    b.Property<string>("MaVaccine")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(0);

                    b.Property<string>("MaNhapVaccine")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(1);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTimes")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaVaccine", "MaNhapVaccine");

                    b.HasIndex("MaNhapVaccine");

                    b.ToTable("CTNhapVaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.CTVaccineEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTimes")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DoTuoi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LieuLuong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaVaccine")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TanSo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MaVaccine");

                    b.ToTable("ChiTietVaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.CTXuatVaccineEntity", b =>
                {
                    b.Property<string>("MaVaccine")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(0);

                    b.Property<string>("MaXuatVaccine")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(1);

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTimes")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.HasKey("MaVaccine", "MaXuatVaccine");

                    b.HasIndex("MaXuatVaccine");

                    b.ToTable("CTXuatVaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.GoiTiemChungEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTimes")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<float>("GiamGia")
                        .HasColumnType("real");

                    b.Property<string>("MaLoaiTiemChung")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("TongTien")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("MaLoaiTiemChung");

                    b.ToTable("GoiTiemChung");
                });

            modelBuilder.Entity("TiemChung.Entity.HoGiaDinhEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTimes")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("TenChuHo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HoGiaDinh");
                });

            modelBuilder.Entity("TiemChung.Entity.KhachHangEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CMND")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTimes")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("TiemChung.Entity.LoaiTiemChungEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTimes")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<float>("GiaTien")
                        .HasColumnType("real");

                    b.Property<string>("MaNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenLoaiTiem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("LoaiTiemChung");
                });

            modelBuilder.Entity("TiemChung.Entity.LoaiVaccineEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTimes")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("LoaiVaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.NhaCungCapEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTimes")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNCC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NhaCungCap");
                });

            modelBuilder.Entity("TiemChung.Entity.NhanVienEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CMND")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTimes")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("TiemChung.Entity.NhapVaccineEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTimes")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MaNhaCungCap")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MaNhaCungCap");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("NhapVaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.RefreshTokenEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpiredAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsRevoked")
                        .HasColumnType("bit");

                    b.Property<bool>("IsUsed")
                        .HasColumnType("bit");

                    b.Property<DateTime>("IssuedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("JwtId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RefreshToken");
                });

            modelBuilder.Entity("TiemChung.Entity.ThongTinTiemChungEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CMND")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTimes")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("DiaDiemTiem")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GioTiem")
                        .HasColumnType("datetime2");

                    b.Property<string>("HTSauTiem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HTTruocTiem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KetQua")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LanTiem")
                        .HasColumnType("int");

                    b.Property<string>("MaGoiTiemChung")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaHoGiaDinh")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaKhachHang")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgayDangKy")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayTiem")
                        .HasColumnType("datetime2");

                    b.Property<string>("TenNguoiDK")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MaGoiTiemChung");

                    b.HasIndex("MaHoGiaDinh");

                    b.HasIndex("MaKhachHang");

                    b.ToTable("ThongTinTiemChung");
                });

            modelBuilder.Entity("TiemChung.Entity.VaccineEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTimes")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<float>("GiaTien")
                        .HasColumnType("real");

                    b.Property<string>("MaLoaiVaccine")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgayHetHan")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgaySX")
                        .HasColumnType("datetime2");

                    b.Property<string>("NhaSanXuat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<string>("TenVaccine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MaLoaiVaccine");

                    b.ToTable("Vaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.XuatVaccineEntity", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CreateBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTimes")
                        .HasColumnType("datetime2");

                    b.Property<DateTimeOffset?>("DeletedTime")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("MaNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("XuatVaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.CTGoiTiemChungEntity", b =>
                {
                    b.HasOne("TiemChung.Entity.GoiTiemChungEntity", "GoiTiemChung")
                        .WithMany("CTGoiTiemChung")
                        .HasForeignKey("MaGoiTiemChung")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TiemChung.Entity.VaccineEntity", "Vaccine")
                        .WithMany("CTGoiTiemChung")
                        .HasForeignKey("MaVaccine")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("GoiTiemChung");

                    b.Navigation("Vaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.CTNhapVaccineEntity", b =>
                {
                    b.HasOne("TiemChung.Entity.NhapVaccineEntity", "NhapVaccine")
                        .WithMany("CTNhapVaccine")
                        .HasForeignKey("MaNhapVaccine")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TiemChung.Entity.VaccineEntity", "Vaccine")
                        .WithMany("CTNhapVaccine")
                        .HasForeignKey("MaVaccine")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("NhapVaccine");

                    b.Navigation("Vaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.CTVaccineEntity", b =>
                {
                    b.HasOne("TiemChung.Entity.VaccineEntity", "Vaccine")
                        .WithMany("CTVaccine")
                        .HasForeignKey("MaVaccine")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Vaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.CTXuatVaccineEntity", b =>
                {
                    b.HasOne("TiemChung.Entity.VaccineEntity", "Vaccine")
                        .WithMany("CTXuatVaccine")
                        .HasForeignKey("MaVaccine")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TiemChung.Entity.XuatVaccineEntity", "XuatVaccine")
                        .WithMany("CTXuatVaccine")
                        .HasForeignKey("MaXuatVaccine")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Vaccine");

                    b.Navigation("XuatVaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.GoiTiemChungEntity", b =>
                {
                    b.HasOne("TiemChung.Entity.LoaiTiemChungEntity", "LoaiTiemChung")
                        .WithMany("GoiTiemChung")
                        .HasForeignKey("MaLoaiTiemChung")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("LoaiTiemChung");
                });

            modelBuilder.Entity("TiemChung.Entity.LoaiTiemChungEntity", b =>
                {
                    b.HasOne("TiemChung.Entity.NhanVienEntity", "NhanVien")
                        .WithMany("LoaiTiemChung")
                        .HasForeignKey("MaNhanVien")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("TiemChung.Entity.NhapVaccineEntity", b =>
                {
                    b.HasOne("TiemChung.Entity.NhaCungCapEntity", "NhaCungCap")
                        .WithMany("NhapVaccine")
                        .HasForeignKey("MaNhaCungCap")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TiemChung.Entity.NhanVienEntity", "NhanVien")
                        .WithMany("NhapVaccine")
                        .HasForeignKey("MaNhanVien")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("NhaCungCap");

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("TiemChung.Entity.RefreshTokenEntity", b =>
                {
                    b.HasOne("TiemChung.Entity.KhachHangEntity", "KhachHang")
                        .WithMany("RefreshTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("TiemChung.Entity.ThongTinTiemChungEntity", b =>
                {
                    b.HasOne("TiemChung.Entity.GoiTiemChungEntity", "GoiTiemChung")
                        .WithMany("ThongTinTiemChung")
                        .HasForeignKey("MaGoiTiemChung")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("TiemChung.Entity.HoGiaDinhEntity", "HoGiaDinh")
                        .WithMany("ThongTinTiemChung")
                        .HasForeignKey("MaHoGiaDinh")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("TiemChung.Entity.KhachHangEntity", "KhachHang")
                        .WithMany("ThongTinTiemChung")
                        .HasForeignKey("MaKhachHang")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("GoiTiemChung");

                    b.Navigation("HoGiaDinh");

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("TiemChung.Entity.VaccineEntity", b =>
                {
                    b.HasOne("TiemChung.Entity.LoaiVaccineEntity", "LoaiVaccine")
                        .WithMany("Vaccine")
                        .HasForeignKey("MaLoaiVaccine")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("LoaiVaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.XuatVaccineEntity", b =>
                {
                    b.HasOne("TiemChung.Entity.NhanVienEntity", "NhanVien")
                        .WithMany("XuatVaccine")
                        .HasForeignKey("MaNhanVien")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("NhanVien");
                });

            modelBuilder.Entity("TiemChung.Entity.GoiTiemChungEntity", b =>
                {
                    b.Navigation("CTGoiTiemChung");

                    b.Navigation("ThongTinTiemChung");
                });

            modelBuilder.Entity("TiemChung.Entity.HoGiaDinhEntity", b =>
                {
                    b.Navigation("ThongTinTiemChung");
                });

            modelBuilder.Entity("TiemChung.Entity.KhachHangEntity", b =>
                {
                    b.Navigation("RefreshTokens");

                    b.Navigation("ThongTinTiemChung");
                });

            modelBuilder.Entity("TiemChung.Entity.LoaiTiemChungEntity", b =>
                {
                    b.Navigation("GoiTiemChung");
                });

            modelBuilder.Entity("TiemChung.Entity.LoaiVaccineEntity", b =>
                {
                    b.Navigation("Vaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.NhaCungCapEntity", b =>
                {
                    b.Navigation("NhapVaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.NhanVienEntity", b =>
                {
                    b.Navigation("LoaiTiemChung");

                    b.Navigation("NhapVaccine");

                    b.Navigation("XuatVaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.NhapVaccineEntity", b =>
                {
                    b.Navigation("CTNhapVaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.VaccineEntity", b =>
                {
                    b.Navigation("CTGoiTiemChung");

                    b.Navigation("CTNhapVaccine");

                    b.Navigation("CTVaccine");

                    b.Navigation("CTXuatVaccine");
                });

            modelBuilder.Entity("TiemChung.Entity.XuatVaccineEntity", b =>
                {
                    b.Navigation("CTXuatVaccine");
                });
#pragma warning restore 612, 618
        }
    }
}
