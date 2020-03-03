USE [FBDb]
GO

/****** Object:  Table [dbo].[Chats]    Script Date: 28-02-2020 13:57:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Chats](
	[ChatId] [int] IDENTITY(1,1) NOT NULL,
	[Chat] [varchar](max) NOT NULL,
	[SenderId] [int] NOT NULL,
	[ReceiverId] [int] NOT NULL,
	[SendDateTime] [datetimeoffset](7) NOT NULL,
 CONSTRAINT [PK_Chats] PRIMARY KEY CLUSTERED 
(
	[ChatId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Chats]  WITH CHECK ADD  CONSTRAINT [FK_Chats_Receiver] FOREIGN KEY([ReceiverId])
REFERENCES [dbo].[FacebookUsers] ([UserID])
GO

ALTER TABLE [dbo].[Chats] CHECK CONSTRAINT [FK_Chats_Receiver]
GO

ALTER TABLE [dbo].[Chats]  WITH CHECK ADD  CONSTRAINT [FK_Chats_Sender] FOREIGN KEY([SenderId])
REFERENCES [dbo].[FacebookUsers] ([UserID])
GO

ALTER TABLE [dbo].[Chats] CHECK CONSTRAINT [FK_Chats_Sender]
GO

