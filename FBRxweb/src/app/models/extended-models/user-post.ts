import {UserPostBase} from '../database-models/user-post-base';
import {FacebookUserBase} from '../database-models/facebook-user-base';
import {PostCommentBase} from '../database-models/post-comment-base';
import {PostLikeBase} from '../database-models/post-like-base';
import {PostShareBase} from '../database-models/post-share-base';
//Generated Imports
export class UserPost extends UserPostBase 
{




//#region Generated Reference Properties
//#region facebookUser Prop
facebookUser : FacebookUserBase;
//#endregion facebookUser Prop
//#region postComments Prop
postComments : PostCommentBase[];
//#endregion postComments Prop
//#region postLikes Prop
postLikes : PostLikeBase[];
//#endregion postLikes Prop
//#region postShares Prop
postShares : PostShareBase[];
//#endregion postShares Prop

//#endregion Generated Reference Properties


}