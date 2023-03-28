-------------------------------------------------------------------
-- CREATE DATABASE
-------------------------------------------------------------------
USE [master]
GO

DROP DATABASE [CoinCatalogue]
GO

CREATE DATABASE [CoinCatalogue]
GO
-------------------------------------------------------------------
-- CREATE TABLES
-------------------------------------------------------------------
-------------------------------------------------------------------
--Coin
-------------------------------------------------------------------
USE [CoinCatalogue]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Coin]') AND type in (N'U'))
DROP TABLE [dbo].[Coin]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Coin](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](max) NULL,
	[country] [nvarchar](max) NULL,
	[year] [int] NULL,
	[denomination] [nvarchar](max) NULL,
	[metal] [nvarchar](max) NULL,
	[fineness] [decimal](6, 2) NULL,
	[weight] [decimal](18, 2) NULL,
	[diameter] [decimal](5, 2) NULL,
	[edge] [varchar](50) NULL,
	[condition] [nvarchar](max) NULL,
	[date_purchase] [date] NULL,
	[value_purchase] [decimal](9, 2) NULL,
	[value_current] [decimal](9, 2) NULL,
	[reverse_design] [nvarchar](max) NULL,
	[reverse_designer] [nvarchar](max) NULL,
	[obverse_design] [nvarchar](max) NULL,
	[obverse_designer] [nvarchar](max) NULL,
 CONSTRAINT [PK_Coin] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO