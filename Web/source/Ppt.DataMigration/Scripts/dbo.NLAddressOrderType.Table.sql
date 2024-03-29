/****** Object:  Table [dbo].[NLAddressOrderType]    Script Date: 10/22/2011 15:35:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF EXISTS(SELECT name FROM sysobjects WHERE name = N'NLAddressOrderType' AND xtype='U')
	DROP TABLE NLAddressOrderType

CREATE TABLE [dbo].[NLAddressOrderType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](255) NULL,
 CONSTRAINT [PK_NLAddressOrderType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


SET IDENTITY_INSERT dbo.NLAddressOrderType ON

INSERT INTO dbo.NLAddressOrderType(Id, Name) VALUES(1, 'ENGLAND PRISONS');
INSERT INTO dbo.NLAddressOrderType(Id, Name) VALUES(2, 'ENGLAND HOSPITALS');
INSERT INTO dbo.NLAddressOrderType(Id, Name) VALUES(3, 'EIRE PRISONS');
INSERT INTO dbo.NLAddressOrderType(Id, Name) VALUES(4, 'EIRE HOSPITALS');

SET IDENTITY_INSERT dbo.NLAddressOrderType OFF