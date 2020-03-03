using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using FBRxweb.BoundedContext.SqlContext;
namespace FBRxweb.Models.Main
{
    [Table("vAllPosts",Schema="dbo")]
    public partial class vAllPost
    {
		#region UserId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion UserId Annotations

        public int UserId { get; set; }


        public int PostId { get; set; }


        public string UserName { get; set; }


        public string Post { get; set; }


        public int TotalLike { get; set; }


        public int TotalComment { get; set; }


        public int TotalShare { get; set; }


        public System.DateTimeOffset CreatedDateTime { get; set; }


        public vAllPost()
        {
        }
	}
}