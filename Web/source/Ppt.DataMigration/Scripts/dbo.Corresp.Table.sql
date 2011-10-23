/****** Object:  Table [dbo].[Corresp]    Script Date: 10/22/2011 15:35:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF EXISTS(SELECT name FROM sysobjects WHERE name = N'Corresp' AND xtype='U')
	DROP TABLE Corresp

CREATE TABLE [dbo].[Corresp](
	[Corref] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NULL,
	[Refno] [int] NULL,
	[Date1] [date] NULL,
	[Type] [nvarchar](255) NULL,
	[Filing] [text] NULL,
	[Response] [int] NULL,
	[Destination] [nvarchar](255) NULL,
	[Correspondant] [nvarchar](255) NULL,
 CONSTRAINT [PK_Corresp] PRIMARY KEY CLUSTERED 
(
	[Corref] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Corresp]  WITH CHECK ADD  CONSTRAINT [FK_Corresp_Contacts] FOREIGN KEY([Response])
REFERENCES [dbo].[ResponseType] ([Id])
GO
ALTER TABLE [dbo].[Corresp] CHECK CONSTRAINT [FK_Corresp_Contacts]
GO
ALTER TABLE [dbo].[Corresp]  WITH CHECK ADD  CONSTRAINT [FK_Corresp_Corresp] FOREIGN KEY([Corref])
REFERENCES [dbo].[Contacts] ([Id])
GO
ALTER TABLE [dbo].[Corresp] CHECK CONSTRAINT [FK_Corresp_Corresp]
GO
