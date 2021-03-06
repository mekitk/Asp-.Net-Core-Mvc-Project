USE [OneRowDb]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 28.05.2022 15:26:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Admins]    Script Date: 28.05.2022 15:26:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admins](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[User_Name] [nvarchar](50) NOT NULL,
	[User_Password] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 28.05.2022 15:26:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Product_Id] [int] IDENTITY(1,1) NOT NULL,
	[Product_Name] [nvarchar](50) NOT NULL,
	[Sale_Price] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Product_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SpareParts]    Script Date: 28.05.2022 15:26:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SpareParts](
	[Part_Id] [int] IDENTITY(1,1) NOT NULL,
	[Part_Name] [nvarchar](50) NOT NULL,
	[Part_Price] [int] NOT NULL,
	[Product_Id] [int] NOT NULL,
	[Product_Id1] [int] NULL,
 CONSTRAINT [PK_SpareParts] PRIMARY KEY CLUSTERED 
(
	[Part_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220526152255_mig1', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220526164639_mig2', N'6.0.5')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20220526204148_mig3', N'6.0.5')
GO
SET IDENTITY_INSERT [dbo].[Admins] ON 

INSERT [dbo].[Admins] ([Id], [User_Name], [User_Password]) VALUES (1, N'admin', 1234)
SET IDENTITY_INSERT [dbo].[Admins] OFF
GO
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Sale_Price]) VALUES (1, N'Ford Fiesta', 300000)
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Sale_Price]) VALUES (2, N'Ford Conn', 250000)
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Sale_Price]) VALUES (3, N'Ford Focus', 430000)
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Sale_Price]) VALUES (4, N'Ford Puma ', 450000)
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Sale_Price]) VALUES (7, N'Ford Test', 555555)
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Sale_Price]) VALUES (8, N'Ford TTT', 666666)
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Sale_Price]) VALUES (9, N'Audi', 323243)
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Sale_Price]) VALUES (10, N'audi a5', 500000)
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Sale_Price]) VALUES (11, N'audi a6', 366000)
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Sale_Price]) VALUES (12, N'audi a8', 550000)
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Sale_Price]) VALUES (13, N'audi a10', 700000)
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Sale_Price]) VALUES (14, N'audi a11', 600000)
INSERT [dbo].[Products] ([Product_Id], [Product_Name], [Sale_Price]) VALUES (16, N'audi a3', 360000)
SET IDENTITY_INSERT [dbo].[Products] OFF
GO
SET IDENTITY_INSERT [dbo].[SpareParts] ON 

INSERT [dbo].[SpareParts] ([Part_Id], [Part_Name], [Part_Price], [Product_Id], [Product_Id1]) VALUES (2, N'Engine ', 26000, 2, NULL)
INSERT [dbo].[SpareParts] ([Part_Id], [Part_Name], [Part_Price], [Product_Id], [Product_Id1]) VALUES (6, N'Brake ', 10000, 1, NULL)
INSERT [dbo].[SpareParts] ([Part_Id], [Part_Name], [Part_Price], [Product_Id], [Product_Id1]) VALUES (7, N'Brake', 12300, 2, NULL)
INSERT [dbo].[SpareParts] ([Part_Id], [Part_Name], [Part_Price], [Product_Id], [Product_Id1]) VALUES (10, N'brake', 15000, 12, NULL)
INSERT [dbo].[SpareParts] ([Part_Id], [Part_Name], [Part_Price], [Product_Id], [Product_Id1]) VALUES (11, N'test', 20000, 16, NULL)
INSERT [dbo].[SpareParts] ([Part_Id], [Part_Name], [Part_Price], [Product_Id], [Product_Id1]) VALUES (12, N'tttt', 20000, 2, NULL)
INSERT [dbo].[SpareParts] ([Part_Id], [Part_Name], [Part_Price], [Product_Id], [Product_Id1]) VALUES (13, N'test', 22, 14, NULL)
INSERT [dbo].[SpareParts] ([Part_Id], [Part_Name], [Part_Price], [Product_Id], [Product_Id1]) VALUES (14, N'Diff', 1230, 9, NULL)
SET IDENTITY_INSERT [dbo].[SpareParts] OFF
GO
ALTER TABLE [dbo].[SpareParts]  WITH CHECK ADD  CONSTRAINT [FK_SpareParts_Products] FOREIGN KEY([Product_Id])
REFERENCES [dbo].[Products] ([Product_Id])
GO
ALTER TABLE [dbo].[SpareParts] CHECK CONSTRAINT [FK_SpareParts_Products]
GO
