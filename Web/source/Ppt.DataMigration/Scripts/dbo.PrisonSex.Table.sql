/****** Object:  Table [dbo].[PrisonSex]    Script Date: 10/22/2011 15:35:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF EXISTS(SELECT name FROM sysobjects WHERE name = N'PrisonSex' AND xtype='U')
	DROP TABLE PrisonSex

CREATE TABLE [dbo].[PrisonSex](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
 CONSTRAINT [PK_PrisonSex] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

INSERT INTO dbo.PrisonSex(Name) VALUES('M');
INSERT INTO dbo.PrisonSex(Name) VALUES('F');
INSERT INTO dbo.PrisonSex(Name) VALUES('M and F');