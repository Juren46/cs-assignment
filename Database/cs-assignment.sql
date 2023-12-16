USE [master]
GO
/****** Object:  Database [cs-assignment]    Script Date: 12/16/2023 3:52:21 PM ******/
CREATE DATABASE [cs-assignment]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'cs-assignment', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.ELIO\MSSQL\DATA\cs-assignment.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'cs-assignment_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.ELIO\MSSQL\DATA\cs-assignment_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [cs-assignment] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [cs-assignment].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [cs-assignment] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [cs-assignment] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [cs-assignment] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [cs-assignment] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [cs-assignment] SET ARITHABORT OFF 
GO
ALTER DATABASE [cs-assignment] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [cs-assignment] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [cs-assignment] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [cs-assignment] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [cs-assignment] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [cs-assignment] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [cs-assignment] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [cs-assignment] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [cs-assignment] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [cs-assignment] SET  DISABLE_BROKER 
GO
ALTER DATABASE [cs-assignment] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [cs-assignment] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [cs-assignment] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [cs-assignment] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [cs-assignment] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [cs-assignment] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [cs-assignment] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [cs-assignment] SET RECOVERY FULL 
GO
ALTER DATABASE [cs-assignment] SET  MULTI_USER 
GO
ALTER DATABASE [cs-assignment] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [cs-assignment] SET DB_CHAINING OFF 
GO
ALTER DATABASE [cs-assignment] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [cs-assignment] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [cs-assignment] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [cs-assignment] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'cs-assignment', N'ON'
GO
ALTER DATABASE [cs-assignment] SET QUERY_STORE = ON
GO
ALTER DATABASE [cs-assignment] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [cs-assignment]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/16/2023 3:52:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[maHoaDon] [char](17) NOT NULL,
	[maSanPham] [char](7) NOT NULL,
	[donGia] [money] NOT NULL,
	[soLuong] [int] NOT NULL,
	[thanhTien] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietPhieuNhap]    Script Date: 12/16/2023 3:52:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietPhieuNhap](
	[maPhieuNhap] [char](15) NOT NULL,
	[maSanPham] [char](7) NOT NULL,
	[soLuong] [int] NOT NULL,
	[donGia] [money] NOT NULL,
	[thanhTien] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/16/2023 3:52:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[maHoaDon] [char](17) NOT NULL,
	[maNguoiTao] [char](7) NOT NULL,
	[maKhachHang] [char](7) NULL,
	[maKhuyenMai] [char](7) NULL,
	[tenKhuyenMai] [nvarchar](255) NULL,
	[thoiGianTao] [datetime2](0) NOT NULL,
	[tongTien] [money] NOT NULL,
	[giamGia] [money] NOT NULL,
	[thanhToan] [money] NOT NULL,
	[tienNhan] [money] NOT NULL,
	[tienThua] [money] NOT NULL,
 CONSTRAINT [PK_HoaDon_1] PRIMARY KEY CLUSTERED 
(
	[maHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/16/2023 3:52:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[maKhachHang] [char](7) NOT NULL,
	[hoTen] [nvarchar](255) NOT NULL,
	[soDienThoai] [varchar](15) NOT NULL,
	[hangThanhVien] [nvarchar](4) NOT NULL,
	[diemThanhVien] [int] NOT NULL,
	[trangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[maKhachHang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhuyenMai]    Script Date: 12/16/2023 3:52:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhuyenMai](
	[maKhuyenMai] [char](7) NOT NULL,
	[tenKhuyenMai] [nvarchar](255) NOT NULL,
	[loaiGiaTri] [nvarchar](50) NOT NULL,
	[giaTri] [float] NOT NULL,
	[thoiGianBatDau] [datetime2](0) NOT NULL,
	[thoiGianKetThuc] [datetime2](0) NOT NULL,
 CONSTRAINT [PK_KhuyenMai] PRIMARY KEY CLUSTERED 
(
	[maKhuyenMai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 12/16/2023 3:52:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[maLoaiSanPham] [char](7) NOT NULL,
	[tenLoaiSanPham] [nvarchar](255) NOT NULL,
	[trangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[maLoaiSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 12/16/2023 3:52:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[maNguoiDung] [char](7) NOT NULL,
	[maPhanQuyen] [char](4) NOT NULL,
	[tenDangNhap] [varchar](255) NOT NULL,
	[matKhau] [varchar](255) NOT NULL,
	[hoTen] [nvarchar](255) NOT NULL,
	[gioiTinh] [nvarchar](3) NULL,
	[ngaySinh] [date] NULL,
	[soDienThoai] [varchar](15) NULL,
	[email] [varchar](255) NULL,
	[diaChi] [nvarchar](255) NULL,
	[trangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NguoiDung_1] PRIMARY KEY CLUSTERED 
(
	[maNguoiDung] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhaCungCap]    Script Date: 12/16/2023 3:52:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhaCungCap](
	[maNhaCungCap] [char](7) NOT NULL,
	[tenNhaCungCap] [nvarchar](255) NOT NULL,
	[soDienThoai] [varchar](15) NULL,
	[email] [varchar](255) NULL,
	[diaChi] [nvarchar](255) NULL,
	[trangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_NhaCungCap] PRIMARY KEY CLUSTERED 
(
	[maNhaCungCap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhanQuyen]    Script Date: 12/16/2023 3:52:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanQuyen](
	[maPhanQuyen] [char](4) NOT NULL,
	[tenPhanQuyen] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_PhanQuyen] PRIMARY KEY CLUSTERED 
(
	[maPhanQuyen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 12/16/2023 3:52:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[maPhieuNhap] [char](15) NOT NULL,
	[maNhaCungCap] [char](7) NOT NULL,
	[maNguoiTao] [char](7) NOT NULL,
	[maNguoiDuyet] [char](7) NOT NULL,
	[maNguoiNhap] [char](7) NOT NULL,
	[thoiGianTao] [datetime2](0) NOT NULL,
	[thoiGianDuyet] [datetime2](0) NOT NULL,
	[thoiGianNhap] [datetime2](0) NOT NULL,
	[thanhTien] [money] NOT NULL,
	[trangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[maPhieuNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/16/2023 3:52:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[maSanPham] [char](7) NOT NULL,
	[maLoaiSanPham] [char](7) NOT NULL,
	[tenSanPham] [nvarchar](255) NOT NULL,
	[donViTinh] [nvarchar](50) NOT NULL,
	[giaBan] [money] NOT NULL,
	[soLuong] [int] NOT NULL,
	[anh] [image] NOT NULL,
	[trangThai] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[maSanPham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_HoaDon] FOREIGN KEY([maHoaDon])
REFERENCES [dbo].[HoaDon] ([maHoaDon])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietHoaDon_SanPham] FOREIGN KEY([maSanPham])
REFERENCES [dbo].[SanPham] ([maSanPham])
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [FK_ChiTietHoaDon_SanPham]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap] FOREIGN KEY([maPhieuNhap])
REFERENCES [dbo].[PhieuNhap] ([maPhieuNhap])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_PhieuNhap]
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietPhieuNhap_SanPham] FOREIGN KEY([maSanPham])
REFERENCES [dbo].[SanPham] ([maSanPham])
GO
ALTER TABLE [dbo].[ChiTietPhieuNhap] CHECK CONSTRAINT [FK_ChiTietPhieuNhap_SanPham]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang] FOREIGN KEY([maKhachHang])
REFERENCES [dbo].[KhachHang] ([maKhachHang])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhuyenMai] FOREIGN KEY([maKhuyenMai])
REFERENCES [dbo].[KhuyenMai] ([maKhuyenMai])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhuyenMai]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NguoiTao] FOREIGN KEY([maNguoiTao])
REFERENCES [dbo].[NguoiDung] ([maNguoiDung])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NguoiTao]
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD  CONSTRAINT [FK_NguoiDung_PhanQuyen] FOREIGN KEY([maPhanQuyen])
REFERENCES [dbo].[PhanQuyen] ([maPhanQuyen])
GO
ALTER TABLE [dbo].[NguoiDung] CHECK CONSTRAINT [FK_NguoiDung_PhanQuyen]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NguoiDuyet] FOREIGN KEY([maNguoiDuyet])
REFERENCES [dbo].[NguoiDung] ([maNguoiDung])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NguoiDuyet]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NguoiNhap] FOREIGN KEY([maNguoiNhap])
REFERENCES [dbo].[NguoiDung] ([maNguoiDung])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NguoiNhap]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NguoiTao] FOREIGN KEY([maNguoiTao])
REFERENCES [dbo].[NguoiDung] ([maNguoiDung])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NguoiTao]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [FK_PhieuNhap_NhaCungCap] FOREIGN KEY([maNhaCungCap])
REFERENCES [dbo].[NhaCungCap] ([maNhaCungCap])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [FK_PhieuNhap_NhaCungCap]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham] FOREIGN KEY([maLoaiSanPham])
REFERENCES [dbo].[LoaiSanPham] ([maLoaiSanPham])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham]
GO
USE [master]
GO
ALTER DATABASE [cs-assignment] SET  READ_WRITE 
GO
