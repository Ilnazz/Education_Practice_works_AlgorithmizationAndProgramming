USE [master]
GO
/****** Object:  Database [ShopDB]    Script Date: 30.05.2022 16:49:40 ******/
CREATE DATABASE [ShopDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ShopDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SERV1215\MSSQL\DATA\ShopDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 10%)
 LOG ON 
( NAME = N'ShopDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SERV1215\MSSQL\DATA\ShopDB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ShopDB] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ShopDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ShopDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ShopDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ShopDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ShopDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ShopDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [ShopDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ShopDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ShopDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ShopDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ShopDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ShopDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ShopDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ShopDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ShopDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ShopDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ShopDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ShopDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ShopDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ShopDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ShopDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ShopDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ShopDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ShopDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ShopDB] SET  MULTI_USER 
GO
ALTER DATABASE [ShopDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ShopDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ShopDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ShopDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [ShopDB] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'ShopDB', N'ON'
GO
ALTER DATABASE [ShopDB] SET QUERY_STORE = OFF
GO
USE [ShopDB]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 30.05.2022 16:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID_Role] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](30) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[ID_Role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supplier]    Script Date: 30.05.2022 16:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supplier](
	[ID_Supplier] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Supplier] PRIMARY KEY CLUSTERED 
(
	[ID_Supplier] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Toy]    Script Date: 30.05.2022 16:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Toy](
	[ID_Toy] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NOT NULL,
	[Price] [decimal](8, 2) NOT NULL,
	[Manufacturer] [nvarchar](255) NOT NULL,
	[Quantity] [int] NOT NULL,
	[ID_Supplier] [int] NOT NULL,
	[Image_Path] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Toy] PRIMARY KEY CLUSTERED 
(
	[ID_Toy] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 30.05.2022 16:49:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[User_ID] [int] IDENTITY(1,1) NOT NULL,
	[Login] [nvarchar](30) NOT NULL,
	[Password] [nvarchar](30) NOT NULL,
	[ID_Role] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[User_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([ID_Role], [Name]) VALUES (1, N'Пользователь')
INSERT [dbo].[Role] ([ID_Role], [Name]) VALUES (2, N'Администратор')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Supplier] ON 

INSERT [dbo].[Supplier] ([ID_Supplier], [Name]) VALUES (1, N'Ларго')
INSERT [dbo].[Supplier] ([ID_Supplier], [Name]) VALUES (2, N'Ленто')
INSERT [dbo].[Supplier] ([ID_Supplier], [Name]) VALUES (3, N'Адажио')
INSERT [dbo].[Supplier] ([ID_Supplier], [Name]) VALUES (4, N'Граве')
INSERT [dbo].[Supplier] ([ID_Supplier], [Name]) VALUES (5, N'Анданте')
INSERT [dbo].[Supplier] ([ID_Supplier], [Name]) VALUES (6, N'Модерато')
INSERT [dbo].[Supplier] ([ID_Supplier], [Name]) VALUES (7, N'Состенуто')
INSERT [dbo].[Supplier] ([ID_Supplier], [Name]) VALUES (8, N'Аллегро')
SET IDENTITY_INSERT [dbo].[Supplier] OFF
GO
SET IDENTITY_INSERT [dbo].[Toy] ON 

INSERT [dbo].[Toy] ([ID_Toy], [Name], [Price], [Manufacturer], [Quantity], [ID_Supplier], [Image_Path]) VALUES (1, N'Медведь', CAST(1000.00 AS Decimal(8, 2)), N'Казанская фабрика игрушек', 100, 1, N'C:\Users\232021\source\repos\Shop\Shop\Images\bear.png')
INSERT [dbo].[Toy] ([ID_Toy], [Name], [Price], [Manufacturer], [Quantity], [ID_Supplier], [Image_Path]) VALUES (2, N'Заяц', CAST(1500.00 AS Decimal(8, 2)), N'Тюменская фабрика игрушек', 50, 2, N'C:\Users\232021\source\repos\Shop\Shop\Images\bunny.png')
INSERT [dbo].[Toy] ([ID_Toy], [Name], [Price], [Manufacturer], [Quantity], [ID_Supplier], [Image_Path]) VALUES (3, N'Корова', CAST(2000.00 AS Decimal(8, 2)), N'Московская фабрика игрушек', 25, 3, N'C:\Users\232021\source\repos\Shop\Shop\Images\cow.png')
INSERT [dbo].[Toy] ([ID_Toy], [Name], [Price], [Manufacturer], [Quantity], [ID_Supplier], [Image_Path]) VALUES (4, N'Собака', CAST(2500.00 AS Decimal(8, 2)), N'Санкт-Петербургская фабрика игрушек', 12, 4, N'C:\Users\232021\source\repos\Shop\Shop\Images\dog.png')
INSERT [dbo].[Toy] ([ID_Toy], [Name], [Price], [Manufacturer], [Quantity], [ID_Supplier], [Image_Path]) VALUES (5, N'Слон', CAST(3000.00 AS Decimal(8, 2)), N'Зеленодольская фабрика игрушек', 125, 5, N'C:\Users\232021\source\repos\Shop\Shop\Images\elephant.png')
INSERT [dbo].[Toy] ([ID_Toy], [Name], [Price], [Manufacturer], [Quantity], [ID_Supplier], [Image_Path]) VALUES (6, N'Жираф', CAST(3500.00 AS Decimal(8, 2)), N'Альметьевская фабрика игрушек', 150, 6, N'C:\Users\232021\source\repos\Shop\Shop\Images\giraffe.png')
INSERT [dbo].[Toy] ([ID_Toy], [Name], [Price], [Manufacturer], [Quantity], [ID_Supplier], [Image_Path]) VALUES (7, N'Лев', CAST(4000.00 AS Decimal(8, 2)), N'Рязанская фабрика игрушек', 175, 7, N'C:\Users\232021\source\repos\Shop\Shop\Images\lion.png')
INSERT [dbo].[Toy] ([ID_Toy], [Name], [Price], [Manufacturer], [Quantity], [ID_Supplier], [Image_Path]) VALUES (8, N'Овца', CAST(4500.00 AS Decimal(8, 2)), N'Тульская фабрика игрушек', 200, 8, N'C:\Users\232021\source\repos\Shop\Shop\Images\sheep.png')
SET IDENTITY_INSERT [dbo].[Toy] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([User_ID], [Login], [Password], [ID_Role]) VALUES (1, N'user', N'user', 1)
INSERT [dbo].[User] ([User_ID], [Login], [Password], [ID_Role]) VALUES (2, N'administrator', N'administrator', 2)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Toy]  WITH CHECK ADD  CONSTRAINT [FK_Toy_Supplier] FOREIGN KEY([ID_Supplier])
REFERENCES [dbo].[Supplier] ([ID_Supplier])
GO
ALTER TABLE [dbo].[Toy] CHECK CONSTRAINT [FK_Toy_Supplier]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([ID_Role])
REFERENCES [dbo].[Role] ([ID_Role])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
USE [master]
GO
ALTER DATABASE [ShopDB] SET  READ_WRITE 
GO
