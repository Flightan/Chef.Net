USE [Cuisine]
GO
/****** Object:  ForeignKey [FK_T_Commentaire_T_Recette]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_Commentaire] DROP CONSTRAINT [FK_T_Commentaire_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Commentaire_T_User]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_Commentaire] DROP CONSTRAINT [FK_T_Commentaire_T_User]
GO
/****** Object:  ForeignKey [FK_T_UserRecette_T_Recette]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_Favoris] DROP CONSTRAINT [FK_T_UserRecette_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_UserRecette_T_User]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_Favoris] DROP CONSTRAINT [FK_T_UserRecette_T_User]
GO
/****** Object:  ForeignKey [FK_T_Note_T_Recette]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_Note] DROP CONSTRAINT [FK_T_Note_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Note_T_User]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_Note] DROP CONSTRAINT [FK_T_Note_T_User]
GO
/****** Object:  ForeignKey [FK_T_Recette_T_User]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_Recette] DROP CONSTRAINT [FK_T_Recette_T_User]
GO
/****** Object:  ForeignKey [FK_T_RecetteIngredient_T_Ingredient]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_RecetteIngredient] DROP CONSTRAINT [FK_T_RecetteIngredient_T_Ingredient]
GO
/****** Object:  ForeignKey [FK_T_RecetteIngredient_T_Recette]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_RecetteIngredient] DROP CONSTRAINT [FK_T_RecetteIngredient_T_Recette]
GO
/****** Object:  Table [dbo].[T_Commentaire]    Script Date: 06/21/2012 20:52:26 ******/
DROP TABLE [dbo].[T_Commentaire]
GO
/****** Object:  Table [dbo].[T_Favoris]    Script Date: 06/21/2012 20:52:26 ******/
DROP TABLE [dbo].[T_Favoris]
GO
/****** Object:  Table [dbo].[T_Note]    Script Date: 06/21/2012 20:52:26 ******/
DROP TABLE [dbo].[T_Note]
GO
/****** Object:  Table [dbo].[T_RecetteIngredient]    Script Date: 06/21/2012 20:52:26 ******/
DROP TABLE [dbo].[T_RecetteIngredient]
GO
/****** Object:  Table [dbo].[T_Recette]    Script Date: 06/21/2012 20:52:26 ******/
DROP TABLE [dbo].[T_Recette]
GO
/****** Object:  Table [dbo].[T_Ingredient]    Script Date: 06/21/2012 20:52:26 ******/
DROP TABLE [dbo].[T_Ingredient]
GO
/****** Object:  Table [dbo].[T_User]    Script Date: 06/21/2012 20:52:26 ******/
DROP TABLE [dbo].[T_User]
GO
/****** Object:  Table [dbo].[T_User]    Script Date: 06/21/2012 20:52:26 ******/
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
SET IDENTITY_INSERT [dbo].[T_User] ON
INSERT [dbo].[T_User] ([id], [password], [nom], [email], [info]) VALUES (0, N'blabla', N'tata', N'tata@tata.com', N'')
INSERT [dbo].[T_User] ([id], [password], [nom], [email], [info]) VALUES (1, N'blabla', N'toto', N'toto@toto.com', N'Info')
SET IDENTITY_INSERT [dbo].[T_User] OFF
/****** Object:  Table [dbo].[T_Ingredient]    Script Date: 06/21/2012 20:52:26 ******/
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
/****** Object:  Table [dbo].[T_Recette]    Script Date: 06/21/2012 20:52:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[T_Recette](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[nom] [varchar](50) NOT NULL,
	[introduction] [varchar](50) NOT NULL,
	[realisation] [varchar](500) NOT NULL,
	[difficulte] [int] NULL,
	[photo] [varchar](50) NULL,
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
SET IDENTITY_INSERT [dbo].[T_Recette] ON
INSERT [dbo].[T_Recette] ([id], [nom], [introduction], [realisation], [difficulte], [photo], [createurID], [temps_cuisson], [temps_repos], [temps_prepa], [date], [categorie]) VALUES (0, N'Paris Brest', N'Introduction', N'Realisation', 5, NULL, 0, 20, 5, 25, NULL, N'Dessert')
INSERT [dbo].[T_Recette] ([id], [nom], [introduction], [realisation], [difficulte], [photo], [createurID], [temps_cuisson], [temps_repos], [temps_prepa], [date], [categorie]) VALUES (5, N'Paris Brest', N'Introduction recette', N'Realisation recette', 5, NULL, 1, 25, 0, 30, CAST(0x0000A077015744EF AS DateTime), N'Categorie')
INSERT [dbo].[T_Recette] ([id], [nom], [introduction], [realisation], [difficulte], [photo], [createurID], [temps_cuisson], [temps_repos], [temps_prepa], [date], [categorie]) VALUES (6, N'Paris Brest', N'Introduction recette', N'Realisation recette', 5, NULL, 1, 25, 0, 30, CAST(0x0000A07701574B73 AS DateTime), N'Categorie')
SET IDENTITY_INSERT [dbo].[T_Recette] OFF
/****** Object:  Table [dbo].[T_RecetteIngredient]    Script Date: 06/21/2012 20:52:26 ******/
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
/****** Object:  Table [dbo].[T_Note]    Script Date: 06/21/2012 20:52:26 ******/
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
/****** Object:  Table [dbo].[T_Favoris]    Script Date: 06/21/2012 20:52:26 ******/
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
/****** Object:  Table [dbo].[T_Commentaire]    Script Date: 06/21/2012 20:52:26 ******/
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
SET IDENTITY_INSERT [dbo].[T_Commentaire] ON
INSERT [dbo].[T_Commentaire] ([id], [texte], [utilisateurID], [recetteID]) VALUES (-1, N'Commentaire', 1, 0)
INSERT [dbo].[T_Commentaire] ([id], [texte], [utilisateurID], [recetteID]) VALUES (0, N'jihjhhj', 1, 0)
INSERT [dbo].[T_Commentaire] ([id], [texte], [utilisateurID], [recetteID]) VALUES (2, N'Blabla', 1, 0)
SET IDENTITY_INSERT [dbo].[T_Commentaire] OFF
/****** Object:  ForeignKey [FK_T_Commentaire_T_Recette]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_Commentaire]  WITH CHECK ADD  CONSTRAINT [FK_T_Commentaire_T_Recette] FOREIGN KEY([recetteID])
REFERENCES [dbo].[T_Recette] ([id])
GO
ALTER TABLE [dbo].[T_Commentaire] CHECK CONSTRAINT [FK_T_Commentaire_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Commentaire_T_User]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_Commentaire]  WITH CHECK ADD  CONSTRAINT [FK_T_Commentaire_T_User] FOREIGN KEY([utilisateurID])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Commentaire] CHECK CONSTRAINT [FK_T_Commentaire_T_User]
GO
/****** Object:  ForeignKey [FK_T_UserRecette_T_Recette]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_Favoris]  WITH CHECK ADD  CONSTRAINT [FK_T_UserRecette_T_Recette] FOREIGN KEY([recetteID])
REFERENCES [dbo].[T_Recette] ([id])
GO
ALTER TABLE [dbo].[T_Favoris] CHECK CONSTRAINT [FK_T_UserRecette_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_UserRecette_T_User]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_Favoris]  WITH CHECK ADD  CONSTRAINT [FK_T_UserRecette_T_User] FOREIGN KEY([userID])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Favoris] CHECK CONSTRAINT [FK_T_UserRecette_T_User]
GO
/****** Object:  ForeignKey [FK_T_Note_T_Recette]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_Note]  WITH CHECK ADD  CONSTRAINT [FK_T_Note_T_Recette] FOREIGN KEY([idRecette])
REFERENCES [dbo].[T_Recette] ([id])
GO
ALTER TABLE [dbo].[T_Note] CHECK CONSTRAINT [FK_T_Note_T_Recette]
GO
/****** Object:  ForeignKey [FK_T_Note_T_User]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_Note]  WITH CHECK ADD  CONSTRAINT [FK_T_Note_T_User] FOREIGN KEY([idUser])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Note] CHECK CONSTRAINT [FK_T_Note_T_User]
GO
/****** Object:  ForeignKey [FK_T_Recette_T_User]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_Recette]  WITH CHECK ADD  CONSTRAINT [FK_T_Recette_T_User] FOREIGN KEY([createurID])
REFERENCES [dbo].[T_User] ([id])
GO
ALTER TABLE [dbo].[T_Recette] CHECK CONSTRAINT [FK_T_Recette_T_User]
GO
/****** Object:  ForeignKey [FK_T_RecetteIngredient_T_Ingredient]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_RecetteIngredient]  WITH CHECK ADD  CONSTRAINT [FK_T_RecetteIngredient_T_Ingredient] FOREIGN KEY([ingredientID])
REFERENCES [dbo].[T_Ingredient] ([id])
GO
ALTER TABLE [dbo].[T_RecetteIngredient] CHECK CONSTRAINT [FK_T_RecetteIngredient_T_Ingredient]
GO
/****** Object:  ForeignKey [FK_T_RecetteIngredient_T_Recette]    Script Date: 06/21/2012 20:52:26 ******/
ALTER TABLE [dbo].[T_RecetteIngredient]  WITH CHECK ADD  CONSTRAINT [FK_T_RecetteIngredient_T_Recette] FOREIGN KEY([recetteID])
REFERENCES [dbo].[T_Recette] ([id])
GO
ALTER TABLE [dbo].[T_RecetteIngredient] CHECK CONSTRAINT [FK_T_RecetteIngredient_T_Recette]
GO
