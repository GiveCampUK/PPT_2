/****** Object:  Table [dbo].[WorkshopTeachers]    Script Date: 10/22/2011 15:35:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF EXISTS(SELECT name FROM sysobjects WHERE name = N'WorkshopTeachers' AND xtype='U')
	DROP TABLE WorkshopTeachers

CREATE TABLE [dbo].[WorkshopTeachers](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TeacherId] [int] NULL,
	[Workshop] [nvarchar](255) NULL,
	[Date] [nvarchar](255) NULL,
	[Notes] [nvarchar](255) NULL,
 CONSTRAINT [PK_WorkshopTeachers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[WorkshopTeachers]  WITH CHECK ADD  CONSTRAINT [FK_WorkshopTeachers_Contacts] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Contacts] ([Id])
GO
ALTER TABLE [dbo].[WorkshopTeachers] CHECK CONSTRAINT [FK_WorkshopTeachers_Contacts]
GO
