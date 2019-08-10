using System.ComponentModel.DataAnnotations;
using Umbraco.Web.Security;
using Umbraco.Web.Models;

namespace AppCMS.Web.Models
{
    public class SignupModel
    {
        [Display(Name = "Name")]
        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "Email")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "PasswordRepeat")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string PasswordRepeat { get; set; }

        public RegisterModel Register(MembershipHelper Members)
        {
            RegisterModel Register = Members.CreateRegistrationModel("member");

            Register.Name = this.Name;
            Register.Email = this.Email;
            Register.UsernameIsEmail = true;
            Register.Password = this.Password;

            return Register;
        }
    }
}