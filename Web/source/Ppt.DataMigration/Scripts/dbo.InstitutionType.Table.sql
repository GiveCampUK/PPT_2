/****** Object:  Table [dbo].[InstitutionType]    Script Date: 10/22/2011 15:35:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF EXISTS(SELECT name FROM sysobjects WHERE name = N'InstitutionType' AND xtype='U')
	DROP TABLE InstitutionType

CREATE TABLE [dbo].[InstitutionType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](255) NULL,
	[ShortCode] [nvarchar](10) NULL,
 CONSTRAINT [PK_[InstitutionType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
