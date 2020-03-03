using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using RxWeb.Core.Annotations;
using RxWeb.Core.Data.Annotations;
using RxWeb.Core.Sanitizers;
using FBRxweb.BoundedContext.SqlContext;
namespace FBRxweb.Models.Main
{
    [Table("vEducationDetails",Schema="dbo")]
    public partial class vEducationDetail
    {

        public string CourseName { get; set; }


        public string CollegeSchoolName { get; set; }


        public string UniversityBoardName { get; set; }


        public string ApplicationObjectName { get; set; }


        public string City { get; set; }

		#region UserId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion UserId Annotations

        public int UserId { get; set; }


        public vEducationDetail()
        {
        }
	}
}