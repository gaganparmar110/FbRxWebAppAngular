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
    [Table("CoverPhotos",Schema="dbo")]
    public partial class CoverPhoto
    {
		#region CoverPhotoId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion CoverPhotoId Annotations

        public int CoverPhotoId { get; set; }

		#region Photo Annotations

        [Required]
		#endregion Photo Annotations

        public string Photo { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FacebookUsers","dbo","","UserId")]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region FacebookUser Annotations

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.FacebookUser.CoverPhotos))]
		#endregion FacebookUser Annotations

        public virtual FacebookUser FacebookUser { get; set; }

		#region FacebookUserDetails Annotations

        [InverseProperty("CoverPhoto")]
		#endregion FacebookUserDetails Annotations

        public virtual ICollection<FacebookUserDetail> FacebookUserDetails { get; set; }


        public CoverPhoto()
        {
			FacebookUserDetails = new HashSet<FacebookUserDetail>();
        }
	}
}