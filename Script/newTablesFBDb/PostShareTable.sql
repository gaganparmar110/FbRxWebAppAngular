USE [FBDb]
GO

/****** Object:  Table [dbo].[PostShares]    Script Date: 28-02-2020 13:57:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PostShares](
	[PostShareId] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[PostId] [int] NOT NULL,
 CONSTRAINT [PK_PostShares] PRIMARY KEY CLUSTERED 
(
	[PostShareId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PostShares]  WITH CHECK ADD  CONSTRAINT [FK_PostShares_FacebookUsers] FOREIGN KEY([UserId])
REFERENCES [dbo].[FacebookUsers] ([UserID])
GO

ALTER TABLE [dbo].[PostShares] CHECK CONSTRAINT [FK_PostShares_FacebookUsers]
GO

ALTER TABLE [dbo].[PostShares]  WITH CHECK ADD  CONSTRAINT [FK_PostShares_Posts] FOREIGN KEY([PostId])
REFERENCES [dbo].[Posts] ([PostId])
GO

ALTER TABLE [dbo].[PostShares] CHECK CONSTRAINT [FK_PostShares_Posts]
GO

