USE [master]
GO
/****** Object:  Database [wpfDb]    Script Date: 23.05.2023 13:02:54 ******/
CREATE DATABASE [wpfDb]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'wpfDb', FILENAME = N'C:\Users\lukas\wpfDb.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'wpfDb_log', FILENAME = N'C:\Users\lukas\wpfDb_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [wpfDb] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [wpfDb].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [wpfDb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [wpfDb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [wpfDb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [wpfDb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [wpfDb] SET ARITHABORT OFF 
GO
ALTER DATABASE [wpfDb] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [wpfDb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [wpfDb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [wpfDb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [wpfDb] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [wpfDb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [wpfDb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [wpfDb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [wpfDb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [wpfDb] SET  ENABLE_BROKER 
GO
ALTER DATABASE [wpfDb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [wpfDb] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [wpfDb] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [wpfDb] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [wpfDb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [wpfDb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [wpfDb] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [wpfDb] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [wpfDb] SET  MULTI_USER 
GO
ALTER DATABASE [wpfDb] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [wpfDb] SET DB_CHAINING OFF 
GO
ALTER DATABASE [wpfDb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [wpfDb] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [wpfDb] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [wpfDb] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [wpfDb] SET QUERY_STORE = OFF
GO
USE [wpfDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 23.05.2023 13:02:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 23.05.2023 13:02:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Telephone] [nvarchar](max) NOT NULL,
	[FullName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Repairs]    Script Date: 23.05.2023 13:02:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Repairs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NOT NULL,
	[isDone] [bit] NOT NULL,
	[Price] [int] NOT NULL,
	[VehicleId] [int] NOT NULL,
	[EmployeeId] [int] NOT NULL,
 CONSTRAINT [PK_Repairs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 23.05.2023 13:02:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[isAdmin] [bit] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehicles]    Script Date: 23.05.2023 13:02:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehicles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Brand] [nvarchar](max) NOT NULL,
	[Model] [nvarchar](max) NOT NULL,
	[Plate] [nvarchar](max) NOT NULL,
	[OwnerFirstName] [nvarchar](max) NOT NULL,
	[OwnerLastName] [nvarchar](max) NOT NULL,
	[OwnerTelephone] [nvarchar](max) NOT NULL,
	[Milage] [bigint] NOT NULL,
 CONSTRAINT [PK_Vehicles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230413080236_init', N'6.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230413083215_entities', N'6.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230413085540_admindata', N'6.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230514124340_ullnames', N'6.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230514145803_cokolwiek', N'6.0.10')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20230523102140_abc', N'6.0.10')
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([Id], [FirstName], [LastName], [Telephone], [FullName]) VALUES (1, N'Piotr', N'Pan', N'123444444', N'Piotr Pan')
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
SET IDENTITY_INSERT [dbo].[Repairs] ON 

INSERT [dbo].[Repairs] ([Id], [Description], [isDone], [Price], [VehicleId], [EmployeeId]) VALUES (1, N'Wymiana Plynu', 1, 1234, 1, 1)
INSERT [dbo].[Repairs] ([Id], [Description], [isDone], [Price], [VehicleId], [EmployeeId]) VALUES (2, N'Wymiana dyfra', 0, 111, 1, 1)
SET IDENTITY_INSERT [dbo].[Repairs] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([Id], [Username], [Password], [isAdmin]) VALUES (1, N'admin', N'$2b$10$wVrsieHSGP.runkqA4Zs2esGIDkRY5nY3tv5oSSv1KV88OQID8Fy2', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
SET IDENTITY_INSERT [dbo].[Vehicles] ON 

INSERT [dbo].[Vehicles] ([Id], [Brand], [Model], [Plate], [OwnerFirstName], [OwnerLastName], [OwnerTelephone], [Milage]) VALUES (1, N'BMW', N'E60', N'KR12345', N'Jan', N'Testowy', N'111222333', 198000)
SET IDENTITY_INSERT [dbo].[Vehicles] OFF
GO
/****** Object:  Index [IX_Repairs_EmployeeId]    Script Date: 23.05.2023 13:02:54 ******/
CREATE NONCLUSTERED INDEX [IX_Repairs_EmployeeId] ON [dbo].[Repairs]
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Repairs_VehicleId]    Script Date: 23.05.2023 13:02:54 ******/
CREATE NONCLUSTERED INDEX [IX_Repairs_VehicleId] ON [dbo].[Repairs]
(
	[VehicleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employees] ADD  DEFAULT (N'') FOR [FullName]
GO
ALTER TABLE [dbo].[Repairs]  WITH CHECK ADD  CONSTRAINT [FK_Repairs_Employees_EmployeeId] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([Id])
GO
ALTER TABLE [dbo].[Repairs] CHECK CONSTRAINT [FK_Repairs_Employees_EmployeeId]
GO
ALTER TABLE [dbo].[Repairs]  WITH CHECK ADD  CONSTRAINT [FK_Repairs_Vehicles_VehicleId] FOREIGN KEY([VehicleId])
REFERENCES [dbo].[Vehicles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Repairs] CHECK CONSTRAINT [FK_Repairs_Vehicles_VehicleId]
GO
USE [master]
GO
ALTER DATABASE [wpfDb] SET  READ_WRITE 
GO
