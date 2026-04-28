using System.ComponentModel.DataAnnotations;

namespace MVC_Project1.ViewModels
{
    public class RegisterRoleViewModel
    {
        public string UserName { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
