USE [FBDb]
GO

/****** Object:  Table [dbo].[PostMedias]    Script Date: 28-02-2020 13:52:11 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PostMedias](
	[PostId] [int] IDENTITY(1,1) NOT NULL,
	[Media] [varchar](max) NOT NULL,
	[UserId] [int] NOT NULL,
	[CreatedDateTime] [datetimeoffset](7) NOT NULL,
 CONSTRAINT [PK__Posts__AA12601865E098B2] PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[PostMedias]  WITH CHECK ADD  CONSTRAINT [FK_Posts_FacebookUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[FacebookUsers] ([UserID])
GO

ALTER TABLE [dbo].[PostMedias] CHECK CONSTRAINT [FK_Posts_FacebookUsers]
GO

