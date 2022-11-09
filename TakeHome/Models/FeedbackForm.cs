using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TakeHome.Models
{
	public class FeedbackForm
	{
        [Display(Name = "First Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide First Name")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "First Name Should be min 1 and max 25 length")]
        public String FirstName
        {
            get;
            set;
        }

        [Display(Name = "Last Name")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Last Name")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "First Name Should be min 1 and max 25 length")]
        public String LastName
        {
            get;
            set;
        }

        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please Provide Valid Email")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Email")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "Email should be min 1 and max 25 length")]
        public String Email
        {
            get;
            set;
        }

        [DataType(DataType.MultilineText)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Comments")]
        [StringLength(200, ErrorMessage = "Comments should have a max length of 200")]
        public string Comments { get; set; }



	}
}