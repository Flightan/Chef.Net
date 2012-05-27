USE [master]
GO
/****** Object:  Database [Cuisine]    Script Date: 05/27/2012 14:57:34 ******/
CREATE DATABASE [Cuisine] ON  PRIMARY 
( NAME = N'Cuisine', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Cuisine.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Cuisine_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Cuisine_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
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
/****** Object:  Table [dbo].[T_Cuisson]    Script Date: 05/27/2012 14:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Cuisson](
	[id] [bigint] NOT NULL,
	[type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T_Cuisson] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_Note]    Script Date: 05/27/2012 14:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Note](
	[id] [bigint] NOT NULL,
	[gout] [int] NULL,
	[originalite] [int] NULL,
	[presentation] [int] NULL,
 CONSTRAINT [PK_T_Note] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Ingredient]    Script Date: 05/27/2012 14:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Ingredient](
	[id] [bigint] NOT NULL,
	[nom] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T_Ingredient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_User]    Script Date: 05/27/2012 14:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_User](
	[id] [bigint] NOT NULL,
	[password] [varchar](50) NOT NULL,
	[prenom] [varchar](50) NOT NULL,
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
/****** Object:  Table [dbo].[T_Recette]    Script Date: 05/27/2012 14:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Recette](
	[id] [bigint] NOT NULL,
	[introduction] [varchar](50) NOT NULL,
	[difficulte] [int] NULL,
	[photo] [image] NULL,
	[origine] [varchar](50) NULL,
	[cout] [varchar](50) NULL,
	[createurID] [bigint] NOT NULL,
 CONSTRAINT [PK_T_Recette] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_UserRecette]    Script Date: 05/27/2012 14:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_UserRecette](
	[id] [bigint] NOT NULL,
	[userID] [bigint] NOT NULL,
	[recetteID] [bigint] NOT NULL,
 CONSTRAINT [PK_T_UserRecette] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_RecetteIngredient]    Script Date: 05/27/2012 14:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_RecetteIngredient](
	[id] [bigint] NOT NULL,
	[recetteID] [bigint] NOT NULL,
	[ingredientID] [bigint] NOT NULL,
 CONSTRAINT [PK_T_RecetteIngredient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Etape]    Script Date: 05/27/2012 14:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Etape](
	[id] [bigint] NOT NULL,
	[preparation] [varchar](100) NULL,
	[temps_a] [varchar](50) NULL,
	[cuissonID] [bigint] NULL,
	[recetteID] [bigint] NOT NULL,
 CONSTRAINT [PK_T_Etape] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_Conseil]    Script Date: 05/27/2012 14:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Conseil](
	[id] [bigint] NOT NULL,
	[texte] [varchar](50) NULL,
	[utilisateurID] [bigint] NOT NULL,
	[recetteID] [bigint] NOT NULL,
 CONSTRAINT [PK_T_Conseil] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[T_Commentaire]    Script Date: 05/27/2012 14:57:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Commentaire](
	[id] [bigint] NOT NULL,
	[texte] [varchar](200) NULL,
	[noteID] [bigint] NULL,
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
/****** Object:  ForeignKey [FK_T_Recette_T_User]    Script Date: 05/27/2012 14:57:38 ******/
ALTER TABLE [dbo].[T_Recette]  WITH CHECK ADD  CONSTRAINT [FK_T_Recette_T_User] FOREIGN KEY([createurID])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Recette] CHECK CONSTRAINT [FK_T_Recette_T_User]
GO
/****** Object:  ForeignKey [FK_T_UserRecette_T_Recette]    Script Date: 05/27/2012 14:57:38 ******/
ALTER TABLE [dbo].[T_UserRecette]  WITH CHECK ADD  CONSTRAINT [FK_T_UserRecette_T_Recette] FOREIGN KEY([recetteID])
REFERENCES [dbo].[T_Recette] ([id])
GO
ALTER TABLE [dbo].[T_UserRecette] CHECK CONSTRAINT [FK_T_UserRecette_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_UserRecette_T_User]    Script Date: 05/27/2012 14:57:38 ******/
ALTER TABLE [dbo].[T_UserRecette]  WITH CHECK ADD  CONSTRAINT [FK_T_UserRecette_T_User] FOREIGN KEY([userID])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_UserRecette] CHECK CONSTRAINT [FK_T_UserRecette_T_User]
GO
/****** Object:  ForeignKey [FK_T_RecetteIngredient_T_Ingredient]    Script Date: 05/27/2012 14:57:38 ******/
ALTER TABLE [dbo].[T_RecetteIngredient]  WITH CHECK ADD  CONSTRAINT [FK_T_RecetteIngredient_T_Ingredient] FOREIGN KEY([ingredientID])
REFERENCES [dbo].[T_Ingredient] ([id])
GO
ALTER TABLE [dbo].[T_RecetteIngredient] CHECK CONSTRAINT [FK_T_RecetteIngredient_T_Ingredient]
GO
/****** Object:  ForeignKey [FK_T_RecetteIngredient_T_Recette]    Script Date: 05/27/2012 14:57:38 ******/
ALTER TABLE [dbo].[T_RecetteIngredient]  WITH CHECK ADD  CONSTRAINT [FK_T_RecetteIngredient_T_Recette] FOREIGN KEY([recetteID])
REFERENCES [dbo].[T_Recette] ([id])
GO
ALTER TABLE [dbo].[T_RecetteIngredient] CHECK CONSTRAINT [FK_T_RecetteIngredient_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Etape_T_Cuisson]    Script Date: 05/27/2012 14:57:38 ******/
ALTER TABLE [dbo].[T_Etape]  WITH CHECK ADD  CONSTRAINT [FK_T_Etape_T_Cuisson] FOREIGN KEY([cuissonID])
REFERENCES [dbo].[T_Cuisson] ([id])
GO
ALTER TABLE [dbo].[T_Etape] CHECK CONSTRAINT [FK_T_Etape_T_Cuisson]
GO
/****** Object:  ForeignKey [FK_T_Etape_T_Recette]    Script Date: 05/27/2012 14:57:38 ******/
ALTER TABLE [dbo].[T_Etape]  WITH CHECK ADD  CONSTRAINT [FK_T_Etape_T_Recette] FOREIGN KEY([recetteID])
REFERENCES [dbo].[T_Recette] ([id])
GO
ALTER TABLE [dbo].[T_Etape] CHECK CONSTRAINT [FK_T_Etape_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Conseil_T_Recette]    Script Date: 05/27/2012 14:57:38 ******/
ALTER TABLE [dbo].[T_Conseil]  WITH CHECK ADD  CONSTRAINT [FK_T_Conseil_T_Recette] FOREIGN KEY([recetteID])
REFERENCES [dbo].[T_Recette] ([id])
GO
ALTER TABLE [dbo].[T_Conseil] CHECK CONSTRAINT [FK_T_Conseil_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Conseil_T_User]    Script Date: 05/27/2012 14:57:38 ******/
ALTER TABLE [dbo].[T_Conseil]  WITH CHECK ADD  CONSTRAINT [FK_T_Conseil_T_User] FOREIGN KEY([utilisateurID])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Conseil] CHECK CONSTRAINT [FK_T_Conseil_T_User]
GO
/****** Object:  ForeignKey [FK_T_Commentaire_T_Note]    Script Date: 05/27/2012 14:57:38 ******/
ALTER TABLE [dbo].[T_Commentaire]  WITH CHECK ADD  CONSTRAINT [FK_T_Commentaire_T_Note] FOREIGN KEY([noteID])
REFERENCES [dbo].[T_Note] ([id])
GO
ALTER TABLE [dbo].[T_Commentaire] CHECK CONSTRAINT [FK_T_Commentaire_T_Note]
GO
/****** Object:  ForeignKey [FK_T_Commentaire_T_Recette]    Script Date: 05/27/2012 14:57:38 ******/
ALTER TABLE [dbo].[T_Commentaire]  WITH CHECK ADD  CONSTRAINT [FK_T_Commentaire_T_Recette] FOREIGN KEY([recetteID])
REFERENCES [dbo].[T_Recette] ([id])
GO
ALTER TABLE [dbo].[T_Commentaire] CHECK CONSTRAINT [FK_T_Commentaire_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Commentaire_T_User]    Script Date: 05/27/2012 14:57:38 ******/
ALTER TABLE [dbo].[T_Commentaire]  WITH CHECK ADD  CONSTRAINT [FK_T_Commentaire_T_User] FOREIGN KEY([utilisateurID])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Commentaire] CHECK CONSTRAINT [FK_T_Commentaire_T_User]
GO
