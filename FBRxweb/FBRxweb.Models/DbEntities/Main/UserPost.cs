using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using FBRxweb.Models.Enums.Main;
using FBRxweb.BoundedContext.SqlContext;
namespace FBRxweb.Models.Main
{
    [Table("UserPosts",Schema="dbo")]
    public partial class UserPost
    {
		#region PostId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion PostId Annotations

        public int PostId { get; set; }

		#region Post Annotations

        [Required]
		#endregion Post Annotations

        public string Post { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FacebookUsers","dbo","","UserId")]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region CreatedDateTime Annotations

        [Required]
		#endregion CreatedDateTime Annotations

        public System.DateTimeOffset CreatedDateTime { get; set; }

		#region TotalLike Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion TotalLike Annotations

        public int TotalLike { get; set; }

		#region TotalComment Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion TotalComment Annotations

        public int TotalComment { get; set; }

		#region TotalShare Annotations

        [Range(1,int.MaxValue)]
        [Required]
		#endregion TotalShare Annotations

        public int TotalShare { get; set; }

		#region FacebookUser Annotations

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.FacebookUser.UserPosts))]
		#endregion FacebookUser Annotations

        public virtual FacebookUser FacebookUser { get; set; }

		#region PostShares Annotations

        [InverseProperty("UserPost")]
		#endregion PostShares Annotations

        public virtual ICollection<PostShare> PostShares { get; set; }

		#region PostLikes Annotations

        [InverseProperty("UserPost")]
		#endregion PostLikes Annotations

        public virtual ICollection<PostLike> PostLikes { get; set; }

		#region PostComments Annotations

        [InverseProperty("UserPost")]
		#endregion PostComments Annotations

        public virtual ICollection<PostComment> PostComments { get; set; }


        public UserPost()
        {
			PostShares = new HashSet<PostShare>();
			PostLikes = new HashSet<PostLike>();
			PostComments = new HashSet<PostComment>();
        }
	}
}