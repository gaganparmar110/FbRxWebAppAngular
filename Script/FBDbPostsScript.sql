alter procedure spPostLikeCommentShares as 
select count (PostId) from PostComments where PostId=2;
select count (PostId) from PostLikes where PostId=2;
select count (PostId) from PostShares where PostId=2;

create procedure spDisplayPosts as
(select PostId,FirstName,Media as Posts, Posts.CreatedDateTime as PostDateTime from Posts,FacebookUsers 
where Posts.UserId=FacebookUsers.UserID)
union
(select PostMessageId as PopstId,FirstName,Message,PostDateTime from PostMessages,FacebookUsers
where PostMessages.UserId=FacebookUsers.UserID ) order by PostDateTime

create procedure spPostMessageLikeCommentShares as 
select count (PostMessageComments.PostMessageId) as Comments,count (PostMessageLikes.PostMessageId),count (PostMessageShares.PostMessageId) 
from PostMessageComments,PostMessageLikes,PostMessageShares where PostMessageComments.PostMessageId=2 or
PostMessageLikes.PostMessageId=2 or PostMessageShares.PostMessageId=2;

insert into Posts values (4,'video2',GETDATE(),7)
insert into PostMessages values('Hello',4,GETDATE())


select count (PostComments.PostId) as Comments,count (PostLikes.PostId) as Likes,count (PostShares.PostId) as Shares
from PostComments,PostLikes,PostShares where PostComments.PostId=5 or
PostLikes.PostId=5 or PostShares.PostId=5;

select * from PostLikes
select * from PostComments
select * from PostShares

alter Procedure spTempPosts as
declare @count int 
	select @count=count(PostId) from Posts,FacebookUsers where Posts.UserId=FacebookUsers.UserID
	print @count
	DECLARE @cnt INT = 0;
	WHILE @cnt < @count
	BEGIN
		declare @id int
		select @id=PostId from Posts where PostId=@cnt+1 ;
		print @id
		declare @totallike int
		select @totallike=count(PostId) from PostLikes where PostId=@cnt+1 ;
		print @totallike
		declare @totalcomment int
		select @totalcomment=count(PostId) from PostComments where PostId=@cnt+1 ;
		print @totalcomment
		declare @totalshare int
		select @totalshare=count(PostId) from PostShares where PostId=@cnt+1 ;
		print @totalshare
	   SET @cnt = @cnt + 1;
	END;

exec spTempPosts
select * from Posts


	select PostId,FirstName,Media as Posts, Posts.CreatedDateTime as PostDateTime from Posts,FacebookUsers 
	where Posts.UserId=FacebookUsers.UserID

CREATE NONCLUSTERED INDEX IndexPostId
ON [dbo].[Posts] ([PostId])

drop index IndexPostId on Posts

alter procedure spTotalCommentOnPost @id int as
select count(PostId) as Comments from PostComments,FacebookUsers where PostId=@id and PostComments.UserId=FacebookUsers.UserID;

create procedure spTotalLikeOnPost @id int as
select count(PostId) as Likes from PostLikes,FacebookUsers where PostId=@id and PostLikes.UserId=FacebookUsers.UserID;

create procedure spTotalShareOnPost @id int as
select count(PostId) as Shares from PostShares,FacebookUsers where PostId=@id and PostShares.UserId=FacebookUsers.UserID;

create procedure spTotalMessageShareOnPost @id int as
select count(PostMessageId) as Shares from PostMessageShares,FacebookUsers where PostMessageId=@id and PostMessageShares.UserId=FacebookUsers.UserID;

create procedure spTotalMessageCommentOnPost @id int as
select count(PostMessageId) as Shares from PostMessageComments,FacebookUsers where PostMessageId=@id and PostMessageComments.UserId=FacebookUsers.UserID;

alter procedure spTotalMessageLikeOnPost @id int as
select count(PostMessageId) as Shares from PostMessageLikes,FacebookUsers where PostMessageId=@id and PostMessageLikes.UserId=FacebookUsers.UserID;

