/****** Object:  Table [dbo].[Contacts]    Script Date: 10/22/2011 15:35:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

IF EXISTS(SELECT name FROM sysobjects WHERE name = N'Contacts' AND xtype='U')
	DROP TABLE Contacts

CREATE TABLE [dbo].[Contacts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OldRefNo] [int] NOT NULL,
	[OldDb] [nvarchar](255) NOT NULL,
	[Surname] [nvarchar](255) NULL,
	[Forename] [nvarchar](255) NULL,
	[Title] [int] NULL,
	[Position] [nvarchar](255) NULL,
	[MailName] [nvarchar](255) NULL,
	[Salutation] [nvarchar](255) NULL,
	[Type] [nvarchar](255) NULL,
	[EmailAddress] [nvarchar](255) NULL,
	[Source] [nvarchar](255) NULL,
	[DOB] [date] NULL,
	[MailCode] [int] NULL,
	[Lost] [datetime] NULL,
	[Deceased] [bit] NULL,
	[ArchivePrisonName] [nvarchar](255) NULL,
	[PNumber] [nvarchar](255) NULL,
	[Cell] [nvarchar](255) NULL,
	[Prevpris] [nvarchar](255) NULL,
	[Address1] [nvarchar](255) NULL,
	[Address2] [nvarchar](255) NULL,
	[Address3] [nvarchar](255) NULL,
	[Town] [int] NULL,
	[County] [nvarchar](255) NULL,
	[Country] [int] NULL,
	[Postcode] [nvarchar](255) NULL,
	[Tel] [nvarchar](255) NULL,
	[Fax] [nvarchar](255) NULL,
	[C_Date] [date] NULL,
	[A_Date] [date] NULL,
	[AmendTime] [date] NULL,
	[Memo] [text] NULL,
	[Type1] [nvarchar](255) NULL,
	[ArchivePrevPris1] [nvarchar](255) NULL,
	[XmasList] [bit] NULL,
	[XmasParty] [bit] NULL,
	[Wing] [nvarchar](255) NULL,
	[Status] [nvarchar](255) NULL,
	[AnnualReport] [bit] NULL,
	[Convenaters] [bit] NULL,
	[AnnualReviewOld] [nvarchar](255) NULL,
	[NoFundRaisingLetter] [bit] NULL,
	[NLCopiesRequired] [int] NULL,
	[NoNewsLetter] [bit] NULL,
	[DontSendEmail] [bit] NULL,
	[FrEvent] [bit] NULL,
	[GiftAidSetup] [bit] NULL,
	[GiftAidStartDate] [date] NULL,
	[GiftAidFormSent] [bit] NULL,
	[GiftAidFromSentDate] [date] NULL,
	[GiftAidNotApplicable] [bit] NULL,
	[BWY_Number] [nvarchar](255) NULL,
	[Prison] [int] NULL,
	[PersonType] [int] NULL,
	[PreviousPrison] [int] NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Contacts]  WITH CHECK ADD  CONSTRAINT [FK_Contacts_Country] FOREIGN KEY([Country])
REFERENCES [dbo].[Country] ([Id])
GO
ALTER TABLE [dbo].[Contacts] CHECK CONSTRAINT [FK_Contacts_Country]
GO
ALTER TABLE [dbo].[Contacts]  WITH CHECK ADD  CONSTRAINT [FK_Contacts_MailCode] FOREIGN KEY([MailCode])
REFERENCES [dbo].[MailCode] ([Id])
GO
ALTER TABLE [dbo].[Contacts] CHECK CONSTRAINT [FK_Contacts_MailCode]
GO
ALTER TABLE [dbo].[Contacts]  WITH CHECK ADD  CONSTRAINT [FK_Contacts_PersonType] FOREIGN KEY([PersonType])
REFERENCES [dbo].[PersonType] ([Id])
GO
ALTER TABLE [dbo].[Contacts] CHECK CONSTRAINT [FK_Contacts_PersonType]
GO
ALTER TABLE [dbo].[Contacts]  WITH CHECK ADD  CONSTRAINT [FK_Contacts_Prison] FOREIGN KEY([Prison])
REFERENCES [dbo].[Prison] ([Id])
GO
ALTER TABLE [dbo].[Contacts] CHECK CONSTRAINT [FK_Contacts_Prison]
GO
ALTER TABLE [dbo].[Contacts]  WITH CHECK ADD  CONSTRAINT [FK_Contacts_Titles] FOREIGN KEY([Title])
REFERENCES [dbo].[Titles] ([Id])
GO
ALTER TABLE [dbo].[Contacts] CHECK CONSTRAINT [FK_Contacts_Titles]
GO
ALTER TABLE [dbo].[Contacts]  WITH CHECK ADD  CONSTRAINT [FK_Contacts_Town] FOREIGN KEY([Town])
REFERENCES [dbo].[Town] ([Id])
GO
ALTER TABLE [dbo].[Contacts] CHECK CONSTRAINT [FK_Contacts_Town]
GO
