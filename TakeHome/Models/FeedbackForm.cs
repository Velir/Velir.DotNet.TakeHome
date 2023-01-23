using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TakeHome.Models
{
	public class FeedbackForm
	{
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide First Name")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "First Name Should be min 1 and max 25 length")]
        public String FirstName
        {
            get;
            set;
        }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Last Name")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "Last Name Should be min 1 and max 25 length")]
        public String LastName
        {
            get;
            set;
        }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Eamil")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please Provide Valid Email")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "Email Should be min 1 and max 25 length")]
        public String Email
        {
            get;
            set;
        }

        [DataType(DataType.MultilineText)]
        [StringLength(200, MinimumLength = 0, ErrorMessage = "Comments should have a max length of 200")]
        public string Comments { get; set; }



	}
}
