create procedure spInsertChats @sender int ,@receiver int as
insert into Chats(Chat,SenderId,ReceiverId,SendDateTime) (select Media as chat,senderId,ReceiverId,Chatmedia.SendDateTime  from ChatMedia,FacebookUsers 
where ((ChatMedia.senderId=@receiver and ChatMedia.receiverId=@sender) or (ChatMedia.SenderId=@sender and ChatMedia.ReceiverId=@receiver)) 
and ChatMedia.SenderId=userid) UNION
(select Message as chat,senderId,ReceiverId,ChatMessages.SendDateTime  from ChatMessages,FacebookUsers 
where ((ChatMessages.senderId=@receiver and ChatMessages.receiverId=@sender) or (ChatMessages.senderId=@sender and ChatMessages.receiverId=@receiver)) 
and ChatMessages.SenderId=UserID) Order by SendDateTime;

exec spInsertChats 1,2

(select Firstname as Sender, chat,SendDateTime  from Chats,FacebookUsers 
where ((Chats.senderId=2 and Chats.receiverId=1) or (Chats.senderId=1 and Chats.receiverId=2)) 
and Chats.SenderId=UserID)



ALTER Procedure [dbo].[spChatListUsers] @id int as
select(
select Distinct Firstname as Name from Chats,FacebookUsers 
where ((Chats.senderId=@id and Chats.receiverId=UserID) or (Chats.senderId=UserId and Chats.receiverId=@id)) 
and Chats.SenderId=UserID for json path)as result
-----------------------------------------------------------------------------------------------------
 use FBDb

create procedure spInsertChatMedia @senderid int ,@receiverid int ,@chat varchar(max) as 
	insert into ChatMedia values (@chat ,@senderid,@receiverid,GETDATE());
	insert into Chats values (@chat,@senderid,@receiverid,GETDATE());

create procedure spInsertChatMessage @senderid int ,@receiverid int ,@chat varchar(max) as 
	insert into ChatMedia values (@chat ,@senderid,@receiverid,GETDATE());
	insert into Chats values (@chat,@senderid,@receiverid,GETDATE());

--------------------------------------------------------------------------------------------------------

alter procedure spUserChats @sender int,@receiver int as
select(
select Firstname as Sender, chat,SendDateTime  from Chats,FacebookUsers 
where ((Chats.senderId=@sender and Chats.receiverId=@receiver) or (Chats.senderId=@receiver and Chats.receiverId=@sender)) 
and Chats.SenderId=UserID for json path) as result

exec spUserChats 2,3


--------------------------------------------------------------------------------------------------------------
use FBDb
ALTER procedure [dbo].[spDisplayPosts] as
insert into Posts (Post,UserId,CreatedDateTime) select Media as Post,PostMedias.UserId, PostMedias.CreatedDateTime  from PostMedias,FacebookUsers 
where PostMedias.UserId=FacebookUsers.UserID
Union (select Message as Post,PostMessages.UserId,PostMessages.CreatedDateTime from PostMessages,FacebookUsers
where PostMessages.UserId=FacebookUsers.UserID ) Order by CreatedDateTime;

exec spDisplayPosts

select * from Posts
--------------------------------------------------------------------------------------------------------------

create procedure spInsertPostMedias @userid int ,@post varchar(max) as 
	insert into PostMedias values (@post,@userid,GETDATE())
	insert into Posts(Post,UserId,CreatedDateTime) values (@post,@userid,GETDATE())

create procedure spInsertPostMessages @userid int ,@post varchar(max) as 
	insert into PostMessages values (@post,@userid,GETDATE())
	insert into Posts(Post,UserId,CreatedDateTime) values (@post,@userid,GETDATE())

alter view vAllPosts as
select Posts.UserId,PostId,FirstName as UserName,Post,TotalLike,TotalComment,TotalShare,Posts.CreatedDateTime from FacebookUsers,Posts where Posts.UserId=FacebookUsers.UserID

select * from vAllPosts where UserId=2

-----------------------------------------------------------------------------------------------------------------------
use FBDb
alter Procedure spInsertLike @userid int, @postid int as
	insert into PostLikes values (@userid,@postid)
	declare @totalLike int
	select @totalLike=count(@postid)  from PostLikes where PostId=@postid
	update Posts set TotalLike=@totalLike where PostId=@postid

exec spInsertLike 4,14



create Procedure spInsertComment  @comment varchar(max), @userid int, @postid int as
	insert into PostComments values (@comment,@userid,@postid)
	declare @totalComment int
	select @totalComment=count(@postid)  from PostComments where PostId=@postid
	update Posts set TotalComment=@totalComment where PostId=@postid

exec spInsertComment 'I Like It', 2,13

create Procedure spInsertShare @userid int, @postid int as
	insert into PostShares values (@userid,@postid)
	declare @totalShare int
	select @totalShare=count(@postid)  from PostShares where PostId=@postid
	update Posts set TotalShare=@totalShare where PostId=@postid

exec spInsertShare 3,18

select * from vAllPosts

create view vCheckLikeUsers as 
select Distinct FirstName as UserName,PostId from PostLikes,FacebookUsers where FacebookUsers.UserID=PostLikes.UserId

select * from vCheckLikeUsers where PostId=14

create view vCheckCommentUsers as 
select Distinct FirstName as UserName,PostId,Comment from PostComments,FacebookUsers where FacebookUsers.UserID=PostComments.UserId

select * from vCheckCommentUsers where PostId=13

create view vCheckShareUsers as 
select Distinct FirstName as UserName,PostId from PostShares,FacebookUsers where FacebookUsers.UserID=PostShares.UserId

select * from vCheckShareUsers where PostId=15

