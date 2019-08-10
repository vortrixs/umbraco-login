using System.ComponentModel.DataAnnotations;

namespace AppCMS.Web.Models
{
    public class LoginModel
    {
        [Display(Name = "Email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}