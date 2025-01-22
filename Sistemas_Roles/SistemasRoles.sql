USE [master]
GO
/****** Object:  Database [Sistemasroles]    Script Date: 21/01/2025 22:25:53 ******/
CREATE DATABASE [Sistemasroles]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sistemasroles', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Sistemasroles.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Sistemasroles_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Sistemasroles_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Sistemasroles] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sistemasroles].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sistemasroles] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sistemasroles] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sistemasroles] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sistemasroles] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sistemasroles] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sistemasroles] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Sistemasroles] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sistemasroles] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sistemasroles] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sistemasroles] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sistemasroles] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sistemasroles] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sistemasroles] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sistemasroles] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sistemasroles] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Sistemasroles] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sistemasroles] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sistemasroles] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sistemasroles] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sistemasroles] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sistemasroles] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sistemasroles] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sistemasroles] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Sistemasroles] SET  MULTI_USER 
GO
ALTER DATABASE [Sistemasroles] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sistemasroles] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sistemasroles] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sistemasroles] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Sistemasroles] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Sistemasroles] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Sistemasroles] SET QUERY_STORE = OFF
GO
USE [Sistemasroles]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 21/01/2025 22:25:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Rol_Id] [int] IDENTITY(1,1) NOT NULL,
	[Detalle] [nvarchar](50) NULL,
 CONSTRAINT [PK_Roles] PRIMARY KEY CLUSTERED 
(
	[Rol_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 21/01/2025 22:25:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id_User] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](50) NULL,
	[Password] [nvarchar](50) NULL,
	[Disponibilidad] [char](1) NULL,
	[createAt] [datetime] NULL,
	[updateAt] [datetime] NULL,
	[Roles_id] [int] NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id_User] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 
GO
INSERT [dbo].[Roles] ([Rol_Id], [Detalle]) VALUES (1, N'Cocinero/a')
GO
INSERT [dbo].[Roles] ([Rol_Id], [Detalle]) VALUES (2, N'Médico')
GO
INSERT [dbo].[Roles] ([Rol_Id], [Detalle]) VALUES (3, N'Enfermera/o')
GO
INSERT [dbo].[Roles] ([Rol_Id], [Detalle]) VALUES (4, N'Secretaria/o')
GO
INSERT [dbo].[Roles] ([Rol_Id], [Detalle]) VALUES (9, N'Guardia')
GO
INSERT [dbo].[Roles] ([Rol_Id], [Detalle]) VALUES (10, N'Conserje')
GO
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 
GO
INSERT [dbo].[Usuarios] ([Id_User], [Username], [Password], [Disponibilidad], [createAt], [updateAt], [Roles_id]) VALUES (5, N'Carlos', N'1234', N'N', CAST(N'2025-01-21T20:17:36.620' AS DateTime), CAST(N'2025-01-21T21:04:20.540' AS DateTime), 1)
GO
INSERT [dbo].[Usuarios] ([Id_User], [Username], [Password], [Disponibilidad], [createAt], [updateAt], [Roles_id]) VALUES (6, N'Juan', N'123456', N'Y', CAST(N'2025-01-21T20:39:53.307' AS DateTime), CAST(N'2025-01-21T20:39:53.307' AS DateTime), 2)
GO
INSERT [dbo].[Usuarios] ([Id_User], [Username], [Password], [Disponibilidad], [createAt], [updateAt], [Roles_id]) VALUES (7, N'Estrella', N'789', N'N', CAST(N'2025-01-21T20:42:29.207' AS DateTime), CAST(N'2025-01-21T20:42:29.207' AS DateTime), 3)
GO
INSERT [dbo].[Usuarios] ([Id_User], [Username], [Password], [Disponibilidad], [createAt], [updateAt], [Roles_id]) VALUES (8, N'Xavier', N'123', N'Y', CAST(N'2025-01-21T22:01:09.297' AS DateTime), CAST(N'2025-01-21T22:01:09.297' AS DateTime), 9)
GO
INSERT [dbo].[Usuarios] ([Id_User], [Username], [Password], [Disponibilidad], [createAt], [updateAt], [Roles_id]) VALUES (9, N'Ximena', N'1234', N'N', CAST(N'2025-01-21T22:02:02.190' AS DateTime), CAST(N'2025-01-21T22:02:12.927' AS DateTime), 10)
GO
INSERT [dbo].[Usuarios] ([Id_User], [Username], [Password], [Disponibilidad], [createAt], [updateAt], [Roles_id]) VALUES (10, N'Julian', N'123', N'N', CAST(N'2025-01-21T22:18:49.693' AS DateTime), CAST(N'2025-01-21T22:18:49.693' AS DateTime), 1)
GO
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD  CONSTRAINT [FK_Usuarios_Roles] FOREIGN KEY([Roles_id])
REFERENCES [dbo].[Roles] ([Rol_Id])
GO
ALTER TABLE [dbo].[Usuarios] CHECK CONSTRAINT [FK_Usuarios_Roles]
GO
USE [master]
GO
ALTER DATABASE [Sistemasroles] SET  READ_WRITE 
GO
