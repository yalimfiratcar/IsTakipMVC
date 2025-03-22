# AcunMedya Akademi Back-End Temel Eğitim Projesi - İş Takip Sistemi
   - AcunMedya Akademi'deki Back-End Temel Eğitim kapsamında geliştirdiğim İş Takip Sistemi Projesi.

   - Projeyi çalıştırabilmek için, aşağıdaki SQL scriptini veritabanınıza eklemeniz gerekmektedir:


   ```sql

   USE [İsTakip_DB]
GO
/****** Object:  Table [dbo].[People]    Script Date: 22.03.2025 17:19:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[People](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AdiSoyadi] [nvarchar](50) NULL,
 CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 22.03.2025 17:19:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Durum] [nvarchar](50) NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WorkJoinedViewModel]    Script Date: 22.03.2025 17:19:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkJoinedViewModel](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[WorkId] [int] NULL,
	[Title] [nvarchar](50) NULL,
	[WorksDurumId] [nchar](10) NULL,
	[CalisanId] [nchar](10) NULL,
	[CreatedDate] [datetime] NULL,
	[DurumId] [int] NULL,
	[Durum] [nvarchar](max) NULL,
	[PeopleId] [int] NULL,
	[AdiSoyadi] [nvarchar](50) NULL,
 CONSTRAINT [PK_WorkJoinedViewModel] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Works]    Script Date: 22.03.2025 17:19:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Works](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](50) NULL,
	[StatusId] [int] NULL,
	[CalisanId] [nchar](10) NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_Works] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[People] ON 

INSERT [dbo].[People] ([Id], [AdiSoyadi]) VALUES (1, N'Fırat Çar')
INSERT [dbo].[People] ([Id], [AdiSoyadi]) VALUES (2, N'Yalım Çare')
INSERT [dbo].[People] ([Id], [AdiSoyadi]) VALUES (3, N'Işıl Su')
SET IDENTITY_INSERT [dbo].[People] OFF
GO
SET IDENTITY_INSERT [dbo].[Works] ON 

INSERT [dbo].[Works] ([Id], [Title], [StatusId], [CalisanId], [CreatedDate]) VALUES (3, N'Sunum Yapılacak', 0, N'1         ', CAST(N'2025-03-22T17:17:07.840' AS DateTime))
INSERT [dbo].[Works] ([Id], [Title], [StatusId], [CalisanId], [CreatedDate]) VALUES (4, N'Site Tasarlanıcak.', 0, N'2         ', CAST(N'2025-03-22T17:17:39.203' AS DateTime))
SET IDENTITY_INSERT [dbo].[Works] OFF
GO
   ```
