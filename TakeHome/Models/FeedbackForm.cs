using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TakeHome.Models
{
    /// <summary>
    /// The model for the Feedback page.
    /// </summary>
    public class FeedbackForm : Base
    {
        /// <summary>
        /// The default minimum character length for most fields.
        /// </summary>
        public const int MinimumLength = 2;

        /// <summary>
        /// The default maximum character length for most fields.
        /// </summary>
        public const int MaximumLength = 25;

        /// <summary>
        /// The First Name field.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your first name.")]
        [StringLength(MaximumLength, MinimumLength = MinimumLength, ErrorMessage = "First Name must be between 2 and 25 characters.")]
        [DisplayName("* First Name")]
        public String FirstName
        {
            get;
            set;
        }

        /// <summary>
        /// The Last Name field.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your last name.")]
        [StringLength(25, MinimumLength = 2, ErrorMessage = "First Name must be between 2 and 25 characters.")]
        [DisplayName("* Last Name")]
        public String LastName
        {
            get;
            set;
        }

        /// <summary>
        /// The Email field.
        /// </summary>
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your email address.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please enter a valid email address.")]
        [StringLength(MaximumLength, MinimumLength = 6, ErrorMessage = "Email address must be between 6 and 25 characters.")]
        [DisplayName("* Email Address")]
        public String Email
        {
            get;
            set;
        }

        /// <summary>
        /// The Feedback field.
        /// </summary>
        [DataType(DataType.MultilineText)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide your feedback.")]
        [StringLength(200, MinimumLength = MinimumLength, ErrorMessage = "Feedback comments must be between 2 and 200 characters.")]
        [DisplayName("* Feedback")]
        public string Feedback { get; set; }



    }
}