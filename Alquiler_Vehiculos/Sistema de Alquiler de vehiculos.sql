USE [master]
GO
/****** Object:  Database [Sistema_Vehiculos]    Script Date: 10/01/2025 18:22:20 ******/
CREATE DATABASE [Sistema_Vehiculos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sistema_Vehiculos', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Sistema_Vehiculos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Sistema_Vehiculos_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Sistema_Vehiculos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Sistema_Vehiculos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sistema_Vehiculos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sistema_Vehiculos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sistema_Vehiculos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sistema_Vehiculos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Sistema_Vehiculos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sistema_Vehiculos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Sistema_Vehiculos] SET  MULTI_USER 
GO
ALTER DATABASE [Sistema_Vehiculos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sistema_Vehiculos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sistema_Vehiculos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sistema_Vehiculos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Sistema_Vehiculos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Sistema_Vehiculos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Sistema_Vehiculos] SET QUERY_STORE = OFF
GO
USE [Sistema_Vehiculos]
GO
/****** Object:  Table [dbo].[Alquileres]    Script Date: 10/01/2025 18:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Alquileres](
	[Id_Alquiler] [int] IDENTITY(1,1) NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Id_Vehiculo] [int] NOT NULL,
	[FechaInicio] [datetime] NULL,
	[FechaFin] [datetime] NULL,
	[CostoTotal] [decimal](10, 2) NULL,
 CONSTRAINT [PK__Alquiler__0D21BB402709EB99] PRIMARY KEY CLUSTERED 
(
	[Id_Alquiler] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/01/2025 18:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](30) NULL,
	[Apellido] [nvarchar](30) NULL,
	[Cedula] [nvarchar](30) NULL,
	[Telefono] [nvarchar](30) NULL,
	[Email] [nvarchar](30) NULL,
	[Direccion] [nvarchar](30) NULL,
 CONSTRAINT [PK__Clientes__E005FBFFCCCDCBE3] PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 10/01/2025 18:22:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[Id_Vehiculo] [int] IDENTITY(1,1) NOT NULL,
	[Marca] [nvarchar](30) NULL,
	[Modelo] [nvarchar](30) NULL,
	[Anio] [int] NULL,
	[Precio_Dia] [decimal](10, 2) NULL,
	[Estado] [nvarchar](30) NULL,
 CONSTRAINT [PK__Vehiculo__FEFD7E3358AEF921] PRIMARY KEY CLUSTERED 
(
	[Id_Vehiculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Clientes] ON 
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Cedula], [Telefono], [Email], [Direccion]) VALUES (3, N'Ana', N'Martínez', N'5544332211', N'0954321876', N'ana.martinez@example.com', N'Urbanización Los Rosales 10')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Cedula], [Telefono], [Email], [Direccion]) VALUES (4, N'Olvia', N'Alcivar', N'kñlkñl', N'lñklñkñl', N'lñklñk', N'ñlklñ')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Cedula], [Telefono], [Email], [Direccion]) VALUES (5, N'Juan', N'Cevallos', N'0802908913', N'0968903989', N'charlie2525@outlook.es', N'Florida Norte')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Cedula], [Telefono], [Email], [Direccion]) VALUES (6, N'Carlos', N'Rea', N'fsfsdf', N'fsdfsfsdf', N'bcvbcvbcv', N'ngvnvnv')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Cedula], [Telefono], [Email], [Direccion]) VALUES (7, N'estrella', N'negra', N'6566565454', N'5456456456', N'fxfgssffsfs', N'fsrfsfsfsdf')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Cedula], [Telefono], [Email], [Direccion]) VALUES (10, N'Juan Carlos', N'Cevallos Rea', N'0802908913', N'0968903989', N'charlie2525outlook.es', N'Florida Norte')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Cedula], [Telefono], [Email], [Direccion]) VALUES (18, N'Juan', N'Cevallos', N'54545645', N'12315645', N'charlie2525', N'fsgfsdgdfhdf')
GO
INSERT [dbo].[Clientes] ([Id_Cliente], [Nombre], [Apellido], [Cedula], [Telefono], [Email], [Direccion]) VALUES (19, N'Angel', N'Rodriguez', N'46546545', N'564546545', N'angelrodriguez@hotmail.com', N'Guasmo Sur')
GO
SET IDENTITY_INSERT [dbo].[Clientes] OFF
GO
SET IDENTITY_INSERT [dbo].[Vehiculos] ON 
GO
INSERT [dbo].[Vehiculos] ([Id_Vehiculo], [Marca], [Modelo], [Anio], [Precio_Dia], [Estado]) VALUES (3, N'Ford', N'Focus', 2019, CAST(18000.00 AS Decimal(10, 2)), N'Alquilado')
GO
INSERT [dbo].[Vehiculos] ([Id_Vehiculo], [Marca], [Modelo], [Anio], [Precio_Dia], [Estado]) VALUES (4, N'Chevrolet', N'Spark', 2020, CAST(15000.00 AS Decimal(10, 2)), N'Disponible')
GO
INSERT [dbo].[Vehiculos] ([Id_Vehiculo], [Marca], [Modelo], [Anio], [Precio_Dia], [Estado]) VALUES (6, N'BMW', N'X5', 2023, CAST(45000.00 AS Decimal(10, 2)), N'Disponible')
GO
INSERT [dbo].[Vehiculos] ([Id_Vehiculo], [Marca], [Modelo], [Anio], [Precio_Dia], [Estado]) VALUES (7, N'Audi', N'A4', 2021, CAST(35000.00 AS Decimal(10, 2)), N'Alquilado')
GO
INSERT [dbo].[Vehiculos] ([Id_Vehiculo], [Marca], [Modelo], [Anio], [Precio_Dia], [Estado]) VALUES (8, N'Mercedes', N'Benz C-Class', 2022, CAST(50000.00 AS Decimal(10, 2)), N'Disponible')
GO
INSERT [dbo].[Vehiculos] ([Id_Vehiculo], [Marca], [Modelo], [Anio], [Precio_Dia], [Estado]) VALUES (9, N'Hyundai', N'Elantra', 2021, CAST(20000.00 AS Decimal(10, 2)), N'Disponible')
GO
INSERT [dbo].[Vehiculos] ([Id_Vehiculo], [Marca], [Modelo], [Anio], [Precio_Dia], [Estado]) VALUES (10, N'Mazda', N'CX-5', 2020, CAST(30000.00 AS Decimal(10, 2)), N'Alquilado')
GO
INSERT [dbo].[Vehiculos] ([Id_Vehiculo], [Marca], [Modelo], [Anio], [Precio_Dia], [Estado]) VALUES (26, N'Mazda', N'3', 2006, CAST(20.00 AS Decimal(10, 2)), N'alquilado')
GO
SET IDENTITY_INSERT [dbo].[Vehiculos] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Clientes__A9D10534B0CA9803]    Script Date: 10/01/2025 18:22:20 ******/
ALTER TABLE [dbo].[Clientes] ADD  CONSTRAINT [UQ__Clientes__A9D10534B0CA9803] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Alquileres]  WITH CHECK ADD  CONSTRAINT [FK__Alquilere__ID_Cl__2A4B4B5E] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Clientes] ([Id_Cliente])
GO
ALTER TABLE [dbo].[Alquileres] CHECK CONSTRAINT [FK__Alquilere__ID_Cl__2A4B4B5E]
GO
ALTER TABLE [dbo].[Alquileres]  WITH CHECK ADD  CONSTRAINT [FK__Alquilere__ID_Ve__2B3F6F97] FOREIGN KEY([Id_Vehiculo])
REFERENCES [dbo].[Vehiculos] ([Id_Vehiculo])
GO
ALTER TABLE [dbo].[Alquileres] CHECK CONSTRAINT [FK__Alquilere__ID_Ve__2B3F6F97]
GO
ALTER TABLE [dbo].[Vehiculos]  WITH CHECK ADD  CONSTRAINT [CK__Vehiculos__Estad__24927208] CHECK  (([Estado]='Mantenimiento' OR [Estado]='Alquilado' OR [Estado]='Disponible'))
GO
ALTER TABLE [dbo].[Vehiculos] CHECK CONSTRAINT [CK__Vehiculos__Estad__24927208]
GO
USE [master]
GO
ALTER DATABASE [Sistema_Vehiculos] SET  READ_WRITE 
GO
