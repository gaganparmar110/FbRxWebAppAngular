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
    [Table("UserChats",Schema="dbo")]
    public partial class UserChat
    {
		#region ChatId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion ChatId Annotations

        public int ChatId { get; set; }

		#region Chat Annotations

        [Required]
		#endregion Chat Annotations

        public string Chat { get; set; }

		#region SenderId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FacebookUsers","dbo","","SenderId")]
		#endregion SenderId Annotations

        public int SenderId { get; set; }

		#region ReceiverId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FacebookUsers","dbo","","ReceiverId")]
		#endregion ReceiverId Annotations

        public int ReceiverId { get; set; }

		#region SendDateTime Annotations

        [Required]
		#endregion SendDateTime Annotations

        public System.DateTimeOffset SendDateTime { get; set; }

		#region FacebookUser Annotations

        [ForeignKey(nameof(ReceiverId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.FacebookUser.UserChats))]
		#endregion FacebookUser Annotations

        public virtual FacebookUser FacebookUser { get; set; }

		#region FacebookUser1 Annotations

        [ForeignKey(nameof(SenderId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.FacebookUser.UserChats1))]
		#endregion FacebookUser1 Annotations

        public virtual FacebookUser FacebookUser1 { get; set; }


        public UserChat()
        {
        }
	}
}