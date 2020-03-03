using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using FBRxweb.BoundedContext.SqlContext;
namespace FBRxweb.Models.Main
{
    [Table("vUserPostDisplay",Schema="dbo")]
    public partial class vUserPostDisplay
    {

        public string FirstName { get; set; }


        public string Comment { get; set; }


        public string Caption { get; set; }


        public string Media { get; set; }


        public vUserPostDisplay()
        {
        }
	}
}