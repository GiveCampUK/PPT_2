/****** Object:  Table [dbo].[ResponseType]    Script Date: 10/22/2011 15:35:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ResponseType](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Response] [nvarchar](255) NULL,
	[Cost] [float] NULL,
	[Destination] [nvarchar](255) NULL,
	[Postage] [float] NULL,
	[Stationary] [float] NULL,
 CONSTRAINT [PK_ResponseType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
