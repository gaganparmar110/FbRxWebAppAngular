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
    [Table("EducationDetails",Schema="dbo")]
    public partial class EducationDetail
    {
		#region EducationId Annotations

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [System.ComponentModel.DataAnnotations.Key]
		#endregion EducationId Annotations

        public int EducationId { get; set; }

		#region CourseName Annotations

        [Required]
        [MaxLength(100)]
		#endregion CourseName Annotations

        public string CourseName { get; set; }

		#region CollegeSchoolName Annotations

        [MaxLength(200)]
		#endregion CollegeSchoolName Annotations

        public string CollegeSchoolName { get; set; }

		#region UniversityBoardName Annotations

        [MaxLength(200)]
		#endregion UniversityBoardName Annotations

        public string UniversityBoardName { get; set; }

		#region City Annotations

        [MaxLength(50)]
		#endregion City Annotations

        public string City { get; set; }

		#region SchoolCollegeAO Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FBApplicationObjects","dbo","","SchoolCollegeAO")]
		#endregion SchoolCollegeAO Annotations

        public int SchoolCollegeAO { get; set; }

		#region CourseStartDate Annotations

        [Required]
		#endregion CourseStartDate Annotations

        public System.DateTime CourseStartDate { get; set; }

		#region CourseEndDate Annotations

        [Required]
		#endregion CourseEndDate Annotations

        public System.DateTime CourseEndDate { get; set; }

		#region UserId Annotations

        [Range(1,int.MaxValue)]
        [Required]
        [RelationshipTableAttribue("FacebookUsers","dbo","","UserId")]
		#endregion UserId Annotations

        public int UserId { get; set; }

		#region FBApplicationObject Annotations

        [ForeignKey(nameof(SchoolCollegeAO))]
        [InverseProperty(nameof(FBRxweb.Models.Main.FBApplicationObject.EducationDetails))]
		#endregion FBApplicationObject Annotations

        public virtual FBApplicationObject FBApplicationObject { get; set; }

		#region FacebookUser Annotations

        [ForeignKey(nameof(UserId))]
        [InverseProperty(nameof(FBRxweb.Models.Main.FacebookUser.EducationDetails))]
		#endregion FacebookUser Annotations

        public virtual FacebookUser FacebookUser { get; set; }


        public EducationDetail()
        {
        }
	}
}