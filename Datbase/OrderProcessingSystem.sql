USE [OrderManagement]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 6/1/2020 4:19:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 6/1/2020 4:19:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[Id] [uniqueidentifier] NOT NULL,
	[OrderBy] [nvarchar](50) NULL,
	[Product] [nvarchar](50) NULL,
	[Category] [nvarchar](50) NULL,
	[CreatedAt] [datetime] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 6/1/2020 4:19:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [uniqueidentifier] NOT NULL,
	[Category] [nvarchar](50) NULL,
	[Name] [nvarchar](50) NULL,
	[Description] [nvarchar](50) NULL,
	[Price] [decimal](18, 0) NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Category] ([Id], [Name], [Description]) VALUES (N'c68afd74-267e-4154-a52d-c47ee9b7a54c', N'Book', N'Study')
GO
INSERT [dbo].[Orders] ([Id], [OrderBy], [Product], [Category], [CreatedAt]) VALUES (N'ce86e24b-4edf-43ca-91b9-d00e3fc2e590', N'testorder', N'product', N'Book', CAST(N'2020-05-31T22:09:20.947' AS DateTime))
INSERT [dbo].[Orders] ([Id], [OrderBy], [Product], [Category], [CreatedAt]) VALUES (N'd8ea4fbf-a66a-4951-89b5-d0d3b467a435', N'testorder', N'product', N'Book', CAST(N'2020-05-31T22:19:23.110' AS DateTime))
INSERT [dbo].[Orders] ([Id], [OrderBy], [Product], [Category], [CreatedAt]) VALUES (N'24dea75a-1cea-4fa1-ae7b-fe0924fa3087', N'testorder', N'product', N'Book', CAST(N'2020-05-31T22:22:18.187' AS DateTime))
INSERT [dbo].[Orders] ([Id], [OrderBy], [Product], [Category], [CreatedAt]) VALUES (N'9bc885cf-7e2a-43ec-8411-b9db54862bc0', N'testorder', N'product', N'Book', CAST(N'2020-05-31T22:28:21.293' AS DateTime))
INSERT [dbo].[Orders] ([Id], [OrderBy], [Product], [Category], [CreatedAt]) VALUES (N'd0b75dd4-5482-499d-a2e0-18754f42b9b9', N'testorder', N'Book', N'Book', CAST(N'2020-05-31T22:29:55.887' AS DateTime))
INSERT [dbo].[Orders] ([Id], [OrderBy], [Product], [Category], [CreatedAt]) VALUES (N'2a7b4bd3-3507-4da6-8cb2-56c80af2de03', N'testorder', N'Book', N'Book', CAST(N'2020-05-31T22:38:39.423' AS DateTime))
GO
INSERT [dbo].[Products] ([Id], [Category], [Name], [Description], [Price]) VALUES (N'11826a6d-2572-4d5a-bb94-73e67b6b2f24', N'Book', N'Book', N'test', CAST(30 AS Decimal(18, 0)))
GO
