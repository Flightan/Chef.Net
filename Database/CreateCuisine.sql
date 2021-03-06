USE [master]
GO
/****** Object:  Database [Cuisine]    Script Date: 06/23/2012 11:38:35 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'Cuisine')
BEGIN
CREATE DATABASE [Cuisine] ON  PRIMARY 
( NAME = N'Cuisine', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Cuisine.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Cuisine_log', FILENAME = N'c:\Program Files (x86)\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\Cuisine_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END
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
/****** Object:  Table [dbo].[T_User]    Script Date: 06/23/2012 11:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[T_User]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[T_User] ON
INSERT [dbo].[T_User] ([id], [password], [nom], [email], [info]) VALUES (0, N'blabla', N'tata', N'tata@tata.com', N'Info toto')
INSERT [dbo].[T_User] ([id], [password], [nom], [email], [info]) VALUES (1, N'blabla', N'toto', N'toto@toto.com', N'Info')
SET IDENTITY_INSERT [dbo].[T_User] OFF
/****** Object:  Table [dbo].[T_Ingredient]    Script Date: 06/23/2012 11:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[T_Ingredient]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[T_Ingredient](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](50) NOT NULL,
 CONSTRAINT [PK_T_Ingredient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[T_Ingredient] ON
INSERT [dbo].[T_Ingredient] ([id], [nom]) VALUES (1, N'Poulet')
SET IDENTITY_INSERT [dbo].[T_Ingredient] OFF
/****** Object:  Table [dbo].[T_Conseil]    Script Date: 06/23/2012 11:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[T_Conseil]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[T_Conseil] ON
INSERT [dbo].[T_Conseil] ([id], [idCreateur], [texte], [photo], [nom], [dateCreation]) VALUES (1, 1, N'Mettre du fromage dans la pate.', NULL, N'Pate au fromage', CAST(0x0000A078012BC487 AS DateTime))
INSERT [dbo].[T_Conseil] ([id], [idCreateur], [texte], [photo], [nom], [dateCreation]) VALUES (2, 1, N'Rajouter du sel pour monter des blancs en neige', NULL, N'Blancs', CAST(0x0000A078012BC487 AS DateTime))
SET IDENTITY_INSERT [dbo].[T_Conseil] OFF
/****** Object:  Table [dbo].[T_Recette]    Script Date: 06/23/2012 11:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[T_Recette]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[T_Recette] ON
INSERT [dbo].[T_Recette] ([id], [nom], [introduction], [realisation], [difficulte], [photo], [createurID], [temps_cuisson], [temps_repos], [temps_prepa], [date], [categorie]) VALUES (0, N'Paris Brest', N'Le Paris-Brest est une patisserie d''origine francaise, en forme de couronne, composee d''une pate a choux fourree d''une creme mousseline pralinee, garnie d''amandes effilees.', N'1Faire chauffer le four à une température de 200°C (th 7); y mettre les amandes à griller légèrement à même la plaque du four.', N'5', N'http://4.bp.blogspot.com/-fxYewIXvOKY/Tm0Fj6B0pzI/AAAAAAAAB8Q/Z0iqwXoGqVQ/s1600/paris-brest.jpg', 0, 20, 5, 25, CAST(0x0000A077015744EF AS DateTime), N'Dessert')
INSERT [dbo].[T_Recette] ([id], [nom], [introduction], [realisation], [difficulte], [photo], [createurID], [temps_cuisson], [temps_repos], [temps_prepa], [date], [categorie]) VALUES (3, N'Poulet rôti', N'Quelques astuces pour réussir un rôti :
- Colorer la pièce avant cuisson à l''aide d''un corps gras résistant aux fortes tempèratures (Huiles ou beurre clarifié).
- Cuire au four sans couvercle en arrosant avec les graisses de cuisson pour éviter que le rôti "séche".', N'1 
Assaisonner l''intérieur du poulet : sel, poivre, thym et gousses d''ail en chemise.
Saler légérement l''extérieur du poulet.
Colorer le poulet sur toutes ces faces dans l''huile fumante.
2 
Enfourner le poulet dans un four chaud à 180°C.
Retourner la pièce pendant la cuisson et arroser de ', N'Expert', N'http://icu.linter.fr/270/302281/1236151439/poulet-roti.jpg', 1, 40, 10, 45, CAST(0x0000A0790034C7E6 AS DateTime), N'Entrée')
INSERT [dbo].[T_Recette] ([id], [nom], [introduction], [realisation], [difficulte], [photo], [createurID], [temps_cuisson], [temps_repos], [temps_prepa], [date], [categorie]) VALUES (4, N'Brochettes de poulet express', N'Vous pouvez réaliser cette recette au barbecue.', N'Lavez et ciselez la citronnelle.

Pelez l''ail et hachez-le.

Ouvrez le piment en deux, retirez les pépins et hachez-le.

Mélangez tous ces ingrédients dans un bol, ajoutez l''huile, 3 c. à soupe d''eau et salez.

Découpez les blancs de poulet en petites lamelles.

Mettez-les dans un plat creux et arrosez-les de marinade. Mélangez et laissez mariner 2 h.

Quand le temps de marinade est écoulé, préchauffez le four position gril, recouvrez la plaque du four de papier aluminium.

Lavez les tomates cerises.

Epluchez les oignons et coupez le vert au ras des bulbes. Coupez les bulbes en quatre.

Retirez les morceaux de viande de la marinade et enroulez-les dans le vert des oignons puis piquez-les sur des brochettes en bois en les alternant avec les tomates cerises et les quartiers d''oignons.

Posez les brochettes sur la plaque du four, saupoudrez-les de paprika.

Enfournez ou déposez vos brochettes sur votre barbecue et faites griller 15 à 18 min en retournant régulièrement les brochettes pour qu''elles dorent de tous les côtés.

Servez dès la sortie du four avec du riz blanc en accompagnement.', N'Intermédiaire', N'http://images.cuisineaz.com/old/recettes/mai024.jpg', 0, 18, -1, 15, CAST(0x0000A07900BA53E5 AS DateTime), N'Entrée')
SET IDENTITY_INSERT [dbo].[T_Recette] OFF
/****** Object:  Table [dbo].[T_RecetteIngredient]    Script Date: 06/23/2012 11:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[T_RecetteIngredient]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[T_RecetteIngredient](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[recetteID] [bigint] NOT NULL,
	[ingredientID] [bigint] NOT NULL,
 CONSTRAINT [PK_T_RecetteIngredient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET IDENTITY_INSERT [dbo].[T_RecetteIngredient] ON
INSERT [dbo].[T_RecetteIngredient] ([id], [recetteID], [ingredientID]) VALUES (1, 3, 1)
SET IDENTITY_INSERT [dbo].[T_RecetteIngredient] OFF
/****** Object:  Table [dbo].[T_Note]    Script Date: 06/23/2012 11:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[T_Note]') AND type in (N'U'))
BEGIN
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
END
GO
SET IDENTITY_INSERT [dbo].[T_Note] ON
INSERT [dbo].[T_Note] ([id], [idUser], [idRecette], [note]) VALUES (1, 0, 0, 5)
INSERT [dbo].[T_Note] ([id], [idUser], [idRecette], [note]) VALUES (2, 0, 4, 4)
SET IDENTITY_INSERT [dbo].[T_Note] OFF
/****** Object:  Table [dbo].[T_Favoris]    Script Date: 06/23/2012 11:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[T_Favoris]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[T_Favoris](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[userID] [bigint] NOT NULL,
	[recetteID] [bigint] NOT NULL,
 CONSTRAINT [PK_T_UserRecette] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[T_Commentaire]    Script Date: 06/23/2012 11:38:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[T_Commentaire]') AND type in (N'U'))
BEGIN
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
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[T_Commentaire] ON
INSERT [dbo].[T_Commentaire] ([id], [texte], [utilisateurID], [recetteID]) VALUES (0, N'Genial', 1, 0)
INSERT [dbo].[T_Commentaire] ([id], [texte], [utilisateurID], [recetteID]) VALUES (2, N'Super recette', 0, 0)
SET IDENTITY_INSERT [dbo].[T_Commentaire] OFF
/****** Object:  ForeignKey [FK_T_Conseil_T_User]    Script Date: 06/23/2012 11:38:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_Conseil_T_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_Conseil]'))
ALTER TABLE [dbo].[T_Conseil]  WITH CHECK ADD  CONSTRAINT [FK_T_Conseil_T_User] FOREIGN KEY([idCreateur])
REFERENCES [dbo].[T_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_Conseil_T_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_Conseil]'))
ALTER TABLE [dbo].[T_Conseil] CHECK CONSTRAINT [FK_T_Conseil_T_User]
GO
/****** Object:  ForeignKey [FK_T_Recette_T_User]    Script Date: 06/23/2012 11:38:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_Recette_T_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_Recette]'))
ALTER TABLE [dbo].[T_Recette]  WITH CHECK ADD  CONSTRAINT [FK_T_Recette_T_User] FOREIGN KEY([createurID])
REFERENCES [dbo].[T_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_Recette_T_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_Recette]'))
ALTER TABLE [dbo].[T_Recette] CHECK CONSTRAINT [FK_T_Recette_T_User]
GO
/****** Object:  ForeignKey [FK_T_RecetteIngredient_T_Ingredient]    Script Date: 06/23/2012 11:38:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_RecetteIngredient_T_Ingredient]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_RecetteIngredient]'))
ALTER TABLE [dbo].[T_RecetteIngredient]  WITH CHECK ADD  CONSTRAINT [FK_T_RecetteIngredient_T_Ingredient] FOREIGN KEY([ingredientID])
REFERENCES [dbo].[T_Ingredient] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_RecetteIngredient_T_Ingredient]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_RecetteIngredient]'))
ALTER TABLE [dbo].[T_RecetteIngredient] CHECK CONSTRAINT [FK_T_RecetteIngredient_T_Ingredient]
GO
/****** Object:  ForeignKey [FK_T_RecetteIngredient_T_Recette]    Script Date: 06/23/2012 11:38:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_RecetteIngredient_T_Recette]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_RecetteIngredient]'))
ALTER TABLE [dbo].[T_RecetteIngredient]  WITH CHECK ADD  CONSTRAINT [FK_T_RecetteIngredient_T_Recette] FOREIGN KEY([recetteID])
REFERENCES [dbo].[T_Recette] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_RecetteIngredient_T_Recette]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_RecetteIngredient]'))
ALTER TABLE [dbo].[T_RecetteIngredient] CHECK CONSTRAINT [FK_T_RecetteIngredient_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Note_T_Recette]    Script Date: 06/23/2012 11:38:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_Note_T_Recette]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_Note]'))
ALTER TABLE [dbo].[T_Note]  WITH CHECK ADD  CONSTRAINT [FK_T_Note_T_Recette] FOREIGN KEY([idRecette])
REFERENCES [dbo].[T_Recette] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_Note_T_Recette]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_Note]'))
ALTER TABLE [dbo].[T_Note] CHECK CONSTRAINT [FK_T_Note_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Note_T_User]    Script Date: 06/23/2012 11:38:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_Note_T_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_Note]'))
ALTER TABLE [dbo].[T_Note]  WITH CHECK ADD  CONSTRAINT [FK_T_Note_T_User] FOREIGN KEY([idUser])
REFERENCES [dbo].[T_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_Note_T_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_Note]'))
ALTER TABLE [dbo].[T_Note] CHECK CONSTRAINT [FK_T_Note_T_User]
GO
/****** Object:  ForeignKey [FK_T_UserRecette_T_Recette]    Script Date: 06/23/2012 11:38:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_UserRecette_T_Recette]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_Favoris]'))
ALTER TABLE [dbo].[T_Favoris]  WITH CHECK ADD  CONSTRAINT [FK_T_UserRecette_T_Recette] FOREIGN KEY([recetteID])
REFERENCES [dbo].[T_Recette] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_UserRecette_T_Recette]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_Favoris]'))
ALTER TABLE [dbo].[T_Favoris] CHECK CONSTRAINT [FK_T_UserRecette_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_UserRecette_T_User]    Script Date: 06/23/2012 11:38:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_UserRecette_T_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_Favoris]'))
ALTER TABLE [dbo].[T_Favoris]  WITH CHECK ADD  CONSTRAINT [FK_T_UserRecette_T_User] FOREIGN KEY([userID])
REFERENCES [dbo].[T_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_UserRecette_T_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_Favoris]'))
ALTER TABLE [dbo].[T_Favoris] CHECK CONSTRAINT [FK_T_UserRecette_T_User]
GO
/****** Object:  ForeignKey [FK_T_Commentaire_T_Recette]    Script Date: 06/23/2012 11:38:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_Commentaire_T_Recette]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_Commentaire]'))
ALTER TABLE [dbo].[T_Commentaire]  WITH CHECK ADD  CONSTRAINT [FK_T_Commentaire_T_Recette] FOREIGN KEY([recetteID])
REFERENCES [dbo].[T_Recette] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_Commentaire_T_Recette]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_Commentaire]'))
ALTER TABLE [dbo].[T_Commentaire] CHECK CONSTRAINT [FK_T_Commentaire_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Commentaire_T_User]    Script Date: 06/23/2012 11:38:40 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_Commentaire_T_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_Commentaire]'))
ALTER TABLE [dbo].[T_Commentaire]  WITH CHECK ADD  CONSTRAINT [FK_T_Commentaire_T_User] FOREIGN KEY([utilisateurID])
REFERENCES [dbo].[T_User] ([id])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_T_Commentaire_T_User]') AND parent_object_id = OBJECT_ID(N'[dbo].[T_Commentaire]'))
ALTER TABLE [dbo].[T_Commentaire] CHECK CONSTRAINT [FK_T_Commentaire_T_User]
GO
