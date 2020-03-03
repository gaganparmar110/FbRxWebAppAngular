using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using FBRxweb.BoundedContext.SqlContext;
namespace FBRxweb.Models.Main
{
    [Table("vAllOnlineUserList",Schema="dbo")]
    public partial class vAllOnlineUserList
    {

        public string Firstname { get; set; }


        public vAllOnlineUserList()
        {
        }
	}
}