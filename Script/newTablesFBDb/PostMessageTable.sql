USE [FBDb]
GO

/****** Object:  Table [dbo].[PostMessages]    Script Date: 28-02-2020 13:52:23 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PostMessages](
	[PostId] [int] IDENTITY(1,1) NOT NULL,
	[Message] [varchar](max) NOT NULL,
	[UserId] [int] NOT NULL,
	[CreatedDateTime] [datetimeoffset](7) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[PostMessages]  WITH CHECK ADD  CONSTRAINT [FK_PostMessages_FacebookUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[FacebookUsers] ([UserID])
GO

ALTER TABLE [dbo].[PostMessages] CHECK CONSTRAINT [FK_PostMessages_FacebookUsers]
GO

