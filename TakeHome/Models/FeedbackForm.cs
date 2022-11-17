using System;
using System.ComponentModel.DataAnnotations;

namespace TakeHome.Models
{
    public class FeedbackForm
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = Constants.Forms.FeedBack.Errors.RequiredFirstName)]
        [StringLength(Constants.Forms.FeedBack.Validation.FirstNameMaxLengthInt, MinimumLength = Constants.Forms.FeedBack.Validation.FirstNameMinLengthInt, ErrorMessage = Constants.Forms.FeedBack.Errors.LengthFirstName)]
        [Display(Name = Constants.Forms.FeedBack.Display.FirstName)]
        public String FirstName
        {
            get;
            set;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = Constants.Forms.FeedBack.Errors.RequiredLastName)]
        [StringLength(Constants.Forms.FeedBack.Validation.LastNameMaxLengthInt, MinimumLength = Constants.Forms.FeedBack.Validation.LastNameMinLengthInt, ErrorMessage = Constants.Forms.FeedBack.Errors.LengthLastName)]
        [Display(Name = Constants.Forms.FeedBack.Display.LastName)]
        public String LastName
        {
            get;
            set;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = Constants.Forms.FeedBack.Errors.RequiredEmail)]
        [RegularExpression(Constants.Forms.Validation.Email, ErrorMessage = Constants.Forms.FeedBack.Errors.RegexEmail)]
        [StringLength(Constants.Forms.FeedBack.Validation.EmailMaxLengthInt, MinimumLength = Constants.Forms.FeedBack.Validation.EmailMinLengthInt, ErrorMessage = Constants.Forms.FeedBack.Errors.LengthEmail)]
        [Display(Name = Constants.Forms.FeedBack.Display.Email)]
        public String Email
        {
            get;
            set;
        }

        [DataType(DataType.MultilineText)]
        [StringLength(Constants.Forms.FeedBack.Validation.CommentsMaxLengthInt, MinimumLength = 0, ErrorMessage = Constants.Forms.FeedBack.Errors.LengthComments)]
        [Display(Name = Constants.Forms.FeedBack.Display.Comments)]
        public string Comments { get; set; }
    }
}