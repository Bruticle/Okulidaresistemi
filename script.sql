USE [okulidare]
GO
/****** Object:  Table [dbo].[Ders]    Script Date: 8.12.2022 21:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NOT NULL,
	[Kredisi] [int] NOT NULL,
	[OkulYonetimId] [int] NOT NULL,
 CONSTRAINT [PK_Ders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ogrenci]    Script Date: 8.12.2022 21:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ogrenci](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [varchar](50) NOT NULL,
	[KayitTarih] [date] NOT NULL,
	[OgrenciNo] [int] NOT NULL,
	[Dtarih] [date] NOT NULL,
	[Bolum] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Ogrenci] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OgrenciDers]    Script Date: 8.12.2022 21:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OgrenciDers](
	[Id] [int] NOT NULL,
	[DersId] [int] NOT NULL,
	[OgrenciId] [int] NOT NULL,
 CONSTRAINT [PK_OgrenciDers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OkulYonetim]    Script Date: 8.12.2022 21:44:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OkulYonetim](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdSoyad] [varchar](50) NULL,
	[Gorevi] [varchar](50) NULL,
	[YonetimTip] [int] NULL,
 CONSTRAINT [PK_OkulYonetim] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ders] ON 

INSERT [dbo].[Ders] ([Id], [Ad], [Kredisi], [OkulYonetimId]) VALUES (100, N'Matematik', 2, 1234)
INSERT [dbo].[Ders] ([Id], [Ad], [Kredisi], [OkulYonetimId]) VALUES (101, N'Fizik', 2, 1235)
INSERT [dbo].[Ders] ([Id], [Ad], [Kredisi], [OkulYonetimId]) VALUES (102, N'Programlama Temelleri', 3, 1236)
INSERT [dbo].[Ders] ([Id], [Ad], [Kredisi], [OkulYonetimId]) VALUES (103, N'Biyoloji', 2, 1237)
SET IDENTITY_INSERT [dbo].[Ders] OFF
GO
SET IDENTITY_INSERT [dbo].[Ogrenci] ON 

INSERT [dbo].[Ogrenci] ([Id], [AdSoyad], [KayitTarih], [OgrenciNo], [Dtarih], [Bolum]) VALUES (1, N'Yağız Eren Kaleli', CAST(N'2020-10-06' AS Date), 123, CAST(N'2002-10-07' AS Date), N'Bilgisayar Programciligi')
INSERT [dbo].[Ogrenci] ([Id], [AdSoyad], [KayitTarih], [OgrenciNo], [Dtarih], [Bolum]) VALUES (2, N'Ahmet Kaya', CAST(N'2019-10-01' AS Date), 124, CAST(N'2001-05-03' AS Date), N'Makina')
INSERT [dbo].[Ogrenci] ([Id], [AdSoyad], [KayitTarih], [OgrenciNo], [Dtarih], [Bolum]) VALUES (3, N'Ali Berk', CAST(N'2019-06-05' AS Date), 24321, CAST(N'1999-03-04' AS Date), N'İsletmecili')
INSERT [dbo].[Ogrenci] ([Id], [AdSoyad], [KayitTarih], [OgrenciNo], [Dtarih], [Bolum]) VALUES (4, N'Mehmet Durmaz', CAST(N'2022-12-06' AS Date), 345, CAST(N'2022-12-06' AS Date), N'Yazılım Mühendisliği')
INSERT [dbo].[Ogrenci] ([Id], [AdSoyad], [KayitTarih], [OgrenciNo], [Dtarih], [Bolum]) VALUES (9, N'Yasin Efe', CAST(N'2020-11-12' AS Date), 414313, CAST(N'2001-04-03' AS Date), N'Bilgisayar Programcılığı')
SET IDENTITY_INSERT [dbo].[Ogrenci] OFF
GO
INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (0, 100, 1)
INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (9996, 103, 4)
INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (9997, 102, 3)
INSERT [dbo].[OgrenciDers] ([Id], [DersId], [OgrenciId]) VALUES (9998, 101, 2)
GO
SET IDENTITY_INSERT [dbo].[OkulYonetim] ON 

INSERT [dbo].[OkulYonetim] ([Id], [AdSoyad], [Gorevi], [YonetimTip]) VALUES (1234, N'Ayşe Fatma', N'Müdür', 1)
INSERT [dbo].[OkulYonetim] ([Id], [AdSoyad], [Gorevi], [YonetimTip]) VALUES (1235, N'Fatma Ayşe', N'Müdür Yardımcısı', 2)
INSERT [dbo].[OkulYonetim] ([Id], [AdSoyad], [Gorevi], [YonetimTip]) VALUES (1236, N'Ali Mehmet', N'Öğretmen', 3)
INSERT [dbo].[OkulYonetim] ([Id], [AdSoyad], [Gorevi], [YonetimTip]) VALUES (1237, N'Mehmet Ali', N'Temizlikçi', 4)
SET IDENTITY_INSERT [dbo].[OkulYonetim] OFF
GO
ALTER TABLE [dbo].[Ders]  WITH NOCHECK ADD  CONSTRAINT [FK_Ders_OkulYonetim1] FOREIGN KEY([OkulYonetimId])
REFERENCES [dbo].[OkulYonetim] ([Id])
GO
ALTER TABLE [dbo].[Ders] NOCHECK CONSTRAINT [FK_Ders_OkulYonetim1]
GO
ALTER TABLE [dbo].[OgrenciDers]  WITH NOCHECK ADD  CONSTRAINT [FK_OgrenciDers_Ders] FOREIGN KEY([DersId])
REFERENCES [dbo].[Ders] ([Id])
GO
ALTER TABLE [dbo].[OgrenciDers] NOCHECK CONSTRAINT [FK_OgrenciDers_Ders]
GO
ALTER TABLE [dbo].[OgrenciDers]  WITH NOCHECK ADD  CONSTRAINT [FK_OgrenciDers_Ogrenci] FOREIGN KEY([OgrenciId])
REFERENCES [dbo].[Ogrenci] ([Id])
GO
ALTER TABLE [dbo].[OgrenciDers] NOCHECK CONSTRAINT [FK_OgrenciDers_Ogrenci]
GO
