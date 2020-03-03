USE [FBDb]
GO

/****** Object:  Table [dbo].[PostLikes]    Script Date: 28-02-2020 13:52:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PostLikes](
	[PostLikeId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[PostId] [int] NOT NULL,
 CONSTRAINT [PK_PostLikes] PRIMARY KEY CLUSTERED 
(
	[PostLikeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PostLikes]  WITH CHECK ADD  CONSTRAINT [FK_PostLikes_FacebookUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[FacebookUsers] ([UserID])
GO

ALTER TABLE [dbo].[PostLikes] CHECK CONSTRAINT [FK_PostLikes_FacebookUsers]
GO

ALTER TABLE [dbo].[PostLikes]  WITH CHECK ADD  CONSTRAINT [FK_PostLikes_Posts] FOREIGN KEY([PostId])
REFERENCES [dbo].[Posts] ([PostId])
GO

ALTER TABLE [dbo].[PostLikes] CHECK CONSTRAINT [FK_PostLikes_Posts]
GO

