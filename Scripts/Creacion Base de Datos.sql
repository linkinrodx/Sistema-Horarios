USE [master]
GO
/****** Object:  Database [Horarios]    Script Date: 12/15/2014 01:59:50 ******/
CREATE DATABASE [Horarios] ON  PRIMARY 
( NAME = N'horarios', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Horarios.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'horarios_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Horarios_1.ldf' , SIZE = 2560KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
EXEC dbo.sp_dbcmptlevel @dbname=N'Horarios', @new_cmptlevel=90
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Horarios].[dbo].[sp_fulltext_database] @action = 'disable'
end
GO
ALTER DATABASE [Horarios] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Horarios] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Horarios] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Horarios] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Horarios] SET ARITHABORT OFF
GO
ALTER DATABASE [Horarios] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Horarios] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Horarios] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Horarios] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Horarios] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Horarios] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Horarios] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Horarios] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Horarios] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Horarios] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Horarios] SET  DISABLE_BROKER
GO
ALTER DATABASE [Horarios] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Horarios] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Horarios] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Horarios] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Horarios] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Horarios] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Horarios] SET  READ_WRITE
GO
ALTER DATABASE [Horarios] SET RECOVERY FULL
GO
ALTER DATABASE [Horarios] SET  MULTI_USER
GO
ALTER DATABASE [Horarios] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Horarios] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Horarios', N'ON'
GO
USE [Horarios]
GO
/****** Object:  Table [dbo].[Dia]    Script Date: 12/15/2014 01:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dia](
	[IdDia] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Dia] PRIMARY KEY CLUSTERED 
(
	[IdDia] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Curricula]    Script Date: 12/15/2014 01:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Curricula](
	[IdCurricula] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Curricula] PRIMARY KEY CLUSTERED 
(
	[IdCurricula] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ciclo]    Script Date: 12/15/2014 01:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ciclo](
	[IdCiclo] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Ciclo] PRIMARY KEY CLUSTERED 
(
	[IdCiclo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CategoriaDocente]    Script Date: 12/15/2014 01:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CategoriaDocente](
	[IdCategoria] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Categoria_docente] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Hora]    Script Date: 12/15/2014 01:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Hora](
	[IdHora] [int] IDENTITY(1,1) NOT NULL,
	[HoraInicio] [varchar](100) NOT NULL,
	[HoraFin] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Hora] PRIMARY KEY CLUSTERED 
(
	[IdHora] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoClase]    Script Date: 12/15/2014 01:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoClase](
	[IdTipoClase] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](150) NOT NULL,
 CONSTRAINT [PK_Tipo_clase] PRIMARY KEY CLUSTERED 
(
	[IdTipoClase] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoAmbiente]    Script Date: 12/15/2014 01:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoAmbiente](
	[IdTipoAmbiente] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Tipo_ambiente] PRIMARY KEY CLUSTERED 
(
	[IdTipoAmbiente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Horario]    Script Date: 12/15/2014 01:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Horario](
	[IdHorario] [int] IDENTITY(1,1) NOT NULL,
	[IdCiclo] [int] NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Horario] PRIMARY KEY CLUSTERED 
(
	[IdHorario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Docente]    Script Date: 12/15/2014 01:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Docente](
	[IdDocente] [int] IDENTITY(1,1) NOT NULL,
	[IdCategoria] [int] NOT NULL,
	[Grado] [varchar](100) NOT NULL,
	[Nombres] [varchar](100) NOT NULL,
	[Apellidos] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Docente] PRIMARY KEY CLUSTERED 
(
	[IdDocente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Asignatura]    Script Date: 12/15/2014 01:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Asignatura](
	[IdAsignatura] [int] IDENTITY(1,1) NOT NULL,
	[IdCurricula] [int] NOT NULL,
	[Descripcion] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Asignatura] PRIMARY KEY CLUSTERED 
(
	[IdAsignatura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Ambiente]    Script Date: 12/15/2014 01:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Ambiente](
	[IdAmbiente] [int] IDENTITY(1,1) NOT NULL,
	[IdTipoAmbiente] [int] NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Ambiente] PRIMARY KEY CLUSTERED 
(
	[IdAmbiente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CeldaHorario]    Script Date: 12/15/2014 01:59:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CeldaHorario](
	[IdHorario] [int] NOT NULL,
	[IdDia] [int] NOT NULL,
	[IdHora] [int] NOT NULL,
	[IdDocente] [int] NULL,
	[IdAsignatura] [int] NULL,
	[IdAmbiente] [int] NULL,
	[IdTipoClase] [int] NULL,
 CONSTRAINT [PK_CeldaHorario] PRIMARY KEY CLUSTERED 
(
	[IdHorario] ASC,
	[IdDia] ASC,
	[IdHora] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Horario_Ciclo]    Script Date: 12/15/2014 01:59:52 ******/
ALTER TABLE [dbo].[Horario]  WITH CHECK ADD  CONSTRAINT [FK_Horario_Ciclo] FOREIGN KEY([IdCiclo])
REFERENCES [dbo].[Ciclo] ([IdCiclo])
GO
ALTER TABLE [dbo].[Horario] CHECK CONSTRAINT [FK_Horario_Ciclo]
GO
/****** Object:  ForeignKey [FK_Docente_CategoriaDocente]    Script Date: 12/15/2014 01:59:52 ******/
ALTER TABLE [dbo].[Docente]  WITH CHECK ADD  CONSTRAINT [FK_Docente_CategoriaDocente] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[CategoriaDocente] ([IdCategoria])
GO
ALTER TABLE [dbo].[Docente] CHECK CONSTRAINT [FK_Docente_CategoriaDocente]
GO
/****** Object:  ForeignKey [FK_Asignatura_Curricula]    Script Date: 12/15/2014 01:59:52 ******/
ALTER TABLE [dbo].[Asignatura]  WITH CHECK ADD  CONSTRAINT [FK_Asignatura_Curricula] FOREIGN KEY([IdCurricula])
REFERENCES [dbo].[Curricula] ([IdCurricula])
GO
ALTER TABLE [dbo].[Asignatura] CHECK CONSTRAINT [FK_Asignatura_Curricula]
GO
/****** Object:  ForeignKey [FK_Ambiente_TipoAmbiente]    Script Date: 12/15/2014 01:59:52 ******/
ALTER TABLE [dbo].[Ambiente]  WITH CHECK ADD  CONSTRAINT [FK_Ambiente_TipoAmbiente] FOREIGN KEY([IdTipoAmbiente])
REFERENCES [dbo].[TipoAmbiente] ([IdTipoAmbiente])
GO
ALTER TABLE [dbo].[Ambiente] CHECK CONSTRAINT [FK_Ambiente_TipoAmbiente]
GO
/****** Object:  ForeignKey [FK_CeldaHorario_Ambiente]    Script Date: 12/15/2014 01:59:52 ******/
ALTER TABLE [dbo].[CeldaHorario]  WITH CHECK ADD  CONSTRAINT [FK_CeldaHorario_Ambiente] FOREIGN KEY([IdAmbiente])
REFERENCES [dbo].[Ambiente] ([IdAmbiente])
GO
ALTER TABLE [dbo].[CeldaHorario] CHECK CONSTRAINT [FK_CeldaHorario_Ambiente]
GO
/****** Object:  ForeignKey [FK_CeldaHorario_Asignatura]    Script Date: 12/15/2014 01:59:52 ******/
ALTER TABLE [dbo].[CeldaHorario]  WITH CHECK ADD  CONSTRAINT [FK_CeldaHorario_Asignatura] FOREIGN KEY([IdAsignatura])
REFERENCES [dbo].[Asignatura] ([IdAsignatura])
GO
ALTER TABLE [dbo].[CeldaHorario] CHECK CONSTRAINT [FK_CeldaHorario_Asignatura]
GO
/****** Object:  ForeignKey [FK_CeldaHorario_Dia]    Script Date: 12/15/2014 01:59:52 ******/
ALTER TABLE [dbo].[CeldaHorario]  WITH CHECK ADD  CONSTRAINT [FK_CeldaHorario_Dia] FOREIGN KEY([IdDia])
REFERENCES [dbo].[Dia] ([IdDia])
GO
ALTER TABLE [dbo].[CeldaHorario] CHECK CONSTRAINT [FK_CeldaHorario_Dia]
GO
/****** Object:  ForeignKey [FK_CeldaHorario_Docente]    Script Date: 12/15/2014 01:59:52 ******/
ALTER TABLE [dbo].[CeldaHorario]  WITH CHECK ADD  CONSTRAINT [FK_CeldaHorario_Docente] FOREIGN KEY([IdDocente])
REFERENCES [dbo].[Docente] ([IdDocente])
GO
ALTER TABLE [dbo].[CeldaHorario] CHECK CONSTRAINT [FK_CeldaHorario_Docente]
GO
/****** Object:  ForeignKey [FK_CeldaHorario_Hora]    Script Date: 12/15/2014 01:59:52 ******/
ALTER TABLE [dbo].[CeldaHorario]  WITH CHECK ADD  CONSTRAINT [FK_CeldaHorario_Hora] FOREIGN KEY([IdHora])
REFERENCES [dbo].[Hora] ([IdHora])
GO
ALTER TABLE [dbo].[CeldaHorario] CHECK CONSTRAINT [FK_CeldaHorario_Hora]
GO
/****** Object:  ForeignKey [FK_CeldaHorario_Horario]    Script Date: 12/15/2014 01:59:52 ******/
ALTER TABLE [dbo].[CeldaHorario]  WITH CHECK ADD  CONSTRAINT [FK_CeldaHorario_Horario] FOREIGN KEY([IdHorario])
REFERENCES [dbo].[Horario] ([IdHorario])
GO
ALTER TABLE [dbo].[CeldaHorario] CHECK CONSTRAINT [FK_CeldaHorario_Horario]
GO
/****** Object:  ForeignKey [FK_CeldaHorario_TipoClase]    Script Date: 12/15/2014 01:59:52 ******/
ALTER TABLE [dbo].[CeldaHorario]  WITH CHECK ADD  CONSTRAINT [FK_CeldaHorario_TipoClase] FOREIGN KEY([IdTipoClase])
REFERENCES [dbo].[TipoClase] ([IdTipoClase])
GO
ALTER TABLE [dbo].[CeldaHorario] CHECK CONSTRAINT [FK_CeldaHorario_TipoClase]
GO
