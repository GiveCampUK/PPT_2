/****** Object:  Table [dbo].[WorkshopPrisons]    Script Date: 10/22/2011 15:35:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF EXISTS(SELECT name FROM sysobjects WHERE name = N'WorkshopPrisons' AND xtype='U')
	DROP TABLE WorkshopPrisons

CREATE TABLE [dbo].[WorkshopPrisons](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PrisonId] [int] NULL,
	[Workshop] [nvarchar](255) NULL,
	[Date] [nvarchar](255) NULL,
	[Notes] [nvarchar](255) NULL,
 CONSTRAINT [PK_WorkshopPrisons] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[WorkshopPrisons]  WITH CHECK ADD  CONSTRAINT [FK_WorkshopPrisons_Prison] FOREIGN KEY([PrisonId])
REFERENCES [dbo].[Prison] ([Id])
GO
ALTER TABLE [dbo].[WorkshopPrisons] CHECK CONSTRAINT [FK_WorkshopPrisons_Prison]
GO
