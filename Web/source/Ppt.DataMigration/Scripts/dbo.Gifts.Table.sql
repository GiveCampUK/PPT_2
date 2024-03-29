/****** Object:  Table [dbo].[Gifts]    Script Date: 10/22/2011 15:35:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF EXISTS(SELECT name FROM sysobjects WHERE name = N'Gifts' AND xtype='U')
	DROP TABLE Gifts

CREATE TABLE [dbo].[Gifts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[GiftType] [int] NULL,
	[Amount] [float] NULL,
	[Source] [text] NULL,
	[Purpose] [text] NULL,
	[Contact] [int] NULL,
 CONSTRAINT [PK_Gifts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Gifts]  WITH CHECK ADD  CONSTRAINT [FK_Gifts_GiftType] FOREIGN KEY([GiftType])
REFERENCES [dbo].[GiftType] ([Id])
GO
ALTER TABLE [dbo].[Gifts] CHECK CONSTRAINT [FK_Gifts_GiftType]
GO
