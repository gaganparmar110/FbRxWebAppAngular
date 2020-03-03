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
    [Table("FBApplicationObjectTypes",Schema="dbo")]
    public partial class FBApplicationObjectType
    {
		#region ApplicationObjectITypeId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion ApplicationObjectITypeId Annotations

        public int ApplicationObjectITypeId { get; set; }

		#region ApplicationObjectTypeName Annotations

        [Required]
        [MaxLength(50)]
		#endregion ApplicationObjectTypeName Annotations

        public string ApplicationObjectTypeName { get; set; }

		#region FBApplicationObjects Annotations

        [InverseProperty("FBApplicationObjectType")]
		#endregion FBApplicationObjects Annotations

        public virtual ICollection<FBApplicationObject> FBApplicationObjects { get; set; }


        public FBApplicationObjectType()
        {
			FBApplicationObjects = new HashSet<FBApplicationObject>();
        }
	}
}