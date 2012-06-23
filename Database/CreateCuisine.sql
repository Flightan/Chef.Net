USE [master]
GO
/****** Object:  Database [Cuisine]    Script Date: 06/23/2012 03:14:36 ******/
CREATE DATABASE [Cuisine] ON  PRIMARY 
( NAME = N'Cuisine', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Cuisine.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Cuisine_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Cuisine_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Cuisine] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Cuisine].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Cuisine] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Cuisine] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Cuisine] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Cuisine] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Cuisine] SET ARITHABORT OFF
GO
ALTER DATABASE [Cuisine] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Cuisine] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Cuisine] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Cuisine] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Cuisine] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Cuisine] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Cuisine] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Cuisine] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Cuisine] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Cuisine] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Cuisine] SET  DISABLE_BROKER
GO
ALTER DATABASE [Cuisine] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Cuisine] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Cuisine] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Cuisine] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Cuisine] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Cuisine] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Cuisine] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Cuisine] SET  READ_WRITE
GO
ALTER DATABASE [Cuisine] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Cuisine] SET  MULTI_USER
GO
ALTER DATABASE [Cuisine] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Cuisine] SET DB_CHAINING OFF
GO
USE [Cuisine]
GO
/****** Object:  ForeignKey [FK_T_Conseil_T_User]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_Conseil] DROP CONSTRAINT [FK_T_Conseil_T_User]
GO
/****** Object:  ForeignKey [FK_T_Recette_T_User]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_Recette] DROP CONSTRAINT [FK_T_Recette_T_User]
GO
/****** Object:  ForeignKey [FK_T_RecetteIngredient_T_Ingredient]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_RecetteIngredient] DROP CONSTRAINT [FK_T_RecetteIngredient_T_Ingredient]
GO
/****** Object:  ForeignKey [FK_T_RecetteIngredient_T_Recette]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_RecetteIngredient] DROP CONSTRAINT [FK_T_RecetteIngredient_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Note_T_Recette]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_Note] DROP CONSTRAINT [FK_T_Note_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Note_T_User]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_Note] DROP CONSTRAINT [FK_T_Note_T_User]
GO
/****** Object:  ForeignKey [FK_T_UserRecette_T_Recette]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_Favoris] DROP CONSTRAINT [FK_T_UserRecette_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_UserRecette_T_User]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_Favoris] DROP CONSTRAINT [FK_T_UserRecette_T_User]
GO
/****** Object:  ForeignKey [FK_T_Commentaire_T_Recette]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_Commentaire] DROP CONSTRAINT [FK_T_Commentaire_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Commentaire_T_User]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_Commentaire] DROP CONSTRAINT [FK_T_Commentaire_T_User]
GO
/****** Object:  Table [dbo].[T_Commentaire]    Script Date: 06/23/2012 03:14:40 ******/
DROP TABLE [dbo].[T_Commentaire]
GO
/****** Object:  Table [dbo].[T_Favoris]    Script Date: 06/23/2012 03:14:40 ******/
DROP TABLE [dbo].[T_Favoris]
GO
/****** Object:  Table [dbo].[T_Note]    Script Date: 06/23/2012 03:14:40 ******/
DROP TABLE [dbo].[T_Note]
GO
/****** Object:  Table [dbo].[T_RecetteIngredient]    Script Date: 06/23/2012 03:14:40 ******/
DROP TABLE [dbo].[T_RecetteIngredient]
GO
/****** Object:  Table [dbo].[T_Recette]    Script Date: 06/23/2012 03:14:40 ******/
DROP TABLE [dbo].[T_Recette]
GO
/****** Object:  Table [dbo].[T_Conseil]    Script Date: 06/23/2012 03:14:40 ******/
DROP TABLE [dbo].[T_Conseil]
GO
/****** Object:  Table [dbo].[T_Ingredient]    Script Date: 06/23/2012 03:14:40 ******/
DROP TABLE [dbo].[T_Ingredient]
GO
/****** Object:  Table [dbo].[T_User]    Script Date: 06/23/2012 03:14:40 ******/
DROP TABLE [dbo].[T_User]
GO
/****** Object:  Table [dbo].[T_User]    Script Date: 06/23/2012 03:14:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_User](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[nom] [varchar](50) NOT NULL,
	[email] [varchar](50) NULL,
	[info] [varchar](50) NULL,
 CONSTRAINT [PK_T_User] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_Ingredient]    Script Date: 06/23/2012 03:14:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Ingredient](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T_Ingredient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_Conseil]    Script Date: 06/23/2012 03:14:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Conseil](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[idCreateur] [bigint] NOT NULL,
	[texte] [varchar](500) NOT NULL,
	[photo] [varchar](100) NULL,
	[nom] [varchar](30) NOT NULL,
	[dateCreation] [datetime] NULL,
 CONSTRAINT [PK_T_Conseil] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_Recette]    Script Date: 06/23/2012 03:14:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Recette](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](50) NOT NULL,
	[introduction] [varchar](600) NOT NULL,
	[realisation] [varchar](3000) NOT NULL,
	[difficulte] [varchar](50) NULL,
	[photo] [varchar](300) NULL,
	[createurID] [bigint] NOT NULL,
	[temps_cuisson] [int] NULL,
	[temps_repos] [int] NULL,
	[temps_prepa] [int] NOT NULL,
	[date] [datetime] NULL,
	[categorie] [varchar](50) NULL,
 CONSTRAINT [PK_T_Recette] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_RecetteIngredient]    Script Date: 06/23/2012 03:14:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_RecetteIngredient](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[recetteID] [bigint] NOT NULL,
	[ingredientID] [bigint] NOT NULL,
 CONSTRAINT [PK_T_RecetteIngredient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Note]    Script Date: 06/23/2012 03:14:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Note](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[idUser] [bigint] NULL,
	[idRecette] [bigint] NULL,
	[note] [int] NULL,
 CONSTRAINT [PK_T_Note] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Favoris]    Script Date: 06/23/2012 03:14:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Favoris](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[userID] [bigint] NOT NULL,
	[recetteID] [bigint] NOT NULL,
 CONSTRAINT [PK_T_UserRecette] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Commentaire]    Script Date: 06/23/2012 03:14:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Commentaire](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[texte] [varchar](200) NULL,
	[utilisateurID] [bigint] NOT NULL,
	[recetteID] [bigint] NOT NULL,
 CONSTRAINT [PK_T_Commentaire] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  ForeignKey [FK_T_Conseil_T_User]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_Conseil]  WITH CHECK ADD  CONSTRAINT [FK_T_Conseil_T_User] FOREIGN KEY([idCreateur])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Conseil] CHECK CONSTRAINT [FK_T_Conseil_T_User]
GO
/****** Object:  ForeignKey [FK_T_Recette_T_User]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_Recette]  WITH CHECK ADD  CONSTRAINT [FK_T_Recette_T_User] FOREIGN KEY([createurID])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Recette] CHECK CONSTRAINT [FK_T_Recette_T_User]
GO
/****** Object:  ForeignKey [FK_T_RecetteIngredient_T_Ingredient]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_RecetteIngredient]  WITH CHECK ADD  CONSTRAINT [FK_T_RecetteIngredient_T_Ingredient] FOREIGN KEY([ingredientID])
REFERENCES [dbo].[T_Ingredient] ([id])
GO
ALTER TABLE [dbo].[T_RecetteIngredient] CHECK CONSTRAINT [FK_T_RecetteIngredient_T_Ingredient]
GO
/****** Object:  ForeignKey [FK_T_RecetteIngredient_T_Recette]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_RecetteIngredient]  WITH CHECK ADD  CONSTRAINT [FK_T_RecetteIngredient_T_Recette] FOREIGN KEY([recetteID])
REFERENCES [dbo].[T_Recette] ([id])
GO
ALTER TABLE [dbo].[T_RecetteIngredient] CHECK CONSTRAINT [FK_T_RecetteIngredient_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Note_T_Recette]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_Note]  WITH CHECK ADD  CONSTRAINT [FK_T_Note_T_Recette] FOREIGN KEY([idRecette])
REFERENCES [dbo].[T_Recette] ([id])
GO
ALTER TABLE [dbo].[T_Note] CHECK CONSTRAINT [FK_T_Note_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Note_T_User]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_Note]  WITH CHECK ADD  CONSTRAINT [FK_T_Note_T_User] FOREIGN KEY([idUser])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Note] CHECK CONSTRAINT [FK_T_Note_T_User]
GO
/****** Object:  ForeignKey [FK_T_UserRecette_T_Recette]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_Favoris]  WITH CHECK ADD  CONSTRAINT [FK_T_UserRecette_T_Recette] FOREIGN KEY([recetteID])
REFERENCES [dbo].[T_Recette] ([id])
GO
ALTER TABLE [dbo].[T_Favoris] CHECK CONSTRAINT [FK_T_UserRecette_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_UserRecette_T_User]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_Favoris]  WITH CHECK ADD  CONSTRAINT [FK_T_UserRecette_T_User] FOREIGN KEY([userID])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Favoris] CHECK CONSTRAINT [FK_T_UserRecette_T_User]
GO
/****** Object:  ForeignKey [FK_T_Commentaire_T_Recette]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_Commentaire]  WITH CHECK ADD  CONSTRAINT [FK_T_Commentaire_T_Recette] FOREIGN KEY([recetteID])
REFERENCES [dbo].[T_Recette] ([id])
GO
ALTER TABLE [dbo].[T_Commentaire] CHECK CONSTRAINT [FK_T_Commentaire_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Commentaire_T_User]    Script Date: 06/23/2012 03:14:40 ******/
ALTER TABLE [dbo].[T_Commentaire]  WITH CHECK ADD  CONSTRAINT [FK_T_Commentaire_T_User] FOREIGN KEY([utilisateurID])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Commentaire] CHECK CONSTRAINT [FK_T_Commentaire_T_User]
GO
