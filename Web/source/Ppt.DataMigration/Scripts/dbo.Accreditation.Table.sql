/****** Object:  Table [dbo].[Accreditation]    Script Date: 10/22/2011 15:35:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF EXISTS(SELECT name FROM sysobjects WHERE name = N'Accreditation' AND xtype='U')
	DROP TABLE Accreditation

CREATE TABLE [dbo].[Accreditation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TeacherId] [int] NULL,
	[Accreditation] [nvarchar](255) NULL,
	[Date] [nvarchar](255) NULL,
	[Notes] [text] NULL,
 CONSTRAINT [PK_Accreditation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Accreditation]  WITH CHECK ADD  CONSTRAINT [FK_Accreditation_Contacts] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Contacts] ([Id])
GO
ALTER TABLE [dbo].[Accreditation] CHECK CONSTRAINT [FK_Accreditation_Contacts]
GO
