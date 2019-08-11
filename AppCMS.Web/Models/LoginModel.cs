using System.ComponentModel.DataAnnotations;

namespace AppCMS.Web.Models
{
    public class LoginModel
    {
        [Display(Name = "E-mail")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool Remember { get; set; }
    }
}