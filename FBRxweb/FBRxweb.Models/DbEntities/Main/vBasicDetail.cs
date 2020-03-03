using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using FBRxweb.BoundedContext.SqlContext;
namespace FBRxweb.Models.Main
{
    [Table("vBasicDetails",Schema="dbo")]
    public partial class vBasicDetail
    {

        public string FirstName { get; set; }


        public string CurrentCity { get; set; }


        public Nullable<int> RelationshipAO { get; set; }


        public string Bio { get; set; }


        public Nullable<int> ProfilePhotoId { get; set; }


        public Nullable<int> CoverPhotoId { get; set; }


        public vBasicDetail()
        {
        }
	}
}