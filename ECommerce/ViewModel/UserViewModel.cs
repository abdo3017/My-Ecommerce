using System.ComponentModel.DataAnnotations;

namespace ECommerce.ViewModel
{
    public class UserViewModel
    {
        public int Id { get; set; }
        [Required,MaxLength(100)]
        [Display(Name = "User Name")]
        [RegularExpression(pattern: @"[a-zA-z]{3,}", ErrorMessage = "your name must be more than 3 char")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password and Confirm not matched")]
        public string ConfirmPassword { get; set; }
        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }
}
