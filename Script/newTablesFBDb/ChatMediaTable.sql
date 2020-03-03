USE [FBDb]
GO

/****** Object:  Table [dbo].[ChatMedia]    Script Date: 28-02-2020 13:58:03 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[ChatMedia](
	[ChatMediaId] [int] IDENTITY(1,1) NOT NULL,
	[Media] [varchar](max) NOT NULL,
	[SenderId] [int] NOT NULL,
	[ReceiverId] [int] NOT NULL,
	[SendDateTime] [datetimeoffset](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ChatMediaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[ChatMedia]  WITH CHECK ADD  CONSTRAINT [FK_ChatMedia_receiver] FOREIGN KEY([ReceiverId])
REFERENCES [dbo].[FacebookUsers] ([UserID])
GO

ALTER TABLE [dbo].[ChatMedia] CHECK CONSTRAINT [FK_ChatMedia_receiver]
GO

ALTER TABLE [dbo].[ChatMedia]  WITH CHECK ADD  CONSTRAINT [FK_ChatMedia_Sender] FOREIGN KEY([SenderId])
REFERENCES [dbo].[FacebookUsers] ([UserID])
GO

ALTER TABLE [dbo].[ChatMedia] CHECK CONSTRAINT [FK_ChatMedia_Sender]
GO

