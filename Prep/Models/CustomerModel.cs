using System.ComponentModel.DataAnnotations;
namespace Prep.Models
{
    public class CustomerModel 
    {
        [Key]
        public int id{get;set;}

        [Required(ErrorMessage = "You must eneter a first name")]
        [StringLength(100, ErrorMessage = "The name must be less than 100 characters")]
        [Display(Name = "First Name")]
        public string fName{get;set;}

        [Required(ErrorMessage = "You must eneter a last name")]
        [StringLength(100)]
        [Display(Name = "Last Name")]
        public string lName{get;set;}

        [Url(ErrorMessage = "You must enter a valid website URL that starts with http or https")]
        [Display(Name = "Your Site")]
        public string website{get;set;}   

        [EmailAddress(ErrorMessage = "You must enter a valid email address that includes and @ symbol")]
        [Display(Name = "Email Address")]
        public string email{get;set;}   

        [Phone(ErrorMessage = "You must eneter a valid phone number that we can contact you at")]
        [Display(Name = "Phone Number")]
        public string phone{get;set;}
    }
}