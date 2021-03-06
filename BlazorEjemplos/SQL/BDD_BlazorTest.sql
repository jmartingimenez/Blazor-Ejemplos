USE [BlazorTest]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 5/24/2021 4:48:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 5/24/2021 4:48:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[RolId] [int] NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Rol] ON 

INSERT [dbo].[Rol] ([Id], [Descripcion]) VALUES (1, N'Admin')
INSERT [dbo].[Rol] ([Id], [Descripcion]) VALUES (2, N'Normal')
SET IDENTITY_INSERT [dbo].[Rol] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([Id], [Username], [Nombre], [Apellido], [RolId], [Password]) VALUES (1, N'admin', N'Super', N'Administrator', 1, N'1234')
INSERT [dbo].[Usuario] ([Id], [Username], [Nombre], [Apellido], [RolId], [Password]) VALUES (2, N'jgimenez', N'Jonatan', N'Gimenez', 2, N'1234')
INSERT [dbo].[Usuario] ([Id], [Username], [Nombre], [Apellido], [RolId], [Password]) VALUES (3, N'papapapa', N'nombreGenerico', N'apellidoGenerico', 2, N'123')
INSERT [dbo].[Usuario] ([Id], [Username], [Nombre], [Apellido], [RolId], [Password]) VALUES (4, N'random1', N'nombreGenerico', N'apellidoGenerico', 2, N'255')
INSERT [dbo].[Usuario] ([Id], [Username], [Nombre], [Apellido], [RolId], [Password]) VALUES (5, N'aloha', N'nombreGenerico', N'apellidoGenerico', 2, N'123')
INSERT [dbo].[Usuario] ([Id], [Username], [Nombre], [Apellido], [RolId], [Password]) VALUES (6, N'lalala', N'nombreGenerico', N'apellidoGenerico', 2, N'123')
INSERT [dbo].[Usuario] ([Id], [Username], [Nombre], [Apellido], [RolId], [Password]) VALUES (7, N'lalala1', N'nombreGenerico', N'apellidoGenerico', 2, N'123')
INSERT [dbo].[Usuario] ([Id], [Username], [Nombre], [Apellido], [RolId], [Password]) VALUES (8, N'alfajor', N'nombreGenerico', N'apellidoGenerico', 2, N'123')
INSERT [dbo].[Usuario] ([Id], [Username], [Nombre], [Apellido], [RolId], [Password]) VALUES (9, N'alfajor2', N'nombreGenerico', N'apellidoGenerico', 2, N'123')
INSERT [dbo].[Usuario] ([Id], [Username], [Nombre], [Apellido], [RolId], [Password]) VALUES (10, N'marco', N'nombreGenerico', N'apellidoGenerico', 2, N'polo')
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Rol] FOREIGN KEY([RolId])
REFERENCES [dbo].[Rol] ([Id])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Rol]
GO
