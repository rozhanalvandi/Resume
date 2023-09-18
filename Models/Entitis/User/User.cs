
using System.ComponentModel.DataAnnotations;

namespace Resume.Presentation.Models.Entitis.User
{
	public class User: IValidatableObject
	{
        [EmailAddress(ErrorMessage = "{0} should be a proper emial")]
        public string? EmailAdderss { get; set; }

        [Required(ErrorMessage = "{0} should not be empty")]
        [Display(Name = "User Name")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = " {0} should be between {2} and {1} charactors")]
        [RegularExpression("^[A-Za-z.]*$", ErrorMessage = "{0} should contain just alphabet and . ")]
        public string? UserName { get; set; }

        [Required(ErrorMessage = "{0} can't be blank")]
        public string? Password { get; set; }


        [Required(ErrorMessage = "{0} can't be empty")]
        [Compare("Password", ErrorMessage = "{0} and {1} not match")]
        public string? ConfirmPassword { get; set; }





        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}

