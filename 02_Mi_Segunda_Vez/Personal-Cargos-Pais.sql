USE [Prueba3]
GO
/****** Object:  Table [dbo].[Cargos]    Script Date: 06/12/2024 18:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cargos](
	[idCargo] [int] NOT NULL,
	[Detalle] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Paises]    Script Date: 06/12/2024 18:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Paises](
	[idPais] [int] NULL,
	[Detalle] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personales]    Script Date: 06/12/2024 18:05:01 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personales](
	[idPersonal] [int] NOT NULL,
	[Nombres] [nvarchar](255) NULL,
	[idCargo] [int] NULL,
	[Sueldo] [decimal](18, 2) NULL,
	[idPais] [int] NULL
) ON [PRIMARY]
GO
