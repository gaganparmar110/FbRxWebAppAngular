using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using FBRxweb.BoundedContext.SqlContext;
namespace FBRxweb.Models.Main
{
    [Table("vDisplayPost",Schema="dbo")]
    public partial class vDisplayPost
    {
		#region PostId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion PostId Annotations

        public int PostId { get; set; }


        public string FirstName { get; set; }


        public string Posts { get; set; }


        public System.DateTimeOffset PostDateTime { get; set; }


        public vDisplayPost()
        {
        }
	}
}