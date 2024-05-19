USE [master]
GO
/****** Object:  Database [QuanLyPhongTro]    Script Date: 5/19/2024 10:37:19 PM ******/
CREATE DATABASE [QuanLyPhongTro]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyPhongTro', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyPhongTro.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QuanLyPhongTro_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\QuanLyPhongTro_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [QuanLyPhongTro] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyPhongTro].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyPhongTro] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyPhongTro] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyPhongTro] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyPhongTro] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyPhongTro] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyPhongTro] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyPhongTro] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyPhongTro] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyPhongTro] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyPhongTro] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [QuanLyPhongTro] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [QuanLyPhongTro] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [QuanLyPhongTro] SET QUERY_STORE = ON
GO
ALTER DATABASE [QuanLyPhongTro] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [QuanLyPhongTro]
GO
/****** Object:  Table [dbo].[tbl_HoaDon]    Script Date: 5/19/2024 10:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_HoaDon](
	[MaHD] [nchar](10) NOT NULL,
	[TienDien] [float] NULL,
	[TienNuoc] [float] NULL,
	[TongTien] [float] NULL,
	[MaKH] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tbl_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_KhachHang]    Script Date: 5/19/2024 10:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_KhachHang](
	[MaKH] [nchar](10) NOT NULL,
	[HoTenKH] [nvarchar](50) NULL,
	[GioiTinhKH] [nvarchar](10) NULL,
	[NgaySinh] [date] NULL,
	[QueQuan] [nvarchar](50) NULL,
	[SDT] [nchar](10) NULL,
	[SoThangThue] [int] NULL,
	[MaP] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tbl_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Phong]    Script Date: 5/19/2024 10:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Phong](
	[MaP] [nchar](10) NOT NULL,
	[GiaPhong] [float] NULL,
	[TrangThai] [nvarchar](20) NULL,
 CONSTRAINT [PK_tbl_Phong] PRIMARY KEY CLUSTERED 
(
	[MaP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_User]    Script Date: 5/19/2024 10:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[HoTen] [nvarchar](50) NOT NULL,
	[Phai] [bit] NOT NULL,
	[DienThoai] [varchar](20) NULL,
	[TaiKhoan] [varchar](50) NULL,
	[MatKhau] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[tbl_User] ADD  DEFAULT ((0)) FOR [Phai]
GO
ALTER TABLE [dbo].[tbl_HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_tbl_HoaDon_tbl_KhachHang] FOREIGN KEY([MaKH])
REFERENCES [dbo].[tbl_KhachHang] ([MaKH])
GO
ALTER TABLE [dbo].[tbl_HoaDon] CHECK CONSTRAINT [FK_tbl_HoaDon_tbl_KhachHang]
GO
ALTER TABLE [dbo].[tbl_KhachHang]  WITH CHECK ADD  CONSTRAINT [FK_tbl_KhachHang_tbl_Phong] FOREIGN KEY([MaP])
REFERENCES [dbo].[tbl_Phong] ([MaP])
GO
ALTER TABLE [dbo].[tbl_KhachHang] CHECK CONSTRAINT [FK_tbl_KhachHang_tbl_Phong]
GO
/****** Object:  StoredProcedure [dbo].[PSP_Customer_CheckCustomerinRoom]    Script Date: 5/19/2024 10:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PSP_Customer_CheckCustomerinRoom]
    @MaP nchar(10)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM tbl_KhachHang
    WHERE MaP = @MaP;
END;
GO
/****** Object:  StoredProcedure [dbo].[PSP_Customer_Delete]    Script Date: 5/19/2024 10:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[PSP_Customer_Delete]
    @MaKH nchar(10)
as
delete tbl_KhachHang
where MaKH=@MaKH
GO
/****** Object:  StoredProcedure [dbo].[PSP_Customer_InsertAndUpdate]    Script Date: 5/19/2024 10:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PSP_Customer_InsertAndUpdate]
	@MaKH nchar(10), 
	@HoTenKH nvarchar(50), 
	@GioiTinhKH nvarchar(10), 
	@NgaySinh date, 
	@QueQuan nvarchar(50), 
	@SDT nchar(10),
	@SoThangThue int,
	@MaP nchar(10)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM tbl_KhachHang WHERE MaKH = @MaKH)
	BEGIN
		-- Nếu @MaKH không phải NULL, thực hiện câu lệnh UPDATE
		UPDATE tbl_KhachHang
		SET HoTenKH = @HoTenKH,
			GioiTinhKH = @GioiTinhKH,
			NgaySinh = @NgaySinh,
			QueQuan = @QueQuan,
			SDT = @SDT,
			SoThangThue = @SoThangThue,
			MaP = @MaP
		WHERE MaKH = @MaKH;
		SELECT @@ROWCOUNT AS TotalRowChanged;
	END
	ELSE
	BEGIN
		-- Nếu @MaKH là NULL, thực hiện câu lệnh INSERT
		INSERT INTO tbl_KhachHang 
		( MaKH,HoTenKH, GioiTinhKH, NgaySinh, QueQuan, SDT, SoThangThue, MaP)
		VALUES (@MaKH,@HoTenKH, @GioiTinhKH, @NgaySinh, @QueQuan, @SDT, @SoThangThue, @MaP);
		SELECT @@ROWCOUNT AS TotalRowChanged;
	END
END


GO
/****** Object:  StoredProcedure [dbo].[PSP_Customer_Select]    Script Date: 5/19/2024 10:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PSP_Customer_Select]
AS
BEGIN
    SELECT MaKH, HoTenKH, GioiTinhKH, NgaySinh, QueQuan,SDT,SoThangThue,MaP
    FROM tbl_KhachHang;
END
GO
/****** Object:  StoredProcedure [dbo].[PSP_KiemTraDangNhap]    Script Date: 5/19/2024 10:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[PSP_KiemTraDangNhap]
@TaiKhoan varchar(50),
@MatKhau varchar(50)
as
if exists (select 1 from tbl_User where TaiKhoan=@TaiKhoan and PWDCOMPARE(@MatKhau,MatKhau)=1)
begin 
	select 1 as Code, ID, TaiKhoan, MatKhau
	from tbl_User
	where TaiKhoan=@TaiKhoan and PWDCOMPARE(@MatKhau,MatKhau)=1
end
else
begin 
	select 0 as Code,'' as ID,N'' as HoTen
End
GO
/****** Object:  StoredProcedure [dbo].[PSP_Room_CheckStatus]    Script Date: 5/19/2024 10:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[PSP_Room_CheckStatus]
    @MaP nchar(10)
AS
BEGIN
    SELECT TrangThai
    FROM tbl_Phong
    WHERE MaP = @MaP
END
GO
/****** Object:  StoredProcedure [dbo].[PSP_Room_Delete]    Script Date: 5/19/2024 10:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[PSP_Room_Delete]
    @MaP nchar(10)
as
delete tbl_Phong
where MaP=@MaP
GO
/****** Object:  StoredProcedure [dbo].[PSP_Room_InsertOrUpdate]    Script Date: 5/19/2024 10:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PSP_Room_InsertOrUpdate]
    @MaP nchar(10),
    @GiaPhong float,
    @TrangThai nvarchar(20)
AS
BEGIN
    SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM [dbo].[tbl_Phong] WHERE [MaP] = @MaP)
    BEGIN
        -- Update existing room
        UPDATE [dbo].[tbl_Phong]
        SET [GiaPhong] = @GiaPhong,
            [TrangThai] = @TrangThai
        WHERE [MaP] = @MaP;
		SELECT @@ROWCOUNT AS TotalRowChanged;
    END
    ELSE
    BEGIN
        -- Insert new room
        INSERT INTO [dbo].[tbl_Phong] ([MaP], [GiaPhong], [TrangThai])
        VALUES (@MaP, @GiaPhong, @TrangThai);
		SELECT @@ROWCOUNT as TotalRowChanged;
    END
END;
GO
/****** Object:  StoredProcedure [dbo].[PSP_Room_Select]    Script Date: 5/19/2024 10:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PSP_Room_Select]
AS
BEGIN
    SET NOCOUNT ON;
    SELECT [MaP], [GiaPhong], [TrangThai]
    FROM [dbo].[tbl_Phong];
END;
GO
/****** Object:  StoredProcedure [dbo].[PSP_User_Delete]    Script Date: 5/19/2024 10:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[PSP_User_Delete]
@ID int
as
delete tbl_User
where ID=@ID
GO
/****** Object:  StoredProcedure [dbo].[PSP_User_InsertAndUpdate]    Script Date: 5/19/2024 10:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PSP_User_InsertAndUpdate]
@ID int, @HoTen nvarchar(50), @Phai bit, @DienThoai varchar(20), @TaiKhoan varchar(50), @MatKhau varbinary(MAX)
as
if exists (select 1 from tbl_User where ID=@ID)
begin
	update tbl_User
	set HoTen=@HoTen,
		Phai=@Phai,
		DienThoai=@DienThoai,
		TaiKhoan=@TaiKhoan,
		MatKhau=@MatKhau
	where ID=@ID
end
else
begin
	insert into tbl_User( HoTen, Phai, DienThoai, TaiKhoan, MatKhau)
	values( @HoTen, @Phai, @DienThoai, @TaiKhoan, @MatKhau)
end
GO
/****** Object:  StoredProcedure [dbo].[PSP_User_Select]    Script Date: 5/19/2024 10:37:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[PSP_User_Select]
@ID int=0
as
select ID, HoTen, Phai, DienThoai, TaiKhoan, MatKhau
from tbl_User
where @ID=Case @ID when 0 then @ID else ID end
GO
USE [master]
GO
ALTER DATABASE [QuanLyPhongTro] SET  READ_WRITE 
GO
