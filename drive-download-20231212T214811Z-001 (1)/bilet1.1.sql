USE [DBbiletsatishi]
GO

/****** Object:  Table [dbo].[Tbl_bilet]    Script Date: 12/2/2023 2:34:27 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Tbl_bilet](
	[K_id] [int] IDENTITY(1,1) NOT NULL,
	[Konsert_adi] [nvarchar](50) NULL,
	[bilet_qiymeti] [int] NULL,
	[bilet_sayi] [int] NULL
) ON [PRIMARY]
GO

