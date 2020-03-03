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
    [Table("FacebookUserDetails",Schema="dbo")]
    public partial class FacebookUserDetail
    {
		#region UserDetailId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion UserDetailId Annotations

        public int UserDetailId { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FacebookUsers","dbo","","UserId")]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region CurrentCity Annotations

        [MaxLength(30)]
		#endregion CurrentCity Annotations

        public string CurrentCity { get; set; }

		#region HomeTown Annotations

        [MaxLength(50)]
		#endregion HomeTown Annotations

        public string HomeTown { get; set; }

		#region RelationshipAO Annotations

        [RelationshipTableAttribue("FBApplicationObjects","dbo","","RelationshipAO")]
		#endregion RelationshipAO Annotations

        public Nullable<int> RelationshipAO { get; set; }


        public string Bio { get; set; }

		#region ProfilePhotoId Annotations

        [RelationshipTableAttribue("ProfilePhotos","dbo","","ProfilePhotoId")]
		#endregion ProfilePhotoId Annotations

        public Nullable<int> ProfilePhotoId { get; set; }

		#region CoverPhotoId Annotations

        [RelationshipTableAttribue("CoverPhotos","dbo","","CoverPhotoId")]
		#endregion CoverPhotoId Annotations

        public Nullable<int> CoverPhotoId { get; set; }

		#region CoverPhoto Annotations

        [ForeignKey(nameof(CoverPhotoId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.CoverPhoto.FacebookUserDetails))]
		#endregion CoverPhoto Annotations

        public virtual CoverPhoto CoverPhoto { get; set; }

		#region FacebookUser Annotations

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.FacebookUser.FacebookUserDetails))]
		#endregion FacebookUser Annotations

        public virtual FacebookUser FacebookUser { get; set; }

		#region FBApplicationObject Annotations

        [ForeignKey(nameof(RelationshipAO))]
        [InverseProperty(nameof(FBRxweb.Models.Main.FBApplicationObject.FacebookUserDetails))]
		#endregion FBApplicationObject Annotations

        public virtual FBApplicationObject FBApplicationObject { get; set; }

		#region ProfilePhoto Annotations

        [ForeignKey(nameof(ProfilePhotoId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.ProfilePhoto.FacebookUserDetails))]
		#endregion ProfilePhoto Annotations

        public virtual ProfilePhoto ProfilePhoto { get; set; }


        public FacebookUserDetail()
        {
        }
	}
}