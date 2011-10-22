/****** Object:  Table [dbo].[Classes]    Script Date: 10/22/2011 15:35:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Classes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[TeacherId] [int] NULL,
	[PrisonId] [int] NULL,
	[ClassDetails] [text] NULL,
	[Notes] [text] NULL,
	[ClassMakeup] [nvarchar](255) NULL,
	[ClassGender] [nvarchar](255) NULL,
	[DoNotCount] [bit] NULL,
	[DateClassStarted] [nvarchar](255) NULL,
	[DateClassStopped] [nvarchar](255) NULL,
	[DrugClass] [bit] NULL,
 CONSTRAINT [PK_Classes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Classes]  WITH CHECK ADD  CONSTRAINT [FK_Classes_Contacts] FOREIGN KEY([TeacherId])
REFERENCES [dbo].[Contacts] ([Id])
GO
ALTER TABLE [dbo].[Classes] CHECK CONSTRAINT [FK_Classes_Contacts]
GO
ALTER TABLE [dbo].[Classes]  WITH CHECK ADD  CONSTRAINT [FK_Classes_Prison] FOREIGN KEY([PrisonId])
REFERENCES [dbo].[Prison] ([Id])
GO
ALTER TABLE [dbo].[Classes] CHECK CONSTRAINT [FK_Classes_Prison]
GO
