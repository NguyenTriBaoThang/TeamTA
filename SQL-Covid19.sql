USE [master]
GO
/****** Object:  Database [Covid19]    Script Date: 10/11/2023 1:32:56 PM ******/
CREATE DATABASE [Covid19]
GO
ALTER DATABASE [Covid19] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Covid19].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Covid19] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Covid19] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Covid19] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Covid19] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Covid19] SET ARITHABORT OFF 
GO
ALTER DATABASE [Covid19] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Covid19] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Covid19] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Covid19] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Covid19] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Covid19] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Covid19] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Covid19] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Covid19] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Covid19] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Covid19] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Covid19] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Covid19] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Covid19] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Covid19] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Covid19] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Covid19] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Covid19] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Covid19] SET  MULTI_USER 
GO
ALTER DATABASE [Covid19] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Covid19] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Covid19] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Covid19] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Covid19] SET DELAYED_DURABILITY = DISABLED 
GO
USE [Covid19]
GO
/****** Object:  Table [dbo].[BenhNhan]    Script Date: 10/11/2023 1:32:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BenhNhan](
	[MaBN] [nvarchar](6) NOT NULL,
	[TenBN] [nvarchar](150) NOT NULL,
	[MaTT] [int] NOT NULL,
	[GhiChu] [nvarchar](max) NULL,
	[BNTXG] [nvarchar](6) NULL,
 CONSTRAINT [PK_BenhNhan] PRIMARY KEY CLUSTERED 
(
	[MaBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TinhTrang]    Script Date: 10/11/2023 1:32:56 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhTrang](
	[MaTT] [int] NOT NULL,
	[TenTT] [nvarchar](150) NOT NULL,
 CONSTRAINT [PK_TrangThai] PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [MaTT], [GhiChu], [BNTXG]) VALUES (N'BN1342', N'Nguyễn Văn A', 2, N'Sau khi trở về từ khu cách ly tập trung để cách ly tại nhà, bệnh
nhân 1342 - nam tiếp viên Vietnam Airlines đã không tuân thủ quy định, dẫn đến việc lây
nhiễm cho người khác và khiến cho nhiều người phải cách ly, nhiều cơ sở kinh doanh và
trường học phải tạm đóng cửa.', NULL)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [MaTT], [GhiChu], [BNTXG]) VALUES (N'BN1347', N'Nguyễn Văn B', 2, N'-Nhập cảnh trên chuyến bay VN5301 từ Nhật – Cần Thơ – Sài Gòn
-Cách ly tại khu cách ly của hãng hàng không Vietnam Airlines. Thành viên tổ bay được
lấy mẫu xét nghiệm SARS-COV-2 lần 1 ngày 15/11/2020, lần 2 ngày 18/11/2020 và có kết
quả xét nghiệm âm tính.', N'BN1342')
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [MaTT], [GhiChu], [BNTXG]) VALUES (N'BN1515', N'Nguyễn Văn C', 2, N'-Từ Qatar nhập cảnh Sân bay Tân Sơn Nhất trên chuyến bay QR970
ngày 9/1/2021
- Cách ly ngay sau khi nhập cảnh tại TP. Hồ Chí Minh', NULL)
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [MaTT], [GhiChu], [BNTXG]) VALUES (N'BN2222', N'Nguyễn Văn D', 3, N'- Tiếp xúc gần với bệnh nhân 1347', N'BN1347')
INSERT [dbo].[BenhNhan] ([MaBN], [TenBN], [MaTT], [GhiChu], [BNTXG]) VALUES (N'BN3132', N'Nguyễn Văn E', 3, N'- Tiếp xúc gần với bệnh nhân 2222', N'BN2222')
INSERT [dbo].[TinhTrang] ([MaTT], [TenTT]) VALUES (1, N'Âm Tính')
INSERT [dbo].[TinhTrang] ([MaTT], [TenTT]) VALUES (2, N'Dương Tính')
INSERT [dbo].[TinhTrang] ([MaTT], [TenTT]) VALUES (3, N'Tái Nhiễm')
ALTER TABLE [dbo].[BenhNhan]  WITH CHECK ADD  CONSTRAINT [FK_BenhNhan_TinhTrang] FOREIGN KEY([MaTT])
REFERENCES [dbo].[TinhTrang] ([MaTT])
GO
ALTER TABLE [dbo].[BenhNhan] CHECK CONSTRAINT [FK_BenhNhan_TinhTrang]
GO
USE [master]
GO
ALTER DATABASE [Covid19] SET  READ_WRITE 
GO
