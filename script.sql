USE [CarDealership]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 11.02.2024 2:41:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[ID_Brand] [int] IDENTITY(1,1) NOT NULL,
	[BrandName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
	[ID_Brand] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Car]    Script Date: 11.02.2024 2:41:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Car](
	[ID_Car] [int] IDENTITY(1,1) NOT NULL,
	[Brand] [int] NOT NULL,
	[Model] [int] NOT NULL,
	[Color] [int] NOT NULL,
	[ColorInterior] [int] NOT NULL,
	[Conditioner] [int] NOT NULL,
	[PowerWindows] [int] NOT NULL,
	[Cost] [int] NOT NULL,
	[Photo] [nvarchar](max) NULL,
	[Status] [nvarchar](max) NOT NULL,
	[Client] [int] NULL,
 CONSTRAINT [PK_Car] PRIMARY KEY CLUSTERED 
(
	[ID_Car] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 11.02.2024 2:41:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ID_Client] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nvarchar](max) NULL,
	[Name] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NULL,
	[Phone] [nvarchar](max) NULL,
	[Email] [nvarchar](max) NULL,
	[Login] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ID_Client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Color]    Script Date: 11.02.2024 2:41:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Color](
	[ID_Color] [int] IDENTITY(1,1) NOT NULL,
	[ColorName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED 
(
	[ID_Color] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ColorInterior]    Script Date: 11.02.2024 2:41:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ColorInterior](
	[ID_ColorInterior] [int] IDENTITY(1,1) NOT NULL,
	[ColorInterior] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_ColorInterior] PRIMARY KEY CLUSTERED 
(
	[ID_ColorInterior] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Model]    Script Date: 11.02.2024 2:41:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Model](
	[ID_Model] [int] IDENTITY(1,1) NOT NULL,
	[ModelName] [nvarchar](max) NOT NULL,
	[Brand] [int] NOT NULL,
	[Cost] [int] NULL,
 CONSTRAINT [PK_Model] PRIMARY KEY CLUSTERED 
(
	[ID_Model] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Brand] ON 

INSERT [dbo].[Brand] ([ID_Brand], [BrandName]) VALUES (1, N'BMW')
INSERT [dbo].[Brand] ([ID_Brand], [BrandName]) VALUES (2, N'Mercedes-Benz')
INSERT [dbo].[Brand] ([ID_Brand], [BrandName]) VALUES (3, N'Porsche')
INSERT [dbo].[Brand] ([ID_Brand], [BrandName]) VALUES (4, N'Lamborghini')
INSERT [dbo].[Brand] ([ID_Brand], [BrandName]) VALUES (5, N'Audi')
SET IDENTITY_INSERT [dbo].[Brand] OFF
GO
SET IDENTITY_INSERT [dbo].[Car] ON 

INSERT [dbo].[Car] ([ID_Car], [Brand], [Model], [Color], [ColorInterior], [Conditioner], [PowerWindows], [Cost], [Photo], [Status], [Client]) VALUES (1, 1, 1, 2, 1, 1, 0, 8950000, N'\images\cars\bmw1.png', N'В продаже', 1)
INSERT [dbo].[Car] ([ID_Car], [Brand], [Model], [Color], [ColorInterior], [Conditioner], [PowerWindows], [Cost], [Photo], [Status], [Client]) VALUES (2, 1, 2, 1, 1, 0, 1, 9805000, N'\images\cars\bmw2.png', N'В продаже', 1)
INSERT [dbo].[Car] ([ID_Car], [Brand], [Model], [Color], [ColorInterior], [Conditioner], [PowerWindows], [Cost], [Photo], [Status], [Client]) VALUES (3, 2, 3, 1, 1, 1, 1, 5405000, N'\images\cars\mercedes1.jpg', N'В продаже', 1)
INSERT [dbo].[Car] ([ID_Car], [Brand], [Model], [Color], [ColorInterior], [Conditioner], [PowerWindows], [Cost], [Photo], [Status], [Client]) VALUES (10, 3, 4, 4, 2, 1, 1, 10000000, N'\images\cars\porsche1.png', N'В продаже', 1)
INSERT [dbo].[Car] ([ID_Car], [Brand], [Model], [Color], [ColorInterior], [Conditioner], [PowerWindows], [Cost], [Photo], [Status], [Client]) VALUES (11, 2, 3, 1, 1, 0, 1, 5350000, N'-', N'Заказ', 1)
INSERT [dbo].[Car] ([ID_Car], [Brand], [Model], [Color], [ColorInterior], [Conditioner], [PowerWindows], [Cost], [Photo], [Status], [Client]) VALUES (12, 1, 2, 1, 1, 1, 1, 9855000, N'-', N'Заказ', 1)
INSERT [dbo].[Car] ([ID_Car], [Brand], [Model], [Color], [ColorInterior], [Conditioner], [PowerWindows], [Cost], [Photo], [Status], [Client]) VALUES (1011, 1, 1, 2, 1, 1, 1, 8955000, N'-', N'Заказ', 1)
SET IDENTITY_INSERT [dbo].[Car] OFF
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([ID_Client], [Surname], [Name], [LastName], [Phone], [Email], [Login], [Password]) VALUES (1, N'Test', N'Test', N'Test', N'+79991111111', N'1@test.ru', N'test1', N'test1')
INSERT [dbo].[Client] ([ID_Client], [Surname], [Name], [LastName], [Phone], [Email], [Login], [Password]) VALUES (2, N'Test', N'Test', N'Test', N'+79992222222', N'2@test.ru', N'test2', N'test2')
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Color] ON 

INSERT [dbo].[Color] ([ID_Color], [ColorName]) VALUES (1, N'Белый')
INSERT [dbo].[Color] ([ID_Color], [ColorName]) VALUES (2, N'Чёрный')
INSERT [dbo].[Color] ([ID_Color], [ColorName]) VALUES (3, N'Красный')
INSERT [dbo].[Color] ([ID_Color], [ColorName]) VALUES (4, N'Жёлтый')
INSERT [dbo].[Color] ([ID_Color], [ColorName]) VALUES (5, N'Зелёный')
INSERT [dbo].[Color] ([ID_Color], [ColorName]) VALUES (6, N'Синий')
INSERT [dbo].[Color] ([ID_Color], [ColorName]) VALUES (7, N'Серый')
SET IDENTITY_INSERT [dbo].[Color] OFF
GO
SET IDENTITY_INSERT [dbo].[ColorInterior] ON 

INSERT [dbo].[ColorInterior] ([ID_ColorInterior], [ColorInterior]) VALUES (1, N'Белый')
INSERT [dbo].[ColorInterior] ([ID_ColorInterior], [ColorInterior]) VALUES (2, N'Чёрный')
INSERT [dbo].[ColorInterior] ([ID_ColorInterior], [ColorInterior]) VALUES (3, N'Красный')
INSERT [dbo].[ColorInterior] ([ID_ColorInterior], [ColorInterior]) VALUES (4, N'Жёлтый')
INSERT [dbo].[ColorInterior] ([ID_ColorInterior], [ColorInterior]) VALUES (5, N'Зелёный')
INSERT [dbo].[ColorInterior] ([ID_ColorInterior], [ColorInterior]) VALUES (6, N'Синий')
INSERT [dbo].[ColorInterior] ([ID_ColorInterior], [ColorInterior]) VALUES (7, N'Серый')
SET IDENTITY_INSERT [dbo].[ColorInterior] OFF
GO
SET IDENTITY_INSERT [dbo].[Model] ON 

INSERT [dbo].[Model] ([ID_Model], [ModelName], [Brand], [Cost]) VALUES (1, N'M3', 1, 8900000)
INSERT [dbo].[Model] ([ID_Model], [ModelName], [Brand], [Cost]) VALUES (2, N'M5', 1, 9800000)
INSERT [dbo].[Model] ([ID_Model], [ModelName], [Brand], [Cost]) VALUES (3, N'CLS-class', 2, 5350000)
INSERT [dbo].[Model] ([ID_Model], [ModelName], [Brand], [Cost]) VALUES (4, N'911', 3, 10000000)
INSERT [dbo].[Model] ([ID_Model], [ModelName], [Brand], [Cost]) VALUES (5, N'Huracan', 4, 33000000)
INSERT [dbo].[Model] ([ID_Model], [ModelName], [Brand], [Cost]) VALUES (6, N'A3', 5, 4700000)
SET IDENTITY_INSERT [dbo].[Model] OFF
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Brand] FOREIGN KEY([Brand])
REFERENCES [dbo].[Brand] ([ID_Brand])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Brand]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Client] FOREIGN KEY([Client])
REFERENCES [dbo].[Client] ([ID_Client])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Client]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Color] FOREIGN KEY([Color])
REFERENCES [dbo].[Color] ([ID_Color])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Color]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_ColorInterior] FOREIGN KEY([ColorInterior])
REFERENCES [dbo].[ColorInterior] ([ID_ColorInterior])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_ColorInterior]
GO
ALTER TABLE [dbo].[Car]  WITH CHECK ADD  CONSTRAINT [FK_Car_Model] FOREIGN KEY([Model])
REFERENCES [dbo].[Model] ([ID_Model])
GO
ALTER TABLE [dbo].[Car] CHECK CONSTRAINT [FK_Car_Model]
GO
ALTER TABLE [dbo].[Model]  WITH CHECK ADD  CONSTRAINT [FK_Model_Brand] FOREIGN KEY([Brand])
REFERENCES [dbo].[Brand] ([ID_Brand])
GO
ALTER TABLE [dbo].[Model] CHECK CONSTRAINT [FK_Model_Brand]
GO
