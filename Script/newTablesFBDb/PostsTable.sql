USE [FBDb]
GO

/****** Object:  Table [dbo].[Posts]    Script Date: 28-02-2020 13:52:39 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Posts](
	[PostId] [int] IDENTITY(1,1) NOT NULL,
	[Post] [varchar](max) NOT NULL,
	[UserId] [int] NOT NULL,
	[CreatedDateTime] [datetimeoffset](7) NOT NULL,
	[TotalLike] [int] NOT NULL,
	[TotalComment] [int] NOT NULL,
	[TotalShare] [int] NOT NULL,
 CONSTRAINT [PK_FacebookUserPosts] PRIMARY KEY CLUSTERED 
(
	[PostId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[Posts] ADD  CONSTRAINT [DF_Posts_TotalLike]  DEFAULT ((0)) FOR [TotalLike]
GO

ALTER TABLE [dbo].[Posts] ADD  CONSTRAINT [DF_Posts_TotalComment]  DEFAULT ((0)) FOR [TotalComment]
GO

ALTER TABLE [dbo].[Posts] ADD  CONSTRAINT [DF_Posts_TotalShare]  DEFAULT ((0)) FOR [TotalShare]
GO

ALTER TABLE [dbo].[Posts]  WITH CHECK ADD  CONSTRAINT [FK_FacebookUserPosts_FacebookUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[FacebookUsers] ([UserID])
GO

ALTER TABLE [dbo].[Posts] CHECK CONSTRAINT [FK_FacebookUserPosts_FacebookUsers]
GO

