CREATE TABLE FacebookUsers(
	[UserID] [int] IDENTITY(1,1) NOT NULL  PRIMARY KEY,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[MobileNo] [bigint] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Password] [varchar](200) NOT NULL,
	[DateOfBirth] [date] NOT NULL,
	[GenderAO] [int] NOT NULL,
	[CreatedDateTime] [datetimeoffset](7) NOT NULL,
	[LoginStatus] [bit] NOT NULL);

------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[Posts](
	[PostId] [int] IDENTITY(1,1) NOT NULL Primary key,
	[UserId] [int] NOT NULL,
	[Media] [varchar](max) NOT NULL,
	[CreatedDateTime] [datetimeoffset](7) NOT NULL,
	[MediaTypeAO] [int] NOT NULL)

------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[PostCaptions](
	[PostCaptionId] [int] IDENTITY(1,1) NOT NULL Primary key,
	[Caption] [varchar](max) NOT NULL,
	[PostId] [int] NOT NULL)

--------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[PostMessages](
	[PostMessageId] [int] IDENTITY(1,1) NOT NULL Primary key,
	[Message] [varchar](max) NOT NULL,
	[UserId] [int] NOT NULL,
	[PostDateTime] [datetimeoffset](7) NOT NULL)

--------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[ChatMedia](
	[ChatMediaId] [int] IDENTITY(1,1) NOT NULL primary key,
	[Media] [varchar](max) NOT NULL,
	[MediaTypeAO] [int] NOT NULL,
	[SenderId] [int] NOT NULL,
	[ReceiverId] [int] NOT NULL,
	[SendDateTime] [datetimeoffset](7) NOT NULL)

----------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[ChatMessages](
	[ChatMessageId] [int] IDENTITY(1,1) NOT NULL primary key,
	[Message] [varchar](max) NOT NULL,
	[SenderId] [int] NOT NULL,
	[ReceiverId] [int] NOT NULL,
	[SendDateTime] [datetimeoffset](7) NOT NULL)

-----------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[CoverPhotos](
	[CoverPhotoId] [int] IDENTITY(1,1) NOT NULL primary key,
	[Photo] [varchar](max) NOT NULL,
	[UserId] [int] NOT NULL)

------------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[EducationDetails](
	[EducationId] [int] IDENTITY(1,1) NOT NULL primary key,
	[CourseName] [varchar](100) NOT NULL,
	[CollegeSchoolName] [varchar](200) NULL,
	[UniversityBoardName] [varchar](200) NULL,
	[City] [varchar](50) NULL,
	[SchoolCollegeAO] [int] NOT NULL,
	[CourseStartDate] [date] NOT NULL,
	[CourseEndDate] [date] NOT NULL,
	[UserId] [int] NOT NULL)

--------------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[FBApplicationObjects](
	[ApplicationObjectId] [int] IDENTITY(1,1) NOT NULL primary key,
	[ApplicationObjectTypeId] [int] NOT NULL,
	[ApplicationObjectName] [varchar](50) NOT NULL)

----------------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[FBApplicationObjectTypes](
	[ApplicationObjectITypeId] [int] IDENTITY(1,1) NOT NULL primary key,
	[ApplicationObjectTypeName] [varchar](50) NOT NULL)

-----------------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[LogActivities](
	[LogActivityId] [int] IDENTITY(1,1) NOT NULL primary key,
	[UserId] [int] NOT NULL)

-----------------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[PostComments](
	[CommentId] [int] IDENTITY(1,1) NOT NULL primary key,
	[Comment] [varchar](max) NOT NULL,
	[PostId] [int] NOT NULL,
	[UserId] [int] NOT NULL)

-------------------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[PostLikes](
	[LikeId] [int] IDENTITY(1,1) NOT NULL primary key,
	[PostId] [int] NOT NULL,
	[UserId] [int] NOT NULL)

-----------------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[PostShares](
	[ShareId] [int] IDENTITY(1,1) NOT NULL primary key,
	[PostId] [int] NOT NULL,
	[UserId] [int] NOT NULL)

---------------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[ProfilePhotos](
	[ProfilePhotoId] [int] IDENTITY(1,1) NOT NULL primary key,
	[Photo] [varchar](max) NOT NULL,
	[UserId] [int] NOT NULL)

-----------------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[FacebookUserDetails](
	[UserDetailId] [int] IDENTITY(1,1) NOT NULL primary key,
	[UserId] [int] NOT NULL,
	[CurrentCity] [varchar](30) NULL,
	[HomeTown] [varchar](50) NULL,
	[RelationshipAO] [int] NULL,
	[Bio] [varchar](max) NULL,
	[ProfilePhotoId] [int] NULL,
	[CoverPhotoId] [int] NULL)

----------------------------------------------------------------------------------------------------------------

CREATE TABLE [dbo].[FacebookUserWorks](
	[UserWorkId] [int] IDENTITY(1,1) NOT NULL primary key,
	[WorkName] [varchar](100) NOT NULL,
	[WorkDescription] [varchar](max) NULL,
	[UserId] [int] NOT NULL,
	[WorkStartDate] [date] NULL,
	[WorkEndDate] [date] NULL)

----------------------------------------------------------------------------------------------------------------

create Procedure [dbo].[spChatListUsers] @id int as
select Distinct Firstname as Name   from FacebookUsers,ChatMessages where senderId=@id and ReceiverId=UserID Union 
select Distinct firstName  from ChatMessages,facebookUsers where receiverId=@id and senderId=UserID;
GO

------------------------------------------------------------------------------------------------------------------

CREATE procedure [dbo].[spOneToOneChats] @sender int,@receiver int as
(select Firstname as Sender,Media,Chatmedia.SendDateTime  from ChatMedia,FacebookUsers 
where ((ChatMedia.senderId=@receiver and ChatMedia.receiverId=@sender) or (ChatMedia.SenderId=@sender and ChatMedia.ReceiverId=@receiver)) 
and ChatMedia.SenderId=userid) UNION
(select Firstname as Sender, Message,ChatMessages.SendDateTime  from ChatMessages,FacebookUsers 
where ((ChatMessages.senderId=@receiver and ChatMessages.receiverId=@sender) or (ChatMessages.senderId=@sender and ChatMessages.receiverId=@receiver)) 
and ChatMessages.SenderId=UserID) Order by SendDateTime;
GO

------------------------------------------------------------------------------------------------------------------

create view vAllOnlineUserList as select Firstname from FacebookUsers where LoginStatus=1;